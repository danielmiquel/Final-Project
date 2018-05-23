using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class FileInformationOfDay : Files
    {
        protected List<Information> listInfo;

        public override void Save()
        {
            try
            {
                StreamWriter file = File.CreateText("lisInformationOfDay.txt");

                foreach (Information i in listInfo)
                {
                    file.WriteLine(i.child.GetCod() + "|" + i.meal + "|" + i.day + "|"
                        + i.eatAmoutB + "|" + i.eatAmoutL
                        + "|" + i.eatAmoutS + "|" + i.depositionsMor
                        + "|" + i.depositionsAft + "|" + i.sleepMor + "|"
                        + i.timeSleepMor + "|" + i.sleepAft + "|"
                        + i.timeSleepAft + "|" + i.messageForHome
                        + "|" + i.messageForSchool);
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
            List<Information> list = new List<Information>();

            try
            {
                StreamReader file = File.OpenText("lisInformationOfDay.txt");
                string[] data = new string[14];
                string line;
                Information info;
                ListOfChildren listChildren = new ListOfChildren();

                do
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        data = line.Split('|');
                        info.child = listChildren.GetChildOfList
                            (Convert.ToInt32(data[0]));
                        info.meal = data[1];
                        info.day = Convert.ToDateTime(data[2]);
                        info.eatAmoutB = Convert.ToInt32(data[3]);
                        info.eatAmoutL = Convert.ToInt32(data[4]);
                        info.eatAmoutS = Convert.ToInt32(data[5]);
                        info.depositionsMor = Convert.ToBoolean(data[6]);
                        info.depositionsAft = Convert.ToBoolean(data[7]);
                        info.sleepMor = Convert.ToBoolean(data[8]);
                        info.timeSleepMor = data[9];
                        info.sleepAft = Convert.ToBoolean(data[10]);
                        info.timeSleepAft = data[11];
                        info.messageForHome = data[12];
                        info.messageForSchool = data[13];
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

        public List<Information> GetList()
        {
            return listInfo;
        }

        public void SetList(List<Information> l)
        {
            listInfo = l;
        }
    }
}
