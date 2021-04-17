using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TP2Archivos
{
    class ManejoDeArchivos
    {
        //Metodo para mostrar el contenido del archivo base con los datos de las tarjetas (no se considera la primera linea directamente)
        public static void MostrarTarjetas(string archivoTarjetas, Dictionary<string, Tarjetas> DicTarjetas)
        {
            using (StreamReader stream = new StreamReader(archivoTarjetas))
            {
                while (!stream.EndOfStream)
                {
                    Console.WriteLine(stream.ReadLine()); 
                }
            }
        }

        //Metodo para mostrar el contenido del nuevo archivo con los datos a modificar de las tarjetas (no se considera la primera linea directamente)
        public static void MostrarTest(string archivoTest, Dictionary<string, Tarjetas> DicTarjetas)
        {
            using (StreamReader stream = new StreamReader(archivoTest))
            {
                while (!stream.EndOfStream)
                {
                    Console.WriteLine(stream.ReadLine());
                }
            }
        }

        //Metodo para mostrar el contenido del archivo base con los datos de las tarjetas (no se considera la primera linea directamente)
        public static void Tarjetas(string archivoTarjetas, Dictionary<string, Tarjetas> DicTarjetas)
        {
            using (StreamReader stream = new StreamReader(archivoTarjetas))
            {
                while (!stream.EndOfStream)
                {
                    //Se lee el contenido del archivo y se guarda en un string
                    string line = stream.ReadLine();
                    //Los datos separados por ; se almacenan en distintos campos
                    string[] campos = line.Split(';');
                    //Se crea una nueva tarjeta va a almacenar los datos
                    Tarjetas NuevaTarjeta = new Tarjetas();
                    NuevaTarjeta.NroTarjeta = campos[0];
                    NuevaTarjeta.Local = campos[1];
                    NuevaTarjeta.CreditoDisponible = int.Parse(campos[2]);
                    //En caso de que haya una tarjeta nueva
                    if (!DicTarjetas.ContainsKey(NuevaTarjeta.NroTarjeta))
                    {
                        DicTarjetas.Add(NuevaTarjeta.NroTarjeta, NuevaTarjeta);
                    }
                    else
                        Console.WriteLine("Error, la clave ya existe!");
                }
            }
        }
        //Metodo en el que se descuenta el debito del archivo Test
        public static void Test(string archivoTest, Dictionary<string, Tarjetas> DicTarjetas)
        {
            using (StreamReader stream = new StreamReader(archivoTest))
            {
                while (!stream.EndOfStream)
                {
                    string linea = stream.ReadLine();
                    string[] campos = linea.Split(';');
                    string NroTarjeta = campos[0];
                    int Descuento = int.Parse(campos[1]);
                    if (DicTarjetas.ContainsKey(NroTarjeta))
                    {
                        Tarjetas NuevaTarjeta = new Tarjetas();
                        //Se aplica el descuento en segun especifique el campo
                        DicTarjetas[NroTarjeta].CreditoDisponible -= Descuento;
                    }
                }
            }
        }


        //Metodo en el que se genera un nuevo archivo con las especificaciones pedidas y los campos actualizados
        public static void Consolidado(string archivoConsolidado, Dictionary<string, Tarjetas> DicTarjetas)
        {
            using (StreamWriter stream = new StreamWriter(archivoConsolidado, true))
            {

                foreach (var item in DicTarjetas.Values)
                {
                    if (item.CreditoDisponible != 0)
                    {
                        string Salida = item.NroTarjeta + ";" + item.Local + ";NO;" + item.CreditoDisponible;
                        stream.WriteLine(Salida);
                        Console.WriteLine(Salida);
                    }
                    else
                    {
                        string lineaSalida = item.NroTarjeta + ";" + item.Local + ";SI;" + item.CreditoDisponible;
                        stream.WriteLine(lineaSalida);
                        Console.WriteLine(lineaSalida);
                    }

                }
            }
        }

    }
}
