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

        public DietSpecificForChild(int i, ListOfChildren lc, ListOfMeals lm)
        {
            InitializeComponent();
            index = i;
            listC = lc;
            listM = lm;
        }

        /*Function that shows the specific food for a child 
         * if the food of the day can not eat it.
         * 
         * TO DO: Show the selected child
         * */
        private void DietSpecificForChild_Load(object sender, EventArgs e)
        {
            if (breakfast == null && lunch == null && snack == null)
            {
                FoodSelection food = new FoodSelection(listC,listM);
                ListOfChildren child = new ListOfChildren();
                ListOfMeals m = new ListOfMeals();
                Child c = child.GetChildOfList(index);
                lbInfoChild.Text = c.GetCod().ToString() + "--" + c.GetName() + " " + c.GetSurname();
                tbBreak.Text = food.SelectFoodForChild(m.GetBreakfastFood(), index);
                tbLunch.Text = food.SelectFoodForChild(m.GetLunchFood(), index);
                tbSnack.Text = food.SelectFoodForChild(m.GetSnackFood(), index);
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
            tbBreak.Text = food.SelectFoodForChild(listM.GetBreakfastFood(), index);
            tbLunch.Text = food.SelectFoodForChild(listM.GetLunchFood(), index);
            tbSnack.Text = food.SelectFoodForChild(listM.GetSnackFood(), index);
            breakfast = food.GetBreakfast();
            lunch = food.GetLunch();
            snack = food.GetSnack();
        }
    }
}
