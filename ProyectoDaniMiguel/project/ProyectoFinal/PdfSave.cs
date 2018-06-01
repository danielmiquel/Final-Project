using System;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Collections.Generic;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ProyectoFinal
{
    class PdfSave
    {
        protected List<InformationOfDay> list;
        protected Child child;
        protected Dictionary<string, string> language;

        public PdfSave(List<InformationOfDay> l,Child c,Dictionary<string,string> d)
        {
            list = l;
            child = c;
            language = d;
        }

        public void CreateAndSavePDFDay()
        {
            try
            {
                Document doc = new Document();
                string[] m = new string[3];
                string write;
                PdfWriter.GetInstance(doc, new FileStream(child.GetSurname() + "_" +
                    child.GetName() + ".pdf", FileMode.Create));

                //Abrimos el documento
                doc.Open();

                doc.Add(new Paragraph(child.GetName() + child.GetSurname()));

                foreach (InformationOfDay inf in list)
                {
                    doc.Add(new Paragraph(inf.GetDayForShow()));

                    m = inf.GetMeal().Split('?');

                    doc.Add(new Paragraph(language["Bre"] + " : " + m[0]));
                    if (inf.GetEatAmoutB() == 1)
                        write = language["All"];
                    else if (inf.GetEatAmoutB() == 2)
                        write = language["Half"];
                    else if (inf.GetEatAmoutB() == 3)
                        write = language["Little"];
                    else
                        write = language["None"];
                    doc.Add(new Paragraph(language["IEBr"] + write));

                    doc.Add(new Paragraph(language["Lunch"] + " : " + m[1]));
                    if (inf.GetEatAmoutL() == 1)
                        write = language["All"];
                    else if (inf.GetEatAmoutL() == 2)
                        write = language["Half"];
                    else if (inf.GetEatAmoutL() == 3)
                        write = language["Little"];
                    else
                        write = language["None"];
                    doc.Add(new Paragraph(language["IELu"] + write));

                    doc.Add(new Paragraph(language["Snack"] + " : " + m[2]));
                    if (inf.GetEatAmoutS() == 1)
                        write = language["All"];
                    else if (inf.GetEatAmoutS() == 2)
                        write = language["Half"];
                    else if (inf.GetEatAmoutS() == 3)
                        write = language["Little"];
                    else
                        write = language["None"];
                    doc.Add(new Paragraph(language["IESn"] + write));

                    doc.Add(new Paragraph(language["Depo"]));
                    switch (inf.GetDepositionsMor())
                    {
                        case 1:
                            write = language["Y"];
                            break;
                        case 2:
                            write = "No";
                            break;
                        default:
                            write = language["None"];
                            break;
                    }
                    doc.Add(new Paragraph(language["Morn"] + ": " + write));

                    switch (inf.GetDepositionsAft())
                    {
                        case 1:
                            write = language["Y"];
                            break;
                        case 2:
                            write = "No";
                            break;
                        default:
                            write = language["None"];
                            break;
                    }
                    doc.Add(new Paragraph(language["Aft"] + ": " + write));

                    doc.Add(new Paragraph(language["Sleep"]));
                    switch (inf.GetSleepMor())
                    {
                        case 1:
                            write = language["Y"];
                            break;
                        case 2:
                            write = "No";
                            break;
                        default:
                            write = language["None"];
                            break;
                    }
                    doc.Add(new Paragraph(language["Morn"] + ": " + write));

                    switch (inf.GetSleepAft())
                    {
                        case 1:
                            write = language["Y"];
                            break;
                        case 2:
                            write = "No";
                            break;
                        default:
                            write = language["None"];
                            break;
                    }
                    doc.Add(new Paragraph(language["Aft"] + ": " + write));

                    if (inf.GetMessageForHome().Length > 0)
                    {
                        doc.Add(new Paragraph(language["MesH"]));
                        doc.Add(new Paragraph(inf.GetMessageForHome()));
                    }


                    if (inf.GetMessageForSchool().Length > 0)
                    {
                        doc.Add(new Paragraph(language["MesS"]));
                        doc.Add(new Paragraph(inf.GetMessageForSchool()));
                    }
                }

                doc.Close();

                AlreadyOk alr = new AlreadyOk(language["Suc"]);
                alr.Show();

            }catch(Exception IO)
            {
                Warning w = new Warning(language["W"]);
                w.Show();
            }
        }
        
    }
}
