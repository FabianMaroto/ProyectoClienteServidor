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
    // https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes
    public class Mensaje<T>
    {
        public string Metodo { get; set; }
        public T Dato { get; set; }
    }
}
