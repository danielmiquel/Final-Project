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
        private int index;
        protected ListOfChildren editList;
        protected Day birt;
        protected Dictionary<string, string> language;

        public FormEdit(int c, ListOfChildren l, Dictionary<string, string> d)
        {
            InitializeComponent();
            index = c;
            editList = l;
            language = d;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            this.Text = "BLIST - " + language["EditC"];
            lbAge.Text = language["Age"];
            lbName.Text = language["Name"];
            lbSurname.Text = language["Sur"];
            lbSex.Text = language["Sex"];
            lbCod.Text = language["Cod"];
            lbObservations.Text = language["Obs"];
            lbInform.Text = language["Info"];
            lbAllergy.Text = language["Aller"];
            lbBirthday.Text = language["Birt"];

            ModifyChild child = new ModifyChild(editList);
            Child modifyChild = child.GetSelectChild(index);
            birt = modifyChild.GetBirthday();
            string[] allergies = modifyChild.GetArrayAllergies();


            tbBirthday.Text = birt.day + "/" + birt.month + "/" + birt.year;
            tbAge.Text =Convert.ToString(modifyChild.GetAge());
            lbTypeAge.Text = modifyChild.GetTypeAge();
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
            Day birthday = new Day();
            DateTime now = DateTime.Today;
            string allergies = "";
            bool addCo = false;
            bool goodDate = false;
            bool failDate = false;
            string[] b = tbBirthday.Text.Split('/');

            birthday.day = Convert.ToInt32(b[0]);
            birthday.month = Convert.ToInt32(b[1]);
            birthday.year = Convert.ToInt32(b[2]);

            //Convert the event of the checkBox into a string 
            //so that it can be stored in the file
            if ((tbName.Text == "") | (tbSurnames.Text == "")
                | (tbSex.Text == ""))
            {
                WarningDataWhite w = new WarningDataWhite(language["WFilesWhite"]);
                w.Show();
            }
            if (tbSex.Text.ToLower().ToString() != "f" &&
                tbSex.Text.ToLower().ToString() != "m")
            {
                WarningInvalidSex w = new WarningInvalidSex(language["WInvSex"]);
                w.Show();
            }
            else
            {
                if(clbVegFrt.CheckedItems.Count > 0)
                {
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
                }
                
                if (dtpAge.Checked)
                {
                    if (dtpAge.Value.Year == now.Date.Year)
                    {
                        if (dtpAge.Value.Month == now.Date.Month)
                        {
                            if (dtpAge.Value.Day < now.Date.Day)
                            {
                                goodDate = true;
                            }
                        }
                        else if (dtpAge.Value.Month < now.Date.Month)
                        {
                            goodDate = true;
                        }
                    }
                    else if (dtpAge.Value.Year < now.Date.Year)
                        goodDate = true;

                    if (goodDate)
                    {
                        birthday.day = dtpAge.Value.Day;
                        birthday.month = dtpAge.Value.Month;
                        birthday.year = dtpAge.Value.Year;
                    }
                    else
                        failDate = true;
                }

                if (failDate)
                {
                    WarningInvalidDate w = new WarningInvalidDate(language["InvDate"]);
                    w.Show();
                }
                else
                {
                    ModifyChild child = new ModifyChild(editList);
                    
                    child.SetModifiedChild(child.SetEditChild(
                        tbName.Text.ToUpper(), tbSurnames.Text.ToUpper(),
                        tbObservation.Text, allergies, 
                        Convert.ToChar(tbSex.Text.ToUpper()),
                        birthday, Convert.ToInt32(tbCod.Text)), index);
                    this.Close();
                }
            }
        }

        private void tbBirthday_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
