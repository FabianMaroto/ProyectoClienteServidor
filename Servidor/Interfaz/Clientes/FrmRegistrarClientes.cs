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

namespace ServidorFITUNED.Interfaz.Clientes
{
    public partial class FrmRegistrarClientes : Form
    {
        public FrmRegistrarClientes()
        {
            InitializeComponent();

            /* Para mostrar las opciones del ComboBox se utilizó la implementación mostrada en la página web adjunta.
             * https://stackoverflow.com/questions/2417960/populating-a-combobox-using-c-sharp
             */
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Masculino", "M");
            dict.Add("Femenino", "F");

            CmbGenero.DataSource = new BindingSource(dict, null); 
            CmbGenero.DisplayMember = "Key";
            CmbGenero.ValueMember = "Value";
        }

        // Evento del botón Regisrar que permite ingresar una nueva sede a la base de datos.
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                LblCamposVacios.Visible = false;
                Datos.Clientes datosClientes = new Datos.Clientes();

                if (CamposVacios() == false)
                {
                    if (ComprobarIdCliente() == false)
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = TxtIdentificacion.Text,
                            Nombre = TxtNombre.Text,
                            PrimerApellido = TxtPrimerApellido.Text,
                            SegundoApellido = TxtSegundoApellido.Text,
                            FechaNacimiento = DtpFechaNacimiento.Value.Date,
                            Genero = Convert.ToChar(CmbGenero.SelectedValue.ToString()),
                            FechaIngreso = DtpFechaIngreso.Value.Date
                        };

                        datosClientes.Registrar(cliente);
                        MessageBox.Show("Cliente registrado con éxito.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("La identificación del cliente ya se encuentra registrada.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        // Método que permite comprobar si la ID que se pretende ingresar ya se encuentra registrada.
        public bool ComprobarIdCliente()
        {
            Datos.Clientes datosClientes = new Datos.Clientes();
            bool existe = false;

            foreach (Cliente c in datosClientes.ObtenerTodos())
            {
                if (c.IdCliente.Equals(TxtIdentificacion.Text))
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        // Método que permite verificar si hay campos del formulario de registro vacíos o no.
        public bool CamposVacios()
        {
            if (!string.IsNullOrEmpty(TxtIdentificacion.Text) && !string.IsNullOrEmpty(TxtNombre.Text) && !string.IsNullOrEmpty(TxtPrimerApellido.Text) &&
                !string.IsNullOrEmpty(TxtSegundoApellido.Text) && !CmbGenero.SelectedValue.Equals(null))
            {
                return false;
            }
            else
            {
                LblCamposVacios.Visible = true;
                LblCamposVacios.Text = "Uno o más campos se encuentran vacíos.";
                return true;
            }
        }

        // Método para limpiar los campos del formulario.
        public void LimpiarFormulario()
        {
            TxtIdentificacion.Clear();
            TxtNombre.Clear();
            TxtPrimerApellido.Clear();
            TxtSegundoApellido.Clear();
        }
    }
}
