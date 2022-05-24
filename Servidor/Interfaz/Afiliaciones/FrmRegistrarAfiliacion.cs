using FITUNED;
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

namespace ServidorFITUNED.Interfaz.Afiliaciones
{
    public partial class FrmRegistrarAfiliacion : Form
    {
        public FrmRegistrarAfiliacion()
        {
            InitializeComponent();
        }

        /* Método que permite desplegar los clientes disponibles para realizar una afiliación.
         * Se empleó como referencia la implementación mostrada en el siguiente enlace: 
         * https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/add-and-remove-items-from-a-wf-combobox?view=netframeworkdesktop-4.8
        */
        public void ClientesDisponibles()
        {
            Datos.Clientes clientes = new Datos.Clientes();

            foreach (Cliente c in clientes.ObtenerTodos())
            {
                LstClientes.Items.Add(c.IdCliente + "  - " + c.Nombre + " " + c.PrimerApellido + " " + c.SegundoApellido);
            }
        }

        /* Método que permite desplegar las sedes disponibles y activas para realizar una afiliación.
         * Se empleó como referencia la implementación mostrada en el siguiente enlace:
         * https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/add-and-remove-items-from-a-wf-combobox?view=netframeworkdesktop-4.8
        */
        public void SedesDisponibles()
        {
            Datos.Sedes sedes = new Datos.Sedes();

            foreach (Sede s in sedes.ObtenerTodas())
            {
                if (s.Estado == true)
                {
                    LstSedes.Items.Add(s.IdSede + "  - " + s.Nombre + "  - " + "Activa");
                }
            }
        }

        // Evento del botón Registrar que permite agregar una afiliación a la base de datos.
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                LblCampoVacios.Visible = false;
                Datos.Afiliaciones afiliaciones = new Datos.Afiliaciones();
                
                if (CamposVacios() == false)
                {
                    if (ComprobarIdAfilicion() == false)
                    {
                        Afiliacion afiliacion = new Afiliacion
                        {
                            IdAfiliacion = Convert.ToInt32(TxtIdAfiliacion.Text),
                            FechaAfiliacion = DtpFecha.Value.Date,
                            ClienteAfiliacion = BuscarCliente(),
                            SedeAfiliacion = BuscarSede()
                        };

                        if (ComprobarSedeAfiliacion() == false)
                        {
                            afiliaciones.Registrar(afiliacion);
                            MessageBox.Show("Afiliación registrada con éxito.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("El cliente ya se encuentra afiliado a la sede seleccionada.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La ID de la afiliación ya se encuentra registrada.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        // Método que permite comprobar si la ID de la afiliación ingresada ya se encuentra registrada.
        public bool ComprobarIdAfilicion()
        {
            Datos.Afiliaciones afiliaciones = new Datos.Afiliaciones();
            bool existe = false;
            foreach (Afiliacion a in afiliaciones.ObtenerTodas())
            {
                if (a.IdAfiliacion.Equals(Convert.ToInt32(TxtIdAfiliacion.Text)))
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        // Método que permite comprobar si un cliente ya se encuentra afiliado a la sede que se seleccionó.
        public bool ComprobarSedeAfiliacion()
        {
            Datos.Afiliaciones afiliaciones = new Datos.Afiliaciones();
            bool existe = false;

            if (!afiliaciones.ObtenerTodas().Count.Equals(0))
            {
                foreach (Afiliacion a in afiliaciones.ObtenerTodas())
                {
                    if (a.SedeAfiliacion.SedeAfiliacionCliente.IdSede == Convert.ToInt32(TxtIdSede.Text) && a.ClienteAfiliacion.IdCliente.Equals(TxtIdCliente.Text))
                    {
                        existe = true;
                        break;
                    }
                }
            }
            return existe;
        }

        // Método que permite comprobar que no hayan incompletos en el formulario de registro.
        public bool CamposVacios()
        {
            if (!string.IsNullOrEmpty(TxtIdAfiliacion.Text) && !string.IsNullOrEmpty(TxtIdCliente.Text) && !string.IsNullOrEmpty(TxtIdSede.Text))
            {
                return false;
            }
            else
            {
                LblCampoVacios.Visible = true;
                LblCampoVacios.Text = "Uno o más campos se encuentran vacíos.";
                return true;
            }
        }

        // Método que permite obtener el cliente al cual se busca realizar una afiliación.
        public Cliente BuscarCliente()
        {
            Datos.Clientes clientes = new Datos.Clientes();
            Cliente cliente = new Cliente();

            foreach (Cliente c in clientes.ObtenerTodos())
            {
                if (c.IdCliente.Equals(TxtIdCliente.Text))
                {
                    cliente = c;
                }
            }
            return cliente;
        }

        // Método que permite obtener la sede a la que el cliente se quiere afiliar.
        public AfiliacionClienteSede BuscarSede()
        {
            Sede sede = new Sede();
            Datos.Sedes sedes = new Datos.Sedes();

            foreach (Sede s in sedes.ObtenerTodas())
            {
                if (s.IdSede.Equals(Convert.ToInt32(TxtIdSede.Text)))
                {
                    sede = s;
                }
            }

            AfiliacionClienteSede sedeAfiliacion = new AfiliacionClienteSede
            {
                SedeAfiliacionCliente = sede
            };
            return sedeAfiliacion;
        }

        // Método que permite limpiar los campos del formulario.
        public void LimpiarFormulario()
        {
            TxtIdAfiliacion.Clear();
            TxtIdCliente.Clear();
            TxtIdSede.Clear();
        }

        // El código implementado en el evento permite evaluar si existen clientes o sedes registradas y con ello habilitar o inhabilitar el botón para realizar un registo.
        private void RegistrarAfiliacion_Load(object sender, EventArgs e)
        {
            Datos.Clientes clientes = new Datos.Clientes();
            Datos.Sedes sedes = new Datos.Sedes();

            if (clientes.ObtenerTodos().Count.Equals(0) || sedes.ObtenerTodas().Count.Equals(0))
            {
                MessageBox.Show("No hay sedes o clientes registrados. Por favor, inténtelo de nuevo.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnRegistrar.Enabled = false;
            }
            else
            {
                ClientesDisponibles();
                SedesDisponibles();
            }
        }

        // Evento de la lista de clientes que permite obtener la ID del cliente seleccionado en ella.
        private void LstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstClientes.SelectedIndex != -1)
            {
                /* Se obtiene el ID del cliente por medio del método Split.
                 * https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-6.0
                 */
                string[] id = LstClientes.SelectedItem.ToString().Split();
                TxtIdCliente.Text = id[0];
            }
        }

        // Evento de la lista de la sede que permite obtener la ID de la sede seleccionada en ella.
        private void LstSedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstSedes.SelectedIndex != -1)
            {
                /* Se obtiene el ID del cliente por medio del método Split.
                 * https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-6.0
                 */
                string[] id = LstSedes.SelectedItem.ToString().Split();
                TxtIdSede.Text = id[0];
            }
        }
    }
}
