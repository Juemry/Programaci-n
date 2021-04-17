using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Cola
    {
        private Nodo primero;
        private Nodo ultimo;

        public int tamañoMaximo = 0;
        private int tamañoActual = 0;


        public Cola(int tamañoMaximo)
        {
            primero = null;
            ultimo = null;
            this.tamañoMaximo = tamañoMaximo;
        }

        public bool IsEmpty()
        {
            return tamañoActual == 0;
        }

        public bool IsFull()
        {
            return tamañoMaximo > 0 && tamañoMaximo == tamañoActual;
        }

        public void Enqueue(Alumno alumno)
        {
            Nodo Nuevo = new Nodo(alumno);

            if (!IsFull()) { 
            //Alumno Nuevo = new Alumno();
            Console.WriteLine("Ingrese el nombre del alumno:");
            Nuevo.Alumno.Nombre= Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del alumno:");
            Nuevo.Alumno.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento del alumno (dd/mm/aa):");
            Nuevo.Alumno.FechaNac = Convert.ToDateTime(Console.ReadLine());
            tamañoActual++;

            if (primero == null)
            {
                    primero = Nuevo;
                    primero.Siguiente = Nuevo;
                    ultimo = Nuevo;
                    tamañoActual++;
            }
            else
            {
                    ultimo.Siguiente = Nuevo;
                    Nuevo.Siguiente = null;
                    ultimo = Nuevo;
                    tamañoActual++;
                }
        }
            else
            {
                Console.WriteLine("La cola se encuentra completa!\n");

            }
        }

        public void Show()
        {
            Alumno Actual = new Alumno();
            Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("Los datos del alumno son: {0} {1} {2}", Actual.Nombre, Actual.Apellido, Actual.FechaNac.ToString("dd/mm/yyyy"));
                    Actual = Actual.Siguiente;

                }
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }

        public void Peek()
        {

            if (Primero != null)
            {
                Console.WriteLine("Los datos del alumno son: {0} {1} {2}", Primero.Nombre, Primero.Apellido, Primero.FechaNac.ToString("dd/mm/yyyy"));
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }

        public void Dequeue()
        {

            if (Primero != null)
            {
                Console.WriteLine("Los datos del alumno son: {0} {1} {2}", Primero.Nombre, Primero.Apellido, Primero.FechaNac.ToString("dd/mm/yyyy"));
                Primero = Primero.Siguiente;
                tamañoActual--;
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }

        
        public Alumno Search(string apellidoBuscado)
        {
            
            if (Primero != null)
            {
                Alumno Buscado = new Alumno();
                Buscado = Primero;
                while (Buscado != null)
                {
                    if(Buscado.Apellido == apellidoBuscado) 
                    {
                        return Buscado;
                    }
                    else
                    {
                        Buscado = Buscado.Siguiente;
                    }
                }
            }
            return null;
        }

       
    }
}
