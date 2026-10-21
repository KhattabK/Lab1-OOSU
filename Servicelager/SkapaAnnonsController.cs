using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicelager
{
    public class SkapaAnnonsController
    {
        private Datalager datalager;

        public SkapaAnnonsController(Datalager datalager)
        {
            this.datalager = datalager;
        }

        public void SkapaKompendium(string titel, decimal pris, Skick skick, Student säljare, Kurs kurs,int antalSidor, int utgivningsÅr)
        {
            Kompendium annons = new Kompendium(
                titel, pris, skick, DateTime.Now,
                Status.TillSalu, säljare, kurs,
                antalSidor, utgivningsÅr);

            datalager.LäggTillAnnons(annons);
        }

        public void SkapaDigitalResurs( string titel, decimal pris, Skick skick, Student säljare, Kurs kurs, string filformat, string leveranssätt)
        {
            DigitalResurs annons = new DigitalResurs(
                titel, pris, skick, DateTime.Now,
                Status.TillSalu, säljare, kurs,
                filformat, leveranssätt);

            datalager.LäggTillAnnons(annons);
        }


        public void SkapaKursbok( string titel, decimal pris, Skick skick,Student säljare, Kurs kurs, string isbn,string författare, int upplaga)
        {
            Kursbok annons = new Kursbok(
                titel, pris, skick, DateTime.Now,
                Status.TillSalu, säljare, kurs,
                isbn, författare, upplaga);

            datalager.LäggTillAnnons(annons);
        }
    }
}
