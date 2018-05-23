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
        public Child child;
        public string meal;
        public DateTime day;
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
        protected int index;

        public ListInformationOfDay()
        {
            file.Load();
            listInfo = file.GetList();
        }
        
        public int GetIndex()
        {
            return index;
        }

        public void SetIndex(int i)
        {
            index = i;
        }

        public Child GetChild(int n)
        {
            return listInfo[n].child;
        }

        public string GetMeal(int n)
        {
            return listInfo[n].meal;
        }

        public DateTime GetDay(int n)
        {
            return listInfo[n].day;
        }

        public int GetEatAmoutB(int n)
        {
            return listInfo[n].eatAmoutB;
        }

        public int GetEatAmoutL(int n)
        {
            return listInfo[n].eatAmoutL;
        }

        public int GetEatAmoutS(int n)
        {
            return listInfo[n].eatAmoutS;
        }

        public string GetMessageForHome(int n)
        {
            return listInfo[n].messageForHome;
        }

        public string GetMessageForSchool(int n)
        {
            return listInfo[n].messageForSchool;
        }

        public bool GetDepositionsMor(int n)
        {
            return listInfo[n].depositionsMor;
        }

        public bool GetDepositionsAft(int n)
        {
            return listInfo[n].depositionsMor;
        }

        public bool GretSleepMor(int n)
        {
            return listInfo[n].sleepMor;
        }

        public bool GretSleepAft(int n)
        {
            return listInfo[n].sleepAft;
        }

        public string GetTimeSleepMor(int n)
        {
            return listInfo[n].timeSleepMor;
        }

        public string GetTimeSleepAft(int n)
        {
            return listInfo[n].timeSleepAft;
        }

        /*
        public void SetChild(int n, string t)
        {
            listInfo[n].child;
        }

        public void SetMeal(int n, string t)
        {
            listInfo[n].meal;
        }

        public void SetDay(int n, string t)
        {
            listInfo[n].day;
        }

        public void SetEatAmoutB(int n, int t)
        {
            listInfo[n].eatAmoutB;
        }

        public void SetEatAmoutL(int n, int t)
        {
            listInfo[n].eatAmoutL;
        }

        public void SetEatAmoutS(int n, int t)
        {
            listInfo[n].eatAmoutS;
        }

        public void SetMessageForHome(int n, string t)
        {
            listInfo[n].messageForHome;
        }

        public void SetMessageForSchool(int n, string t)
        {
            listInfo[n].messageForSchool;
        }

        public void SetDepositionsMor(int n,bool t)
        {
            listInfo[n].depositionsMor;
        }

        public void SetDepositionsAft(int n,bool t)
        {
            listInfo[n].depositionsMor;
        }

        public void SretSleepMor(int n,bool t)
        {
            listInfo[n].sleepMor;
        }

        public void SretSleepAft(int n,bool t)
        {
            listInfo[n].sleepAft;
        }

        public void SetTimeSleepMor(int n, string t)
        {
            listInfo[n].timeSleepMor;
        }

        public void SetTimeSleepAft(int n,string t)
        {
            listInfo[n].timeSleepAft = t;
        }
        */
    }
}
