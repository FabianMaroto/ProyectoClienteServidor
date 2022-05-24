using FITUNED;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Universidad Estatal a Distancia
 * Programación Avanzada
 * 
 * Proyecto
 * Fabián de Jesús Maroto Fernández
 * 
 * I Cuatrimestre 2022
 */

/* El código que corresponde a esta clase toma como referencia
 * las implementaciones del ejemplo proporcionado por el tutor
 * en la sesión virtual #4. Específicamente, de la solución
 * llamada BibliotecaServidor de las clases de la carpeta
 * datos.
 * 
 * El uso del bloque using se implementó a partir de la
 * información expuesta en las siguientes páginas web:
 * https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-6.0
 * https://social.msdn.microsoft.com/Forums/vstudio/en-US/dd4e52bd-5854-4aa6-91dc-da4ceaba9be2/c-using-amp-sqlconn-does-the-connection-close-itself-when-falling-out-of-scope?forum=csharpgeneral
 */

namespace ServidorFITUNED.Datos
{
    public class Clientes
    {
        private static string cadenaConexion;
        public Clientes()
        {
            cadenaConexion = "Data Source=DESKTOP-81ERCSU\\SQLEXPRESS;Initial Catalog=FITUNED;Integrated Security=True";
        }

        // Método que permite registrar un cliente en la base de datos.
        public void Registrar(Cliente cliente)
        {
            try
            {
                // 
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "INSERT INTO Cliente (IdCliente, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero, FechaIngreso)" +
                                       "VALUES (@IdCliente, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Genero, @FechaIngreso)";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;
                    comando.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                    comando.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                    comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Genero", cliente.Genero);
                    comando.Parameters.AddWithValue("@FechaIngreso", cliente.FechaIngreso);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite obtener los clientes registrados en la base de datos.
        public List<Cliente> ObtenerTodos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "SELECT * FROM Cliente";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    List<Cliente> clientes = new List<Cliente>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new Cliente
                            {
                                IdCliente = reader.GetString(0),
                                Nombre = reader.GetString(1),
                                PrimerApellido = reader.GetString(2),
                                SegundoApellido = reader.GetString(3),
                                FechaNacimiento = reader.GetDateTime(4),
                                Genero = Convert.ToChar(reader.GetString(5)),
                                FechaIngreso = reader.GetDateTime(6)
                            });
                        }
                    }
                    return clientes;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
