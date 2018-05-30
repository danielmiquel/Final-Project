using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class RemoveChild
    {
        public RemoveChild(int index,ListOfChildren list)
        {
            list.listChildren.RemoveAt(index);
            List<Child> children = list.GetList();

            foreach (Child i in children)
            {
                if(i.GetCod() > index + 1)
                {
                    i.SetCod(i.GetCod() - 1);
                }
            }

            list.SaveListOfChildren();
        }
    }
}
