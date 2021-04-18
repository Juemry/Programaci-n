using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AllocConsole();//Agregar esta línea dentro del constructor 
            InitializeComponent();
        } //Agregar estas dos líneas seguido al constructor 
        [System.Runtime.InteropServices.DllImport("kernel32.dll")] 
        private static extern bool AllocConsole();

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btnejecutar_Click(object sender, EventArgs e)
        {
            {
                string dato;
                int[] vector; //declaro mi vector 
                vector = new int[10];//inicializo mi vector 
                //recorro con el ciclo for las 10 posiciones del vector para cargar el mismo 
                int i; for (i = 1; i < 10; i++)
                {
                    Console.WriteLine("Ingrese un valor: ");//Imprimo en pantalla 
                    dato = Console.ReadLine();//Guardo en mi variable dato el valor ingresado por consola 
                    vector[i] = Int32.Parse(dato); //guardo el dato en el vector, en la posición i(i toma el valor del bucle) 
                }
                Console.WriteLine("Los datos del vector fueron impresos"); //Recorro nuevamente el vector, para cargar los datos en mi listBox 
                for (i = 1; i < 10; i++)
                {
                    Lst1.Items.Add("En la posición : " + i + " el valor es: " + vector[i]);
                }
            }
        }
    }
}
