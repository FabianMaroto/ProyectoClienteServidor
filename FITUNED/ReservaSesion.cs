using FITUNED;
using System;
using System.Collections.Generic;
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

namespace FITUNED
{
    public class ReservaSesion
    {
        public int IdReserva { get; set; } // Propiedad para la id de la reservación.
        public Sede IdSede { get; set; } // Propiedad para el objeto de tipo Sede.
        public Cliente IdCliente{ get; set; } // Propiedad para el objeto de tipo Cliente.
        public DateTime Fecha { get; set; } // Propiedad para la fecha.
    }
}
