﻿using System;

namespace ProyectoFinal
{
    public class Child
    {
        protected Day birth;
        protected string typeAge;
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

        public Day GetBirthday()
        {
            return birth;
        }

        public int GetAge()
        {
            return age;
        }

        //Calculates the age from the date of birth
        public void SetAge(Day t)
        {
            DateTime now = DateTime.Now;

            if(t.year == now.Year)
            {
                if (now.Month != t.month)
                {
                    age = (now.Month - t.month) - 1;
                    if (now.Day >= t.day)
                        age++;
                }
                else
                    age = 0;
                typeAge = "Months";
            }
            else
            {
                if(now.Year - t.year == 1)
                {
                    age = (12 - t.month) + now.Month - 1;
                    if (now.Day >= t.day)
                        age++;
                    typeAge = "Months";
                    if(age >= 12)
                    {
                        age = 1;
                        typeAge = "Years";
                    }
                }
                else
                {
                    age = now.Year - t.year;
                    if (now.Month == t.month && now.Day == t.day)
                        age++;
                    typeAge = "Years";
                }
            } 
        }

        public void SetBirthday(Day d)
        {
            birth = d;
            SetAge(birth);
        }

        public string GetTypeAge()
        {
            return typeAge;
        }

        public void SetBirthdayInt(int day, int month, int year)
        {
            birth.day = day;
            birth.month = month;
            birth.year = year;
            SetAge(birth);
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
