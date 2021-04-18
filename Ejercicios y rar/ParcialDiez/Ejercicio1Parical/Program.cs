using Ejercicio1Parical.Model;
using System;

namespace Ejercicio1Parical
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Opcion = 0;
            int Opcion1 = 0;
            int cantalumnos = 0;
            
            Arranque(ref Opcion1);
            while(Opcion1 == 1)
            {
                CantidadAlumnos(ref cantalumnos);
                Cola cola = new Cola(cantalumnos);
                CargadeOpciones(ref Opcion, ref Opcion1);
                while(Opcion != 7)
                {
                    SwitchCaseOp(Opcion, cola);
                    Console.ReadKey();
                    CargadeOpciones(ref Opcion, ref Opcion1);
                }
            }
            Console.WriteLine("Hasta Pronto!");
            Console.ReadKey();
        }










        private static void Arranque(ref int Opcion1)
        {
            Console.WriteLine("Bienvenido al Sistema Queue de Alumnos.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Seleccione una opcion...");
            Console.WriteLine("1.Carga de Alumnos.");
            Console.WriteLine("2.Salir.");
            Opcion1 = Convert.ToInt32(Console.ReadLine());
        }

        private static int CantidadAlumnos(ref int Opcion)
        {
            Console.WriteLine("Cargar cantidad de alumnos maxima: ");
            Opcion = Convert.ToInt32(Console.ReadLine());
            return Opcion;
        }

        private static int CargadeOpciones(ref int Opcion, ref int Opcion1)
        {
            Console.Clear();
            Console.WriteLine("Elija una Opcion...");
            Console.WriteLine("1.Queue Alumno");
            Console.WriteLine("2.Dequeue Alumno");
            Console.WriteLine("3.Peek Alumno");
            Console.WriteLine("4.Consultar si está vacía.");
            Console.WriteLine("5.Consultar si está llena.");
            Console.WriteLine("6.Buscar por Apellido.");
            Console.WriteLine("7.Salir");
            Opcion = Convert.ToInt32(Console.ReadLine());
            if (Opcion == 7)
            {
                Opcion1 = 0;
            }
            return Opcion;
        }

        private static void SwitchCaseOp(int Opcion, Cola cola)
        {
            switch (Opcion)
            {
                case 1:
                    Alumno alumno = new Alumno();
                    string name="";
                    string lastname="";
                    DateTime FechaNac = DateTime.Now;
                    try
                    {
                        Console.WriteLine("Ingrese el nombre del Alumno: ");
                        name = Console.ReadLine();
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    try
                    {
                        Console.WriteLine("Ingrese el apellido del Alumno: ");
                        lastname = Console.ReadLine();
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    try
                    {
                        Console.WriteLine("Ingrese fecha de nacimiento: ");
                        FechaNac= Convert.ToDateTime(Console.ReadLine());
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine(error.Message);
                        Console.WriteLine("Recuerde el tipo de entrada dd/mm/yyyy");
                    }

                    alumno.Apellido = lastname;
                    alumno.Nombre = name;
                    alumno.FechaNacimiento = FechaNac;

                    cola.Enqueue(alumno);
                    break;
                case 2:
                    cola.Dequeue();
                    break;
                case 3:
                    cola.Peek();
                    break;
                case 4:
                    if (cola.IsEmpty())
                    {
                        Console.WriteLine("La cola esta vacía.");
                    }
                    else
                    {
                        Console.WriteLine("La cola no esta vacía.");
                    }
                    break;
                case 5:
                    if (cola.IsFull())
                    {
                        Console.WriteLine("La cola esta llena.");
                    }
                    else
                    {
                        Console.WriteLine("La cola no esta llena.");
                    }
                    break;
                case 6:
                    Console.WriteLine("Ingrese Apellido del alumno a buscar...");
                    string alumno1 = "";
                    try
                    {
                        alumno1 = Console.ReadLine();
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    cola.BuscarApellido(alumno1);
                    break;
                default:
                    break;

            }
        }

    }
}
