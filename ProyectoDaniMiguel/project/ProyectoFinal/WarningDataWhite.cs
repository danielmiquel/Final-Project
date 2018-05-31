using System;
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
    public partial class WarningDataWhite : Form
    {
        protected string message;

        public WarningDataWhite(string l)
        {
            InitializeComponent();
            message = l;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarningDataWhite_Load(object sender, EventArgs e)
        {
            lbWarning.Text = message;
        }
    }
}
