
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BookSwap
{
    public class DigitalResurs : Annons
    {
        private string Filformat;
        private string Leveranssätt;

        public DigitalResurs(string titel, decimal pris, Skick skick, DateTime publiceringsdatum, Status status, Student säljare, Kurs kurs, string filformat, string leveranssätt)
            : base(titel, pris, skick, publiceringsdatum, status, säljare, kurs)
        {
            Filformat = filformat;
            Leveranssätt = leveranssätt;
        }

        public override string SkrivUt()
        {
            return $"{Titel} - {Pris} kr - Skick: {Skick} - Kurs: {Kurs.Namn} - Filformat: {Filformat}";
        }
    }
}
