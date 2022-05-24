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
    public partial class FrmConsultarCupos : Form
    {
        public FrmConsultarCupos()
        {
            InitializeComponent();
        }

        // Evento que permite desplegar en el DataGridView todos los cupos de las sedes registrados.
        private void ConsultarCuposSedes_Load(object sender, EventArgs e)
        {
            DgvCupos.Rows.Clear();

            Datos.Cupos datosCuposSedes = new Datos.Cupos();

            List<CupoSede> cuposSede = datosCuposSedes.ObtenerTodos();

            foreach (CupoSede cs in cuposSede)
            {
                int row = DgvCupos.Rows.Add();

                DgvCupos.Rows[row].Cells[0].Value = cs.SedeCupo.Nombre;
                DgvCupos.Rows[row].Cells[1].Value = cs.FechaCupo.ToShortDateString();
                DgvCupos.Rows[row].Cells[2].Value = cs.Cupos;
            }
        }
    }
}
