﻿namespace PTOuatelse
{
    partial class ProduitAjoute
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
            this.OKProduitAjoute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKProduitAjoute
            // 
            this.OKProduitAjoute.Location = new System.Drawing.Point(107, 80);
            this.OKProduitAjoute.Name = "OKProduitAjoute";
            this.OKProduitAjoute.Size = new System.Drawing.Size(75, 23);
            this.OKProduitAjoute.TabIndex = 0;
            this.OKProduitAjoute.Text = "OK";
            this.OKProduitAjoute.UseVisualStyleBackColor = true;
            this.OKProduitAjoute.Click += new System.EventHandler(this.OKProduitAjoute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nouveau produit ajouté.";
            // 
            // ProduitAjoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 115);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKProduitAjoute);
            this.Name = "ProduitAjoute";
            this.Text = "ProduitAjoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKProduitAjoute;
        private System.Windows.Forms.Label label1;
    }
}