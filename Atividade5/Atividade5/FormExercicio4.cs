using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class FormExercicio4 : Form
    {
        public FormExercicio4()
        {
            InitializeComponent();
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (char c in rchtxtTexto.Text)
            { 
                if (char.IsLetter(c))
                    contador++;
            }

            MessageBox.Show("Caracteres Alfabéticos:" + contador);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            while(x < rchtxtTexto.Text.Length)
            {
                if (char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("A posição em branco e:" + (x + 1));
                    break;
                }

                x++;
            }
        }

        private void btnNumerico_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for(var x = 0; x < rchtxtTexto.Text.Length; x++)
            {
                if (char.IsNumber(rchtxtTexto.Text[x]))
                    contador++;
            }
            MessageBox.Show("Caracteres Numéricos: " + contador);
        }

    }
}
