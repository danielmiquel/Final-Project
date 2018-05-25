using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    //Class for work with the progres of children the all days
    public struct Day
    {
        public int day;
        public int month;
        public int year;
    }
    
    public struct TimeSleep
    {
        public int hour;
        public int minute;
    }

    class InformationOfDay
    {
        protected Day daySave;
        protected int cod;
        protected int eatAmoutB;
        protected int eatAmoutL;
        protected int eatAmoutS;
        protected string messageForHome;
        protected string messageForSchool;
        protected bool depositionsMor;
        protected bool depositionsAft;
        protected bool sleepMor;
        protected bool sleepAft;
        protected TimeSleep timeSleepMor;
        protected TimeSleep timeSleepAft;
        protected string meal;
        
        public InformationOfDay(int cod, int eatAmoutB, int eatAmoutL,
            int eatAmoutS, string messageForHome, string messageForSchool, 
            bool depositionsMor, bool depositionsAft, bool sleepMor, 
            bool sleepAft, string meal)
        {
            this.cod = cod;
            this.eatAmoutB = eatAmoutB;
            this.eatAmoutL = eatAmoutL;
            this.eatAmoutS = eatAmoutS;
            this.messageForHome = messageForHome;
            this.messageForSchool = messageForSchool;
            this.depositionsMor = depositionsMor;
            this.depositionsAft = depositionsAft;
            this.sleepMor = sleepMor;
            this.sleepAft = sleepAft;
            this.meal = meal;
        }

        public int GetCod()
        {
            return cod;
        }

        public string GetMeal()
        {
            return meal;
        }

        public Day GetDay()
        {
            return daySave;
        }

        public int GetEatAmoutB()
        {
            return eatAmoutB;
        }

        public int GetEatAmoutL()
        {
            return eatAmoutL;
        }

        public int GetEatAmoutS()
        {
            return eatAmoutS;
        }

        public string GetMessageForHome()
        {
            return messageForHome;
        }

        public string GetMessageForSchool()
        {
            return messageForSchool;
        }

        public bool GetDepositionsMor()
        {
            return depositionsMor;
        }

        public bool GetDepositionsAft()
        {
            return depositionsMor;
        }

        public bool GetSleepMor()
        {
            return sleepMor;
        }

        public bool GetSleepAft()
        {
            return sleepAft;
        }

        public TimeSleep GetTimeSleepMor()
        {
            return timeSleepMor;
        }

        public TimeSleep GetTimeSleepAft()
        {
            return timeSleepAft;
        }

        public void SetCod(int i)
        {
            cod = i;
        }

        public void SetMeal(string t)
        {
            meal = t;
        }

        public void SetDay(Day t)
        {
            daySave = t;
        }

        public void SetEatAmoutB(int t)
        {
            eatAmoutB = t;
        }

        public void SetEatAmoutL(int t)
        {
            eatAmoutL = t;
        }

        public void SetEatAmoutS(int t)
        {
            eatAmoutS = t;
        }

        public void SetMessageForHome(int n, string t)
        {
            messageForHome = t;
        }

        public void SetMessageForSchool(int n, string t)
        {
            messageForSchool = t;
        }

        public void SetDepositionsMor(bool t)
        {
            depositionsMor = t;
        }

        public void SetDepositionsAft(bool t)
        {
            depositionsMor = t;
        }

        public void SetSleepMor(bool t)
        {
            sleepMor = t;
        }

        public void SetSleepAft(bool t)
        {
            sleepAft = t;
        }

        public void SetTimeSleepMor(TimeSleep t)
        {
            timeSleepMor = t;
        }

        public void SetTimeSleepAft(TimeSleep t)
        {
           timeSleepAft = t;
        }
        
        public void AddTimeSleepAft(int h, int m)
        {
            timeSleepAft.hour = h;
            timeSleepAft.minute = m;
        }

        public void AddTimeSleepMor(int h, int m)
        {
            timeSleepMor.hour = h;
            timeSleepMor.minute = m;
        }

        public void AddDaySave(int day,int month,int year)
        {
            daySave.day = day;
            daySave.month = month;
            daySave.year = year;
        }
    }
}
