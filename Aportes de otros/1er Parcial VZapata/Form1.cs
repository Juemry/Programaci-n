using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        Cola miCola = null;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length == 0)
            {
                MessageBox.Show("Ingresar un nombre valido, por favor");
            }
            else
            {
                Alumno unNuevoNuevo = new Alumno();
                unNuevoNuevo.Nombre = txtNombreNodo.Text;
                miCola.Encolar(unNuevoNuevo);
                MostrarCola();
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("No hay elementos en la cola");
            }
            else
            {
                miCola.Desencolar();
                MostrarCola();
            }
        }
        private void MostrarCola()
        {
            lstCola.Items.Clear();
            MostrarNodoEnPantalla(miCola.Inicio);

        }

        private void MostrarNodoEnPantalla(Alumno unNodo)
        {
            if (unNodo != null) 
            {
                lstCola.Items.Add(unNodo.Nombre);
            }

            if (unNodo.Siguiente != null)
            {
                MostrarNodoEnPantalla(unNodo.Siguiente);
            }
        }

        private void txtCantidadAlumnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicioCola_Click(object sender, EventArgs e)
        {
            miCola = new Cola(Int32.Parse(txtCantidadAlumnos.Text));
        }
    }
}
