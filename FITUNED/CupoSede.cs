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
    public class CupoSede
    {
        public Sede SedeCupo { get; set; } // Propiedad para el objeto de tipo Sede.
        public DateTime FechaCupo { get; set; } // Propiedad para la fecha.
        public int Cupos { get; set; } // Propiedad para la cantidad de cupos.
    }
}
