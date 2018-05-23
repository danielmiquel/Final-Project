namespace ProyectoFinal
{
    public class Child
    {
        protected int age;
        protected string name;
        protected string surname;
        protected int cod;
        protected char sex;
        protected string observations;
        protected string allergies;

        public Child(int cod, string name, string surname, char sex,
            int age, string observations, string allergies)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.observations = observations;
            this.cod = cod;
            this.allergies = allergies;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int newAge)
        {
            age = newAge;
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
