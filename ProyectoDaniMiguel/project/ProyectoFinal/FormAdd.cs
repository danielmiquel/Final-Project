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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        //Add a new child
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

            AddChild newChild = new AddChild();
            newChild.SetListWithNewChild(newChild.SetNewChild(
                tbName.Text, tbSurnames.Text, tbObservation.Text,
                Convert.ToInt32(tbAge.Text), Convert.ToInt32(tbCod.Text),
                allergies, Convert.ToChar(tbSex.Text)));
            this.Close();
        }
    }
}
