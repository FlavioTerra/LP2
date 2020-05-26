using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double salario = Convert.ToDouble(txtSalario.Text);
                double salBruto = 0;
                double prod = Convert.ToDouble(txtProducao.Text);
                double gratificacao = Convert.ToDouble(txtGratificacao.Text);

                if (prod >= 150)
                    salBruto = salario + (salario * 0.25) + gratificacao;
                else if (prod >= 120)
                    salBruto = salario + (salario * 0.15) + gratificacao;
                else if (prod >= 100)
                    salBruto = salario + (salario * 0.05) + gratificacao;
                else
                    salBruto = salario + gratificacao;

                if (salBruto >= 7000 && prod < 150 || salBruto >= 7000 && gratificacao == 0)
                    MessageBox.Show("Salário imcompativel");
                else
                    txtSalBruto.Text = salBruto.ToString("N2");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
