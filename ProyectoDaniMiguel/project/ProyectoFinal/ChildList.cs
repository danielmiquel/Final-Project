using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ChildList : Form
    {
        FormAdd fAdd = new FormAdd();
        FormEdit fEdit = new FormEdit();
        Diet fDiet = new Diet();

        public ChildList()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListOfChild listChildren = new ListOfChild();

            foreach (string i in listChildren.ListForShow())
            {
                clbChildren.Items.Add(i);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            fAdd.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            
            if (clbChildren.CheckedItems.Count == 1)
            {
                ModifyChild m = new ModifyChild();
                m.SetIndex(clbChildren.SelectedIndex);
                fEdit.Show();
            }
            else if(clbChildren.CheckedItems.Count == 0)
            {
                WarningNotSelct w = new WarningNotSelct();
                w.Show();
            }
            else
            {
                WarningSelectOnlyOne w = new WarningSelectOnlyOne();
                w.Show();
            }
            
        }

        private void clbChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btAllergiesDiet_Click(object sender, EventArgs e)
        {
            fDiet.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(clbChildren.SelectedIndex != null)
            {
                ListOfChild list = new ListOfChild();
                list.listChildren.RemoveAt(clbChildren.SelectedIndex);
                list.SaveListOfChildren();
                clbChildren.Items.RemoveAt(clbChildren.SelectedIndex);
            }
        }
    }
}
