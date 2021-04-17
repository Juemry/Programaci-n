using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int linea = 0;
            ////int diametro = 0;
            //Console.WriteLine("Ingrese medida de un (1) lado del cuadrado..!");

            //lado = Int32.Parse(Console.ReadLine())*4;
            ////diametro =lado * 4;

            Console.WriteLine("bienvenido campeones al champions legion");//, lado);
            Console.WriteLine("Elija la linea que desea jugar(1 a 5):");//, lado);
            Console.WriteLine("TOP");
            Console.WriteLine("JG");
            Console.WriteLine("MID");
            Console.WriteLine("BOT");
            Console.WriteLine("SUP");
            linea = Int32.Parse(Console.ReadLine());
            while (linea < 5) { 
            switch (linea)
                {
                case 1: 
                    Console.WriteLine("Usted eligio TOP");
                    break;
                case 2:
                    Console.WriteLine("Usted eligio JG");
                    break;

                case 3:
                    Console.WriteLine("Usted eligio MID");
                    break;

                case 4:
                    Console.WriteLine("Usted eligio BOT");
                    break;

                case 5:
                    Console.WriteLine("Usted eligio SUP");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
            }
            Console.WriteLine("Gracias por elegir champions legion");//, lado);
            Console.ReadLine();

        }
    }
}
