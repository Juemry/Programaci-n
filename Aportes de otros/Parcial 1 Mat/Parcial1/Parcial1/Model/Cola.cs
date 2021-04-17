using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    /*
     * La clase cola no tiene que ser publica, solo son publicos
     * los metodos que deseamos que puedan ser utilizados en el 
     * main
     */

    class Cola
    {
        /*Primero y ultimo no son propiedades
         * son variables del tipo Nodo
         */
        private Nodo primero;
        private Nodo ultimo;


        private int tamañoMaximo = 0;
        private int tamañoActual = 0;

        //para que es esto? :D 
        //public int TamMaximo(int tamañoMaximo)
        //{
        //    return tamañoMaximo;
        //}

        public Cola(int tamañoMaximo = 0)
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

            if (primero == null)
            {
                //cuando no tenes nada, el nodo nuevo es el primero 
                //y el ultimo
                primero = Nuevo;
                primero.Siguiente = Nuevo;
                ultimo = Nuevo;
                tamañoActual++;
            }
            else
            {
                //aca no estabas apuntando bien los nodos
                //los tenes que encadenar
                ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                ultimo = Nuevo;
                tamañoActual++;
            }

            
        }

        public void Show()
        {
            if (!IsEmpty())
            {
                Nodo Mostrar = primero;
                while (Mostrar != null)
                {
                    Alumno AlumnoMostrado = Mostrar.Alumno;
                    Console.WriteLine("Los datos del alumno son: {0} {1} {2}", AlumnoMostrado.Nombre, AlumnoMostrado.Apellido, AlumnoMostrado.FechaNac.ToString("dd/mm/yyyy"));
                    Mostrar = Mostrar.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }

        public Alumno Peek()
        {

            if (!IsEmpty())
            {
                Alumno AlumnoTope = primero.Alumno;
                Console.WriteLine("Los datos del alumno son: {0} {1} {2}", AlumnoTope.Nombre, AlumnoTope.Apellido, AlumnoTope.FechaNac.ToString("dd/mm/yyyy"));
                return AlumnoTope;
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
                return null;
            }
        }

        public void Dequeue()
        {

            if (!IsEmpty())
            {
                Alumno AlumnoEliminado = primero.Alumno;
                Console.WriteLine("Los datos del alumno eliminado son: {0} {1} {2}", AlumnoEliminado.Nombre, AlumnoEliminado.Apellido, AlumnoEliminado.FechaNac.ToString("dd/mm/yyyy"));
                primero = primero.Siguiente;
                tamañoActual--;
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }


        public Alumno Search(string apellidoBuscado)
        {

            if (!IsEmpty())
            {
                Nodo Buscado = primero;
                Alumno AlumnoBuscado = Buscado.Alumno;

                while (Buscado != null)
                {
                    if (AlumnoBuscado.Apellido == apellidoBuscado)
                    {
                        Console.WriteLine("Los datos del alumno son: {0} {1} {2}", AlumnoBuscado.Nombre, AlumnoBuscado.Apellido, AlumnoBuscado.FechaNac.ToString("dd/mm/yyyy"));
                        return AlumnoBuscado;
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