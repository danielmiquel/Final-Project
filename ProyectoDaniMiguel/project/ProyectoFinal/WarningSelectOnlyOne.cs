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
    public partial class WarningSelectOnlyOne : Form
    {
        protected string l;
        public WarningSelectOnlyOne(string message)
        {
            InitializeComponent();
            l = message;
        }

        private void WarningSelectOnlyOne_Load(object sender, EventArgs e)
        {
            lbWarning.Text = l;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
