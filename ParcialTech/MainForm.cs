﻿using ParcialTech.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tipoEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TiposEmailsRegistroForm().Show();
        }
    }
}