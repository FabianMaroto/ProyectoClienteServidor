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
    public class Sedes
    {
        private static string cadenaConexion;
        public Sedes()
        {
            cadenaConexion = "Data Source=DESKTOP-81ERCSU\\SQLEXPRESS;Initial Catalog=FITUNED;Integrated Security=True";
        }
        
        // Método que permite registrar una sede en la base de datos.
        public void Registrar(Sede sede)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "INSERT INTO Sede (IdSede, Nombre, Direccion, Estado, Telefono)" +
                                       "VALUES (@IdSede, @Nombre, @Direccion, @Estado, @Telefono)";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;
                    comando.Parameters.AddWithValue("@IdSede", sede.IdSede);
                    comando.Parameters.AddWithValue("@Nombre", sede.Nombre);
                    comando.Parameters.AddWithValue("@Direccion", sede.Direccion);
                    comando.Parameters.AddWithValue("@Estado", sede.Estado);
                    comando.Parameters.AddWithValue("@Telefono", sede.Telefono);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite obtener las sedes registradas en la base de datos.
        public List<Sede> ObtenerTodas()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "SELECT * FROM Sede";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    List<Sede> sedes = new List<Sede>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sedes.Add(new Sede
                            {
                                IdSede = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Direccion = reader.GetString(2),
                                Estado = reader.GetBoolean(3),
                                Telefono = reader.GetString(4)
                            });
                        }
                    }
                    return sedes;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
