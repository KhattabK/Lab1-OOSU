using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Servicelager
{
    public class KursController
    {
        private Datalager datalager;

        public KursController(Datalager datalager)
        {
            this.datalager = datalager;
        }

        // Returnerar alla kurser som finns i datalagret
        public List<Kurs> HämtaKurser()
        {
            return datalager.Kurser;
        }

        // Skapar en ny kurs. Returnerar false om något fält är tomt eller om kurskoden redan finns
        public bool LäggTillKurs(string kod, string namn)
        {
            if (string.IsNullOrWhiteSpace(kod) || string.IsNullOrWhiteSpace(namn))
            {
                return false;
            }

            if (ÄrKodUpptagen(kod))
            {
                return false;
            }

            Kurs nyKurs = new Kurs(kod, namn);
            datalager.LäggTillKurs(nyKurs);
            return true;
        }

        // Ändrar en befintlig kurs. Kontrollerar bara koden om den faktiskt har ändrats
        public bool ÄndraKurs(Kurs kurs, string kod, string namn)
        {
            if (string.IsNullOrWhiteSpace(kod) || string.IsNullOrWhiteSpace(namn))
            {
                return false;
            }

            if (kod != kurs.Kod && ÄrKodUpptagen(kod))
            {
                return false;
            }

            kurs.Ändra(kod, namn);
            return true;
        }

        // Tar bort en kurs. Går inte om någon annons är kopplad till kursen
        public bool TaBortKurs(Kurs kurs)
        {
            foreach (Annons annons in datalager.Annonser)
            {
                if (annons.Kurs == kurs)
                {
                    return false;
                }
            }

            datalager.TaBortKurs(kurs);
            return true;
        }

        private bool ÄrKodUpptagen(string kod)
        {
            foreach (Kurs kurs in datalager.Kurser)
            {
                if (kurs.Kod == kod)
                {
                    return true;
                }
            }
            return false;
        }
    }
}