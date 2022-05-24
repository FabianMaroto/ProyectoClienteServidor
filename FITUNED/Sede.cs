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
    public class Sede
    {
        public int IdSede { get; set; } // Propiedad para el ID de la sede.
        public string Nombre { get; set; } // Propiedad para el nombre de la sede. 
        public string Direccion { get; set; } // Propiedad para la dirección de la sede.
        public bool Estado { get; set; } // Propiedad para el estado de la sede.
        public string Telefono { get; set; } // Propiedad para el teléfono de la sede.
    }
}
