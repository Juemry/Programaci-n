using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1Parical.Model
{
    public class Cola
    {
        private int tamañoMaximo = 0;

        private int tamañoActual = 0;
        private Nodo Inicial { get; set; }

        public Cola(int tamañomaximo = 0)
        {
            this.tamañoMaximo = tamañomaximo;
        }

        public void Enqueue(Alumno alumno)
        {
            if (!IsFull())
            {
                Nodo nodo = new Nodo(alumno);
                if (Inicial != null)
                {
                    Inicial.Siguiente = nodo;
                    tamañoActual++;
                }
                else
                {
                    Inicial = nodo;
                    tamañoActual++;
                }
            }
            else
            {
                Console.WriteLine("La cola esta llena.");
            }
        }

        public void Dequeue()
        {
            if (!IsEmpty())
            {
                Alumno alumnoreturn = Inicial.Alumno;
                Inicial = Inicial.Siguiente;
                Console.WriteLine(alumnoreturn.Nombre + " " + alumnoreturn.Apellido + " esta saliendo de la cola. ");
                tamañoActual--;
            }
            else
            {
                Console.WriteLine("La cola esta vacía.");
            }
        }

        public Alumno Peek()
        {
            if (!IsEmpty())
            {
                Alumno alumnoreturn = Inicial.Alumno;
                Console.WriteLine("Retornando alumno Peek: " + alumnoreturn.Nombre + " " + alumnoreturn.Apellido);
                Console.WriteLine("Fecha de Nacimiento: " + alumnoreturn.FechaNacimiento);
                return alumnoreturn;
            }
            return null;
        }

        public bool IsFull()
        {
            return tamañoMaximo > 0 && tamañoMaximo == tamañoActual;    
        }

        public bool IsEmpty()
        {
            return tamañoActual == 0;
        }

        public Alumno BuscarApellido(string apellido)
        {
            if (!IsEmpty())
            {
                Nodo temporal = Inicial;
                Alumno temporalalumno = new Alumno();
                while (temporal != null)
                {
                    if (temporal.Alumno.Apellido == apellido)
                    {
                        temporalalumno = temporal.Alumno;
                        Console.WriteLine("Alumno encontrado...");
                        Console.WriteLine("Devolviendo Alumno " + temporalalumno.Apellido + " ...");
                        Console.WriteLine("Apellido:  " + temporalalumno.Apellido);
                        Console.WriteLine("Nombre: " + temporalalumno.Nombre);
                        Console.WriteLine("Fecha de Naciemiento: " + temporalalumno.FechaNacimiento.ToString());
                        return temporalalumno;
                    }
                    else
                    {
                        temporal = temporal.Siguiente;
                    }
                }
            }
            else
            {
                Console.WriteLine("La cola está vacía");
            }
            
            return null;
        }
        
    }
}
