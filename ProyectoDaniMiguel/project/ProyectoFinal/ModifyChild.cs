//Luis Selles
//V0.04  -  Creating the class to modify the Childs of the list

using System;

namespace ProyectoFinal
{
    class ModifyChild
    {
        protected  int index;

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
        
    }
}
