﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalControlGastos
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void GeneralTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Settings = new Settings();
            Settings.Show();
            Hide();
        }

        private void GeneralAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
