using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLado1.Clear();
            txtLado2.Clear();
            txtLado3.Clear();
            txtResultado.Clear();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            double Lado1, Lado2, Lado3;

            if(double.TryParse(txtLado1.Text, out Lado1) && double.TryParse(txtLado2.Text, out Lado2) && double.TryParse(txtLado3.Text, out Lado3))
            {
                if (Math.Abs(Lado2 - Lado3) < Lado1 && Math.Abs(Lado2 + Lado3) > Lado1
                && Math.Abs(Lado1 - Lado3) < Lado2 && Math.Abs(Lado1 + Lado3) > Lado2
                && Math.Abs(Lado2 - Lado1) < Lado3 && Math.Abs(Lado2 + Lado1) > Lado3)
                {
                    if (Lado1 == Lado2 && Lado2 == Lado3 && Lado3 == Lado1)
                        txtResultado.Text = "Equilátero";
                    else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado3 == Lado1)
                        txtResultado.Text = "Isósceles";
                    else
                        txtResultado.Text = "Escaleno";


                }
                else
                    txtResultado.Text = "Não Forma Triângulo";
            }
            else
                MessageBox.Show("Dados inválidos!");

        }
    }
}
