using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmradiobutton : Form
    {
        public frmradiobutton()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            {
                this.Txt1.Text = null;
                this.Txt2.Text = null;
                this.Txtrta.Text = null;
            }
        }

        private void Btnif_Click(object sender, EventArgs e)
        {
            if (this.Optresta.Checked)
            {
                this.Txtrta.Text = (Int32.Parse(Txt1.Text) - Int32.Parse(Txt2.Text)).ToString();
            }
            if (this.Optsuma.Checked)
            {
                this.Txtrta.Text = (Int32.Parse(Txt1.Text) - Int32.Parse(this.Txt2.Text)).ToString();
            }
            if (Optcoc.Checked)
            {
                if (Int32.Parse(this.Txt2.Text) != 0)
                {
                    this.Txtrta.Text = (Int32.Parse(this.Txt1.Text) / Int32.Parse(this.Txt2.Text)).ToString();
                }
            }
            if (Optprod.Checked)
            {
                this.Txtrta.Text = (Convert.ToInt32(this.Txt1.Text) * Convert.ToInt32(this.Txt2.Text)).ToString();
            }
            if (this.Optsuma.Checked)
            {
                this.Txtrta.Text = (Convert.ToInt32(this.Txt1.Text) + Convert.ToInt32(this.Txt2.Text)).ToString();
            }
        }

        private void Btnswitch_Click(object sender, EventArgs e)
        {
            bool mayor_cero = true;
            int opcion = 0;
            if (this.Txt1.Text != null && this.Txt2.Text != null)
            {
                if (Int32.Parse(this.Txt2.Text) != 0)
                {
                    mayor_cero = true;
                }
                else
                {
                    mayor_cero = false;
                }
                if (this.Optsuma.Checked) opcion = 1;
                if (this.Optresta.Checked) opcion = 2;
                if (this.Optprod.Checked) opcion = 3;
                if (this.Optcoc.Checked)
                {
                    if (mayor_cero) opcion = 4;
                }
                switch (opcion)
                {
                    case 1:
                        this.Txtrta.Text = (Int32.Parse(Txt1.Text) + Int32.Parse(this.Txt2.Text)).ToString(); break;
                    case 2:
                        this.Txtrta.Text = (Int32.Parse(Txt1.Text) - Int32.Parse(Txt2.Text)).ToString();
                        break;
                    case 3:
                        this.Txtrta.Text = (Int32.Parse(this.Txt1.Text) * Int32.Parse(this.Txt2.Text)).ToString();
                        break;
                    case 4:
                        this.Txtrta.Text = (Int32.Parse(this.Txt1.Text) / Int32.Parse(this.Txt2.Text)).ToString();
                        break;
                    default:
                        string mensaje = "La operación no se puede realizar";
                        string titulo = "Importante";
                        MessageBoxButtons botones = MessageBoxButtons.YesNo;
                        DialogResult resultado;
                        resultado = MessageBox.Show(mensaje, titulo, botones);
                        if (resultado == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Txt1.Text = null;
                            this.Txt2.Text = null;
                            this.Txtrta.Text = null;
                        }
                        break;
                }
            }
        }
    }
    }
}
