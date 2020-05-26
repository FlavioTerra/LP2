namespace Atividade6
{
    partial class Form1
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
            this.rchtxtFrases = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrases
            // 
            this.rchtxtFrases.Location = new System.Drawing.Point(109, 36);
            this.rchtxtFrases.Name = "rchtxtFrases";
            this.rchtxtFrases.Size = new System.Drawing.Size(295, 80);
            this.rchtxtFrases.TabIndex = 0;
            this.rchtxtFrases.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(59, 158);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(130, 61);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Quantidade de espaços em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(195, 158);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(130, 61);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Quantidade de letras R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(331, 158);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(130, 61);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Ocorrências de pares de letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 269);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchtxtFrases);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrases;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnPares;
    }
}