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
    public class Cliente
    {
        public string IdCliente { get; set; } // Propiedad para la identificación del cliente.
        public string Nombre { get; set; } // Propiedad para el nombre del cliente.
        public string PrimerApellido { get; set; } // Propiedad para el primer apellido del cliente.
        public string SegundoApellido { get; set; } // Propiedad para el segundo apellido del cliente.
        public DateTime FechaNacimiento { get; set; } // Propiedad para la fecha de nacimiento del cliente.
        public char Genero { get; set; } // Propiedad para el género del cliente.
        public DateTime FechaIngreso { get; set; } // Propiedad para la fecha de ingreso del cliente.
    }
}
