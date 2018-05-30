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
            //listInformationAllDays.Sort(CompareInformation);
            listInformationAllDays.Sort(CompareInformationByDay);
            f.SetList(listInformationAllDays);
            f.Save();
        }

        public int CompareInformation(InformationOfDay i1, InformationOfDay i2)
        {
            return i1.GetCod() - i2.GetCod();
        }

        
        public int CompareInformationByDay(InformationOfDay i1, InformationOfDay i2)
        {
            CompareInformation(i1, i2);
            CompareInformationByYear(i1, i2);
            CompareInformationByMonth(i1, i2);
            return i2.GetDay().day -  i1.GetDay().day;
        }

        public int CompareInformationByMonth(InformationOfDay i1, InformationOfDay i2)
        {
            return i2.GetDay().month - i1.GetDay().month;
        }

        public int CompareInformationByYear(InformationOfDay i1, InformationOfDay i2)
        {
            return i2.GetDay().year - i1.GetDay().year;
        }
        

        public void SetEditInformation(InformationOfDay i)
        {
            foreach (InformationOfDay t in listInformationAllDays)
            {
                if((i.GetCod() == t.GetCod()) && (t.GetDay().Equals(i.GetDay())))
                {
                    listInformationAllDays.Remove(t);
                    SetInformation(i);
                }
            }
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

        public InformationOfDay GetInformationOfAChildFromDate(Day d, int cod)
        {
            foreach (InformationOfDay i in GetInformationOfAChild(cod))
            {
                if ((i.GetDay().day == d.day) && (i.GetDay().month == d.month) 
                    && (i.GetDay().year == d.year))
                {
                    InformationOfDay info = i;
                    return info;
                }
            }
            return null;
        }
    }
}
