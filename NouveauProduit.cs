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
    public partial class NouveauProduit : Form
    {
        public NouveauProduit()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
