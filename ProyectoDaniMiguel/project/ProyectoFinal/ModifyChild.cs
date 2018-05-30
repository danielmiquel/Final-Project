//Luis Selles
//V0.04  -  Creating the class to modify the Childs of the list

using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    public class ModifyChild
    {
        public  int index;
        public List<Child> listChildren;
        protected ListOfChildren list;

        public ModifyChild(ListOfChildren l)
        {
            listChildren = l.GetList();
            list = l;
        }

        public ListOfChildren ModList(ListOfChildren listChild)
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
        /*
        public List<Child> GetListChildren()
        {
            ListOfChildren list = new ListOfChildren();
            return list.GetList();
        }
        */

        //Return the select child  for modify
        public Child GetSelectChild(int i)
        {
            return listChildren[i];
        }

        //Insert the modified child in list and save
        public void SetModifiedChild(Child c,int i)
        {
            listChildren.RemoveAt(i);
            listChildren.Insert(i, c);
            list.SetList(listChildren);
            list.SaveListOfChildren();
        }
    }
}
