using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int qtdeBrancos = 0;

            if (rchtxtFrases.Text.Length <= 100)
            {
                foreach (char x in rchtxtFrases.Text)
                {
                    if (char.IsWhiteSpace(x))
                        qtdeBrancos++;
                }
                MessageBox.Show("Quantidade de espaços em brancos: " + qtdeBrancos);
            }
            else
                MessageBox.Show("Limte de 100 letras");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int contador = 0;

            if (rchtxtFrases.Text.Length <= 100)
            {

                for(int x = 0; x < rchtxtFrases.Text.Length; x++)
                {
                    if (rchtxtFrases.Text[x] == 'r')
                        contador++;
                }

                MessageBox.Show("Quantidade de R: " + contador);
            }
            else
                MessageBox.Show("Limte de 100 letras");
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int contador = 0;

            if (rchtxtFrases.Text.Length <= 100)
            {
                for (int cont = 0; cont < rchtxtFrases.Text.Length - 1; cont++)
                {
                    if (rchtxtFrases.Text[cont] == rchtxtFrases.Text[cont + 1])
                        contador++;
                }

                MessageBox.Show("Quantidade de ocorrencia de pares: " + contador);
            }
            else
                MessageBox.Show("Limte de 100 letras");
        }
    }
}
