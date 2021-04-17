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
        Cola miCola = new Cola();
        Nodo listaFemeninos = new Nodo();
        Nodo listaMasculinos = new Nodo();
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
                Nodo unNuevoNuevo = new Nodo();
                unNuevoNuevo.Nombre = txtNombreNodo.Text;
                miCola.Encolar(unNuevoNuevo);
                MostrarCola();
            }
            
            if (txtSexo.Text == "1")
            {
                
                listaFemeninos.Nombre = txtNombreNodo.Text;
                listaFemeninos.Sexo = "F";
                //miCola.EncolarSexo(listaFemeninos);
                MostrarColaFemenino();
            }
            else
            {
                listaMasculinos.Sexo = "M";
                listaMasculinos.Nombre = txtNombreNodo.Text;
                //miCola.EncolarSexo(listaMasculinos);
                MostrarColaMasculino();
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


        private void MostrarColaFemenino()
        {
            lstFem.Items.Clear();
            MostrarNodoEnPantalla(miCola.Inicio);

        }

        private void MostrarColaMasculino()
        {
            lstMasc.Items.Clear();
            MostrarNodoEnPantalla(miCola.Inicio);
        }

        private void MostrarNodoEnPantalla(Nodo unNodo)
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

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(listaFemeninos.Siguiente != null)
            {
                lstFem.Items.Add("No hay elementos en la cola");
            }
            else
            {
                while (listaFemeninos.Siguiente != null) ;
                lstFem.Items.Add(listaFemeninos.Nombre);
                listaFemeninos = listaFemeninos.Siguiente;

            }

            if (listaMasculinos.Siguiente != null)
            {
                lstMasc.Items.Add("No hay elementos en la cola");
            }
            else
            {
                while (listaMasculinos.Siguiente != null) ;
                lstMasc.Items.Add(listaMasculinos.Nombre);
                listaMasculinos = listaMasculinos.Siguiente;

            }

            }
        }
    }

