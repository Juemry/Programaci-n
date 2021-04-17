using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPObligatorioN1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola ColaAlumnos = new Cola();
            int opc = 0;
            Console.WriteLine("**Software de Cargado de Colas de Alumnos**\n\n");
            do
            {
                Console.WriteLine("\n\n Ingrese la accion que desea realizar: ");
                Console.WriteLine("1) Cargar alumnos en la Cola de Alumnos");
                Console.WriteLine("2) Mostrar la Cola de Alumnos");
                Console.WriteLine("3) Mostrar al primero alumno de la Cola de Alumnos");
                Console.WriteLine("4) Borrar el primer alumno agregado a la Cola de Alumnos");
                Console.WriteLine("Ingrese la accion que desea realizar (cero para salir): ");
                opc = Int32.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        ColaAlumnos.insertarNodo();
                        break;
                    case 2:
                        ColaAlumnos.mostrarCola();
                        break;
                    case 3:
                        ColaAlumnos.mostrarPrimero();
                        break;
                    case 4:
                        ColaAlumnos.borrarPrimero();
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
