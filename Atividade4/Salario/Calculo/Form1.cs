using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            double bruto, descINSS, descIRPF, salFamilia = 0, salLiquido;
            byte qtdeFilhos;


            if (double.TryParse(mskbxSalariobruto.Text, out bruto) && byte.TryParse(mskbxFilhos.Text, out qtdeFilhos) && txtNome.Text != "")
            {
                if (bruto <= 800.47)
                {
                    mskbxINSS.Text = "7.65%";
                    descINSS = 0.0765 * bruto;
                }
                else if (bruto <= 1050)
                {
                    mskbxINSS.Text = "8.65%";
                    descINSS = 0.0865 * bruto;
                }
                else if (bruto <= 1400.77)
                {
                    mskbxINSS.Text = "9.00%";
                    descINSS = 0.09 * bruto;
                }
                else if (bruto <= 2801.56)
                {
                    mskbxINSS.Text = "11.00%";
                    descINSS = 0.11 * bruto;
                }
                else
                {
                    mskbxINSS.Text = "Teto";
                    descINSS = 308.17;
                }

                mskbxINSSdesconto.Text = descINSS.ToString("N2");

                if (bruto <= 1257.12)
                {
                    mskbxIRPF.Text = "0";
                    descIRPF = 0;
                }
                else if (bruto <= 2512.08)
                {
                    mskbxIRPF.Text = "15.00%";
                    descIRPF = bruto * 0.15;
                }
                else
                {
                    mskbxIRPF.Text = "27.5%";
                    descIRPF = bruto * 0.275;
                }

                mskbxIRPFdesconto.Text = descIRPF.ToString("N2");

                if (bruto <= 435.52)
                    salFamilia = qtdeFilhos * 22.33;

                else if (bruto <= 654.61)
                    salFamilia = qtdeFilhos * 15.74;

                mskbxSalariofamilia.Text = salFamilia.ToString("N2");

                salLiquido = bruto - descIRPF - descINSS + salFamilia;

                mskbxSalarioliquido.Text = salLiquido.ToString("N2");

                if (rbtnMasculino.Checked)
                {
                    if (ckbxCasado.Checked)
                        lblDados.Text = "Os descontos do salário do Sr." + txtNome.Text +
                           "\nQue é casado\nE que tem " + qtdeFilhos + " filho(s) são:\n";
                    else
                        lblDados.Text = "Os descontos do salário do Sr." + txtNome.Text +
                           "\nQue é solteiro\nE que tem " + qtdeFilhos + " filho(s) são:\n";
                }
                else
                {
                    if (ckbxCasado.Checked)
                        lblDados.Text = "Os descontos do salário da Sr." + txtNome.Text +
                           "\nQue é casada\nE que tem " + qtdeFilhos + " filho(s) são:\n";
                    else
                        lblDados.Text = "Os descontos do salário da Sr." + txtNome.Text +
                           "\nQue é solteira\nE que tem " + qtdeFilhos + " filho(s) são:\n";
                }
            }
            else
                MessageBox.Show("Entrada inválida!");

        }
    }
}
