
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwap
{
    public class Kursbok : Annons
    {
        private string ISBN;
        private string Författare;
        private int Upplaga;

        public Kursbok(string titel, decimal pris, Skick skick, DateTime publiceringsdatum, Status status, Student säljare, Kurs kurs, string isbn, string författare, int upplaga)
            : base(titel, pris, skick, publiceringsdatum, status, säljare, kurs)
        {
            ISBN = isbn;
            Författare = författare;
            Upplaga = upplaga;
        }

        public override string SkrivUt()
        {
            return $"{Titel} - {Pris} kr - Skick: {Skick} Kurs: {Kurs.Namn} - Författare: {Författare}";
        }
    }
}
