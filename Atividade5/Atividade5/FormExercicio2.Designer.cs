namespace Atividade5
{
    partial class FormExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnIguais = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.btnInserir3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(124, 37);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(124, 75);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnIguais
            // 
            this.btnIguais.Location = new System.Drawing.Point(37, 145);
            this.btnIguais.Name = "btnIguais";
            this.btnIguais.Size = new System.Drawing.Size(99, 42);
            this.btnIguais.TabIndex = 2;
            this.btnIguais.Text = "Testar iguais";
            this.btnIguais.UseVisualStyleBackColor = true;
            this.btnIguais.Click += new System.EventHandler(this.btnIguais_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(66, 40);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 4;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(66, 78);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 5;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(167, 145);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(99, 42);
            this.btnInserir2.TabIndex = 6;
            this.btnInserir2.Text = "Inserir texto1 no texto2";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // btnInserir3
            // 
            this.btnInserir3.Location = new System.Drawing.Point(287, 145);
            this.btnInserir3.Name = "btnInserir3";
            this.btnInserir3.Size = new System.Drawing.Size(99, 42);
            this.btnInserir3.TabIndex = 7;
            this.btnInserir3.Text = "Inserir asteriscos no texto1";
            this.btnInserir3.UseVisualStyleBackColor = true;
            this.btnInserir3.Click += new System.EventHandler(this.btnInserir3_Click);
            // 
            // FormExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 241);
            this.Controls.Add(this.btnInserir3);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnIguais);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "FormExercicio2";
            this.Text = "FormExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnIguais;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnInserir2;
        private System.Windows.Forms.Button btnInserir3;
    }
}