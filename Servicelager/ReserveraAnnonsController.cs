using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Servicelager
{
    public class ReserveraAnnonsController
    {
        private Datalager Datalager;

        public ReserveraAnnonsController(Datalager datalager)
        {
            // När Controller-objektet skapas skickas ett befintligt Datalager in.
            // Referensen till detta Datalager sparas i attributet Datalager,

            this.Datalager = datalager;
        }

        //Metod som reserverar annonsen genom att anropa Reservera() och skicka med köparen
        // returnerar antingen true eller false, true om reserveringen lyckades och annars false
        //Om reserveringen lyckas skapas en Affär som sparas i Datalager
        public bool ReserveraAnnons(int annonsId, Student inloggadStudent)
        {
            //hämtar annonsen med annonsID
            Annons annons = Datalager.HämtaAnnons(annonsId);
            if (annons == null)
            {
                return false;
            }
            bool lyckades = annons.Reservera(inloggadStudent);

            if (lyckades)
            {
                Affär affär = new Affär(inloggadStudent, annons.Säljare, annons, DateTime.Now);
                Datalager.LäggTillAffär(affär);
            }

            return lyckades;
        }

        //Skapar en lista med endast annonser med status "TillSalu" och returnerar den
        public List<Annons> ListaTillgängligaAnnonser()
        {
            List<Annons> tillgängligaAnnonser = new List<Annons>();
            List<Annons> annonser = Datalager.HämtaAnnonser();

            foreach (Annons annons in annonser)
            {
                if (annons.Status == Status.TillSalu)
                {
                    tillgängligaAnnonser.Add(annons);
                }
            }
            return tillgängligaAnnonser;

        }

        public List<Annons> HämtaAllaAnnonser()
        {
            List<Annons>annonser=new List<Annons>();
            annonser = Datalager.HämtaAnnonser();
            return annonser;
        }

        //markerar annonsens status som Såld och affärens status som Genomförd
        public bool BekräftaKöp(Affär affär)
        {
            bool lyckades = affär.Annons.BekräftaKöp();

            if (!lyckades)
            {
                return false;
            }
            affär.Genomför();
            return true;
        }
    }
}