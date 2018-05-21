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
        public WarningSelectOnlyOne()
        {
            InitializeComponent();
        }

        private void WarningSelectOnlyOne_Load(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
