using System;

namespace ProyectoFinal
{
    //TO DO 
    //End to implements methods of abstract class
    class Breakfast : FoodType
    {
        public Breakfast(string foodType, string dish, string foodstuff,
            string allergies) : base(foodType, dish, foodstuff, allergies)
        {
        }

        public override string GetAllergies()
        {
            throw new NotImplementedException();
        }

        public override string GetDish()
        {
            throw new NotImplementedException();
        }

        public override string GetFoodstuff()
        {
            throw new NotImplementedException();
        }

        public override string GetFoodType()
        {
            throw new NotImplementedException();
        }

        public override void Set(string newDish)
        {
            throw new NotImplementedException();
        }

        public override void SetAllergies(string newAllergies)
        {
            throw new NotImplementedException();
        }

        public override void SetFoodStuff(string newFoodstuff)
        {
            throw new NotImplementedException();
        }

        public override void SetFoodType(string newFoodType)
        {
            throw new NotImplementedException();
        }
    }
}
