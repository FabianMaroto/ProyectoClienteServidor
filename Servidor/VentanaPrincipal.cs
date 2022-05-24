using ServidorFITUNED.Interfaz.Sedes;
using ServidorFITUNED.Interfaz.Clientes;
using ServidorFITUNED.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServidorFITUNED.Interfaz.Afiliaciones;
using ServidorFITUNED.Interfaz.CuposSedes;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using FITUNED;
using Newtonsoft.Json;

/* Universidad Estatal a Distancia
 * Programación Avanzada
 * 
 * Proyecto
 * Fabián de Jesús Maroto Fernández
 * 
 * I Cuatrimestre 2022
 */

/* Parte del código para el proyecto ServidorFITUNED toma como referencia 
 * las implementaciones presentadas en el ejemplo brindado por el tutor 
 * de la sesión virtual #4, específicamente, de la solución denominada 
 * BibliotecaServidor.
 * 
 * La imagen utilizada para representar el ícono y el logo del servidor
 * fue extraída de la siguiente página web:
 * https://www.flaticon.com/premium-icon/dumbbell_2964659
 */

namespace ServidorFITUNED
{
    public partial class VentanaPrincipal : Form
    {
        TcpListener tcpListener;
        Thread subprocesoCliente;
        bool servidorIniciado;
        int conectados = 0;
        private delegate void EscribirBitacoraDelegate(string id);
        EscribirBitacoraDelegate escribirBitacora;
        private delegate void MostrarConectadosDelegate(int conectado);
        MostrarConectadosDelegate mostrarConectados;
        object bloqueoCliente = new object();

        public VentanaPrincipal()
        {
            InitializeComponent();
            BtnIniciar.Enabled = true;
            BtnDetener.Enabled = false;
            escribirBitacora = new EscribirBitacoraDelegate(EscribirBitacora);
            mostrarConectados = new MostrarConectadosDelegate(MostrarConectados);
        }

        // Evento que permite mostrar el formulario de consulta de sedes.
        private void OpcConsultarSedes_Click(object sender, EventArgs e)
        {
            FrmConsultarSedes ventana = new FrmConsultarSedes();
            ventana.Show(this);
        }

        // Evento que permite mostrar el formulario de registro de sedes.
        private void OpcRegistrarSedes_Click(object sender, EventArgs e)
        {
            FrmRegistrarSede ventana = new FrmRegistrarSede();
            ventana.Show(this);
        }

        // Evento que permite mostrar el formulario de consulta de clientes.
        private void OpcConsultarClientes_Click(object sender, EventArgs e)
        {
            FrmConsultarClientes ventana = new FrmConsultarClientes();
            ventana.Show(this);
        }

        // Evento que permite mostrar el formulario de registro de clientes.
        private void OpcRegistrarClientes_Click(object sender, EventArgs e)
        {
            FrmRegistrarClientes ventana = new FrmRegistrarClientes();
            ventana.Show(this);
        }

        // Evento que permite mostrar el formulario de consultar de las afiliaciones de los clientes.
        private void OpcConsultarSedesCliente_Click(object sender, EventArgs e)
        {
            FrmConsultarAfiliaciones ventana = new FrmConsultarAfiliaciones();
            ventana.Show(this);
        }

        // Evento que permite mostrar el formulario de registro de afiliaciones de clientes.
        private void OpcRegistrarSedesCliente_Click(object sender, EventArgs e)
        {
            FrmRegistrarAfiliacion ventana = new FrmRegistrarAfiliacion();
            ventana.Show(this);
        }

        // Evento que permite mostrar el formulario de consulta de los cupos de cada sede.
        private void OpcConsultarCuposSede_Click(object sender, EventArgs e)
        {
            FrmConsultarCupos ventana = new FrmConsultarCupos();
            ventana.Show(this);
        }

        // Evento que permite mostrar el formulario de registro de cupos para una sede.
        private void OpcRegistrarCuposSede_Click(object sender, EventArgs e)
        {
            FrmRegistrarCupos ventana = new FrmRegistrarCupos();
            ventana.Show(this);
        }

        // Método que permite añadir a la bitácora la información cuando un cliente se conecta al servidor.
        private void EscribirBitacora(string id)
        {
            TxtBitacora.AppendText(DateTime.Now.ToString() + " >> " + id);
            TxtBitacora.AppendText(Environment.NewLine);
        }

        // Método que permite modificar el label de los clientes que se encuentran conectados al servidor.
        private void MostrarConectados(int conectado)
        {
            LblConectados.Text = conectado.ToString();
        }

        // Evento que permite iniciar el servidor.
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            IPAddress direccion = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(direccion, 15810);
            servidorIniciado = true;

            subprocesoCliente = new Thread(new ThreadStart(EscucharClientes));
            subprocesoCliente.Start();
            subprocesoCliente.IsBackground = true; // Establece el subproceso a segundo plano.

            BtnIniciar.Enabled = false;
            BtnDetener.Enabled = true;

            TxtBitacora.Text = "El servidor se inició con éxito.";
            TxtBitacora.AppendText(Environment.NewLine);
        }

        // Método que permite indentificar los clientes que desean conectarse al servidor.
        public void EscucharClientes()
        {
            tcpListener.Start();

            while (servidorIniciado)
            {
                TcpClient cliente = tcpListener.AcceptTcpClient();
                Thread procesoCliente = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                procesoCliente.Start(cliente);
            }
        }

        // Método que permite recibir las peticiones que el cliente realice al servidor.
        public void ComunicacionCliente(object cliente)
        {
            TcpClient tcpCliente = (TcpClient)cliente;
            StreamReader servidorReader = new StreamReader(tcpCliente.GetStream());
            StreamWriter servidorWriter = new StreamWriter(tcpCliente.GetStream());

            while (servidorIniciado)
            {
                try
                {
                    var mensaje = servidorReader.ReadLine();
                    Mensaje<object> mensajeRecibido = JsonConvert.DeserializeObject<Mensaje<object>>(mensaje);
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorWriter);
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            tcpCliente.Close();
        }

        // Método que permite evaluar el tipo de petición que realizó el cliente al servidor.
        public void SeleccionarMetodo(string metodo, string mensaje, ref StreamWriter servidorWriter)
        {
            switch (metodo)
            {
                case "Conectar":
                    Mensaje<string> mensajeConectar = JsonConvert.DeserializeObject<Mensaje<string>>(mensaje);
                    Conectar(mensajeConectar.Dato, ref servidorWriter);
                    break;
                case "ObtenerCliente":
                    Mensaje<string> mensajeCliente = JsonConvert.DeserializeObject<Mensaje<string>>(mensaje);
                    ObtenerCliente(mensajeCliente.Dato, ref servidorWriter);
                    break;
                case "ObtenerAfiliaciones":
                    Mensaje<string> mensajeAfiliaciones = JsonConvert.DeserializeObject<Mensaje<string>>(mensaje);
                    ObtenerAfiliaciones(mensajeAfiliaciones.Dato, ref servidorWriter);
                    break;
                case "ObtenerCupos":
                    ObtenerCupos(ref servidorWriter);
                    break;
                case "ObtenerReservaciones":
                    ObtenerReservaciones(ref servidorWriter);
                    break;
                case "ObtenerReservacionesCliente":
                    Mensaje<string> mensajeReservaciones = JsonConvert.DeserializeObject<Mensaje<string>>(mensaje);
                    ObtenerReservacionesCliente(mensajeReservaciones.Dato, ref servidorWriter);
                    break;
                case "AgregarReservacion":
                    Mensaje<ReservaSesion> mensajeReservacion = JsonConvert.DeserializeObject<Mensaje<ReservaSesion>>(mensaje);
                    AgregarReservacion(mensajeReservacion.Dato);
                    break;
                case "Desconectar":
                    Mensaje<string> mensajeDesconectar = JsonConvert.DeserializeObject<Mensaje<string>>(mensaje);
                    Desconectar(mensajeDesconectar.Dato);
                    break;
                default:
                    break;
            }
        }
        
        // Método que permite recibir la identificación del cliente y verificar si es válida para poder ingresar a la aplicación.
        public void Conectar(string idCliente, ref StreamWriter servidorWriter)
        {
            Clientes datosClientes = new Clientes();
            Afiliaciones datosAfiliaciones = new Afiliaciones();
            bool validar = false;

            foreach (Cliente c in datosClientes.ObtenerTodos())
            {
                if (idCliente.Equals(c.IdCliente))
                {
                    foreach (Afiliacion a in datosAfiliaciones.ObtenerTodas())
                    {
                        if (idCliente.Equals(a.ClienteAfiliacion.IdCliente))
                        {
                            validar = true; // El cliente se encuentra registrado y afiliado a una o más sedes.
                            break;
                        }
                    }
                    break;
                }
            }

            // Envía al usuario el resultado de la validación de la identificación ingresada.
            servidorWriter.WriteLine(JsonConvert.SerializeObject(validar));
            servidorWriter.Flush();

            if (validar)
            {
                conectados++;
                TxtBitacora.Invoke(escribirBitacora, new object[] { idCliente + " se conectó al servidor." });
                LblConectados.Invoke(mostrarConectados, new object[] { conectados });
            }
        }

        // Método que permite modificar la bitácora y la etiqueta de los clientes conectados de la pantalla principal.
        public void Desconectar(string idCliente)
        {
            conectados--;
            TxtBitacora.Invoke(escribirBitacora, new object[] { idCliente + " se desconectó del servidor." });
            LblConectados.Invoke(mostrarConectados, new object[] { conectados });
        }

        // Método que permite obtener un cliente en específico de la base de datos.
        public void ObtenerCliente(string idCliente, ref StreamWriter servidorWriter)
        {
            Cliente cliente = new Cliente();
            Clientes datosClientes = new Clientes();

            foreach (Cliente c in datosClientes.ObtenerTodos())
            {
                if (idCliente.Equals(c.IdCliente))
                {
                    cliente = c;
                    break;
                }
            }

            servidorWriter.WriteLine(JsonConvert.SerializeObject(cliente));
            servidorWriter.Flush();
        }

        // Método que permite obtener las afiliaciones de un cliente en específico de la base de datos.
        public void ObtenerAfiliaciones(string idCliente, ref StreamWriter servidorWriter)
        {
            List<Afiliacion> listaAfiliaciones = new List<Afiliacion>();
            Afiliaciones datosAfiliaciones = new Afiliaciones();

            foreach (Afiliacion a in datosAfiliaciones.ObtenerAfiliacion(idCliente))
            {
                listaAfiliaciones.Add(a);
            }

            servidorWriter.WriteLine(JsonConvert.SerializeObject(listaAfiliaciones));
            servidorWriter.Flush();
        }

        // Método que permite obtener todos los cupos de las sedes registrados de la base de datos.
        public void ObtenerCupos(ref StreamWriter servidorWriter)
        {
            List<CupoSede> listaCupos = new List<CupoSede>();
            Cupos datosCupos = new Cupos();

            foreach (CupoSede cs in datosCupos.ObtenerTodos())
            {
                listaCupos.Add(cs);
            }

            servidorWriter.WriteLine(JsonConvert.SerializeObject(listaCupos));
            servidorWriter.Flush();
        }

        // Método que permite obtener todas las reservaciones registradas de la base de datos.
        public void ObtenerReservaciones(ref StreamWriter servidorWriter)
        {
            List<ReservaSesion> listaReservaciones = new List<ReservaSesion>();
            Reservas datosReservas = new Reservas();

            foreach (ReservaSesion rs in datosReservas.ObtenerReservaciones())
            {
                listaReservaciones.Add(rs);
            }

            servidorWriter.WriteLine(JsonConvert.SerializeObject(listaReservaciones));
            servidorWriter.Flush();
        }

        // Método que permite obtener la o las reservaciones de un cliente en específico de la base de datos.
        public void ObtenerReservacionesCliente(string idCliente, ref StreamWriter servidorWriter)
        {
            List<ReservaSesion> listaReservaciones = new List<ReservaSesion>();
            Reservas datosReservaciones = new Reservas();

            foreach (ReservaSesion rs in datosReservaciones.ObtenerReservacionesCliente(idCliente))
            {
                listaReservaciones.Add(rs);
            }

            servidorWriter.WriteLine(JsonConvert.SerializeObject(listaReservaciones));
            servidorWriter.Flush();

            TxtBitacora.Invoke(escribirBitacora, new object[] { idCliente + " consultó sus reservaciones." });
        }

        // Método que permite registrar la reservación de una fecha de la base de datos.
        public void AgregarReservacion(ReservaSesion reservaSesion)
        {
            lock (bloqueoCliente)
            {
                Cupos cupos = new Cupos();

                CupoSede cupoSede = new CupoSede
                {
                    SedeCupo = new Sede { IdSede = reservaSesion.IdSede.IdSede },
                    FechaCupo = reservaSesion.Fecha
                };

                cupos.ActualizarCupos(cupoSede);

                Reservas reservas = new Reservas();

                reservas.Registrar(reservaSesion);

                TxtBitacora.Invoke(escribirBitacora, new object[] { reservaSesion.IdCliente.IdCliente + " realizó una reservación." });
            }
        }

        // Evento que permite finalizar la escucha de clientes y los subprocesos de los mismos.
        private void BtnDetener_Click(object sender, EventArgs e)
        {
            servidorIniciado = false;
            tcpListener.Stop();
            subprocesoCliente.Abort();

            TxtBitacora.Text = "El servidor fue detenido.";
            TxtBitacora.AppendText(Environment.NewLine);
            BtnIniciar.Enabled = true;
            BtnDetener.Enabled = false;
            conectados = 0;
            LblConectados.Text = conectados.ToString();
        }
    }
}
