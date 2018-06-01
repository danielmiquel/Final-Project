using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ErasureConfirmation : Form
    {
        protected Dictionary<string, string> language;

        public ErasureConfirmation(Dictionary<string,string> l)
        {
            InitializeComponent();
            language = l;
        }

        private void ErasureConfirmation_Load(object sender, EventArgs e)
        {
            lbSure.Text = language["Delt?"];
            this.Text = language["Eru"];
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
