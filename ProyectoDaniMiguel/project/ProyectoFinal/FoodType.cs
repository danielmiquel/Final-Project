

namespace ProyectoFinal
{
    //This class use for do list of all food type(breakfast,lunch and snack)
    //for separate the diferents meals
    abstract class FoodType
    {
        protected string foodType;
        protected string dish;
        protected string foodstuff;
        protected string allergies;

        public  FoodType(string foodType, string dish,
            string foodstuff, string allergies)
        {
            this.foodType = foodType;
            this.dish = dish;
            this.foodstuff = foodstuff;
            this.allergies = allergies;
        }

        public abstract string GetDish();

        public abstract void Set(string newDish);

        public abstract string GetFoodstuff();

        public abstract void SetFoodStuff(string newFoodstuff);

        public abstract string GetAllergies();

        public abstract void SetAllergies(string newAllergies);

        public abstract string GetFoodType();

        public abstract void SetFoodType(string newFoodType);
        
    }
}
