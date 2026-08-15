namespace CotaçãoDolar
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.lblUsd = new System.Windows.Forms.Label();
            this.txtUsd = new System.Windows.Forms.TextBox();
            this.lblCotacao = new System.Windows.Forms.Label();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.Location = new System.Drawing.Point(12, 15);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(85, 15);
            this.lblUsd.TabIndex = 0;
            this.lblUsd.Text = "Valor em US$:";
            // 
            // txtUsd
            // 
            this.txtUsd.Location = new System.Drawing.Point(110, 12);
            this.txtUsd.Name = "txtUsd";
            this.txtUsd.Size = new System.Drawing.Size(150, 23);
            this.txtUsd.TabIndex = 1;
            // 
            // lblCotacao
            // 
            this.lblCotacao.AutoSize = true;
            this.lblCotacao.Location = new System.Drawing.Point(12, 50);
            this.lblCotacao.Name = "lblCotacao";
            this.lblCotacao.Size = new System.Drawing.Size(92, 15);
            this.lblCotacao.TabIndex = 2;
            this.lblCotacao.Text = "Cotação (R$):";
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(110, 47);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(150, 23);
            this.txtCotacao.TabIndex = 3;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(110, 86);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(150, 27);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 130);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 15);
            this.lblResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtCotacao);
            this.Controls.Add(this.lblCotacao);
            this.Controls.Add(this.txtUsd);
            this.Controls.Add(this.lblUsd);
            this.Name = "Form1";
            this.Text = "Conversor USD -> BRL";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUsd;
        private System.Windows.Forms.TextBox txtUsd;
        private System.Windows.Forms.Label lblCotacao;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;

        #endregion
    }
}
