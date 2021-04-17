using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int a, tot, i;
            tot = 00;
            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("ingrese un valor");
                cadena = Console.ReadLine();
                a = Convert.ToInt32(cadena);
                tot = tot + a;
            }
            Console.WriteLine("el total de la suma es {0}", tot);
            Console.ReadKey();
        }
    }
}
