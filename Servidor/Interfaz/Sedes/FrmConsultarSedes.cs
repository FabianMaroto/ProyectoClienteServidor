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
    public partial class FrmConsultarSedes : Form
    {
        public FrmConsultarSedes()
        {
            InitializeComponent();
        }

        // Evento que permite desplegar en el DataGridView todas las sedes registradas en la base de datos.
        private void ConsultarSedes_Load(object sender, EventArgs e)
        {
            Datos.Sedes datosSedes = new Datos.Sedes();

            List<Sede> sedes = datosSedes.ObtenerTodas();

            DgvSedes.DataSource = sedes;
        }
    }
}
