using System.Collections.Generic;

namespace ProyectoFinal
{
    //This class get the list of meals that FileMeals load
    public class ListOfMeals
    {
        private List<Meal> listMeals;
        protected List<Meal> listLunch = new List<Meal>();
        protected List<Meal> listSnack = new List<Meal>();
        protected List<Meal> listBreakfast = new List<Meal>();
        private FileMeals list = new FileMeals();

        public ListOfMeals()
        {
            list.Load();
            listMeals = list.GetList();
        }

        public List<Meal> GetListOfMeals()
        {
            return listMeals;
        }

        //Functions that divide the list<Meals> according to type
        public List<Meal> GetLunchFood()
        {
            foreach (Meal i in listMeals)
            {
                if (i.GetFoodType() == "lunch")
                {
                    listLunch.Add(i);
                }
            }

            return listLunch;
        }

        public List<Meal> GetSnackFood()
        {
            foreach (Meal i in listMeals)
            {
                if (i.GetFoodType() == "snack")
                {
                    listSnack.Add(i);
                }
            }

            return listSnack;
        }

        public List<Meal> GetBreakfastFood()
        {
            foreach (Meal i in listMeals)
            {
                if (i.GetFoodType() == "breakfast")
                {
                    listBreakfast.Add(i);
                }
            }

            return listBreakfast;
        }
    }
}
