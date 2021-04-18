using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PracticosEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los ejercicios estan hechos como metodos y comentados, tal como sugirió el profesor
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            //Ejercicio8();
            //Ejercicio9();
            //Ejercicio15();

        }

        private static void Ejercicio15()
        {
            //Ejercicio 15
            //Informar cuantos días faltan para el 25 / 12 / 2020.
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now}");
            Console.WriteLine($"Fecha formateada: {now.ToString("yyyyMMdd")}");
            string ffutura = "25/12/2020";
            DateTime navidad;
            navidad = DateTime.Parse(ffutura);
            Console.WriteLine($"Navidad es el {navidad.ToString("dd/MM/yyyy")} y cae un {navidad.DayOfWeek}");
            TimeSpan paranavidadfalta;
            paranavidadfalta = navidad - now;
            Console.WriteLine($"Para navidad faltan: {paranavidadfalta.Days} dias");
            Console.ReadKey();
        }

        private static void Ejercicio9()
        {
            //Ejercicio 9
            //Dadas dos frases concatenarlas y mostrar el resultado.
            String frase1;
            String frase2;
            Console.WriteLine("Ingrese una frase, por favor: ");
            frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese otra frase, por favor: ");
            frase2 = Console.ReadLine();
            Console.WriteLine("El resultado de ambas frases es : {0} {1}", frase1, frase2);
            Console.ReadKey();
        }

        private static void Ejercicio8()
        {
            //Ejercicio 8
            //Calcular el factorial de 6.
            int numero0 = 1 * 2 * 3 * 4 * 5 * 6;
            Console.Write("El factorial de 6 (!6) es de: {0} \n", numero0);
            int numero1 = 0;
            int i = 1;
            int numero2 = 1;
            Console.WriteLine("Si desea calcular el factorial de otro numero ingreselo por favor. 0 para salir");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if (numero1 != 0)
            {
                for (i = 1; i <= numero1; i++)
                {
                    numero2 = numero2 * i;
                }
                Console.Write("El factorial del numero {0}, es de: {1}", numero1, numero2);
                Console.ReadKey();
            }

            Console.ReadKey();
        }

        private static void Ejercicio7()
        {
            //Ejercicio 7
            //Si 1Byte tiene 8 bits, desarrolle una solución programática que permita calcular cuántos bits hay en cualquier combinación de x KBytes. Explique cómo llegó a esa conclusión.
            int numero1 = 0;
            Console.WriteLine("Ingrese una cantidad de KiloBytes (KB) que desea transformar a Bits por favor: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            //La cantidad de Bits en un KiloByte es de 8000, por ende, para obtener la cantidad de de Bits en un KB, hay que multiplicar por 8000
            Console.Write("La cantidad de Bits que hay en {0} KB, es de {1} Bits", numero1, numero1 * 8000);
            Console.ReadKey();
        }

        private static void Ejercicio6()
        {

            //Ejercicio 6
            //Si la circunferencia de un círculo es pi *Diámetro, desarrollar una aplicación que dada la circunferencia calcule el diámetro.
            double numero1 = 0;
            double numero2 = 3.1415;
            Console.WriteLine("Ingrese la circunferencia del circulo para obtener el diametro, por favor: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("El diametro del circulo, cuya circunferencia es de {0}, es de: {1}", numero1, numero1 / numero2);
            Console.ReadKey();
        }

        private static void Ejercicio5()
        {
            //Ejercicio 5
            //Dados los datos necesarios de un Rectángulo calcular la superficie.
            int numero1 = 0;
            int numero2 = 0;
            Console.WriteLine("Ingrese la altura del rectangulo por favor: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la base del rectangulo por favor: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("La superficie del rectangulo cuya altura es de {0} y base de {1}, es de: {2}", numero1, numero2, numero1 * numero2);
            Console.ReadKey();
        }

        private static void Ejercicio4()
        {
            //Ejercicio 4
            //Dados los datos necesarios de un Cuadrado calcular la superficie.
            int numero1 = 0;
            Console.WriteLine("Ingrese el valor de los lados del cuadrado por favor: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("La superficie del cuadrado cuyas lados son de {0}, es de: {1}", numero1, numero1 * numero1);
            Console.ReadKey();
        }

        private static void Ejercicio3()
        {
            //Ejercicio 3
            //Dados los lados de un triangulo calcular el perímetro.
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            Console.WriteLine("Ingrese el primer lado del triangulo por favor: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado del triangulo por favor: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado del triangulo por favor: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("El perimetro del triangulo conformado por los lados {0}, {1} y {2} es de: {3}", numero1, numero2, numero3, numero1 + numero2 + numero3);
            Console.ReadKey();
        }

        private static void Ejercicio2()
        {
            //Ejercicio 2
            //Desarrollar una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos.
            int numero1 = 0;
            int numero2 = 0;
            Console.WriteLine("Ingrese un numero por favor: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero por favor: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 >= numero2)
            {
                Console.Write("La cantidad de numeros entre {0} y {1}, es de: {2}", numero1, numero2, numero1 - numero2);
                Console.ReadKey();
            }
            else
            {
                Console.Write("La cantidad de numeros entre {0} y {1}, es de: {2}", numero1, numero2, numero2 - numero1);
                Console.ReadKey();
            }
        }

        private static void Ejercicio1()
        {
            //Ejercicio 1
            //Dados dos valores ingresados por teclado mostrar la suma de ambos.
            int Numero1 = 0;
            int Numero2 = 0;
            Console.WriteLine("Ingrese un número por favor: ");
            Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número por favor: ");
            Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es {0} ", Numero1 + Numero2);
            Console.ReadKey();
        }
    }
}
