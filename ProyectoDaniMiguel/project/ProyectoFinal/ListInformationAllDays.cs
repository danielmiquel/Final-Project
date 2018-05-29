using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ListInformationAllDays
    {
        protected List<InformationOfDay> listInformationAllDays;
        protected FileInformationOfDay f = new FileInformationOfDay();

        public ListInformationAllDays()
        {
            f.Load();
            listInformationAllDays = f.GetList();
        }

        public void SetInformation(InformationOfDay d)
        {
            listInformationAllDays.Add(d);
            f.SetList(listInformationAllDays);
            f.Save();
        }

        public List<InformationOfDay> GetInformationOfAChild(int cod)
        {
            List<InformationOfDay> listOfAChild = new List<InformationOfDay>();
            foreach (InformationOfDay i in listInformationAllDays)
            {
                if (i.GetCod() == cod)
                {
                    listOfAChild.Add(i);
                }
            }

            return listOfAChild;
        }

        public InformationOfDay GetInformationOfAChildFromDate(DateTime d, int cod)
        {
            foreach (InformationOfDay i in GetInformationOfAChild(cod))
            {
                if (i.GetDay().Equals(d))
                {
                    InformationOfDay info = i;
                    return info;
                }
            }
            return null;
        }
    }
}
