using System;
using System.Collections.Generic;


namespace ProyectoFinal
{
    //Class to select meals according to the time of day
    class FoodSelection
    {
        protected List<Child> children;
        protected List<Meal> meals;
        ListOfChild listC = new ListOfChild();
        ListOfMeals listM = new ListOfMeals();
        Random rnd = new Random();
        
        public FoodSelection() { }

        //Functions that take food for every moment of the day
        public string GetBreakfast()
        {
            return FoodForShow(listM.GetBreakfastFood());
        }

        public string GetLunch()
        {
            return FoodForShow(listM.GetLunchFood());
        }

        public string GetSnack()
        {
            return FoodForShow(listM.GetSnackFood());
        }

        //Function to take a meal randomly
        /*TO DO: Do not change the diet every time you close 
         * and open the program, each day have one and
         * do not repeat two days in a row
         * */
        private string FoodForShow(List<Meal> l)
        {
            int num1 = 0, num2;
            do
            {
                num2 = rnd.Next(0, l.Count);
            } while (num2 == num1);
            num1 = num2;

            Meal meal = l[num2];

            string food = "Dish: " + meal.GetDish() + "   Foodstuff: " 
                + meal.GetFoodstuff() + "   Allergies: " + meal.GetAllergies();
            return food;
        }

        //Function that chooses a meal according to a child's allergies
        public string SelectFoodForChild(Child c,List<Meal> m)
        {
            int cont = 0;
            bool found = false;
            do
            {
                if (!m[cont].GetAllergies().Contains(c.GetAllergies()))
                    found = true;
                cont++;
            } while (m[cont].GetAllergies().Contains(c.GetAllergies()) && cont < m.Count && !found);
            return m[cont].GetFood();
        }
    }
}
