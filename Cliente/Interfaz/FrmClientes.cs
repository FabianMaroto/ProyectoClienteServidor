using ClienteFITUNED.Clases;
using ClienteFITUNED.Interfaz;
using FITUNED;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Universidad Estatal a Distancia
 * Programación Avanzada
 * 
 * Proyecto
 * Fabián de Jesús Maroto Fernández
 * 
 * I Cuatrimestre 2022
 */

/* Parte del código para el proyecto ClienteFITUNED toma como referencia 
 * las implementaciones presentadas en el ejemplo brindado por el tutor 
 * de la sesión virtual #4, específicamente, de la solución denominada 
 * BibliotecaCliente.
 * 
 * La imagen utilizada para representar el ícono y el logo del cliente
 * fue extraída de la siguiente página web:
 * https://www.flaticon.com/premium-icon/dumbbell_2964659
 */

namespace ClienteFITUNED
{
    public partial class FrmCliente : Form
    {
        private Cliente cliente;
        private List<Afiliacion> listaAfiliaciones;
        private List<CupoSede> listaCupos;
        private bool clienteConectado = false;
        private int idReserva = 0;
        private Random rand;
        private int semilla;

        public FrmCliente()
        {
            InitializeComponent();
            LblBienvenido.Visible = true;
            LblBienvenido.Dock = DockStyle.Fill;
            LblConectado.Text = "Desconectado(a)";
            LblConectado.ForeColor = Color.Red;
            BtnReservar.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnReservar.Visible = false;
            BtnConsultar.Visible = false;
            LblNombreCompleto.Visible = false;
            LblSusAfiliaciones.Visible = false;
            LstAfiliaciones.Visible = false;
            PnlReservar.Visible = false;
            PnlConsultar.Visible = false;

            /* La generación de los números aleatorios para la ID de las reservas
             * toma como referencia lo presentado en la página web adjunta.
             * https://daniccardenas.com/crear-numeros-aleatorios-con-c-sharp/
             */
            semilla = Environment.TickCount;
            rand = new Random(semilla);
            idReserva = rand.Next();
        }

        // Evento que permite evaluar si la identificación que se ingresó es válida.
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtIdentificacion.Text))
                {
                    if (ClienteTCP.Conectar(TxtIdentificacion.Text))
                    {
                        InterfazIngresar();
                        clienteConectado = true;

                        cliente = new Cliente();
                        cliente = ClienteTCP.ObtenerCliente(TxtIdentificacion.Text); // Obtiene el cliente que actualmente ingresó a la aplicación.
                        LblNombreCompleto.Text = cliente.Nombre + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido;
                        LblNombreCompleto.Visible = true;

                        listaAfiliaciones = new List<Afiliacion>();
                        listaAfiliaciones = ClienteTCP.ObtenerAfiliaciones(TxtIdentificacion.Text); // Obtiene todas las afiliaciones que corresponden al cliente actual.
                        LstAfiliaciones.Items.Clear();
                        foreach (Afiliacion a in listaAfiliaciones)
                        {
                            LstAfiliaciones.Items.Add(a.SedeAfiliacion.SedeAfiliacionCliente.IdSede + "  - " + a.SedeAfiliacion.SedeAfiliacionCliente.Nombre);
                        }

                        ObtenerCupos();
                    }
                    else
                    {
                        MessageBox.Show("La identificación ingresada no es válida o no cumple con los requisitos establecidos.", "FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cédula.", "FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        // Método que permite modificar las propiedades de los componentes de la GUI al conectarse un cliente.
        public void InterfazIngresar()
        {
            BtnIngresar.Enabled = false;
            LblBienvenido.Visible = false;
            LblConectado.Text = "Conectado(a)";
            LblConectado.ForeColor = Color.Lime;
            BtnReservar.Enabled = true;
            BtnConsultar.Enabled = true;
            BtnReservar.Visible = true;
            BtnConsultar.Visible = true;
            TxtIdentificacion.ReadOnly = true;
            LblSusAfiliaciones.Visible = true;
            LstAfiliaciones.Visible = true;
            BtnReservar.BackColor = Color.DarkGray;
            BtnConsultar.BackColor = Color.DarkGray;
        }

        // Evento que permite finalizar la conexión del cliente con el servidor.
        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteConectado)
                {
                    ClienteTCP.Desconectar(TxtIdentificacion.Text);

                    InterfazDesconectar();
                }
                else
                {
                    MessageBox.Show("El cliente ya se encuentra desconectado.", "FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        // Método que permite modificar las propiedades de los componentes de la GUI al desconectarse un cliente.
        public void InterfazDesconectar()
        {
            LblBienvenido.Visible = true;
            LblBienvenido.Dock = DockStyle.Fill;
            LblConectado.Text = "Desconectado(a)";
            LblConectado.ForeColor = Color.Red;
            BtnReservar.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnReservar.Visible = false;
            BtnConsultar.Visible = false;
            LblNombreCompleto.Visible = false;
            LblSusAfiliaciones.Visible = false;
            LstAfiliaciones.Visible = false;
            PnlReservar.Visible = false;
            PnlConsultar.Visible = false;
            clienteConectado = false;
            BtnIngresar.Enabled = true;
            TxtIdentificacion.ReadOnly = false;
            BtnReservar.BackColor = Color.DarkGray;
            BtnConsultar.BackColor = Color.DarkGray;
        }

        // Método que permite obtener el total de los cupos que actualmente se encuentran registrados.
        public List<CupoSede> ObtenerCupos()
        {
            listaCupos = new List<CupoSede>();

            listaCupos = ClienteTCP.ObtenerCupos();

            return listaCupos;
        }

        // Método que proporciona los valores a los campos requeridos para las reservas.
        private void BtnReservar_Click(object sender, EventArgs e)
        {
            BtnReservar.BackColor = Color.DarkGray;
            LblBienvenido.Visible = false;
            PnlConsultar.Visible = false;
            PnlReservar.Visible = true;
            PnlReservar.Dock = DockStyle.Fill;
            LblIdCliente.Text = cliente.IdCliente;
            BtnConsultar.BackColor = Color.Gray;

            CmbSedes.DataSource = ObtenerSedesDisponibles();
            CmbSedes.DisplayMember = "Nombre";
            CmbSedes.ValueMember = "IdSede";
        }

        /* Método que permite obtener las sedes de las cuales se pueden realizar reservaciones
         * de acuerdo a las afiliaciones que el cliente posea.
        */
        public List<Sede> ObtenerSedesDisponibles()
        {
            List<Sede> listaSedes = new List<Sede>();

            foreach (Afiliacion a in listaAfiliaciones)
            {
                foreach (CupoSede cs in ObtenerCupos())
                {
                    if (a.SedeAfiliacion.SedeAfiliacionCliente.IdSede.Equals(cs.SedeCupo.IdSede))
                    {
                        listaSedes.Add(cs.SedeCupo);
                        break;
                    }
                }
            }

            return listaSedes;
        }

        // Evento que permite salir de las reservas o las consultas de reservas (etiqueta con el texto FITUNED).
        private void PnlFituned_Click(object sender, EventArgs e)
        {
            PnlReservar.Visible = false;
            PnlConsultar.Visible = false;
            BtnReservar.BackColor = Color.DarkGray;
            BtnConsultar.BackColor = Color.DarkGray;
        }

        // Evento que permite salir de las reservas o las consultas de reservas (imagen).
        private void PnlImagen_Click(object sender, EventArgs e)
        {
            PnlReservar.Visible = false;
            PnlConsultar.Visible = false;
            BtnReservar.BackColor = Color.DarkGray;
            BtnConsultar.BackColor = Color.DarkGray;
        }
        
        // Evento que permite mostrar las fechas de las sedes que cuentan con cupos para realizar una reservación.
        private void CmbSedes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbSedes.SelectedIndex != -1)
            {
                CmbFechas.DataSource = ObtenerFechas();
                CmbFechas.DisplayMember = "FechaCupo";
                CmbFechas.ValueMember = "FechaCupo";
            }
        }

        // Método que permite obtener las fechas a partir de los cupos que se encuentran registrados.
        public List<CupoSede> ObtenerFechas()
        {
            List<CupoSede> listaFechas = new List<CupoSede>();

            Sede sede = (Sede)CmbSedes.SelectedItem;

            /* Para establecer el rango de días que debe desplegar el ComboBox de las fechas
             * se utilizó como referencia lo expuesto en la siguiente página web:
             * https://www.kyocode.com/2018/09/sumar-restar-dias-en-c/
             */
            DateTime diasSiguientes = DateTime.Today.AddDays(2);

            foreach (CupoSede cs in ObtenerCupos())
            {
                if (sede.IdSede.Equals(cs.SedeCupo.IdSede))
                {
                    if (cs.FechaCupo.Date >= DateTime.Today.Date && cs.FechaCupo.Date <= diasSiguientes)
                    {
                        if (cs.Cupos > 0)
                        {
                            listaFechas.Add(cs);
                        }
                    }
                }
            }
            return listaFechas;
        }

        // Evento que permite manejar el comportamiento del formulario cuando se realiza click en el botón para cerrar la ventana.
        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clienteConectado)
            {
                e.Cancel = true;
                MessageBox.Show("Es necesario desconectarse antes de cerrar el cliente.", "FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                e.Cancel = false;
            }
        }

        // Evento que permite validar y enviar al servidor la petición de registro de una reservación de un cliente.
        private void BtnReservarFecha_Click(object sender, EventArgs e)
        {
            if (!ComprobarReservacion(Convert.ToDateTime(CmbFechas.SelectedValue)))
            {
                if (CmbFechas.SelectedIndex != -1)
                {
                    if (!ComprobarCupos((Sede)CmbSedes.SelectedItem, Convert.ToDateTime(CmbFechas.SelectedValue)))
                    {
                        ReservaSesion reserva = new ReservaSesion
                        {
                            IdReserva = idReserva,
                            IdSede = new Sede { IdSede = Convert.ToInt32(CmbSedes.SelectedValue) },
                            IdCliente = new Cliente { IdCliente = cliente.IdCliente },
                            Fecha = Convert.ToDateTime(CmbFechas.SelectedValue)
                        };

                        ClienteTCP.AgregarReservacion(reserva);
                        MessageBox.Show("Reservación realizada con éxito.", "FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La sede seleccionada no cuenta con cupos disponibles.", "FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La sede seleccionada no cuenta con fechas disponibles.", "FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Reservación existente para la fecha seleccionada.", "FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que permite evaluar si la fecha en la que se desea realizar una reservación ya se encuentra registrada para el cliente.
        public bool ComprobarReservacion(DateTime fechaReserva)
        {
            foreach (ReservaSesion rs in ObtenerTodasReservaciones())
            {
                if (cliente.IdCliente.Equals(rs.IdCliente.IdCliente) && fechaReserva.Equals(rs.Fecha))
                {
                    return true;
                }

                if (idReserva.Equals(rs.IdReserva))
                {
                    idReserva = rand.Next();
                }
            }
            return false;
        }

        // Método que permite evaluar si la fecha seleccionada cuenta con cupos disponibles.
        public bool ComprobarCupos(Sede sede, DateTime fechaReserva)
        {
            foreach (CupoSede cs in ObtenerCupos())
            {
                if (fechaReserva.Equals(cs.FechaCupo) && sede.IdSede.Equals(cs.SedeCupo.IdSede))
                {
                    if (cs.Cupos <= 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Método que permite obtener el total de las sedes actualmente registradas.
        public List<ReservaSesion> ObtenerTodasReservaciones()
        {
            List<ReservaSesion> listaReservas = new List<ReservaSesion>();

            listaReservas = ClienteTCP.ObtenerReservaciones();

            return listaReservas;
        }

        // Evento que permite mostrar las reservaciones registradas del cliente que se encuentra conectado.
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DgvReservaciones.Rows.Clear();
            BtnConsultar.BackColor = Color.DarkGray;
            LblBienvenido.Visible = false;
            PnlReservar.Visible = false;
            PnlConsultar.Visible = true;
            PnlConsultar.Dock = DockStyle.Fill;
            BtnReservar.BackColor = Color.Gray;

            DgvReservaciones.Dock = DockStyle.Fill;

            List<ReservaSesion> listaReservaciones = ClienteTCP.ObtenerReservacionesCliente(cliente.IdCliente);

            foreach (ReservaSesion rs in listaReservaciones)
            {
                int row = DgvReservaciones.Rows.Add();

                DgvReservaciones.Rows[row].Cells[0].Value = rs.IdCliente.Nombre;
                DgvReservaciones.Rows[row].Cells[1].Value = rs.IdCliente.PrimerApellido;
                DgvReservaciones.Rows[row].Cells[2].Value = rs.IdCliente.SegundoApellido;
                DgvReservaciones.Rows[row].Cells[3].Value = rs.IdSede.Nombre;
                DgvReservaciones.Rows[row].Cells[4].Value = rs.IdReserva;
                DgvReservaciones.Rows[row].Cells[5].Value = rs.Fecha.ToShortDateString();
            }
        }
    }
}
