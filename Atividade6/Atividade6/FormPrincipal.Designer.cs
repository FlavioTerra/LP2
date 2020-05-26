namespace Atividade6
{
    partial class FormPrincipal
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
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.btnForm4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(39, 86);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(121, 65);
            this.btnForm1.TabIndex = 0;
            this.btnForm1.Text = "Formulário1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(166, 86);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(121, 65);
            this.btnForm2.TabIndex = 1;
            this.btnForm2.Text = "Formulário 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(293, 86);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(121, 65);
            this.btnForm3.TabIndex = 2;
            this.btnForm3.Text = "Formulário 3";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // btnForm4
            // 
            this.btnForm4.Location = new System.Drawing.Point(420, 86);
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(121, 65);
            this.btnForm4.TabIndex = 3;
            this.btnForm4.Text = "Formulário 4";
            this.btnForm4.UseVisualStyleBackColor = true;
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 258);
            this.Controls.Add(this.btnForm4);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnForm1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnForm3;
        private System.Windows.Forms.Button btnForm4;
    }
}

