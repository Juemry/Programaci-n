using Listas.Model;
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
    public partial class frmSecundario : Form
    {
        public Paciente Pac1 { get; set; }
        public Color ColorSeleccionado { get; set; }
        public frmSecundario()
        {
            InitializeComponent();
        }

        private void frmSecundario_Load(object sender, EventArgs e)
        {
            Pac1 = new Paciente();
            Pac1.Nombre = "Pedro";

            cmbColores.Items.Add("Rojo");
            cmbColores.Items.Add("Azul");
            cmbColores.Items.Add("Verde");
            cmbColores.Items.Add("Amarillo");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //string colorSeleccionado = cmbColores.SelectedItem.ToString();

            //if (colorSeleccionado == "Rojo")
            //    ColorSeleccionado = Color.Red;

            //if (colorSeleccionado == "Azul")
            //    ColorSeleccionado = Color.Blue;

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorSeleccionado = colorDialog.Color;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
