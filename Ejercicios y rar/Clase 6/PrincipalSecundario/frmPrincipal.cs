using Listas.Model;
using Listas.Model.TDA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincipalSecundario
{
    public partial class frmPrincipal : Form
    {
        public Lista ListaPacientes { get; set; } = new Lista();

        frmSecundario frmSecundarioObj;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if(frmSecundarioObj == null)
                frmSecundarioObj = new frmSecundario();

            frmSecundarioObj.Show();
        }

        private void btnMostrarHolaMundo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculto el principal...
            frmSecundario frmSecundarioObjDialog = new frmSecundario();

            DialogResult resultado = frmSecundarioObjDialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Acá caigo cuando desde el formulario secundario aceptaron ALGO...
                this.BackColor = frmSecundarioObjDialog.ColorSeleccionado;

                MessageBox.Show("Agregando un paciente desde el form secundario: " + frmSecundarioObjDialog.Pac1.Nombre); //Traer un objeto desde otro form...

                ListaPacientes.AgregarAlComienzo(frmSecundarioObjDialog.Pac1);
                RefrescarListBox();

                MessageBox.Show("El usuario aceptó");
            }
            else
                MessageBox.Show("El usuario canceló");            

            this.Show();//Vuelvo a mostrarme...
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Paciente paciente1 = new Paciente(37);
            paciente1.Nombre = "Lucía";
            ListaPacientes.AgregarAlComienzo(paciente1);

            Paciente paciente2 = new Paciente();
            paciente2.Nombre = "Martín";
            ListaPacientes.AgregarAlComienzo(paciente2);

            Paciente paciente3 = new Paciente();
            paciente3.Nombre = "Jorge";
            ListaPacientes.AgregarAlComienzo(paciente3);

            RefrescarListBox();
        }

        private void RefrescarListBox()
        {            
            Paciente paciente = ListaPacientes.QuitarAlComienzo();

            while (paciente != null)
            {
                lstPacientes.Items.Add(paciente.Nombre);
                paciente = ListaPacientes.QuitarAlComienzo();
            }
        }
    }
}
