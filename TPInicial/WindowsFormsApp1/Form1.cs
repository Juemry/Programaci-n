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
    public partial class frmcalculadora : Form
    {
        public frmcalculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            Txtrta.Text = Convert.ToString(Convert.ToInt32(Txtop1.Text) - Convert.ToInt32(Txtop2.Text));
        }

        private void Btnprod_Click(object sender, EventArgs e)
        {
            Txtrta.Text = (Int32.Parse(Txtop1.Text) * Int32.Parse(Txtop2.Text)).ToString();

        }

        private void Btncoc_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(Txtop1.Text);
            int den = Int32.Parse(Txtop2.Text);
            if (den != 0)
            {
                Txtrta.Text = (Int32.Parse(Txtop1.Text) / Int32.Parse(Txtop2.Text)).ToString();
            }
            

        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            Txtrta.Text = (Int32.Parse(Txtop1.Text) + Int32.Parse(Txtop2.Text)).ToString();

        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtop1.Text = "";
            Txtop2.Text = "";
            Txtrta.Text = "";
            this.Txtop1.Focus();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
