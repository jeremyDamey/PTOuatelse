﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTOuatelse
{
    public partial class NouveauSalarie : Form
    {
        public NouveauSalarie()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CodeSalarie_TextChanged(object sender, EventArgs e)
        {
            this.Text = CodeSalarie.Text;
        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {
            this.Text = Nom.Text;
        }

        private void Adresse1_TextChanged(object sender, EventArgs e)
        {
            this.Text = Adresse1.Text;
        }

        private void Adresse2_TextChanged(object sender, EventArgs e)
        {
            this.Text = Adresse2.Text;
        }

        private void CodePostal_TextChanged(object sender, EventArgs e)
        {
            this.Text = CodePostal.Text;
        }

        private void NomVille_TextChanged(object sender, EventArgs e)
        {
            this.Text = NomVille.Text;
        }

        private void NomPays_TextChanged(object sender, EventArgs e)
        {
            this.Text = NomPays.Text;
        }

        private void Téléphone_TextChanged(object sender, EventArgs e)
        {
            this.Text = Téléphone.Text;
        }

        private void DateNaissance_TextChanged(object sender, EventArgs e)
        {
            this.Text = DateNaissance.Text;
        }

        private void Mail_TextChanged(object sender, EventArgs e)
        {
            this.Text = Mail.Text;
        }

        private void ValiderNouveauSalarie_Click(object sender, EventArgs e)
        {
            SalarieAjoute salarieAjoute = new SalarieAjoute();
            salarieAjoute.Show();
            this.Hide();
        }
    }
}
