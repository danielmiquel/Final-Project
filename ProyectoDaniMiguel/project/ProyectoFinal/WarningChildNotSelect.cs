﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class WarningNotSelct : Form
    {
        protected string message;
        public WarningNotSelct(string l)
        {
            InitializeComponent();
            message = l;
        }

        private void WarningChildNotSelect_Load(object sender, EventArgs e)
        {
            lbWarning.Text = message;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
