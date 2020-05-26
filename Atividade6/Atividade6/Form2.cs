using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double somatoria = 0;
                int n = Convert.ToInt32(txtNumero.Text);

                for (int cont = 1; cont <= n; cont++)
                {
                    somatoria = somatoria +  (1 / Convert.ToDouble(cont));
                }

                MessageBox.Show("H = " + somatoria.ToString("N2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
