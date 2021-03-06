﻿using System;
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
        protected ListOfChildren saveList;
        protected Dictionary<string, string> language;

        public FormAdd(int i,ListOfChildren s, Dictionary<string, string> d)
        {
            InitializeComponent();
            index = i;
            saveList = s;
            language = d;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "BLIST - " + language["AddC"];
            lbName.Text = language["Name"];
            lbSurname.Text = language["Sur"];
            lbSex.Text = language["Sex"];
            lbCod.Text = language["Cod"];
            lbObservations.Text = language["Obs"];
            lbInform.Text = language["Info"];
            lbAllergy.Text = language["Aller"];
            lbBirthday.Text = language["Birt"];
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
                Day birthday = new Day();
                DateTime now = DateTime.Today;
                bool goodDate = false;

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
                    AddChild newChild = new AddChild();
                    newChild.SetListWithNewChild(newChild.SetNewChild(
                        tbName.Text.ToUpper(), tbSurnames.Text.ToUpper(),
                        tbObservation.Text, allergies,
                        Convert.ToChar(tbSex.Text.ToUpper()), birthday,
                        saveList.GetList().Count+1),saveList);
                    
                    this.Close();
                }
                else
                {
                    WarningInvalidDate w = new WarningInvalidDate(language["WInvDate"]);
                    w.Show();
                }
            }
        }

        private void dtpAge_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
