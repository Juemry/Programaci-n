using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Model.TDA
{
    internal class Nodo
    {
        public Paciente Paciente { get; set; }

        public Nodo Siguiente { get; set; }

        public Nodo(Paciente paciente)
        {
            this.Paciente = paciente;
        }
    }
}
