using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal
{
    //Class for save and load the file os children
    class FileChild
    {
        
        public void SaveChildren(List<Child> listSave)
        {
            try
            {
                if(!File.Exists("lisOfChildren.txt"))
                    Console.WriteLine("Eror,file not found");

                StreamWriter file = File.CreateText("lisOfChildren.txt");

                foreach (Child i in listSave)
                {
                    file.WriteLine(i.GetCod() + "|" + i.GetName() + "|"
                        + i.GetSurname() + "|" + i.GetSex() + "|" +
                        i.GetAge() + "|" + i.GetObservations()
                        + "|" + i.GetAllergies());
                }
                file.Close();

            }catch(IOException e)
            {
                Console.WriteLine("Eror: "+e.Message);
            }
        
        }

        public List<Child> LoadChildren()
        {
            List<Child> listLoadChild = new List<Child>();

            try
            {
                StreamReader file = File.OpenText("lisOfChildren.txt");
                string[] data= new string[7];
                string line;
                Child child;

                do
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        data = line.Split('|');
                        child = new Child(Convert.ToInt32(data[0]), data[1], 
                            data[2],Convert.ToChar(data[3]), 
                            Convert.ToInt32(data[4]), data[5], data[6]);
                        listLoadChild.Add(child);
                    }
                } while (line != null);
                file.Close();
            
            }
            catch(IOException e)
            {
                Console.WriteLine("Eror: "+e.Message);
            }

            return listLoadChild;
        }
    }
}
