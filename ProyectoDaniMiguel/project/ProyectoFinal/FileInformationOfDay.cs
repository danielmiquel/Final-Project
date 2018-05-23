using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class FileInformationOfDay
    {
        public void SaveInfo(List<Information> listSave)
        {
            try
            {
                if (!File.Exists("lisInformationOfDay.txt"))
                    Console.WriteLine("Eror,file not found");

                StreamWriter file = File.CreateText("lisInformationOfDay.txt");

                foreach (Information i in listSave)
                {
                    file.WriteLine(i.child + "|" + i.meal + "|" + i.day + "|"
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

        public List<Information> LoadInfo()
        {
            List<Information> listLoadInfo = new List<Information>();

            try
            {
                StreamReader file = File.OpenText("lisInformationOfDay.txt");
                string[] data = new string[14];
                string line;
                Information info;

                do
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        data = line.Split('|');
                        info.child = data[0];
                        info.meal = data[1];
                        info.day = data[2];
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
                        listLoadInfo.Add(info);
                    }
                } while (line != null);
                file.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine("Eror: " + e.Message);
            }

            return listLoadInfo;
        }
    }
}
