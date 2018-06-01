using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ChildList : Form
    {
        protected ListOfChildren listChildren = new ListOfChildren();
        protected ListOfMeals listMeals = new ListOfMeals();
        public Dictionary<string, string> language;
        private int totChild = 0,totMen = 0,totWom = 0;


        public ChildList()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SelectLenguage sl = new SelectLenguage();
            if(sl.ShowDialog() == DialogResult.OK)
            {
                language = sl.language;
            }
            else
            {
                this.Close();
            }

            if (listChildren.GetList() != null)
            {
                listChildren.SetNumDiferentChildren(listChildren.GetList(), 
                    ref totChild, ref totWom,ref totMen);

                foreach (string i in listChildren.ListForShow())
                {
                    clbChildren.Items.Add(i);
                }
                
                btRefresh.Text = language["Refr"];
                btAdd.Text = language["AddC"];
                btNormalDiet.Text = language["Diet"];
                btAllergiesDiet.Text = language["DietA"];
                btDelete.Text = language["DelC"];
                btEdit.Text = language["EditC"];
                btShow.Text = language["ShowC"];
                lbTotalChildren.Text = language["TotC"];
                lbTotalFemale.Text = language["TotW"];
                lbTotalMens.Text = language["TotM"];

                tbTotalChildren.Text = totChild.ToString();
                tbTotalFemale.Text = totWom.ToString();
                tbTotalMens.Text = totMen.ToString();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAdd fAdd = new FormAdd(Convert.ToInt32
                (clbChildren.Items.Count),listChildren,language);
            fAdd.Show();
        }

        //Conditions for edit a child,if the condition is not met, 
        //an alert message will be
        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (clbChildren.CheckedIndices.Count == 1)
                {
                    FormEdit fEdit = new FormEdit(clbChildren.SelectedIndex,
                        listChildren,language);
                    fEdit.Show();
                }
                else if (clbChildren.CheckedIndices.Count == 0)
                {
                    WarningNotSelct warningNot = new WarningNotSelct(language["NotSelec"]);
                    warningNot.Show();
                }
                else
                {
                    WarningSelectOnlyOne warningOnyl = new WarningSelectOnlyOne(language["Only1Ch"]);
                    warningOnyl.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning(language["WFail"]);
                warning.Show();
            }
        }

        private void clbChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Conditions for show a child diet without allergies
        private void btAllergiesDiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbChildren.CheckedItems.Count == 1)
                {
                    DietSpecificForChild fDietAll = 
                        new DietSpecificForChild(clbChildren.SelectedIndex,
                        listChildren,listMeals, language);
                    fDietAll.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
                {
                    WarningNotSelct warningNot = new WarningNotSelct(language["NotSelc"]);
                    warningNot.Show();
                }
                else
                {
                    WarningSelectOnlyOne warningOnyl = new WarningSelectOnlyOne(language["Only1Ch"]);
                    warningOnyl.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning(language["WFail"]);
                warning.Show();
            }
        }

        //Conditions for remove a child,if the condition is not met, 
        //an alert message will be
        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbChildren.CheckedItems.Count > 0)
                {
                    ErasureConfirmation er = new ErasureConfirmation(language);
                    if(er.ShowDialog() == DialogResult.OK)
                    {
                        RemoveChild rChild = new RemoveChild(
                        clbChildren.SelectedIndex, listChildren);
                        clbChildren.Items.RemoveAt(clbChildren.SelectedIndex);
                    }
                }
                else
                {
                    WarningNotSelct warningNot = new WarningNotSelct(language["NotSelc"]);
                    warningNot.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning(language["WFail"]);
                warning.Show();
            }
        }

        //To update the list that is displayed on the 
        //screen when a fault is made
        private void btRefresh_Click(object sender, EventArgs e)
        {
            clbChildren.Items.Clear();
            tbTotalChildren.Clear();
            tbTotalFemale.Clear();
            tbTotalMens.Clear();
            totWom = 0;
            totMen = 0;

            listChildren.SetNumDiferentChildren(listChildren.GetList(),
                    ref totChild, ref totWom, ref totMen);

            foreach (string i in listChildren.ListForShow())
            {
                clbChildren.Items.Add(i);
            }

            tbTotalChildren.Text = totChild.ToString();
            tbTotalFemale.Text = totWom.ToString();
            tbTotalMens.Text = totMen.ToString();
        }

        //Diet for all children haven't allergies
        private void btNormalDiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbChildren.CheckedItems.Count == 1)
                {
                    Diet fDiet = new Diet(clbChildren.SelectedIndex,
                        listChildren,listMeals, language);
                    fDiet.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
                {
                    WarningNotSelct warningNot = new WarningNotSelct(language["NotSelc"]);
                    warningNot.Show();
                }
                else
                {
                    WarningSelectOnlyOne warningOnyl = new WarningSelectOnlyOne(language["Only1Ch"]);
                    warningOnyl.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning(language["WFail"]);
                warning.Show();
            }
        }

        //See all the information of a selected child about what 
        //he has done throughout the day since he is at school
        private void btShow_Click(object sender, EventArgs e)
        {       
            try
            {
                if (clbChildren.CheckedItems.Count == 1)
                {
                    ShowChild sForm = new ShowChild(clbChildren.SelectedIndex,
                        listChildren,listMeals, language);
                    sForm.Show();
                }
                else if (clbChildren.CheckedItems.Count == 0)
                {
                    WarningNotSelct warningNot = new WarningNotSelct(language["NotSelc"]);
                    warningNot.Show();
                }
                else
                {
                    WarningSelectOnlyOne warningOnyl = new WarningSelectOnlyOne(language["Only1Ch"]);
                    warningOnyl.Show();
                }
            }
            catch (Exception)
            {
                Warning warning = new Warning(language["WFail"]);
                warning.Show();
            }
        }
    }
}
