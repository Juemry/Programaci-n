using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Ejercicio 1*");
            float a, b, c;
            a = 10;
            b = (float)30.5;
            c = (float)(a + b);
            Console.WriteLine("{0}+{1}={2}", a, b, c);
            Console.ReadKey();
        }
    }
}
