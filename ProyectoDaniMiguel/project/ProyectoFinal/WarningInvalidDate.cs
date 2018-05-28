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
        public WarningInvalidDate()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbWarningInvalidDate_Click(object sender, EventArgs e)
        {

        }
    }
}
