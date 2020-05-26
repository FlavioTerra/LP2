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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            string frase = txtPalavra.Text;
            string s = "";

            if (txtPalavra.Text.Length <= 50)
            {
                for (int x = 0; x < frase.Length; x++)
                {
                    if(char.IsWhiteSpace(frase[x]))
                        frase = frase.Remove(x, 1);
                }

                char[] frase2 = frase.ToCharArray();
                Array.Reverse(frase2);

                foreach (char c in frase2)
                    s = s + c.ToString();

                if(s == frase)
                    MessageBox.Show("É um palíndromo");
                else
                    MessageBox.Show("Não é palíndromo");
            }
            else
                MessageBox.Show("Limite máximo de 50 letras");
        }
    }
}
