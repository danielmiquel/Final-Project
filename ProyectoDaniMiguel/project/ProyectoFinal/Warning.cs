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
    public partial class Warning : Form
    {
        protected string message;

        public Warning(string l)
        {
            InitializeComponent();
            message = l;
        }

        private void Warning_Load(object sender, EventArgs e)
        {
            lbWarning.Text = message;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
