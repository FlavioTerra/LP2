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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExercicio2 frm2 = new FormExercicio2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Normal;
            frm2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExercicio3 frm3 = new FormExercicio3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Normal;
            frm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExercicio4 frm4 = new FormExercicio4();
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Normal;
            frm4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExercicio5 frm5 = new FormExercicio5();
            frm5.MdiParent = this;
            frm5.WindowState = FormWindowState.Normal;
            frm5.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
