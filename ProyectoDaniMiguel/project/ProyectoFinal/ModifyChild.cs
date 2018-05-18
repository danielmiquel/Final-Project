//Luis Selles
//V0.04  -  Creating the class to modify the Childs of the list

using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    class ModifyChild
    {
        protected  int index;
        protected List<Child> listChildren;

        public ModifyChild()
        {
        }

        public ListOfChild ModList(ListOfChild listChild)
        {
            return listChild;
        }

        //Return index of child to modify
        public int GetIndex()
        {
            return index;
        }

        //set the index of child to modify
        public void SetIndex(int newIndex)
        {
            this.index = newIndex;
        }

        //Return the current list
        public List<Child> GetListChildren()
        {
            ListOfChild list = new ListOfChild();
            return list.GetList();
        }

        //Return the select child  for modify
        public Child GetSelectChild()
        {
            listChildren = GetListChildren();
            return listChildren[index];
        }

        //Insert the modified child in list and save
        public void SetModifiedChild(Child c,int i)
        {
            listChildren = GetListChildren();
            listChildren.RemoveAt(i);
            listChildren.Insert(i, c);
            ListOfChild save = new ListOfChild();
            save.SetList(listChildren);
            save.SaveListOfChildren();
        }
    }
}
