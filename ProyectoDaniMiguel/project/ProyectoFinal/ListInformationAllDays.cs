﻿using System;
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
            listInformationAllDays.Sort(CompareInformationByYear);
            listInformationAllDays.Sort(CompareInformationByMonth);
            f.SetList(listInformationAllDays);
            f.Save();
        }

        public int CompareInformation(InformationOfDay i1, InformationOfDay i2)
        {
            return i1.GetCod() - i2.GetCod();
        }

        
        public int CompareInformationByDay(InformationOfDay i1, InformationOfDay i2)
        {
            return i2.GetDay().day -  i1.GetDay().day;
        }

        public int CompareInformationByMonth(InformationOfDay i1, InformationOfDay i2)
        {
            if (i2.GetDay().month == i1.GetDay().month)
                return CompareInformationByDay(i1, i2);
            else
                return i2.GetDay().month - i1.GetDay().month;
        }

        public int CompareInformationByYear(InformationOfDay i1, InformationOfDay i2)
        {
            
            return i2.GetDay().year - i1.GetDay().year;
        }

        //Set the information of a child of a certain day, if that 
        //information already exists, replace it with the new information
        public void SetEditInformation(InformationOfDay i)
        {
            bool found = false;
            for(int j = 0; j < listInformationAllDays.Count && !found; j++)
            {
                if ((i.GetCod() == listInformationAllDays[j].GetCod()) && 
                    (listInformationAllDays[j].GetDay().Equals(i.GetDay())))
                {
                    listInformationAllDays.Remove(listInformationAllDays[j]);
                    SetInformation(i);
                    found = true;
                }
            }
        }

        //Returns InformationOfChild of a certain child
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

        //Returns InformationOfChild of a certain date
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
