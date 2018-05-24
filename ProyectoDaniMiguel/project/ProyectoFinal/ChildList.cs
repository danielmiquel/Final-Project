using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ChildList : Form
    {
        protected int totalWomen;
        protected int totalMens;

        public ChildList()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListOfChildren listChildren = new ListOfChildren();

            foreach(Child  i in listChildren.GetList())
            {
                if (i.GetSex() == 'F')
                    totalWomen++;
                else if (i.GetSex() == 'M')
                    totalMens++;
            }

            foreach (string i in listChildren.ListForShow())
            {
                clbChildren.Items.Add(i);
            }

            tbTotalChildren.Text = clbChildren.Items.Count.ToString();
            tbTotalFemale.Text = totalWomen.ToString();
            tbTotalMens.Text = totalMens.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAdd fAdd = new FormAdd(Convert.ToInt32
                (clbChildren.Items.Count));
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
                    FormEdit fEdit = new FormEdit(clbChildren.SelectedIndex);
                    fEdit.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
                {
                    WarningNotSelct warningNot = new WarningNotSelct();
                    warningNot.Show();
                }
                else
                {
                    WarningSelectOnlyOne warningOnyl = new WarningSelectOnlyOne();
                    warningOnyl.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning();
                warning.Show();
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
                    DietSpecificForChild fDietAll = 
                        new DietSpecificForChild(clbChildren.SelectedIndex);
                    fDietAll.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
                {
                    WarningNotSelct warningNot = new WarningNotSelct();
                    warningNot.Show();
                }
                else
                {
                    WarningSelectOnlyOne warningOnyl = new WarningSelectOnlyOne();
                    warningOnyl.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbChildren.CheckedItems.Count > 0)
                {
                    RemoveChild rChild = new RemoveChild(clbChildren.SelectedIndex);
                    clbChildren.Items.RemoveAt(clbChildren.SelectedIndex);
                }
                else
                {
                    WarningNotSelct warningNot = new WarningNotSelct();
                    warningNot.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning();
                warning.Show();
            }
            
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ListOfChildren listChildren = new ListOfChildren();
            clbChildren.Items.Clear();
            tbTotalChildren.Clear();
            tbTotalFemale.Clear();
            tbTotalMens.Clear();
            totalWomen = 0;
            totalMens = 0;

            foreach (Child i in listChildren.GetList())
            {
                if (i.GetSex() == 'F')
                    totalWomen++;
                else if (i.GetSex() == 'M')
                    totalMens++;
            }

            foreach (string i in listChildren.ListForShow())
            {
                clbChildren.Items.Add(i);
            }

            tbTotalChildren.Text = clbChildren.Items.Count.ToString();
            tbTotalFemale.Text = totalWomen.ToString();
            tbTotalMens.Text = totalMens.ToString();
        }

        private void btNormalDiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbChildren.CheckedItems.Count == 1)
                {
                    Diet fDiet = new Diet(clbChildren.SelectedIndex);
                    fDiet.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
                {
                    WarningNotSelct warningNot = new WarningNotSelct();
                    warningNot.Show();
                }
                else
                {
                    WarningSelectOnlyOne warningOnyl = new WarningSelectOnlyOne();
                    warningOnyl.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {       
            try
            {
                if (clbChildren.CheckedItems.Count == 1)
                {
                    ShowChild sForm = new ShowChild(clbChildren.SelectedIndex);
                    sForm.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
                {
                    WarningNotSelct warningNot = new WarningNotSelct();
                    warningNot.Show();
                }
                else
                {
                    WarningSelectOnlyOne warningOnyl = new WarningSelectOnlyOne();
                    warningOnyl.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning();
                warning.Show();
            }
        }
    }
}
