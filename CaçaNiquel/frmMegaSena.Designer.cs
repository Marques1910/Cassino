namespace CaçaNiquel
{
    partial class frmMegaSena
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.btnSortearNumeros = new System.Windows.Forms.Button();
            this.lstCartoes = new System.Windows.Forms.ListBox();
            this.txtQtdeCartoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeros.Location = new System.Drawing.Point(100, 94);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(320, 64);
            this.lblNumeros.TabIndex = 10;
            // 
            // btnSortearNumeros
            // 
            this.btnSortearNumeros.Location = new System.Drawing.Point(203, 502);
            this.btnSortearNumeros.Name = "btnSortearNumeros";
            this.btnSortearNumeros.Size = new System.Drawing.Size(122, 49);
            this.btnSortearNumeros.TabIndex = 9;
            this.btnSortearNumeros.Text = "Sortear";
            this.btnSortearNumeros.UseVisualStyleBackColor = true;
            this.btnSortearNumeros.Click += new System.EventHandler(this.btnSortearNumeros_Click);
            // 
            // lstCartoes
            // 
            this.lstCartoes.FormattingEnabled = true;
            this.lstCartoes.ItemHeight = 16;
            this.lstCartoes.Location = new System.Drawing.Point(100, 174);
            this.lstCartoes.Name = "lstCartoes";
            this.lstCartoes.Size = new System.Drawing.Size(320, 292);
            this.lstCartoes.TabIndex = 8;
            // 
            // txtQtdeCartoes
            // 
            this.txtQtdeCartoes.Location = new System.Drawing.Point(225, 37);
            this.txtQtdeCartoes.Name = "txtQtdeCartoes";
            this.txtQtdeCartoes.Size = new System.Drawing.Size(100, 22);
            this.txtQtdeCartoes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Qtde. de Catões:";
            // 
            // frmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 589);
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

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Button btnSortearNumeros;
        private System.Windows.Forms.ListBox lstCartoes;
        private System.Windows.Forms.TextBox txtQtdeCartoes;
        private System.Windows.Forms.Label label1;
    }
}