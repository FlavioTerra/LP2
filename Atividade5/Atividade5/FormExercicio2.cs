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
    public partial class FormExercicio2 : Form
    {
        public FormExercicio2()
        {
            InitializeComponent();
        }

        private void btnIguais_Click(object sender, EventArgs e)
        {
            if(string.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
                MessageBox.Show("São iguais!");          
            else
                MessageBox.Show("São diferentes!");
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int meio;

            meio = txtPalavra2.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + 
            txtPalavra1.Text + txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length - meio);

        }

        private void btnInserir3_Click(object sender, EventArgs e)
        {
            int meio;

            meio = txtPalavra1.Text.Length / 2;
            txtPalavra1.Text = txtPalavra1.Text.Insert(meio, "**");
        }
    }
}
