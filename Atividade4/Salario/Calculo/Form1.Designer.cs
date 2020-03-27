namespace Calculo
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalariobruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalariofamilia = new System.Windows.Forms.Label();
            this.lblSalarioliquido = new System.Windows.Forms.Label();
            this.lblINSSdesconto = new System.Windows.Forms.Label();
            this.lblIRPFdesconto = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.mskbxSalariobruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mskbxINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalariofamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioliquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxINSSdesconto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxIRPFdesconto = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(7, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(106, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome funcionário";
            // 
            // lblSalariobruto
            // 
            this.lblSalariobruto.AutoSize = true;
            this.lblSalariobruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalariobruto.Location = new System.Drawing.Point(7, 56);
            this.lblSalariobruto.Name = "lblSalariobruto";
            this.lblSalariobruto.Size = new System.Drawing.Size(79, 13);
            this.lblSalariobruto.TabIndex = 1;
            this.lblSalariobruto.Text = "Salário bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilhos.Location = new System.Drawing.Point(7, 84);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(102, 13);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Numero de filhos";
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(119, 119);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(132, 23);
            this.btnVerifica.TabIndex = 3;
            this.btnVerifica.Text = "Verifica Desconto";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(7, 216);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(86, 13);
            this.lblINSS.TabIndex = 4;
            this.lblINSS.Text = "Aliquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRPF.Location = new System.Drawing.Point(7, 245);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(85, 13);
            this.lblIRPF.TabIndex = 5;
            this.lblIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalariofamilia
            // 
            this.lblSalariofamilia.AutoSize = true;
            this.lblSalariofamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalariofamilia.Location = new System.Drawing.Point(7, 278);
            this.lblSalariofamilia.Name = "lblSalariofamilia";
            this.lblSalariofamilia.Size = new System.Drawing.Size(88, 13);
            this.lblSalariofamilia.TabIndex = 6;
            this.lblSalariofamilia.Text = "Salário família";
            // 
            // lblSalarioliquido
            // 
            this.lblSalarioliquido.AutoSize = true;
            this.lblSalarioliquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioliquido.Location = new System.Drawing.Point(7, 311);
            this.lblSalarioliquido.Name = "lblSalarioliquido";
            this.lblSalarioliquido.Size = new System.Drawing.Size(87, 13);
            this.lblSalarioliquido.TabIndex = 7;
            this.lblSalarioliquido.Text = "Salário liquido";
            // 
            // lblINSSdesconto
            // 
            this.lblINSSdesconto.AutoSize = true;
            this.lblINSSdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSSdesconto.Location = new System.Drawing.Point(241, 216);
            this.lblINSSdesconto.Name = "lblINSSdesconto";
            this.lblINSSdesconto.Size = new System.Drawing.Size(94, 13);
            this.lblINSSdesconto.TabIndex = 8;
            this.lblINSSdesconto.Text = "Desconto INSS";
            // 
            // lblIRPFdesconto
            // 
            this.lblIRPFdesconto.AutoSize = true;
            this.lblIRPFdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRPFdesconto.Location = new System.Drawing.Point(241, 245);
            this.lblIRPFdesconto.Name = "lblIRPFdesconto";
            this.lblIRPFdesconto.Size = new System.Drawing.Size(93, 13);
            this.lblIRPFdesconto.TabIndex = 9;
            this.lblIRPFdesconto.Text = "Desconto IRPF";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(28, 19);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(35, 17);
            this.rbtnMasculino.TabIndex = 11;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(28, 53);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(32, 17);
            this.rbtnFeminino.TabIndex = 12;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(341, 12);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(93, 85);
            this.gbxSexo.TabIndex = 13;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCasado.Location = new System.Drawing.Point(348, 125);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(68, 17);
            this.ckbxCasado.TabIndex = 14;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // mskbxSalariobruto
            // 
            this.mskbxSalariobruto.Location = new System.Drawing.Point(119, 49);
            this.mskbxSalariobruto.Mask = "######.##";
            this.mskbxSalariobruto.Name = "mskbxSalariobruto";
            this.mskbxSalariobruto.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalariobruto.TabIndex = 15;
            // 
            // mskbxFilhos
            // 
            this.mskbxFilhos.Location = new System.Drawing.Point(119, 81);
            this.mskbxFilhos.Mask = "##";
            this.mskbxFilhos.Name = "mskbxFilhos";
            this.mskbxFilhos.Size = new System.Drawing.Size(100, 20);
            this.mskbxFilhos.TabIndex = 16;
            // 
            // mskbxINSS
            // 
            this.mskbxINSS.Enabled = false;
            this.mskbxINSS.Location = new System.Drawing.Point(119, 209);
            this.mskbxINSS.Name = "mskbxINSS";
            this.mskbxINSS.Size = new System.Drawing.Size(100, 20);
            this.mskbxINSS.TabIndex = 17;
            // 
            // mskbxIRPF
            // 
            this.mskbxIRPF.Enabled = false;
            this.mskbxIRPF.Location = new System.Drawing.Point(119, 242);
            this.mskbxIRPF.Name = "mskbxIRPF";
            this.mskbxIRPF.Size = new System.Drawing.Size(100, 20);
            this.mskbxIRPF.TabIndex = 18;
            // 
            // mskbxSalariofamilia
            // 
            this.mskbxSalariofamilia.Enabled = false;
            this.mskbxSalariofamilia.Location = new System.Drawing.Point(119, 275);
            this.mskbxSalariofamilia.Name = "mskbxSalariofamilia";
            this.mskbxSalariofamilia.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalariofamilia.TabIndex = 19;
            // 
            // mskbxSalarioliquido
            // 
            this.mskbxSalarioliquido.Enabled = false;
            this.mskbxSalarioliquido.Location = new System.Drawing.Point(119, 308);
            this.mskbxSalarioliquido.Name = "mskbxSalarioliquido";
            this.mskbxSalarioliquido.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalarioliquido.TabIndex = 20;
            // 
            // mskbxINSSdesconto
            // 
            this.mskbxINSSdesconto.Enabled = false;
            this.mskbxINSSdesconto.Location = new System.Drawing.Point(341, 209);
            this.mskbxINSSdesconto.Name = "mskbxINSSdesconto";
            this.mskbxINSSdesconto.Size = new System.Drawing.Size(100, 20);
            this.mskbxINSSdesconto.TabIndex = 21;
            // 
            // mskbxIRPFdesconto
            // 
            this.mskbxIRPFdesconto.Enabled = false;
            this.mskbxIRPFdesconto.Location = new System.Drawing.Point(341, 242);
            this.mskbxIRPFdesconto.Name = "mskbxIRPFdesconto";
            this.mskbxIRPFdesconto.Size = new System.Drawing.Size(100, 20);
            this.mskbxIRPFdesconto.TabIndex = 22;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 20);
            this.txtNome.TabIndex = 23;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(21, 153);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(41, 13);
            this.lblDados.TabIndex = 10;
            this.lblDados.Text = "Dados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(512, 348);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskbxIRPFdesconto);
            this.Controls.Add(this.mskbxINSSdesconto);
            this.Controls.Add(this.mskbxSalarioliquido);
            this.Controls.Add(this.mskbxSalariofamilia);
            this.Controls.Add(this.mskbxIRPF);
            this.Controls.Add(this.mskbxINSS);
            this.Controls.Add(this.mskbxFilhos);
            this.Controls.Add(this.mskbxSalariobruto);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblIRPFdesconto);
            this.Controls.Add(this.lblINSSdesconto);
            this.Controls.Add(this.lblSalarioliquido);
            this.Controls.Add(this.lblSalariofamilia);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalariobruto);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalariobruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalariofamilia;
        private System.Windows.Forms.Label lblSalarioliquido;
        private System.Windows.Forms.Label lblINSSdesconto;
        private System.Windows.Forms.Label lblIRPFdesconto;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.MaskedTextBox mskbxSalariobruto;
        private System.Windows.Forms.MaskedTextBox mskbxFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxINSS;
        private System.Windows.Forms.MaskedTextBox mskbxIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalariofamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioliquido;
        private System.Windows.Forms.MaskedTextBox mskbxINSSdesconto;
        private System.Windows.Forms.MaskedTextBox mskbxIRPFdesconto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDados;
    }
}

