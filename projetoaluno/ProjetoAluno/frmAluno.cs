using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAluno
{
    public partial class frmAluno : Form
    {
        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();

        public frmAluno()
        {
            InitializeComponent();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            Cidade Cid = new Cidade(); 
            dsCidade.Tables.Add(Cid.Listar());

            cbxCidade.DataSource = dsCidade.Tables["TBCIDADE"];

            cbxCidade.DisplayMember = "nome_cidade";

            cbxCidade.ValueMember = "id_cidade";

            cbxCidade.DataBindings.Add("SelectedValue", bnAluno, "cidade_id_aluno");

            try
            {
                Aluno Alu = new Aluno();
                dsAluno.Tables.Add(Alu.Listar());
                bnAluno.DataSource = dsCidade.Tables["TBALUNO"];
                dgvAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;

                txtRa.DataBindings.Add("TEXT", bnAluno, "ra_aluno");
                txtNomeAluno.DataBindings.Add("TEXT", bnAluno, "nome_aluno");
                cbxCidade.DataBindings.Add("SelectedItem", bnAluno, "cidade_id_aluno");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmAluno_Load_1(object sender, EventArgs e)
        {

        }
    }
}
