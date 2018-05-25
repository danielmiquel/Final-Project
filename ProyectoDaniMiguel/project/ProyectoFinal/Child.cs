using System;

namespace ProyectoFinal
{
    public struct Birthday
    {
        public int day;
        public int month;
        public int year;
    }

    public class Child
    {
        protected Birthday birth;
        protected int age;
        protected string name;
        protected string surname;
        protected int cod;
        protected char sex;
        protected string observations;
        protected string allergies;

        public Child(int cod, string name, string surname, char sex,
            string observations, string allergies)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.observations = observations;
            this.cod = cod;
            this.allergies = allergies;
        }

        public Birthday GetBirthday()
        {
            return birth;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge()
        {
            DateTime now = new DateTime();
            age = now.Year - birth.year;
            if (now.Month > birth.month && now.Day > birth.day)
                age++;
        }

        public void SetBirthdayInt(Birthday d)
        {
            birth = d;
        }

        public void SetBirthdayInt(int day, int month, int year)
        {
            birth.day = day;
            birth.month = month;
            birth.year = year;
        }

        public int GetCod()
        {
            return cod;
        }

        public void SetCod(int code)
        {
            cod = code;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetSurname(string newSurname)
        {
            surname = newSurname;
        }

        public string GetObservations()
        {
            return observations;
        }

        public void SetObservations(string newObservations)
        {
            observations = newObservations;
        }

        public  char GetSex()
        {
            return sex;
        }

        public void SetSex(char newSex)
        {
            sex = newSex;
        }

        public string GetAllergies()
        {
            return allergies;
        }

        public void SetAllergies(string newAllergy)
        {
            allergies = newAllergy;
        }

        //Function that changes from a string to an 
        //array in order to work with allergies
        public string[] GetArrayAllergies()
        {
            string[] allergies = GetAllergies().Split(',');
            return allergies;
        }
    }
}
