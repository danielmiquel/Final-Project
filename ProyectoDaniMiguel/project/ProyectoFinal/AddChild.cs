using System.Collections.Generic;


namespace ProyectoFinal
{
    class AddChild
    {
        //Create new child for insert in list
        public Child SetNewChild(string name, string surname,
            string observations, string allergy,char sex,Day birthay)
        {
            ListOfChildren l = new ListOfChildren();
            int cod = l.GetList().Count + 1;
            Child newChild = new Child(cod,name,surname,sex,
                observations,allergy);
            newChild.SetBirthday(birthay);
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
