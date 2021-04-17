using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamañoMaximo = 0;
            int opc = 0;

            Console.WriteLine("**Software de Cargado de Colas de Alumnos**\n\n");
            Console.WriteLine("Ingrese la cantidad de alumnos con la que se va trabajar: \n");

            tamañoMaximo = Int32.Parse(Console.ReadLine());

            Cola ColaAlumnos = new Cola(tamañoMaximo);
            ColaAlumnos.TamMaximo(tamañoMaximo);

            do
            {
                Console.WriteLine("Ingrese la accion que desea realizar: ");
                Console.WriteLine("1) Cargar alumnos en la Cola de Alumnos");
                Console.WriteLine("2) Mostrar al primero alumno de la Cola de Alumnos");
                Console.WriteLine("3) Buscar alumno por Apellido");
                Console.WriteLine("4) Corroborar si la Cola de Alumnos esta vacia");
                Console.WriteLine("5) Corroborar si la Cola de Alumnos esta llena");
                Console.WriteLine("6) Borrar el primer alumno agregado a la Cola de Alumnos");
                Console.WriteLine("7) Mostrar la Cola de Alumnos");
                Console.WriteLine("Ingrese la accion que desea realizar (cero para salir): ");
                opc = Int32.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        ColaAlumnos.Enqueue();
                        break;
                    case 2:
                        ColaAlumnos.Peek();
                        break;
                    case 3:
                        if (ColaAlumnos.IsEmpty() != true)
                        {
                            string apellidoBusq;
                            Alumno Buscado = new Alumno();
                            Console.WriteLine("Ingrese el apellido del alumno que desea buscar: ");
                            apellidoBusq = Console.ReadLine();
                            ColaAlumnos.Search(apellidoBusq);
                            if (Buscado != null)
                            {
                                Console.WriteLine("Los datos del alumno son: {0} {1} {2}", Buscado.Nombre, Buscado.Apellido, Buscado.FechaNac.ToString("dd/mm/yyyy"));
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron alumnos con ese apellido \n ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La Cola de Alumnos se encuentra vacia \n");
                        }
                        break;
                    case 4:
                        ColaAlumnos.IsEmpty();
                        if (ColaAlumnos.IsEmpty() != true)
                        {
                            Console.WriteLine("Hay alumnos en la Cola\n");
                        }
                        else
                        {
                            Console.WriteLine("La Cola de Alumnos se encuentra vacia \n");
                        }
                        break;
                    case 5:
                        ColaAlumnos.IsFull();
                        if (ColaAlumnos.IsFull() != true)
                        {
                            Console.WriteLine("Hay lugares disponibles en la Cola de Alumnos\n");
                        }
                        else
                        {
                            Console.WriteLine("La Cola de Alumnos esta llena \n");
                        }
                        break;
                    case 6:
                        ColaAlumnos.Dequeue();
                        break;
                    case 7:
                        ColaAlumnos.Show();
                        break;
                    default:
                        Console.WriteLine("Ingreso un valor incorrecto, vuelva a intentar");
                        break;

                }
            } while (opc != 0);

            Console.WriteLine("A seleccionado salir del Software de Cargado de Colas de Alumnos. Hasta luego!\n\n");
            Console.ReadLine();
        }
    }
}
