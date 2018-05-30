using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class FileInformationOfDay : Files
    {
       protected List<InformationOfDay> listInfo;

        public override void Save()
        {
            try
            {
                StreamWriter file = File.CreateText("listInformationOfDay.txt");
                
                foreach (InformationOfDay i in listInfo)
                {
                    file.WriteLine(i.GetCod() + "|" 
                        + i.GetMeal() + "|" 
                        + i.GetDay().day+","+i.GetDay().month+","
                        + i.GetDay().year + "|"+ i.GetEatAmoutB() +"|" 
                        + i.GetEatAmoutL()+ "|" + i.GetEatAmoutS() + "|" 
                        + i.GetDepositionsMor()+ "|"+i.GetDepositionsAft()+"|" 
                        + i.GetSleepMor() + "|"
                        + i.GetTimeSleepMorSince().hour+","
                        + i.GetTimeSleepMorSince().minute + "," 
                        + i.GetTimeSleepMorUntil().hour + ","
                        + i.GetTimeSleepMorUntil().minute + "|"
                        + i.GetSleepAft() + "|"
                        + i.GetTimeSleepAftSince().hour+","
                        + i.GetTimeSleepAftSince().minute + ","
                        + i.GetTimeSleepAftUntil().hour + ","
                        + i.GetTimeSleepAftUntil().minute + "|"
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



            try
            { 

                if (File.Exists("listInformationOfDay.txt"))
                {
                    List<InformationOfDay> list = new List<InformationOfDay>();
                    StreamReader file = File.OpenText("listInformationOfDay.txt");
                    string[] data = new string[14];
                    string[] date = new string[3];
                    string[] timeSleepMor = new string[4];
                    string[] timeSleepAft = new string[4];
                    //string[] meals = new string[7];
                    string line;
                    InformationOfDay info;

                    do
                    {
                        line = file.ReadLine();
                        if (line != null && line.Length > 1)
                        {
                            data = line.Split('|');
                            date = data[2].Split(',');
                            timeSleepMor = data[9].Split(',');
                            timeSleepMor = data[11].Split(',');
                            /*
                            meals = data[1].Split(',');
                            DateTime time = new DateTime(Convert.ToInt32(data[6]),
                                Convert.ToInt32(data[5]),
                                Convert.ToInt32(data[4]));
                            string m = new Meal(meals[0], meals[1], meals[2], meals[3], time);
                            */
                            info = new InformationOfDay(Convert.ToInt32(data[0]),
                                Convert.ToInt32(data[3]), Convert.ToInt32(data[4]),
                                Convert.ToInt32(data[5]), data[12], data[13],
                                Convert.ToInt32(data[6]),
                                Convert.ToInt32(data[7]),
                                Convert.ToInt32(data[8]),
                                Convert.ToInt32(data[10]));
                            info.AddTimeSleepMor(Convert.ToInt32(timeSleepMor[0]),
                                Convert.ToInt32(timeSleepMor[1]),
                                Convert.ToInt32(timeSleepMor[2]),
                                Convert.ToInt32(timeSleepMor[3]));
                            info.AddTimeSleepAft(Convert.ToInt32(timeSleepAft[0]),
                                Convert.ToInt32(timeSleepAft[1]),
                                Convert.ToInt32(timeSleepAft[2]),
                                Convert.ToInt32(timeSleepAft[3]));
                            info.AddDaySave(Convert.ToInt32(date[0]),
                                Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
                            /*
                            Warning w = new Warning(date[0],date`[1],date[2]);
                            w.Show();
                            */
                            info.SetMeal(data[1]);
                            list.Add(info);
                        }

                    } while (line != null);
                    file.Close();
                    listInfo = list;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Eror: " + e.Message);
            }
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
