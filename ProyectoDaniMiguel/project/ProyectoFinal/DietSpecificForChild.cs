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
        public DietSpecificForChild()
        {
            InitializeComponent();
        }

        /*Function that shows the specific food for a child 
         * if the food of the day can not eat it.
         * 
         * TO DO: Show the selected child
         * */
        private void DietSpecificForChild_Load(object sender, EventArgs e)
        {
            FoodSelection food = new FoodSelection();
            ListOfChild child = new ListOfChild();
            ListOfMeals m = new ListOfMeals();
            Child c = child.GetChildOfList(0);
            label1.Text =   food.SelectFoodForChild(c, m.GetBreakfastFood());
        }
    }
}
