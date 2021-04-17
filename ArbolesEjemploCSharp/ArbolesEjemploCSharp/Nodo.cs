using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesEjemploCSharp
{
    public class Nodo
    {
        public string Nombre { get; set; }
        
        public int Edad { get; set; }
        public Nodo(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public Nodo Derecha { get; set; }
        public Nodo Izquierda { get; set; }
    }
}
