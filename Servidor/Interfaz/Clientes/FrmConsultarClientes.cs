using FITUNED;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorFITUNED.Interfaz.Clientes
{
    public partial class FrmConsultarClientes : Form
    {
        public FrmConsultarClientes()
        {
            InitializeComponent();
        }

        // Permite mostrar los clientes registrados en la base de datos.
        private void Consultar_Load(object sender, EventArgs e)
        {
            Datos.Clientes datosClientes = new Datos.Clientes();

            List<Cliente> clientes = datosClientes.ObtenerTodos();

            DgvClientes.DataSource = clientes;
        }
    }
}
