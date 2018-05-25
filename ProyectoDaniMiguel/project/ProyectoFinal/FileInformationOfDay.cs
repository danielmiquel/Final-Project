﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class FileInformationOfDay : Files
    {
       protected List<InformationOfDay> listInfo;

        public override void Save()
        {
            try
            {
                StreamWriter file = File.CreateText("lisInformationOfDay.txt");
                
                foreach (InformationOfDay i in listInfo)
                {
                    file.WriteLine(i.GetCod() + "|" + i.GetMeal() + "|" 
                        + i.GetDay().day+","+i.GetDay().month+","
                        + i.GetDay().year + "|"+ i.GetEatAmoutB() +"|" 
                        + i.GetEatAmoutL()+ "|" + i.GetEatAmoutS() + "|" 
                        + i.GetDepositionsMor()+ "|"+i.GetDepositionsAft()+"|" 
                        + i.GetSleepMor() + "|"+ i.GetTimeSleepMor().hour+","
                        + i.GetTimeSleepMor().minute + "|" 
                        + i.GetSleepAft() + "|"+i.GetTimeSleepAft().minute+","
                        + i.GetTimeSleepAft().minute + "|" 
                        + i.GetMessageForHome()+ "|" + i.GetMessageForSchool());
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
            
            List<InformationOfDay> list = new List<InformationOfDay>();

            try
            {
                StreamReader file = File.OpenText("lisInformationOfDay.txt");
                string[] data = new string[18];
                string line;
                InformationOfDay info;
                ListOfChildren listInfo = new ListOfChildren();

                do
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        info = new InformationOfDay(Convert.ToInt32(data[0]),
                            Convert.ToInt32(data[5]),Convert.ToInt32(data[6]),
                            Convert.ToInt32(data[7]),data[16],data[17],
                            Convert.ToBoolean(data[8]),
                            Convert.ToBoolean(data[9]), 
                            Convert.ToBoolean(data[10]), 
                            Convert.ToBoolean(data[13]),data[1]);
                        info.AddTimeSleepMor(Convert.ToInt32(data[11]),
                            Convert.ToInt32(data[12]));
                        info.AddTimeSleepAft(Convert.ToInt32(data[14]),
                            Convert.ToInt32(data[15]));
                        info.AddDaySave(Convert.ToInt32(data[2]),
                            Convert.ToInt32(data[3]),Convert.ToInt32(data[4]));

                        list.Add(info);
                    }

                } while (line != null);
                file.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine("Eror: " + e.Message);
            }

            listInfo = list;
        }
        
        public List<InformationOfDay> GetList()
        {
            return listInfo;
        }

        public void SetList(List<InformationOfDay> l)
        {
            listInfo = l;
        }
    }
}
