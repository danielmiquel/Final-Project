using System;
using System.Collections.Generic;


namespace ProyectoFinal
{
    //Class to select meals according to the time of day
    public class FoodSelection
    {
        protected int index;
        protected ListOfChildren listC;
        protected ListOfMeals listM;
        protected Random rnd = new Random();
        protected string mealSave = "";
        
        public FoodSelection(ListOfChildren lc,ListOfMeals lm)
        {
            listC = lc;
            listM = lm;
        }

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
            Child child = listC.GetChildOfList(i);
            bool found; 

            if (child.GetAllergies() == "")
            {
                return FoodForShow(m);
            }

            else
            {
                string[] arrAllergiesChild = child.GetArrayAllergies();
                string[] arrAllergiesMeals = new string[m.Count];
                for (int j = 0; j < m.Count; j++)
                {
                    arrAllergiesMeals[j] = m[j].GetAllergies();
                }

                for (int j = 0; j < m.Count; j++)
                {
                    found = false;

                    for (int h = 0; h < arrAllergiesChild.Length && !found; h++)
                    {
                        if (arrAllergiesMeals[j].Contains(arrAllergiesChild[h]))
                            found = true;
                        if ((h == arrAllergiesChild.Length - 1) && (!found))
                            return m[j].GetFood();
                    }
                }

                return "";
            }
        }
    }
}
