using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp1Programación.Model;

namespace Tp1Programación
{
    public partial class frmPrincipal : Form
    {
        Lista Lista = new Lista();
        frmSecundario frm;
       
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bttnOtro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm = new frmSecundario();
            frm.ShowDialog();
            this.Show();
            
        }

        public void bttnCargar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese el nombre del alumno para continuar y pulse 'Agregar'");
            }
            else
            {

                Alumno unNuevoNodo = new Alumno();
                unNuevoNodo.Nombre = txtNombre.Text;
                Lista.AgregarUnNodo(unNuevoNodo);
                txtNombre.Text = "";
                MostrarLista();
              
            }

        }
        public void MostrarLista()
        {
            lstNombres.Items.Clear();

            if (Lista.Inicial != null)
            {
                AgregarNombreLista(Lista.Inicial);
            }
            
           
        }

        public void AgregarNombreLista(Alumno nombre)
        {
            if(nombre != null)
            {
                lstNombres.Items.Add(nombre.Nombre);
                AgregarNombreLista(nombre.Siguiente);
            }
        }

        private void BttnTope_Click(object sender, EventArgs e)
        {
            if (Lista.Inicial != null)
            {
                Nodo temporal =Inicial;
                while (temporal.Siguiente != null)
                {

                    temporal = temporal.Siguiente;
                }


                return temporal;

            }
            return inicial;
        }
    }
}
