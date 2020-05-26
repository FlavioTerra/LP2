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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();

            novo.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();

            novo.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 novo = new Form3();

            novo.Show();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            Form4 novo = new Form4();

            novo.Show();
        }
    }
}
