using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int a, b;
            Console.WriteLine("ingrese un valor");
            cadena = Console.ReadLine();
            a = Convert.ToInt32(cadena);
            Console.WriteLine("ingrese otro valor");
            cadena = Console.ReadLine();
            b = Convert.ToInt32(cadena);
            if (a == b)
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("son distintos");
                if (a < b)
                {
                    Console.WriteLine("el primero es menor al segundo");
                }
                else
                {
                    Console.WriteLine("el segundo es menor al primero");
                }
            }
            Console.Read();

        }
    }
}
