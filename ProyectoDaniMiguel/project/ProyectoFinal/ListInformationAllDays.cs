using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class ListInformationAllDays
    {
        protected List<InformationOfDay> listInformationAllDays;
        protected FileInformationOfDay f = new FileInformationOfDay();

        public ListInformationAllDays()
        {
            f.Load();
            listInformationAllDays = f.GetList();
        }

        
    }
}
