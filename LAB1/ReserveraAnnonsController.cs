

using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwap
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
        public bool ReserveraAnnons(Annons annons, Student köpare)
        {
            return annons.Reservera(köpare);
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
    }
}
