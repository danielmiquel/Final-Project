﻿namespace ProyectoFinal
{
    class Meal
    {
        protected string foodType;
        protected string dish;
        protected string foodstuff;
        protected string allergies;

        public Meal(string foodType,string dish,string foodstuff,string allergies)
        {
            this.foodType = foodType;
            this.dish = dish;
            this.foodstuff = foodstuff;
            this.allergies = allergies;
        }

        public string GetDish()
        {
            return dish;
        }

        public void Set(string newDish)
        {
            dish = newDish;
        }

        public string GetFoodstuff()
        {
            return foodstuff;
        }

        public void SetFoodStuff(string newFoodstuff)
        {
            foodstuff = newFoodstuff;
        }

        public string GetAllergies()
        {
            return allergies;
        }

        public void SetAllergies(string newAllergies)
        {
            allergies = newAllergies;
        }

        public string GetFoodType()
        {
            return foodType;
        }

        public void SetFoodType(string newFoodType)
        {
            foodType = newFoodType;
        }

        public string[] GetArrayAllergies()
        {
            string[] allergies = GetAllergies().Split(',');
            return allergies;
        }

        public string GetFood()
        {
            return "Dish: "+dish+"   Foodstruff: "
                +foodstuff+"   Allergies: "+allergies;
        }
    }
}
