using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {


            //declaración de variables iniciales
            int tamañoMaximo = 0;
            int opc = 0;
            //comienzo del programa y solicitud de tamaño máximo de la cola
            Console.WriteLine("*Software de Cargado de Colas de Alumnos*\n");
            Console.WriteLine("Ingrese la cantidad de alumnos con la que se va trabajar: \n");

            tamañoMaximo = Int32.Parse(Console.ReadLine());

            //creación de la cola
            Cola ColaAlumnos = new Cola(tamañoMaximo);
            ColaAlumnos.TamMaximo(tamañoMaximo);




            //ejecución del menu para operar la cola mientras la opción del usuario sea distinta de 0
            do
            {
                try //utilización de try y catch para evitar cierres inoporturnos y errores del programa
                {
                    Console.WriteLine("\n Ingrese la accion que desea realizar: ");
                    Console.WriteLine("1) Cargar alumnos en la Cola de Alumnos");
                    Console.WriteLine("2) Mostrar al primero alumno de la Cola de Alumnos");
                    Console.WriteLine("3) Buscar alumno por Apellido");
                    Console.WriteLine("4) Corroborar si la Cola de Alumnos esta vacia");
                    Console.WriteLine("5) Corroborar si la Cola de Alumnos esta llena");
                    Console.WriteLine("6) Borrar el primer alumno agregado a la Cola de Alumnos");
                    Console.WriteLine("7) Mostrar la Cola de Alumnos"); //para corroboración
                    Console.WriteLine("Ingrese la accion que desea realizar (cero para salir): ");
                    opc = Int32.Parse(Console.ReadLine()); //lectura de la opción
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                




                switch (opc) //switch para las diferentes opciones del menu
                {
                    case 1: //creación un nuevo alumno, solicitud de los datos y encolado del mismo por función Queue
                        Alumno alumno = new Alumno();
                        if (!ColaAlumnos.IsFull()) //corroboración de que la cola tiene espacio y solicitud de datos
                        {
                            try
                            {
                                Console.WriteLine("\nIngrese el nombre del alumno:");
                                alumno.Nombre = Console.ReadLine();
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine(error.Message);
                            }
                            try
                            {
                                Console.WriteLine("Ingrese el apellido del alumno:");
                                alumno.Apellido = Console.ReadLine();
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine(error.Message);
                            }
                            try
                            {
                                Console.WriteLine("Ingrese la fecha de nacimiento del alumno (dd/mm/aaaa):");
                                alumno.FechaNac = Convert.ToDateTime(Console.ReadLine());
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine(error.Message);
                            }
                           
                            ColaAlumnos.Enqueue(alumno); //funcion de encolar al alumno
                        }
                        else //mensaje en caso de que no haya datos
                        {
                            Console.WriteLine("La cola se encuentra completa!\n");
                        }
                        break;
                    case 2:
                        ColaAlumnos.Peek(); //función directa que muestra el alumno del tope
                        break;
                    case 3:
                        if (ColaAlumnos.IsEmpty() != true) //funcion de busqueda, corrobora primero que la cola tenga datos
                        {
                            //definición de variables y solicitud del apellido como criterio para la busqueda
                            string apellidoBusq;
                            Alumno Encontrado = new Alumno();
                            Console.WriteLine("Ingrese el apellido del alumno que desea buscar: ");
                            apellidoBusq = Console.ReadLine();
                            Encontrado = ColaAlumnos.Search(apellidoBusq); //implementación de la función de busqueda con devolución del primer objeto alumno que coincide con el criterio
                            if (Encontrado != null) //en caso de que se haya encontrado un apellido igual al buscado se imprimen los datos del alumno
                            {
                                Console.WriteLine("Los datos del alumno son: {0} {1} {2}", Encontrado.Nombre, Encontrado.Apellido, Encontrado.FechaNac.ToString("dd/mm/yyyy"));
                            }
                            else //mensaje en caso de que no se encuentren apellidos iguales
                            {
                                Console.WriteLine("No se encontraron alumnos con ese apellido \n ");
                            }
                        }
                        else //mensaje en caso de que no se encuentren alumnos
                        {
                            Console.WriteLine("La Cola de Alumnos se encuentra vacia \n");
                        }
                        break;
                    case 4:
                        //ColaAlumnos.IsEmpty();
                        if (ColaAlumnos.IsEmpty() != true) //corroboración del estado de la cola e impresión en caso de que NO este vacia
                        {
                            Console.WriteLine("La Cola no esta vacia. Hay lugares ocupados\n");
                        }
                        else //En caso de que SI este vacia
                        {
                            Console.WriteLine("La Cola de Alumnos se encuentra vacia \n");
                        }
                        break;
                    case 5:
                        //ColaAlumnos.IsFull();
                        if (ColaAlumnos.IsFull() != true) //corroboración del estado de la cola e impresión en caso de que NO este llena
                        {
                            Console.WriteLine("La Cola de Alumnos no esta llena. Hay lugares disponibles en \n");
                        }
                        else //En caso de que SI este llena
                        {
                            Console.WriteLine("La Cola de Alumnos esta llena \n");
                        }
                        break;
                    case 6:
                        ColaAlumnos.Dequeue(); //función directa de eliminar primer alumno de la cola
                        break;
                    case 7:
                        ColaAlumnos.Show(); //función de mostrar alumnos
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