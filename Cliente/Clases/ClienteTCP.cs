using FITUNED;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

/* Parte del código para el proyecto ClienteFITUNED toma como referencia 
 * las implementaciones presentadas en el ejemplo brindado por el tutor 
 * de la sesión virtual #4, específicamente, de la solución denominada 
 * BibliotecaCliente.
 */

namespace ClienteFITUNED.Clases
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient tcpCliente;
        private static IPEndPoint endPointServidor;
        private static StreamReader clienteReader;
        private static StreamWriter clienteWriter;

        // Método que permite enviar la petición del cliente para conectarse al servidor. Asimismo, devuelve a este si su ID es válida.
        public static bool Conectar(string idCliente)
        {
            bool validado = false;

            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                tcpCliente = new TcpClient();
                endPointServidor = new IPEndPoint(ipServidor, 15810);
                tcpCliente.Connect(endPointServidor);
                Mensaje<string> mensajeConectar = new Mensaje<string> { Metodo = "Conectar", Dato = idCliente };

                clienteReader = new StreamReader(tcpCliente.GetStream());
                clienteWriter = new StreamWriter(tcpCliente.GetStream());
                clienteWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                clienteWriter.Flush();

                var mensaje = clienteReader.ReadLine();
                validado = JsonConvert.DeserializeObject<bool>(mensaje);
            }
            catch (Exception ex)
            {
                return validado;
                throw;
            }
            return validado;
        }

        // Método que permite enviar la petición para desconectar un cliente del servidor.
        public static void Desconectar(string idCliente)
        {
            try
            {
                Mensaje<string> mensajeDesconectar = new Mensaje<string> { Metodo = "Desconectar", Dato = idCliente };

                clienteWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
                clienteWriter.Flush();

                tcpCliente.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        } 

        // Método que permite enviar la petición al servidor para obtener un cliente en específico.
        public static Cliente ObtenerCliente(string idCliente)
        {
            Cliente cliente = new Cliente();
            try
            {
                Mensaje<string> mensajeCliente = new Mensaje<string> { Metodo = "ObtenerCliente", Dato = idCliente };

                clienteWriter.WriteLine(JsonConvert.SerializeObject(mensajeCliente));
                clienteWriter.Flush();

                var mensaje = clienteReader.ReadLine();
                cliente = JsonConvert.DeserializeObject<Cliente>(mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
            return cliente;
        }

        // Método que permite enviar la petición al servidor para obtener solamente las afiliciones de un cliente en específico.
        public static List<Afiliacion> ObtenerAfiliaciones(string idCliente)
        {
            List<Afiliacion> listaAfiliaciones = new List<Afiliacion>();
            try
            {
                Mensaje<string> mensajeAfiliaciones = new Mensaje<string> { Metodo = "ObtenerAfiliaciones", Dato = idCliente };

                clienteWriter.WriteLine(JsonConvert.SerializeObject(mensajeAfiliaciones));
                clienteWriter.Flush();

                var mensaje = clienteReader.ReadLine();
                listaAfiliaciones = JsonConvert.DeserializeObject<List<Afiliacion>>(mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaAfiliaciones;
        }

        // Método que permite enviar la petición al servidor para obtener todos los cupos de las sedes registrados en la base de datos.
        public static List<CupoSede> ObtenerCupos()
        {
            List<CupoSede> listaCupos = new List<CupoSede>();
            try
            {
                Mensaje<string> mensajeCupos = new Mensaje<string> { Metodo = "ObtenerCupos" };

                clienteWriter.WriteLine(JsonConvert.SerializeObject(mensajeCupos));
                clienteWriter.Flush();

                var mensaje = clienteReader.ReadLine();
                listaCupos = JsonConvert.DeserializeObject<List<CupoSede>>(mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaCupos;
        }

        // Método que permite enviar la petición al servidor para obtener todas las reservaciones actualmente registradas en la base de datos.
        public static List<ReservaSesion> ObtenerReservaciones()
        {
            List<ReservaSesion> listaReservas = new List<ReservaSesion>();
            try
            {
                Mensaje<string> mensajeReservas = new Mensaje<string> { Metodo = "ObtenerReservaciones" };

                clienteWriter.WriteLine(JsonConvert.SerializeObject(mensajeReservas));
                clienteWriter.Flush();

                var mensaje = clienteReader.ReadLine();
                listaReservas = JsonConvert.DeserializeObject<List<ReservaSesion>>(mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaReservas;
        }

        // Método que permite enivar al servidor la reservación de una fecha de un cliente.
        public static bool AgregarReservacion(ReservaSesion reservaSesion)
        {
            try
            {
                Mensaje<ReservaSesion> mensajeReservar = new Mensaje<ReservaSesion> { Metodo = "AgregarReservacion", Dato = reservaSesion };

                clienteWriter.WriteLine(JsonConvert.SerializeObject(mensajeReservar));
                clienteWriter.Flush();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método que permite enviar la petición al servidor para obtener solamente las reservaciones de un cliente en específico.
        public static List<ReservaSesion> ObtenerReservacionesCliente(string idCliente)
        {
            List<ReservaSesion> listaReservaciones = new List<ReservaSesion>();
            try
            {
                Mensaje<string> mensajeReservaciones = new Mensaje<string> { Metodo = "ObtenerReservacionesCliente", Dato = idCliente };

                clienteWriter.WriteLine(JsonConvert.SerializeObject(mensajeReservaciones));
                clienteWriter.Flush();

                var mensaje = clienteReader.ReadLine();
                listaReservaciones = JsonConvert.DeserializeObject<List<ReservaSesion>>(mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaReservaciones;
        }
    }
}
