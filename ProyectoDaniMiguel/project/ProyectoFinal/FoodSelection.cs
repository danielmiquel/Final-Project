using System;
using System.Collections.Generic;


namespace ProyectoFinal
{
    //Class to select meals according to the time of day
    public class FoodSelection
    {
        protected int index;
        protected ListOfChildren listC = new ListOfChildren();
        protected ListOfMeals listM = new ListOfMeals();
        protected Random rnd = new Random();
        protected string mealSave = "";
        
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

        //Return index of child to modify
        public int GetIndex()
        {
            return index;
        }

        //set the index of child to modify
        public void SetIndex(int newIndex)
        {
            this.index = newIndex;
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
        public string SelectFoodForChild(List<Meal> m,int i)
        {
            Child c = listC.GetChildOfList(i);
            int cont = 0;
            bool found;
            string[] allergiesC = c.GetArrayAllergies();
            List<string> listAlC = new List<string>();

            foreach (string t in allergiesC)
            {
                listAlC.Add(t);
            }

            do
            {
                found = false;
                string[] allergiesM = m[cont].GetArrayAllergies();
                for(int j = 0; j < allergiesM.Length && !found; j++)
                {
                    if (listAlC.Contains(allergiesM[j]))
                        found = true;
                }
                if(found)
                    cont++;

            } while (cont < m.Count && found);
            if (cont >= m.Count)
                return "Not food";
            else
                return m[cont].GetFood();
        }
    }
}
