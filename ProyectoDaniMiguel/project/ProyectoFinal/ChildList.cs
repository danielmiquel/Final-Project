using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ChildList : Form
    {
        FormAdd fAdd = new FormAdd();
        DietSpecificForChild fDietAll = new DietSpecificForChild();
        

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

        //Conditions for edit a child,if the condition is not met, 
        //an alert message will be
        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbChildren.CheckedItems.Count == 1)
                {
                    FormEdit fEdit = new FormEdit();
                    ModifyChild m = new ModifyChild();
                    m.SetIndex(clbChildren.SelectedIndex);
                    fEdit.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
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
            catch (Exception)
            {
                Warning w = new Warning();
                w.Show();
            }
        }

        private void clbChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btAllergiesDiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbChildren.CheckedItems.Count == 1)
                {
                    DietSpecificForChild fDietAll = new DietSpecificForChild();
                    FoodSelection food = new FoodSelection();
                    food.SetIndex(clbChildren.SelectedIndex);
                    fDietAll.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
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
            catch (Exception)
            {
                Warning w = new Warning();
                w.Show();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(clbChildren.CheckedItems.Count > 0)
            {
                ListOfChild list = new ListOfChild();
                list.listChildren.RemoveAt(clbChildren.SelectedIndex);
                list.SaveListOfChildren();
                clbChildren.Items.RemoveAt(clbChildren.SelectedIndex);
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ListOfChild listChildren = new ListOfChild();
            clbChildren.Items.Clear();
            foreach (string i in listChildren.ListForShow())
            {
                clbChildren.Items.Add(i);
            }
        }

        private void btNormalDiet_Click(object sender, EventArgs e)
        {
            try
            {
                Diet fDiet = new Diet();
                fDiet.Show();
            }
            catch (Exception)
            {
                Warning w = new Warning();
                w.Show();
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            ShowChild sForm = new ShowChild();
            sForm.Show();
        }
    }
}
