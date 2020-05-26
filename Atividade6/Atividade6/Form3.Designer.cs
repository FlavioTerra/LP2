namespace Atividade6
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(77, 44);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(146, 20);
            this.txtPalavra.TabIndex = 0;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(25, 47);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(46, 13);
            this.lblPalavra.TabIndex = 1;
            this.lblPalavra.Text = "Palavra:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(302, 155);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(129, 53);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar se é Palíndromo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 229);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.txtPalavra);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Button btnVerificar;
    }
}