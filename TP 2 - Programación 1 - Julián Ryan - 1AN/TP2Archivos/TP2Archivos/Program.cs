using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rutas de acceso a los archivos
            string Tarjetas = ConfigurationManager.AppSettings["rutaArchivoTarjetas"];
            string Test = ConfigurationManager.AppSettings["rutaArchivoTest"];
            string Consolidado = ConfigurationManager.AppSettings["rutaArchivoConsolidado"];
            //Creación de un diccionario para trabajar con los archivos
            Dictionary<string, Tarjetas> Acumulador = new Dictionary<string, Tarjetas>();
            //Menu de operaciones
            int opc = 0;
            Console.WriteLine("**Software de Tarjetas**\n\n");
            do
            {
                Console.WriteLine("\n\n Ingrese la accion que desea realizar: ");
                Console.WriteLine("1) Mostrar archivo de tarjetas");
                Console.WriteLine("2) Mostrar nuevos datos");
                Console.WriteLine("3) Consolidar y mostrar nuevos actualizados");
                Console.WriteLine("Ingrese la accion que desea realizar (cero para salir): ");
                opc = Int32.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        ManejoDeArchivos.MostrarTarjetas(Tarjetas, Acumulador);
                        break;
                    case 2:
                        ManejoDeArchivos.MostrarTest(Test, Acumulador);
                        break;
                    case 3:
                        ManejoDeArchivos.Tarjetas(Tarjetas, Acumulador);
                        ManejoDeArchivos.Test(Test, Acumulador);
                        ManejoDeArchivos.Consolidado(Consolidado, Acumulador);
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
