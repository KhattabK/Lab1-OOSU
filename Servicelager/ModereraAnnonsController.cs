using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Servicelager
{
    public class ModereraAnnonsController
    {
        private Datalager datalager;

        public ModereraAnnonsController(Datalager datalager)
        {
            this.datalager = datalager;
        }

        // Admin ser alla annonser, oavsett status
        public List<Annons> HämtaAllaAnnonser()
        {
            return datalager.HämtaAnnonser();
        }

        // Tar bort en annons. Om annonsen är reserverad avbryts affären som hör till den
        public void TaBortAnnons(Annons annons)
        {
            foreach (Affär affär in datalager.Affärer)
            {
                if (affär.Annons == annons && affär.Status == AffärStatus.Reserverad)
                {
                    affär.Avbryt();
                }
            }

            datalager.TaBortAnnons(annons);
        }
    }
}