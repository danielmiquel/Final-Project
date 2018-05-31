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
    public partial class DietSpecificForChild : Form
    {
        protected string breakfast;
        protected string lunch;
        protected string snack;
        protected int index;
        protected ListOfChildren listC;
        protected ListOfMeals listM;
        protected Dictionary<string, string> language;

        public DietSpecificForChild(int i, ListOfChildren lc, ListOfMeals lm, Dictionary<string, string> d)
        {
            InitializeComponent();
            index = i;
            listC = lc;
            listM = lm;
            language = d;
        }

        /*Function that shows the specific food for a child 
         * if the food of the day can not eat it.
         * */
        private void DietSpecificForChild_Load(object sender, EventArgs e)
        {
            lbB.Text = language["Bre"];
            lbL.Text = language["Lunch"];
            lbS.Text = language["Sanck"];
            btChange.Text = language["Chan"];

            if (breakfast == null && lunch == null && snack == null)
            {
                FoodSelection food = new FoodSelection(listC, listM);
                Child c = listC.GetChildOfList(index);
                lbInfoChild.Text = c.GetCod().ToString() + "--" + c.GetName() + " " + c.GetSurname();
                tbBreak.Text = food.SelectFoodForChild(listM.GetBreakfastFood(), index);
                tbLunch.Text = food.SelectFoodForChild(listM.GetLunchFood(), index);
                tbSnack.Text = food.SelectFoodForChild(listM.GetSnackFood(), index);
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

        private void btChange_Click(object sender, EventArgs e)
        {
            FoodSelection food = new FoodSelection(listC, listM);

            string b = breakfast, l = lunch,s = snack;
            if (cbBreakfast.Checked)
            {
                while(b == breakfast)
                {
                    b = food.SelectFoodForChild(listM.GetBreakfastFood(), index);
                }
                tbBreak.Text = b;
            }
                
            if (cbLunch.Checked)
            {
                while (l == lunch)
                {
                    l = food.SelectFoodForChild(listM.GetLunchFood(), index);
                }
                tbLunch.Text = l;
            }

            if (cbSnack.Checked)
            {
                while (l == snack)
                {
                    s = food.SelectFoodForChild(listM.GetSnackFood(), index);
                }
                tbSnack.Text = l;
            }

            breakfast = b;
            lunch = l;
            snack = s;
        }
    }
}
