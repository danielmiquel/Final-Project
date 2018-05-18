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

        public void SetIndex(int newIndex)
        {
            this.index = newIndex;
        }
        
        public List<Child> GetListChildren()
        {
            ListOfChild list = new ListOfChild();
            return list.GetList();
        }

        public Child GetSelectChild()
        {
            listChildren = GetListChildren();
            return listChildren[index];
        }
    }
}
