using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Nodo //clase de creación de nodos con sus propiedades
    {
        public Alumno Alumno { get; set; }

        public Nodo Siguiente { get; set; }

        public Nodo(Alumno alumno)
        {
            this.Alumno = alumno;
        }
    }
}