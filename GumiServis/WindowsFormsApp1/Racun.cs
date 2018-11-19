using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Racun
    {
        public UslugaProdaja Usluga { get; set; }
        public int Kolicina { get; set; }

        public double Cijena
        {
            get; set;
        }

        public void unesiCijenu(bool popust)
        {
            if (popust)
            {
                Cijena = Kolicina * Usluga.Jed_cijena * 0.2;
            }
            else
            {
                Cijena = Kolicina * Usluga.Jed_cijena;
            }
        }
    }
}