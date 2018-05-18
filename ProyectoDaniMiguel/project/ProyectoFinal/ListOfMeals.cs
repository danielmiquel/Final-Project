using System.Collections.Generic;

namespace ProyectoFinal
{
    //This class get the list of meals that FileMeals load
    class ListOfMeals
    {
        private List<Meals> listMeals;
        protected List<Meals> listLunch;
        protected List<Meals> listSnack;
        protected List<Meals> listBreakfast;
        private FileMeals list = new FileMeals();

        public ListOfMeals()
        {
            listMeals = list.LoadMeals();
        }

        public List<Meals> GetListOfMeals()
        {
            return listMeals;
        }
        
        public List<Meals> GetLunchFood()
        {
            foreach (Meals i in listMeals)
            {
                if (i.GetFoodType() == "lunch")
                {
                    listLunch.Add(i);
                }
            }

            return listLunch;
        }

        public List<Meals> GetSnackFood()
        {
            foreach (Meals i in listMeals)
            {
                if (i.GetFoodType() == "snack")
                {
                    listSnack.Add(i);
                }
            }

            return listSnack;
        }

        public List<Meals> GetBreakfastFood()
        {
            foreach (Meals i in listMeals)
            {
                if (i.GetFoodType() == "breakfast")
                {
                    listBreakfast.Add(i);
                }
            }

            return listBreakfast;
        }

        public List<string> ListForShow(string option)
        {
            List<string> list = new List<string>();
            List<Meals> list2;

            switch (option)
            {
                case "lunch":
                    list2 = GetLunchFood();
                    break;
                case "breakfast":
                    list2 = GetBreakfastFood();
                    break;
                case "sanck":
                    list2 = GetSnackFood();
                    break;
                default:
                    list2 = listMeals;
                    break;
            }
            foreach (Meals i in list2)
            {
                list.Add("Dish:" + i.GetDish() + ", Foodstuff:"
                    +i.GetFoodstuff()+" ,Allergies:"+i.GetAllergies());
            }
            return list;
        }
    }
}
