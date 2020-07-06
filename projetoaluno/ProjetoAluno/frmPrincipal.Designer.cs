namespace ProjetoAluno
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCidade = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastro,
            this.btnSobre,
            this.btnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCadastro
            // 
            this.btnCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCidade,
            this.btnAluno});
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(66, 20);
            this.btnCadastro.Text = "Cadastro";
            // 
            // btnCidade
            // 
            this.btnCidade.Name = "btnCidade";
            this.btnCidade.Size = new System.Drawing.Size(111, 22);
            this.btnCidade.Text = "Cidade";
            this.btnCidade.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(111, 22);
            this.btnAluno.Text = "Aluno";
            this.btnAluno.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(49, 20);
            this.btnSobre.Text = "Sobre";
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 20);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 245);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCadastro;
        private System.Windows.Forms.ToolStripMenuItem btnCidade;
        private System.Windows.Forms.ToolStripMenuItem btnAluno;
        private System.Windows.Forms.ToolStripMenuItem btnSobre;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
    }
}

