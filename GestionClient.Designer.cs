﻿namespace PTOuatelse
{
    partial class GestionClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClients));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NouveauClient = new System.Windows.Forms.Button();
            this.modifierClient = new System.Windows.Forms.Button();
            this.supprimerClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rechercher = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des Clients";
            // 
            // NouveauClient
            // 
            this.NouveauClient.Location = new System.Drawing.Point(37, 102);
            this.NouveauClient.Name = "NouveauClient";
            this.NouveauClient.Size = new System.Drawing.Size(100, 23);
            this.NouveauClient.TabIndex = 2;
            this.NouveauClient.Text = "Nouveau Client";
            this.NouveauClient.UseVisualStyleBackColor = true;
            this.NouveauClient.Click += new System.EventHandler(this.NouveauClient_Click);
            // 
            // modifierClient
            // 
            this.modifierClient.Location = new System.Drawing.Point(143, 102);
            this.modifierClient.Name = "modifierClient";
            this.modifierClient.Size = new System.Drawing.Size(100, 23);
            this.modifierClient.TabIndex = 3;
            this.modifierClient.Text = "Modifier Client";
            this.modifierClient.UseVisualStyleBackColor = true;
            this.modifierClient.Click += new System.EventHandler(this.modifierClient_Click);
            // 
            // supprimerClient
            // 
            this.supprimerClient.Location = new System.Drawing.Point(249, 102);
            this.supprimerClient.Name = "supprimerClient";
            this.supprimerClient.Size = new System.Drawing.Size(100, 23);
            this.supprimerClient.TabIndex = 4;
            this.supprimerClient.Text = "Supprimer Client";
            this.supprimerClient.UseVisualStyleBackColor = true;
            this.supprimerClient.Click += new System.EventHandler(this.supprimerClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(838, 231);
            this.dataGridView1.TabIndex = 5;
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(652, 102);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(100, 20);
            this.rechercher.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GestionClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.supprimerClient);
            this.Controls.Add(this.modifierClient);
            this.Controls.Add(this.NouveauClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GestionClients";
            this.Text = "Gestion des Clients";
            this.Load += new System.EventHandler(this.GestionClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NouveauClient;
        private System.Windows.Forms.Button modifierClient;
        private System.Windows.Forms.Button supprimerClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox rechercher;
        private System.Windows.Forms.Button button1;
    }
}