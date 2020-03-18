using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaProject
{
    public class Dokuments
    {
        private String number;
        private int maxsumm;
        private DateTime datums;
        private List<Rinda> rinda;


        /// <summary>
        ///  Konstruktors: izpildās tad, kad tiek izveidots jauns dokuments
        ///  kā parametru padod maksimālo summu
        /// </summary>
        public Dokuments(int maxsum)
        {
            // aizpildam datumu
            this.datums = GetMonday();
            // izveidojam masīva rindu
            this.rinda = new List<Rinda>();
            // maksimālā summa
            this.maxsumm = maxsum;
        }

        public string Number { get => number; set => number = value; }
        public int Maxsumm { get => maxsumm; set => maxsumm = value; }
        public DateTime Datums { get => datums; set => datums = value; }
        public List<Rinda> Rinda { get => rinda; set => rinda = value; }

        /// <summary>
        /// funkcija, kas atgriež nedēļas pirmdienu
        /// </summary>
        /// <returns></returns>
        private static DateTime GetMonday()
        {
            DateTime timenow = DateTime.Now;
            if (timenow.DayOfWeek != DayOfWeek.Monday)
                return timenow.Subtract(new TimeSpan((int)timenow.DayOfWeek - 1, 0, 0, 0));

            return timenow;
        }

        /// <summary>
        /// Saskaita un atgriež dokumneta rindu kopējo summu
        /// </summary>
        /// <returns></returns>
        public int TotalDocumentSum() {
            int totalsumm = 0;
            foreach(Rinda r in this.rinda) {
                totalsumm = totalsumm + r.Summa;
            }

            return totalsumm;
        }
    }
}
