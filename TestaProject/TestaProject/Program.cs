using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Izveido jaunu dokumentu, parametrā ir max summa
            Dokuments doc = new Dokuments(100);

            // aizpildam ar datiem, līdz sasniedz max summu
            int skaititajs = 0;
            int totalsumm = 0;
            int newsumm;
            Rinda newrinda;
            Random r = new Random();
            bool isDone = false;
            do
            {
                skaititajs++;
                newsumm = r.Next(0, 10); // gadījuma skaitlis no 0 līdz 10
                newrinda = new Rinda();
                newrinda.Kods = "KODS" + skaititajs;
                newrinda.Summa = newsumm;

                totalsumm = totalsumm + newsumm;

                if (totalsumm > doc.Maxsumm)
                {
                    isDone = true;
                }
                else
                {
                    doc.Rinda.Add(newrinda);
                }
            } while (isDone == false);


            //izvadīšana
            Console.WriteLine("Dokumenta Nr:     " + doc.Number);
            Console.WriteLine("Dokumenta datums: " + doc.Datums);
            Console.WriteLine("Dokumenta max sum: " + doc.Maxsumm);
            Console.WriteLine("Dokumenta rindu skaits: " + doc.Rinda.Count());
            Console.WriteLine("Dokumenta kopējā summa: " + doc.TotalDocumentSum());

            Console.WriteLine("Dokumenta rindas");
            foreach (Rinda ri in doc.Rinda)
            {
                Console.WriteLine("Kods: " + ri.Kods + "   summa: " + ri.Summa);
            }
            Console.WriteLine("Nepievienotā rinda");
            Console.WriteLine("Kods: " + newrinda.Kods + "   summa: " + newrinda.Summa);

            Console.WriteLine("Summa tiktu pārsniegta par: " + ((doc.TotalDocumentSum() + newrinda.Summa) - doc.Maxsumm));
        }
    }
}
