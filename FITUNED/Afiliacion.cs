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
    public class Afiliacion
    {
        public int IdAfiliacion { get; set; } // Propiedad para almacenar la id de la afiliación.
        public DateTime FechaAfiliacion { get; set; } // Propiedad para almacenar la fecha de la afiliación.
        public Cliente ClienteAfiliacion { get; set; } // Propiedad para el objeto de tipo Cliente.
        public AfiliacionClienteSede SedeAfiliacion { get; set; }  // Propiedad para objeto de tipo AfiliacionClienteSede, el cual a su vez contiene un objeto de tipo Sede.
    }
}
