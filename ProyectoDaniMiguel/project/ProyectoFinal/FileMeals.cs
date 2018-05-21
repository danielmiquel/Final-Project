using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal
{
    class FileMeals
    {
        public void SaveMeals(List<Meal> listSave)
        {
            try
            {
                if (!File.Exists("lisOfMeals.txt"))
                    Console.WriteLine("Eror,file not found");

                StreamWriter file = File.AppendText("lisOfMeals.txt");

                foreach (Meal i in listSave)
                {
                    file.WriteLine(i.GetFoodType()+"|"+i.GetFoodstuff() 
                        + "|" + i.GetDish()+ "|" + i.GetAllergies());
                }
                file.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine("Eror: " + e.Message);
            }
        }

        public List<Meal> LoadMeals()
        {
            List<Meal> listLoadMeals = new List<Meal>();

            try
            {
                StreamReader file = File.OpenText("listOfMeals.txt");
                string[] data = new string[4];
                string line;
                Meal meal;

                do
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        data = line.Split('|');
                        meal = new Meal(data[0],data[1],data[2],data[3]);
                        listLoadMeals.Add(meal);
                    }
                } while (line != null);
                file.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine("Eror: " + e.Message);
            }

            return listLoadMeals;
        }
    }
}
