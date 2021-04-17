using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPObligatorioN1
{
    class Cola
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();


        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }

        public void insertarNodo()
        {
            Nodo Nuevo = new Nodo();
            //Nombre = textBox1.Text;
            Console.WriteLine("Ingrese el nombre del Alumno: ");
            Nuevo.Nombre = Console.ReadLine();

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
        }

        public void mostrarCola()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("El nombre del alumno/a es " + Actual.Nombre);
                    Actual = Actual.Siguiente;

                }
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }

        public void mostrarPrimero()
        {
            //Nodo Actual = new Nodo();
            
            if (Primero != null)
            {
                Console.WriteLine("El nombre del alumno/a es " + Primero.Nombre);

            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }

        public void borrarPrimero()
        {
            
            if (Primero != null)
            {
                Console.WriteLine("Se elimino el nombre del alumno/a " + Primero.Nombre);
                Primero = Primero.Siguiente;
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }
    }
}
