using System.Collections.Generic;

namespace ProyectoFinal
{

    //This class get the list of children that FileChild load
    public class ListOfChildren
    {
        public List<Child> listChildren;
        private FileChild children = new FileChild();

        public ListOfChildren()
        {
            children.Load();
            listChildren = children.GetList();
        }

        public List<Child> GetList()
        {
            return listChildren;
        }

        public void SetList(List<Child> list)
        {
            listChildren = list;
        }

        public int CompareChildren(Child c1,Child c2)
        {
            return c1.GetCod() - c2.GetCod();
        }
        
        public void SaveListOfChildren()
        {
            listChildren.Sort(CompareChildren);
            children.SetList(listChildren);
            children.Save();
        }

        //Method to remove a children
        public void RemoveChild(int n)
        {
            listChildren.RemoveAt(n);
            children.SetList(listChildren);
            children.Save();
        }

        public List<string> ListForShow()
        {
            List<string> list = new List<string>();

            foreach (Child i in listChildren)
            {
                list.Add(i.GetCod() + " " + i.GetName() + " " + i.GetSurname());
            }

            return list;
        }

        public Child GetChildOfList(int n)
        {
            return listChildren[n];
        }
        /*
        public Child GetChildOfListByCod(int n)
        {
            return listChildren;
        }
        */
    }
}
