
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Models
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

        public override string VisaDetaljer()
        {
            return $"Titel: {Titel}\n" +
                   $"Pris: {Pris} kr\n" +
                   $"Skick: {Skick}\n" +
                   $"Kurs: {Kurs.Namn}\n" +
                   $"Status: {Status}\n" +
                   $"Filformat: {Filformat}\n" +
                   $"Leveranssätt: {Leveranssätt}";
        }
    }
}
