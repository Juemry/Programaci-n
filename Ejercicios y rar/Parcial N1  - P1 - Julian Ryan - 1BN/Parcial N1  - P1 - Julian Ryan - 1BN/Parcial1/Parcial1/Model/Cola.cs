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
        //iniciación de variables
        private Nodo Primero;
        private Nodo Ultimo;

        public int tamañoMaximo = 0;
        private int tamañoActual = 0;

        //tamaño máximo ingresado por el usuario, creo
        public int TamMaximo(int tamañoMaximo)
        {
            return tamañoMaximo;
        }

        //constructor de la cola
        public Cola(int tamañoMaximo = 0)
        {
            Primero = null;
            Ultimo = null;
            this.tamañoMaximo = tamañoMaximo;
        }

        //metodo para determinar si la cola esta vacia
        public bool IsEmpty()
        {
            return tamañoActual == 0;
        }

        //metodo para determinar si la cola esta llena
        public bool IsFull()
        {
            return tamañoMaximo > 0 && tamañoMaximo == tamañoActual;
        }

        //metodo para poner alumnos en la cola
        public void Enqueue(Alumno alumno)
        {
            Nodo Nuevo = new Nodo(alumno); //creación de un nuevo nodo

            if (!IsFull()) //corroboración del estado de la cola
            {
                //Nodo nodo = new Nodo(alumno);
                if (Primero != null) //en caso de que el alumno no sea el único, se colocan detras en la cola los siguientes
                {
                    Ultimo.Siguiente = Nuevo;
                    Nuevo.Siguiente = null;
                    Ultimo = Nuevo;
                    tamañoActual++;
                }
                else //en caso de que el alumno sea el único
                {
                    Primero = Nuevo;
                    Primero.Siguiente = Nuevo;
                    Ultimo = Nuevo;
                    tamañoActual++;
                }
            }
            else
            {
                Console.WriteLine("La cola esta llena!\n");
            }
        }

        public void Show() //metodo para mostrar los elementos de la cola
        {
            if (!IsEmpty())
            {
                Nodo Mostrar = Primero;
                while (Mostrar != null) //ciclo while hasta que el nodo llega al valor null, mientras se va imprimiendo la info de los alumnos
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

        public Alumno Peek() //metodo para mostrar el primer valor de la cola
        {

            if (!IsEmpty())
            {
                Alumno AlumnoTope = Primero.Alumno; //se utilizan los datos de alumno guardados en el primer nodo y se imprime su información
                Console.WriteLine("Los datos del alumno son: {0} {1} {2}", AlumnoTope.Nombre, AlumnoTope.Apellido, AlumnoTope.FechaNac.ToString("dd/mm/yyyy"));
                return AlumnoTope;
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
                return null;
            }
        }

        public void Dequeue() //metodo para eliminar el primer nodo de la cola
        {

            if (!IsEmpty())
            {
                Alumno AlumnoEliminado = Primero.Alumno; //se utilizan los datos de alumno guardados en el primer nodo y se "pisa" o borra su información
                Console.WriteLine("Los datos del alumno eliminado son: {0} {1} {2}", AlumnoEliminado.Nombre, AlumnoEliminado.Apellido, AlumnoEliminado.FechaNac.ToString("dd/mm/yyyy"));
                Primero = Primero.Siguiente;
                tamañoActual--;
            }
            else
            {
                Console.WriteLine("\n La Cola de Alumnos se encuentra vacia \n");
            }
        }


        public Alumno Search(string apellidoBuscado) //método de busqueda según criterio de apellidos
        {

            if (!IsEmpty()) 
            {
                Nodo Buscado = Primero;
                Alumno AlumnoBuscado = Buscado.Alumno;
                //luego de corroborar que la cola tiene nodos se crea uno nuevo, cuyo valor de referencia es el del primer alumno en la cola
                //y va a ir comprobando en los siguientes nodos si el apellido es igual o no a ingresado por el usuario
                while (Buscado != null)
                {
                    if (Buscado.Alumno.Apellido == apellidoBuscado)
                    {
                        AlumnoBuscado = Buscado.Alumno;
                        return AlumnoBuscado; //si es igual, devuelve a "AlumnoBuscado" como un objeto a la función Main donde se imprimen sus datos
                    }
                    else
                    {
                        Buscado = Buscado.Siguiente;//en caso de que no lo sea se sigue buscando
                    }

                }
            }
            return null;
        }

       
    }
}