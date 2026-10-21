
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
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

        public override string VisaDetaljer()
        {
            return $"Titel: {Titel}\n" +
                   $"Pris: {Pris} kr\n" +
                   $"Skick: {Skick}\n" +
                   $"Kurs: {Kurs.Namn}\n" +
                   $"Status: {Status}\n" +
                   $"ISBN: {ISBN}\n" +
                   $"Författare: {Författare}\n"+
                   $"Upplaga: {Upplaga}";
        }
    }
}
