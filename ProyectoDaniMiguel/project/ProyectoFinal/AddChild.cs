using System.Collections.Generic;


namespace ProyectoFinal
{
    class AddChild
    {
        //Create new child for insert in list
        public Child SetNewChild(string name, string surname,
            string observations, string allergy,char sex,Day birthay,int cod)
        {
            Child newChild = new Child(cod,name,surname,sex,
                observations,allergy);
            newChild.SetBirthday(birthay);
            return newChild;
        }

        //insert new child in list and save this
        public void SetListWithNewChild(Child c,ListOfChildren list)
        {
            List<Child> children = list.GetList();

            children.Add(c);
            list.SetList(children);
            list.SaveListOfChildren();
        }
    }
}
