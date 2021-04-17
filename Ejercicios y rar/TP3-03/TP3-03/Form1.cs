using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_03
{
    public partial class Form1 : Form
    {
        public int acum;
        public Form1()
        {
            InitializeComponent();
       
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            LSTnumeros.Items.Clear();
            TXTnumero.Text = "0";
            LBLresultado.Text = "0";
            acum = 0;
        }

        private void BTNcargar_Click(object sender, EventArgs e)
        {
            LSTnumeros.Items.Add(TXTnumero.Text);
            acum = acum + Int32.Parse(TXTnumero.Text);
            LBLresultado.Text = acum.ToString();
            TXTnumero.Clear();
            TXTnumero.Focus();
        }
    }
}
