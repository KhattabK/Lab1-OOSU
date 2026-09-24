using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student
    {
        private string Förnamn;
        private string Efternamn;
        private string Epost;
        private string Telefonnummer;
        public List<Annons> ReserveradeAnnonser { get; private set; }

        public Student (string förnamn, string efternamn, string epost, string telefonnummer)
        {
            Förnamn = förnamn;
            Efternamn= efternamn;
            Epost = epost;
            Telefonnummer = telefonnummer;

            ReserveradeAnnonser = new List<Annons>();
        }
    }
}
