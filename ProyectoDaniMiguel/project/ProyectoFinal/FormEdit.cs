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
            string[] allergies = modifyChild.GetArrayAllergies();

            tbAge.Text =Convert.ToString(modifyChild.GetAge());
            tbName.Text = modifyChild.GetName();
            tbCod.Text = Convert.ToString(modifyChild.GetCod());
            tbSex.Text = Convert.ToString(modifyChild.GetSex());
            tbSurnames.Text = modifyChild.GetSurname();
            tbObservation.Text = modifyChild.GetObservations();

            //Convert an array of string into corresponding 
            //checked boxes in the checkBox
            for (int i = 0; i < clbVegFrt.Items.Count; i++)
            {
                for (int j = 0; j < allergies.Length; j++)
                {
                    if (clbVegFrt.Items[i].ToString() == allergies[j])
                    {
                        clbVegFrt.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbSex_TextChanged(object sender, EventArgs e)
        {

        }

        //Edit a child
        private void btOK_Click(object sender, EventArgs e)
        {
            string allergies = "";
            bool addCo = false;
            //Convert the event of the checkBox into a string 
            //so that it can be stored in the file
            for (int i = 0; i < clbVegFrt.Items.Count; i++)
            {
                if (clbVegFrt.GetItemChecked(i))
                {
                    if (addCo)
                    {
                        allergies += ",";
                        addCo = false;
                    }
                    allergies += clbVegFrt.Items[i].ToString();
                    addCo = true;
                }
            }
            ModifyChild child = new ModifyChild();
            Child modifiedChild = new Child(Convert.ToInt32(tbCod.Text),
                tbName.Text,tbSurnames.Text,Convert.ToChar(tbSex.Text), 
                Convert.ToInt32(tbAge.Text),tbObservation.Text,
                allergies);
            child.SetModifiedChild(modifiedChild,child.GetIndex());
            this.Close();
        }
    }
}
