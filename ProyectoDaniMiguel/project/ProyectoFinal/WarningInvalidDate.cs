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
    public partial class WarningInvalidDate : Form
    {
        protected string l;

        public WarningInvalidDate(string message)
        {
            InitializeComponent();
            l = message;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbWarningInvalidDate_Click(object sender, EventArgs e)
        {

        }

        private void WarningInvalidDate_Load(object sender, EventArgs e)
        {
            lbWarning.Text = l;
        }
    }
}
