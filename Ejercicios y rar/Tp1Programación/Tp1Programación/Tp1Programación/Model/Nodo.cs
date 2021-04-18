using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Programación.Model
{
    internal class Nodo
    {
        public Alumno Nombre { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Alumno nombre)
        {
            this.Nombre = nombre;

        }
    }
}
