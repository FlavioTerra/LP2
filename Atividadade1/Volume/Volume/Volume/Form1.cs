using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtAltura.Clear();
            txtVolume.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if((double.TryParse(txtRaio.Text, out verify1) && double.TryParse(txtAltura.Text, out verify2)))
            {
                double Volume = Math.PI * Math.Pow(verify1, 2) * verify2;
                txtVolume.Text = Volume.ToString("N2");
            }
            else
                MessageBox.Show("Dados Inválidos!");

        }
    }
}
