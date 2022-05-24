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
    public class Cupos
    {
        private static string cadenaConexion;

        public Cupos()
        {
            cadenaConexion = "Data Source=DESKTOP-81ERCSU\\SQLEXPRESS;Initial Catalog=FITUNED;Integrated Security=True";
        }

        // Método que permite registra el cupo de una sede en la base de datos.
        public void Registrar(CupoSede cupoSede)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "INSERT INTO CupoSede (IdSede, FechaCupo, Cupos)" +
                                       "VALUES (@IdSede, @FechaCupo, @Cupos)";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@IdSede", cupoSede.SedeCupo.IdSede);
                    comando.Parameters.AddWithValue("@FechaCupo", cupoSede.FechaCupo);
                    comando.Parameters.AddWithValue("@Cupos", cupoSede.Cupos);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite obtener los cupos de las sedes registrados en la base de datos.
        public List<CupoSede> ObtenerTodos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "SELECT CupoSede.IdSede, Sede.Nombre, FechaCupo, Cupos " +
                                       "FROM CupoSede, Sede " +
                                       "WHERE CupoSede.IdSede = Sede.IdSede ";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    List<CupoSede> cuposSedes = new List<CupoSede>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cuposSedes.Add(new CupoSede
                            {
                                SedeCupo = new Sede { 
                                    IdSede = reader.GetInt32(0),
                                    Nombre = reader.GetString(1) },
                                FechaCupo = reader.GetDateTime(2),
                                Cupos = reader.GetInt32(3)
                            });
                        }
                    }
                    return cuposSedes;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite actualizar los cupos de una sede. Toma como parámetro un objeto de tipo CupoSede y de acuerdo a sus datos resta en 1 sus cupos.
        public void ActualizarCupos(CupoSede cupoSede)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "UPDATE CupoSede " +
                                       "SET Cupos = Cupos - 1 " +
                                       "WHERE IdSede = @IdSede " +
                                       "AND FechaCupo = @FechaCupo ";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@IdSede", cupoSede.SedeCupo.IdSede);
                    comando.Parameters.AddWithValue("@FechaCupo", cupoSede.FechaCupo);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
