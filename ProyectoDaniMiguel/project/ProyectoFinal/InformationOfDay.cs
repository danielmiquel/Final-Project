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

    public class InformationOfDay
    {
        protected Day daySave;
        protected int cod;
        protected int eatAmoutB;
        protected int eatAmoutL;
        protected int eatAmoutS;
        protected string messageForHome;
        protected string messageForSchool;
        protected int depositionsMor;
        protected int depositionsAft;
        protected int sleepMor;
        protected int sleepAft;
        protected TimeSleep timeSleepMorUntil;
        protected TimeSleep timeSleepMorSince;
        protected TimeSleep timeSleepAftUntil;
        protected TimeSleep timeSleepAftSince;
        protected string meal;
        
        public InformationOfDay(int cod, int eatAmoutB, int eatAmoutL,
            int eatAmoutS, string messageForHome, string messageForSchool,
            int depositionsMor, int depositionsAft, int sleepMor,
            int sleepAft)
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

        public string GetDayForShow()
        {
            return daySave.day+"/"+daySave.month+"/"+daySave.year;
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

        public int GetDepositionsMor()
        {
            return depositionsMor;
        }

        public int GetDepositionsAft()
        {
            return depositionsMor;
        }

        public int GetSleepMor()
        {
            return sleepMor;
        }

        public int GetSleepAft()
        {
            return sleepAft;
        }

        public TimeSleep GetTimeSleepMorSince()
        {
            return timeSleepMorSince;
        }

        public TimeSleep GetTimeSleepAftSince()
        {
            return timeSleepAftSince;
        }

        public TimeSleep GetTimeSleepMorUntil()
        {
            return timeSleepMorUntil;
        }

        public TimeSleep GetTimeSleepAftUntil()
        {
            return timeSleepAftUntil;
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

        public void SetDepositionsMor(int t)
        {
            depositionsMor = t;
        }

        public void SetDepositionsAft(int t)
        {
            depositionsMor = t;
        }

        public void SetSleepMor(int t)
        {
            sleepMor = t;
        }

        public void SetSleepAft(int t)
        {
            sleepAft = t;
        }

        public void SetTimeSleepMorUntil(TimeSleep t)
        {
            timeSleepMorUntil = t;
        }

        public void SetTimeSleepAftUntil(TimeSleep t)
        {
            timeSleepAftUntil = t;
        }

        public void SetTimeSleepMorSince(TimeSleep t)
        {
            timeSleepMorSince = t;
        }

        public void SetTimeSleepAftSince(TimeSleep t)
        {
            timeSleepAftSince = t;
        }

        public void AddTimeSleepAft(int h1, int m1,int h2,int m2)
        {
            timeSleepAftUntil.hour = h2;
            timeSleepAftUntil.minute = m2;
            timeSleepAftSince.hour = h1;
            timeSleepAftSince.minute = m1;
        }

        public void AddTimeSleepMor(int h1, int m1, int h2, int m2)
        {
            timeSleepMorSince.hour = h1;
            timeSleepMorSince.minute = m1;
            timeSleepMorUntil.hour = h2;
            timeSleepMorUntil.minute = m2;
        }

        public void AddDaySave(int day,int month,int year)
        {
            daySave.day = day;
            daySave.month = month;
            daySave.year = year;
        }
    }
}
