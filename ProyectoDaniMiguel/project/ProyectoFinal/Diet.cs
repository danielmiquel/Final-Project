using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Diet : Form
    {
        protected string breakfast;
        protected string lunch;
        protected string snack;
        protected int index;
        protected ListOfChildren listC;
        protected ListOfMeals listM;
        protected Dictionary<string, string> language;

        public Diet(int i,ListOfChildren lc,ListOfMeals lm, Dictionary<string, string> d)
        {
            InitializeComponent();
            index = i;
            listC = lc;
            listM = lm;
            language = d;
        }

        private void Diet_Load(object sender, EventArgs e)
        {
            lbB.Text = language["Bre"];
            lbL.Text = language["Lunch"];
            lbS.Text = language["Sanck"];
            btChange.Text = language["Chan"];

            if (breakfast == null && lunch == null && snack == null)
            {
                FoodSelection food = new FoodSelection(listC,listM);
                tbBreak.Text = food.GetBreakfast();
                tbLunch.Text = food.GetLunch();
                tbSnack.Text = food.GetSnack();
                breakfast = food.GetBreakfast();
                lunch = food.GetLunch();
                snack = food.GetSnack();
            }
            else
            {
                tbBreak.Text = breakfast;
                tbLunch.Text = lunch;
                tbSnack.Text = snack;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSnack_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLunch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBreak_TextChanged(object sender, EventArgs e)
        {

        }

        //Function that changes the food to show
        private void btChange_Click(object sender, EventArgs e)
        {
            FoodSelection food = new FoodSelection(listC, listM);

            string b = breakfast, l = lunch, s = snack;

            if (cbBreakfast.Checked)
            {
                while (b == breakfast)
                {
                    b = food.GetBreakfast();
                }
                tbBreak.Text = b;
            }

            if (cbLunch.Checked)
            {
                while (l == lunch)
                {
                    l = food.GetLunch();
                }
                tbLunch.Text = l;
            }

            if (cbSnack.Checked)
            {
                while (s == snack)
                {
                    s = food.GetSnack();
                }
                tbSnack.Text = l;
            }

            breakfast = b;
            lunch = l;
            snack = s;
        }
    }
}
