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
    public partial class ShowChild : Form
    {
        protected int index;
        public ShowChild(int i)
        {
            InitializeComponent();
            index = i;
        }

        private void ShowChild_Load(object sender, EventArgs e)
        {
            ListInformationOfDay list = new ListInformationOfDay();
            list.SetIndex(index);
            ListOfChildren listChildren = new ListOfChildren();
            listChildren.GetChildOfList(index);
            tbName.Text = listChildren.GetChildOfList(index).GetName();
            tbSurnames.Text = listChildren.GetChildOfList(index).GetSurname();
            tbSex.Text = listChildren.GetChildOfList(index).GetSex().ToString();
            tbCod.Text = listChildren.GetChildOfList(index).GetCod().ToString();
            tbObservations.Text = listChildren.GetChildOfList(index).GetObservations();
            tbAllergies.Text = listChildren.GetChildOfList(index).GetAllergies();
            tbAge.Text = listChildren.GetChildOfList(index).GetAge().ToString();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
