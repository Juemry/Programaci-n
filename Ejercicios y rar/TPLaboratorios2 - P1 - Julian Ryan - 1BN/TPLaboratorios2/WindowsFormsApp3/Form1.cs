using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string dato;
        int[] vector; //declaro mi vector
        //int i;

        public Form1()
        {
            AllocConsole();//Agregar esta línea dentro del constructor 
            InitializeComponent();
        } //Agregar estas dos líneas seguido al constructor 
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void Btnejecutar_Click(object sender, EventArgs e)
        {
            Lst1.Items.Clear(); //limpio los items de la lista
            vector = new int[10];//inicializo mi vector
                                 //recorro con el ciclo for las 10 posiciones del vector para cargar el mismo
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor: ");
                dato = Console.ReadLine();
                vector[i] = Int32.Parse(dato);
            }
            Console.WriteLine("Los datos del vector fueron impresos");
            //Recorro nuevamente el vector, para cargar los datos en mi listBox
            for (int i = 0; i < 10; i++)
            {
                Lst1.Items.Add("En la posición : " + i + " el valor es: " + vector[i]);
            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lst1.Items.Clear();
            Array.Sort(vector);//esta instrucción ordena el vector 
            for (int i = 0; i < 10; i++) 
            {
                Lst1.Items.Add("El valor es: " + vector[i] + " en la posición : " + i); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] vectorDestino = new int[20]; 
            Array.Copy(vector, 0, vectorDestino, 0, 10);
            for (int i = 0; i < 10; i++) 
            { 
                Lst1.Items.Add(vectorDestino[i] + " en la posición " + i); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int superior;
            int inferior;
            Lst1.Items.Clear();
            superior = vector.GetUpperBound(0);//Obtiene el índice del último elemento de la dimensión especificada en la matriz. 
            inferior = vector.GetLowerBound(0);// Obtiene el índice del primer elemento de la dimensión especificada en la matriz. 
            Lst1.Items.Add("El límite inferior es " + inferior + " y el superior es " + superior);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicion;
            posicion = Array.BinarySearch(vector, 9);
            Lst1.Items.Clear();
            Lst1.Items.Add("En la posicionposición " + posicion + " se encuentra el número 9");
        }

        
    }
}

