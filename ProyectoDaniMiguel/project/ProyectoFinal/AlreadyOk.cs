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
    public partial class AlreadyOk : Form
    {
        protected string write;

        public AlreadyOk(string l)
        {
            InitializeComponent();
            write = l;
        }

        private void AlreadyOk_Load(object sender, EventArgs e)
        {
            lbMes.Text = write;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
