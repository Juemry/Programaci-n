using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Model
{
    public class Paciente
    {
        public String Nombre { get; set; }

        public int Temperatura { get; set; }

        public Paciente(int temperatura = 36)
        {
            this.Temperatura = temperatura;
        }
    }
}
