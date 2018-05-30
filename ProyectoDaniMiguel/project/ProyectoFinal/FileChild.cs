using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal
{
    //Class for save and load the file os children
    class FileChild : Files
    {
        protected List<Child> listChildren;

        public override void Save()
        {
            try
            {
                StreamWriter file = File.CreateText("listOfChildren.txt");
                /*
                if (!File.Exists("listOfChildren.txt"))
                     file = File.CreateText("listOfChildren.txt");
                else
                    file 
                */

                foreach (Child i in listChildren)
                {
                    file.WriteLine(i.GetCod() + "|" + i.GetName()
                        + "|" + i.GetSurname() + "|" + i.GetSex()
                        + "|" + i.GetBirthday().day + "," + i.GetBirthday().month + ","
                        + i.GetBirthday().year
                        + "|" + i.GetObservations() + "|" + i.GetAllergies());
                }
                file.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine("Eror: " + e.Message);
            }

        }

        public override void Load()
        {
            

            try
            {
                if (File.Exists("listOfChildren.txt"))
                {
                    List<Child> list = new List<Child>();
                    StreamReader file = File.OpenText("listOfChildren.txt");
                    string[] data = new string[7];
                    string[] birthday = new string[3];
                    string line;
                    Child child;

                    do
                    {
                        line = file.ReadLine();
                        if (line != null)
                        {
                            data = line.Split('|');
                            child = new Child(Convert.ToInt32(data[0]), data[1],
                                data[2], Convert.ToChar(data[3]), data[5], data[6]);
                            birthday = data[4].Split(',');
                            child.SetBirthdayInt(Convert.ToInt32(birthday[0]),
                                Convert.ToInt32(birthday[1]),
                                Convert.ToInt32(birthday[2]));
                            list.Add(child);
                        }
                    } while (line != null);
                    file.Close();
                    listChildren = list;
                }
                else
                {
                    listChildren = null;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public List<Child> GetList()
        {
            return listChildren;
        }

        public void SetList(List<Child> l)
        {
            listChildren = l;
        }
    }
}
