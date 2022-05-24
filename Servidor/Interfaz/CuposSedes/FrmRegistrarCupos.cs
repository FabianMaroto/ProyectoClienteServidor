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

namespace ServidorFITUNED.Interfaz.CuposSedes
{
    public partial class FrmRegistrarCupos : Form
    {
        public FrmRegistrarCupos()
        {
            InitializeComponent();
            LblCamposVacios.Visible = false;

            Datos.Sedes sedes = new Datos.Sedes();

            CmbSedes.DataSource = sedes.ObtenerTodas();
            CmbSedes.DisplayMember = "Nombre";
            CmbSedes.ValueMember = "IdSede";
        }

        // Evento que permite evaluar y registrar en la base de datos los cupos de una sede para una fecha definida.
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                LblCamposVacios.Visible = false;
                Datos.Cupos datosCuposSedes = new Datos.Cupos();

                if (!string.IsNullOrEmpty(TxtCupos.Text))
                {
                    if (ComprobarFecha() == false)
                    {
                        CupoSede cupoSede = new CupoSede
                        {
                            SedeCupo = ObtenerSede(),
                            FechaCupo = DtpFecha.Value.Date,
                            Cupos = Convert.ToInt32(TxtCupos.Text)
                        };

                        datosCuposSedes.Registrar(cupoSede);
                        MessageBox.Show("Cupo registrado con éxito.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCupos.Clear();
                    }
                    else
                    {
                        MessageBox.Show("La fecha seleccionada para los cupos de la sede ya se encuentra registrada.", "Servidor FITUNED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LblCamposVacios.Visible = true;
                    LblCamposVacios.Text = "Uno o más campos se encuentran vacíos.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        // Método que permite validar y verificar que la fecha a la que se desea asignar cupos no se encuentre registrada.
        public bool ComprobarFecha()
        {
            Datos.Cupos datosCuposSedes = new Datos.Cupos();
            bool existe = false;

            if  (!datosCuposSedes.ObtenerTodos().Count.Equals(0))
            {
                foreach (CupoSede cs in datosCuposSedes.ObtenerTodos())
                {
                    /* Para realizar la comparación de la fecha a la que se desea asignar cupos y las ya 
                     * registradas, se empleó lo expuesto en la documentación de Microsoft.
                     * https://docs.microsoft.com/en-us/dotnet/api/system.datetime.compare?view=net-6.0
                     */
                    int resultado = DateTime.Compare(cs.FechaCupo.Date, DtpFecha.Value.Date);

                    if (cs.SedeCupo.IdSede.Equals(ObtenerSede().IdSede) && resultado == 0)
                    {
                        existe = true;
                        break;
                    }
                }
            }

            return existe;
        }

        // Método que permite obtener las sedes registradas en la base de datos y que estas se muestren en un ComboBox.
        public Sede ObtenerSede()
        {
            Datos.Sedes datosSedes = new Datos.Sedes();
            Sede sede = new Sede();

            foreach (Sede s in datosSedes.ObtenerTodas())
            {
                if (CmbSedes.SelectedValue.Equals(s.IdSede))
                {
                    sede = s;
                    break;
                }
            }

            return sede;
        }
    }
}
