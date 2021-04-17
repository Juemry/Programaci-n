using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Model.TDA
{
    public class Cola
    {
        private Nodo inicial;

        private int tamanio = 0;
        public Cola(int tamanio = 10)
        {
            this.tamanio = tamanio;
        }

        public Cola()
        {

        }

        public void Enqueue(Paciente paciente)
        {

        }

        public Paciente Dequeue() //Quita el elemento y lo devuelve
        {
            return null;
        }

        public Paciente Peek() //Solamente devuelve el elemento...
        {
            return null;
        }

        public bool IsEmpty()
        {
            return false;
        }

        public bool IsFull()
        {
            return false;
        }
    }
}
