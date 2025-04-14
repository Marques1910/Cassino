namespace Mega_Sena
{
    partial class frmMegaSena
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdeCartoes = new System.Windows.Forms.TextBox();
            this.lstCartoes = new System.Windows.Forms.ListBox();
            this.btnSortearNumeros = new System.Windows.Forms.Button();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qtde. de Catões:";
            // 
            // txtQtdeCartoes
            // 
            this.txtQtdeCartoes.Location = new System.Drawing.Point(191, 87);
            this.txtQtdeCartoes.Name = "txtQtdeCartoes";
            this.txtQtdeCartoes.Size = new System.Drawing.Size(100, 22);
            this.txtQtdeCartoes.TabIndex = 1;
            // 
            // lstCartoes
            // 
            this.lstCartoes.FormattingEnabled = true;
            this.lstCartoes.ItemHeight = 16;
            this.lstCartoes.Location = new System.Drawing.Point(66, 224);
            this.lstCartoes.Name = "lstCartoes";
            this.lstCartoes.Size = new System.Drawing.Size(320, 292);
            this.lstCartoes.TabIndex = 2;
            // 
            // btnSortearNumeros
            // 
            this.btnSortearNumeros.Location = new System.Drawing.Point(169, 552);
            this.btnSortearNumeros.Name = "btnSortearNumeros";
            this.btnSortearNumeros.Size = new System.Drawing.Size(122, 49);
            this.btnSortearNumeros.TabIndex = 3;
            this.btnSortearNumeros.Text = "Sortear";
            this.btnSortearNumeros.UseVisualStyleBackColor = true;
            this.btnSortearNumeros.Click += new System.EventHandler(this.btnSortearNumeros_Click);
            // 
            // lblNumeros
            // 
            this.lblNumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeros.Location = new System.Drawing.Point(66, 144);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(320, 64);
            this.lblNumeros.TabIndex = 5;
            // 
            // frmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 653);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.btnSortearNumeros);
            this.Controls.Add(this.lstCartoes);
            this.Controls.Add(this.txtQtdeCartoes);
            this.Controls.Add(this.label1);
            this.Name = "frmMegaSena";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdeCartoes;
        private System.Windows.Forms.ListBox lstCartoes;
        private System.Windows.Forms.Button btnSortearNumeros;
        private System.Windows.Forms.Label lblNumeros;
    }
}

