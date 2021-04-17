using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //--i;
            //Console.WriteLine(i--);
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //int result = 10;
            //try
            //{
            //    int a = 50;
            //    int b = 0;
            //    result = a / b;
            //    Console.WriteLine("Error división");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error general");
            //}
            //finally
            //{
            //    Console.WriteLine("Resultado: {0}", result);
            //}

            Console.ReadLine();
        }
    }
}
