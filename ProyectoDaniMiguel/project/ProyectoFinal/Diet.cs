using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Diet : Form
    {
        protected string breakfast;
        protected string lunch;
        protected string snack;

        public Diet()
        {
            InitializeComponent();
        }

        private void Diet_Load(object sender, EventArgs e)
        {
            if (breakfast == null && lunch == null && snack == null)
            {
                FoodSelection food = new FoodSelection();
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
            FoodSelection food = new FoodSelection();
            tbBreak.Text = food.GetBreakfast();
            tbLunch.Text = food.GetLunch();
            tbSnack.Text = food.GetSnack();
            breakfast = food.GetBreakfast();
            lunch = food.GetLunch();
            snack = food.GetSnack();
        }
    }
}
