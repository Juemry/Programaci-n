using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Alumno
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
       

        public Alumno Siguiente { get; set; }

        public Alumno()
        {
            Nombre = "";
            Apellido = "";
            FechaNacimiento = DateTime.Now;
            Siguiente = null;
        }

        
    }
}
