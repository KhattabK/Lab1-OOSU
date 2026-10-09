
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;

namespace Models
{
    public class Kompendium : Annons
    {
        private int AntalSidor;
        private int UtgivningsÅr;

        public Kompendium(string titel, decimal pris, Skick skick, DateTime publiceringsdatum, Status status, Student säljare, Kurs kurs, int antalSidor, int utgivningsÅr)
            : base(titel, pris, skick, publiceringsdatum, status, säljare, kurs)
        {
            AntalSidor = antalSidor;
            UtgivningsÅr = utgivningsÅr;
        }
        public override string SkrivUt()
        {
            return $"ID {Id}: {Titel} - {Pris} kr - Skick: {Skick}  - Antal sidor: {AntalSidor}";
        }
    }
}
