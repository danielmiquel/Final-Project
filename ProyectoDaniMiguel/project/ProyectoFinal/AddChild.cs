using System.Collections.Generic;


namespace ProyectoFinal
{
    class AddChild
    {
        //Create new child for insert in list
        public Child SetNewChild(string name, string surname,
            string observations, int age, string allergy,char sex)
        {
            ListOfChildren l = new ListOfChildren();
            int cod = l.GetList().Count + 1;
            Child newChild = new Child(cod,name,surname,sex,age,
                observations,allergy);
            return newChild;
        }

        //insert new child in list and save this
        public void SetListWithNewChild(Child c)
        {
            ListOfChildren save = new ListOfChildren();
            List<Child> children = save.GetList();
            children.Add(c);
            save.SetList(children);
            save.SaveListOfChildren();
        }
    }
}
