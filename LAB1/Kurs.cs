using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwap
{
    public class Kurs
    {
        //public för att kunna används av SkrivUt()
        public string Kod { get; private set; }
        public string Namn { get; private set; }

        public Kurs(string kod, string namn)
        {
            Kod = kod;
            Namn = namn;
        }
    }
}
