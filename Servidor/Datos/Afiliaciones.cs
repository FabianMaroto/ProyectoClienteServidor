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
    public class Afiliaciones
    {
        private static string cadenaConexion;

        public Afiliaciones()
        {
            cadenaConexion = "Data Source=DESKTOP-81ERCSU\\SQLEXPRESS;Initial Catalog=FITUNED;Integrated Security=True";
        }

        // Método que permite registrar una afiliación de un cliente a una sede en la base de datos.
        public void Registrar(Afiliacion afiliacion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "INSERT INTO AfiliacionSede (IdAfiliacion, FechaAfiliacion, IdCliente, IdSede)" +
                                       "VALUES (@IdAfiliacion, @FechaAfiliacion, @IdCliente, @IdSede)";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@IdAfiliacion", afiliacion.IdAfiliacion);
                    comando.Parameters.AddWithValue("@FechaAfiliacion", afiliacion.FechaAfiliacion);
                    comando.Parameters.AddWithValue("@IdCliente", afiliacion.ClienteAfiliacion.IdCliente);
                    comando.Parameters.AddWithValue("@IdSede", afiliacion.SedeAfiliacion.SedeAfiliacionCliente.IdSede);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite obtener de la base de datos las afiliaciones de un único cliente.
        public List<Afiliacion> ObtenerAfiliacion(string idCliente)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "SELECT IdAfiliacion, FechaAfiliacion, " +
                                       "AfiliacionSede.IdCliente, Cliente.Nombre, PrimerApellido, SegundoApellido, " +
                                       "AfiliacionSede.IdSede, Sede.Nombre, Estado, Telefono " +
                                       "FROM Sede, AfiliacionSede, Cliente " +
                                       "WHERE AfiliacionSede.IdSede = Sede.IdSede " +
                                       "AND AfiliacionSede.IdCliente = Cliente.IdCliente " +
                                       "AND AfiliacionSede.IdCliente = @IdCliente";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@IdCliente", idCliente);

                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    List<Afiliacion> afiliaciones = new List<Afiliacion>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            afiliaciones.Add(new Afiliacion
                            {
                                IdAfiliacion = reader.GetInt32(0),
                                FechaAfiliacion = reader.GetDateTime(1),
                                ClienteAfiliacion = new Cliente { IdCliente = reader.GetString(2),
                                    Nombre = reader.GetString(3),
                                    PrimerApellido = reader.GetString(4),
                                    SegundoApellido = reader.GetString(5) },
                                SedeAfiliacion = new AfiliacionClienteSede { SedeAfiliacionCliente = new Sede { 
                                    IdSede = reader.GetInt32(6), 
                                    Nombre = reader.GetString(7), 
                                    Estado = reader.GetBoolean(8), 
                                    Telefono = reader.GetString(9) } }
                            });
                        }
                    }
                    return afiliaciones;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite obtener las afiliaciones registradas en la base de datos.
        public List<Afiliacion> ObtenerTodas()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "SELECT IdAfiliacion, FechaAfiliacion, " +
                                       "AfiliacionSede.IdCliente, Cliente.Nombre, PrimerApellido, SegundoApellido, " +
                                       "AfiliacionSede.IdSede, Sede.Nombre, Estado, Telefono " +
                                       "FROM Sede, AfiliacionSede, Cliente " +
                                       "WHERE AfiliacionSede.IdSede = Sede.IdSede " +
                                       "AND AfiliacionSede.IdCliente = Cliente.IdCliente ";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    List<Afiliacion> afiliaciones = new List<Afiliacion>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            afiliaciones.Add(new Afiliacion
                            {
                                IdAfiliacion = reader.GetInt32(0),
                                FechaAfiliacion = reader.GetDateTime(1),
                                ClienteAfiliacion = new Cliente
                                {
                                    IdCliente = reader.GetString(2),
                                    Nombre = reader.GetString(3),
                                    PrimerApellido = reader.GetString(4),
                                    SegundoApellido = reader.GetString(5)
                                },
                                SedeAfiliacion = new AfiliacionClienteSede
                                {
                                    SedeAfiliacionCliente = new Sede
                                    {
                                        IdSede = reader.GetInt32(6),
                                        Nombre = reader.GetString(7),
                                        Estado = reader.GetBoolean(8),
                                        Telefono = reader.GetString(9)
                                    }
                                }
                            });
                        }
                    }
                    return afiliaciones;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        } 
    }
}
