using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Kurs
    {
        //public get så att andra klasser kan läsa kod och namn, private set så att de bara ändras via Ändra()
        public string Kod { get; private set; }
        public string Namn { get; private set; }

        public Kurs(string kod, string namn)
        {
            Kod = kod;
            Namn = namn;
        }

        public void Ändra(string kod, string namn)
        {
            Kod = kod;
            Namn = namn;
        }
    }
}
