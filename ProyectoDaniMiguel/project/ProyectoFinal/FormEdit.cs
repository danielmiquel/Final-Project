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
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            ModifyChild child = new ModifyChild();
            Child modifyChild = child.GetSelectChild();
            tbAge.Text =Convert.ToString(modifyChild.GetAge());
            tbName.Text = modifyChild.GetName();
            tbCod.Text = Convert.ToString(modifyChild.GetCod());
            tbSex.Text = Convert.ToString(modifyChild.GetSex());
            tbSurnames.Text = modifyChild.GetSurname();
            tbObservation.Text = modifyChild.GetObservations();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbSex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
