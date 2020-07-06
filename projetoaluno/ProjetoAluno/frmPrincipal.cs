using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql; //Provedor do SQL Server
using System.Data.SqlClient;

namespace ProjetoAluno
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=LAPTOP-PBSA575E\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro com o banco de dados =/" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade novo = new frmCidade();

            novo.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno novo = new frmAluno();

            novo.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre novo = new Sobre();

            novo.Show();
        }
    }
}
