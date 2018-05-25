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
        protected int index;

        public FormAdd(int i)
        {
            InitializeComponent();
            index = i;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tbCod.Text = Convert.ToString(index + 1);
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
            if((tbName.Text == "") | (tbSurnames.Text == "") 
                | (tbSex.Text == ""))
            {
                Warning w = new Warning();
                w.Show();
            }
            else
            {
                /*
                AddChild newChild = new AddChild();
                newChild.SetListWithNewChild(newChild.SetNewChild(
                    tbName.Text, tbSurnames.Text, tbObservation.Text,
                    allergies, Convert.ToChar(tbSex.Text)));
                this.Close();
                */
            }
        }
    }
}
