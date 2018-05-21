using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Diet : Form
    {
        public Diet()
        {
            InitializeComponent();
        }

        private void Diet_Load(object sender, EventArgs e)
        {
            FoodSelection food = new FoodSelection();
            tbBreak.Text = food.GetBreakfast();
            tbLunch.Text = food.GetLunch();
            tbSnack.Text = food.GetSnack();
            
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
        }
    }
}
