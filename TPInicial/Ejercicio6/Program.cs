﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int leg, sdo, tot, cont;
            float prom;
            tot = cont = 0;
            prom = 0;
            Console.WriteLine("ingrese el num de legajo");
            cadena = Console.ReadLine();
            leg = Convert.ToInt32(cadena);
            while (leg != 0)
            {
                Console.WriteLine("ingrese el sueldo");
                cadena = Console.ReadLine();
                sdo = Convert.ToInt32(cadena);
                tot = tot + sdo;
                cont = cont + 1;
                Console.WriteLine("ingrese el num de legajo. 0 para salir");
                cadena = Console.ReadLine();
                leg = Convert.ToInt32(cadena);
            }
            Console.WriteLine("el total pagado es {0}\n", tot);
            Console.ReadKey();
            prom = (float)(tot / cont);
            Console.WriteLine("el sueldo promedio es {0,2:F2}", prom);
            //Console.WriteLine("el sueldo promedio es {0}", prom);
            Console.ReadKey();

        }
    }
}
