using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    //Class for work with the progres of children the all days
    public struct Information
    {
        public string child;
        public string meal;
        public string day;
        public int eatAmoutB;
        public int eatAmoutL;
        public int eatAmoutS;
        public string messageForHome;
        public string messageForSchool;
        public bool depositionsMor;
        public bool depositionsAft;
        public bool sleepMor;
        public bool sleepAft;
        public string timeSleepMor;
        public string timeSleepAft;
    }

    class ListInformationOfDay
    {
        private FileInformationOfDay file = new FileInformationOfDay();
        protected List<Information> listInfo;

        public ListInformationOfDay()
        {
            listInfo = file.LoadInfo();
        }
        
        public string GetChild(int n)
        {
            return listInfo[n].child;
        }

        public string GetMeal(int n)
        {
            return listInfo[n].meal;
        }

        public string GetDay(int n)
        {
            return listInfo[n].day;
        }

        //TO DO:
        /* Finally Getter and Setters
         * /
        
        
        /*
        public string GetChild(int n)
        {
            return listInfo[n].child;
        }

        public string GetChild(int n)
        {
            return listInfo[n].child;
        }

        public string GetChild(int n)
        {
            return listInfo[n].child;
        }
        */
    }
}
