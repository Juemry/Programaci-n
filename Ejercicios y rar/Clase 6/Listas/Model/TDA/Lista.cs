using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Model.TDA
{
    public class Lista
    {
        private Nodo inicial;
        //private int contador;

        public Lista()
        {

        }

        public void AgregarAlComienzo(Paciente paciente)
        {
            Nodo nodo = new Nodo(paciente);
            nodo.Siguiente = inicial;
            inicial = nodo;
        }

        public void AgregarAlFinal(Paciente paciente)
        {
            Nodo nodo = new Nodo(paciente);
            Nodo ultimoNodo = ObtenerUltimoNodo(inicial);
            ultimoNodo.Siguiente = nodo;
        }

        public Paciente QuitarAlComienzo() //public void QuitarAlComienzo()
        {
            if (inicial != null)
            {
                Paciente pacienteReturn = inicial.Paciente;
                Console.WriteLine("Quitando paciente: " + pacienteReturn.Nombre);
                inicial = inicial.Siguiente;
                return pacienteReturn;
            }
            return null;
        }

        public Paciente QuitarAlFinal() //public void QuitarAlFinal()
        {
            Nodo anteultimo = ObtenerAnteUltimoNodo(inicial);
            Paciente pacienteFinal = anteultimo.Siguiente.Paciente;

            anteultimo.Siguiente = null;

            return pacienteFinal;
        }



        //Peek al comienzo o al final...
        public Paciente PeekComienzo()
        {
            if (inicial != null)
            {
                Paciente pacienteReturn = inicial.Paciente;
                Console.WriteLine("Devolviendo el paciente del tope: " + pacienteReturn.Nombre);                
                return pacienteReturn;
            }
            return null;
        }


        public Paciente Busqueda(string nombre)
        {
            //Algoritmo de búsqueda...



            return null;
        }

        public Paciente Actualizar(string nombre, Paciente paciente)
        {
            //Algoritmo de búsqueda y actualización...



            return null;
        }

        //public void Agregar(int pos, Paciente paciente) por posición
        //public void Agregar(string nombre, Paciente paciente) por un criterio de búsqueda

        public void Recorrer()
        {
            //Bucle para mostrar todos los datos de nuestros nodos...
            if (inicial != null)
            {
                Nodo temporal = inicial;

                while (temporal.Siguiente != null)
                {
                    Console.WriteLine("Paciente " + temporal.Paciente.Nombre);
                    temporal = temporal.Siguiente;
                }
                Console.WriteLine("Último paciente: " + temporal.Paciente.Nombre);
            }
        }

        private Nodo ObtenerUltimoNodo()
        {
            //Bucle para mostrar todos los datos de nuestros nodos...
            if (inicial != null)
            {
                Nodo temporal = inicial;
                while (temporal.Siguiente != null)
                {
                    temporal = temporal.Siguiente;
                }
                return temporal;
            }
            return inicial;
        }

        private Nodo ObtenerUltimoNodo(Nodo nodo)
        {
            if (nodo == null || nodo.Siguiente == null) //Este debería el último nodo
                return nodo;
            
            return ObtenerUltimoNodo(nodo.Siguiente);
        }

        private Nodo ObtenerAnteUltimoNodo(Nodo nodo)
        {
            if (nodo == null || nodo.Siguiente == null || nodo.Siguiente.Siguiente == null) //Este debería el último nodo
                return nodo;

            return ObtenerAnteUltimoNodo(nodo.Siguiente);
        }
    }
}
