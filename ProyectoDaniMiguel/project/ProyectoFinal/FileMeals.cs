using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal
{
    class FileMeals : Files
    {
        protected List<Meal> listMeals;

        public override void Save()
        {
            try
            {
                if (!File.Exists("lisOfMeals.txt"))
                    Console.WriteLine("Eror,file not found");

                StreamWriter file = File.AppendText("lisOfMeals.txt");

                foreach (Meal i in listMeals)
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

        public override void Load()
        {
            try
            {
                if (File.Exists("listOfMeals.txt"))
                {
                    List<Meal> list = new List<Meal>();
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
                            meal = new Meal(data[0], data[1], data[2], data[3]);
                            list.Add(meal);
                        }
                    } while (line != null);


                    listMeals = list;
                    file.Close();
                }
                else
                {
                    listMeals = new List<Meal>();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Eror: " + e.Message);
            }

        }

        public List<Meal> GetList()
        {
            return listMeals;
        }

        public void SetList(List<Meal> l)
        {
            listMeals = l;
        }
    }
}
