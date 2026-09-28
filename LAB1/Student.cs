
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwap
{
    public class Student
    {
        private string Förnamn;
        private string Efternamn;
        private string Epost;
        private string Telefonnummer;
        public List<Annons> ReserveradeAnnonser { get; private set; }

        public Student(string förnamn, string efternamn, string epost, string telefonnummer)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Epost = epost;
            Telefonnummer = telefonnummer;

            ReserveradeAnnonser = new List<Annons>();
        }

        //lägger till den Reserverade annonsen i studentens(köparens) ReserveradeAnnonser lista
        //där sparas de tills affären är helt genomförd. 
        public void LäggTillReserveradAnnons(Annons annons)
        {
            ReserveradeAnnonser.Add(annons);
        }
    }
}
