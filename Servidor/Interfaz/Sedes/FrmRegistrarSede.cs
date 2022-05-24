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

namespace ServidorFITUNED.Interfaz.Sedes
{
    public partial class FrmRegistrarSede : Form
    {
        public FrmRegistrarSede()
        {
            InitializeComponent();

            /* Para mostrar las opciones del ComboBox se utilizó la implementación mostrada en la página web adjunta.
             * https://stackoverflow.com/questions/2417960/populating-a-combobox-using-c-sharp
             */
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Activa", "true");
            dict.Add("Inactiva", "false");

            CmbEstado.DataSource = new BindingSource(dict, null);
            CmbEstado.DisplayMember = "Key";
            CmbEstado.ValueMember = "Value";
        }

        // Evento del botón Registrar con el cual se ingresan los datos de un nuevo registro a la base de datos.
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                LblCamposVacios.Visible = false;
                Datos.Sedes datosSede = new Datos.Sedes();

                if (CamposVacios() == false)
                {
                    if (ComprobarIdSede() == false)
                    {
                        Sede sede = new Sede
                        {
                            IdSede = Convert.ToInt32(TxtIdSede.Text),
                            Nombre = TxtNombre.Text,
                            Direccion = TxtDireccion.Text,
                            Estado = Convert.ToBoolean(CmbEstado.SelectedValue.ToString()),
                            Telefono = TxtTelefono.Text
                        };

                        datosSede.Registrar(sede);
                        MessageBox.Show("Sede registrada con éxito.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("La ID de la sede ya se encuentra registrado.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        // Método que permite comprobar si la ID que se desea ingresar ya se encuentra registrada.
        public bool ComprobarIdSede()
        {
            Datos.Sedes datosSede = new Datos.Sedes();
            bool existe = false;
            
            foreach (Sede s in datosSede.ObtenerTodas())
            {
                if (s.IdSede.Equals(Convert.ToInt32(TxtIdSede.Text)))
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        // Método para comprobar que los campos del formulario no se encuentren vacíos o nulos.
        public bool CamposVacios()
        {
            if (!string.IsNullOrEmpty(TxtIdSede.Text) && !string.IsNullOrEmpty(TxtNombre.Text) && !string.IsNullOrEmpty(TxtDireccion.Text) &&
                !CmbEstado.SelectedValue.Equals(null) && !string.IsNullOrEmpty(TxtTelefono.Text))
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
            TxtIdSede.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            CmbEstado.SelectionStart = 0;
            TxtTelefono.Clear();
        }
    }
}
