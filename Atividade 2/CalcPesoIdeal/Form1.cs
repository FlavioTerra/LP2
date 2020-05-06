using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double altura, peso, resul;

                altura = Convert.ToDouble(mskbxAltura.Text);
                peso = Convert.ToDouble(mskbxPeso.Text);

                if (rbtnMasculino.Checked)
                    resul = 72.7 * altura - 58;
                else
                    resul = 62.1 * altura - 44.7;

                if(peso < resul)
                    MessageBox.Show("Coma bastante massas e doces");
                else if(peso == resul)
                    MessageBox.Show("Você está com o peso ideal");
                else
                    MessageBox.Show("Regime Obrigatório Já");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ ex.Message);
            }
        }
    }
}
