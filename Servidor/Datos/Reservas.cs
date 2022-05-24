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
    public class Reservas
    {
        private static string cadenaConexion;

        public Reservas()
        {
            cadenaConexion = "Data Source=DESKTOP-81ERCSU\\SQLEXPRESS;Initial Catalog=FITUNED;Integrated Security=True";
        }

        // Método que permite registra la reservación de una fecha de un cliente en la base de datos.
        public void Registrar(ReservaSesion reservaSesion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "INSERT INTO Reserva (IdReserva, IdSede, IdCliente, Fecha) " +
                                       "VALUES (@IdReserva, @IdSede, @IdCliente, @Fecha)";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@IdReserva", reservaSesion.IdReserva);
                    comando.Parameters.AddWithValue("@IdSede", reservaSesion.IdSede.IdSede);
                    comando.Parameters.AddWithValue("@IdCliente", reservaSesion.IdCliente.IdCliente);
                    comando.Parameters.AddWithValue("@Fecha", reservaSesion.Fecha);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite obtener las reservaciones registradas en la base de datos.
        public List<ReservaSesion> ObtenerReservaciones()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "SELECT * FROM Reserva";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    List<ReservaSesion> reservaSesion = new List<ReservaSesion>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            reservaSesion.Add(new ReservaSesion
                            {
                                IdReserva = reader.GetInt32(0),
                                IdSede = new Sede
                                {
                                    IdSede = reader.GetInt32(1)
                                },
                                IdCliente = new Cliente
                                {
                                    IdCliente = reader.GetString(2)
                                },
                                Fecha = reader.GetDateTime(3)
                            });
                        }
                    }
                    return reservaSesion;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite obtener las reservaciones registradas en la base de datos de un único cliente.
        public List<ReservaSesion> ObtenerReservacionesCliente(string idCliente)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "SELECT Cliente.Nombre, Cliente.PrimerApellido, Cliente.SegundoApellido, Sede.Nombre, IdReserva, Fecha " +
                                       "FROM Cliente, Sede, Reserva " +
                                       "WHERE Reserva.IdCliente = @IdCliente " +
                                       "AND Cliente.IdCliente = @IdCliente " +
                                       "AND Reserva.IdSede = Sede.IdSede ";

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@IdCliente", idCliente);

                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    List<ReservaSesion> reservaSesion = new List<ReservaSesion>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            reservaSesion.Add(new ReservaSesion
                            {
                                IdCliente = new Cliente
                                {
                                    Nombre = reader.GetString(0),
                                    PrimerApellido = reader.GetString(1),
                                    SegundoApellido = reader.GetString(2)
                                },
                                IdSede = new Sede
                                {
                                    Nombre = reader.GetString(3)
                                },
                                IdReserva = reader.GetInt32(4),
                                Fecha = reader.GetDateTime(5)
                            }); 
                        }
                    }
                    return reservaSesion;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
