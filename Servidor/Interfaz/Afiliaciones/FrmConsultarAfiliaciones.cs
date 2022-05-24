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

namespace ServidorFITUNED.Interfaz.Afiliaciones
{
    public partial class FrmConsultarAfiliaciones : Form
    {
        public FrmConsultarAfiliaciones()
        {
            InitializeComponent();
        }

        // Evento del botón Buscar que permite obtener las sedes a las que se encuentra afiliado un cliente.
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DgvAfiliaciones.Rows.Clear();

                Datos.Afiliaciones datosAfiliaciones = new Datos.Afiliaciones();

                // Se envía como parámetro la ID del cliente al que se le desea consultar las sedes.
                List<Afiliacion> afiliaciones = datosAfiliaciones.ObtenerAfiliacion(TxtId.Text);

                // Se agregan las afiliaciones al DataGridView.
                foreach (Afiliacion a in afiliaciones)
                {
                    int row = DgvAfiliaciones.Rows.Add();

                    DgvAfiliaciones.Rows[row].Cells[0].Value = a.IdAfiliacion;
                    DgvAfiliaciones.Rows[row].Cells[1].Value = a.FechaAfiliacion.ToShortDateString();
                    DgvAfiliaciones.Rows[row].Cells[2].Value = a.ClienteAfiliacion.IdCliente;
                    DgvAfiliaciones.Rows[row].Cells[3].Value = a.ClienteAfiliacion.Nombre;
                    DgvAfiliaciones.Rows[row].Cells[4].Value = a.ClienteAfiliacion.PrimerApellido;
                    DgvAfiliaciones.Rows[row].Cells[5].Value = a.ClienteAfiliacion.SegundoApellido;
                    DgvAfiliaciones.Rows[row].Cells[6].Value = a.SedeAfiliacion.SedeAfiliacionCliente.IdSede;
                    DgvAfiliaciones.Rows[row].Cells[7].Value = a.SedeAfiliacion.SedeAfiliacionCliente.Nombre;
                    DgvAfiliaciones.Rows[row].Cells[8].Value = a.SedeAfiliacion.SedeAfiliacionCliente.Estado ? "Activa" : "Inactiva";
                    DgvAfiliaciones.Rows[row].Cells[9].Value = a.SedeAfiliacion.SedeAfiliacionCliente.Telefono;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }
    }
}
