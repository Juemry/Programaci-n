using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Ejercicio1Parical.Model
{
    public class Nodo
    {
        public Alumno Alumno { get; set; }

        public Nodo Siguiente { get; set; }

        public Nodo(Alumno alumno)
        {
            this.Alumno = alumno;
        }
    }
}
