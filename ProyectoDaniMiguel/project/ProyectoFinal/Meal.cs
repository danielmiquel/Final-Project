using System;

namespace ProyectoFinal
{
    public class Meal
    {
        protected string foodType;
        protected string dish;
        protected string foodstuff;
        protected string allergies;
        protected DateTime dateOfUse;

        public Meal(string foodType, string dish, string foodstuff, string allergies, DateTime dateOfUse)
        {
            this.foodType = foodType;
            this.dish = dish;
            this.foodstuff = foodstuff;
            this.allergies = allergies;
            this.dateOfUse = dateOfUse;
        }

        public Meal(string foodType,string dish,string foodstuff,string allergies)
        {
            this.foodType = foodType;
            this.dish = dish;
            this.foodstuff = foodstuff;
            this.allergies = allergies;
        }

        public Meal() { }

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

        public DateTime GetDateOfUse()
        {
            return dateOfUse;
        }

        public void SetDateOfUse(DateTime d)
        {
            dateOfUse = d;
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

        public string GetFoorForSaveUseOfData()
        {
            return foodType + "," + foodstuff + ","
                + dish + "," + allergies + "," + dateOfUse.Day
                + "," + dateOfUse.Month + "," + dateOfUse.Year;
        }

        public string GetFoorForSave()
        {
            return foodType + "," + foodstuff + ","
                + dish + "," + allergies;
        }
    }
}

