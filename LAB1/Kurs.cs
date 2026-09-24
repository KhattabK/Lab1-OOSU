using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Kurs
    {
        private string Kod;
        private string Namn;

        public Kurs (string kod, string namn)
        {
            Kod=kod;
            Namn=namn;
        }
    }
}
