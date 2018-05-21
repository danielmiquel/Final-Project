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
    public partial class WarningNotSelct : Form
    {
        public WarningNotSelct()
        {
            InitializeComponent();
        }

        private void WarningChildNotSelect_Load(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
