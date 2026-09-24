using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Annons //bör troligtvis ändras till abstract class
    {
        public string Titel { get; private set; }
        private decimal Pris;
        private string Skick;
        private DateTime Publiceringsdatum;
        public string Status { get; private set; } // bör kanske göras till en enum

        private Student Säljare;
        private Kurs Kurs;

        public Annons(string titel, decimal pris, string skick,  DateTime publiceringsdatum, string status, Student säljare, Kurs kurs)
        {
            Titel=titel;
            Pris=pris;
            Skick=skick;
            Publiceringsdatum=publiceringsdatum;
            Status=status; // bör kanske göras till en enum
            Säljare = säljare;
            Kurs= kurs;

        }

        public void Reservera(Student köpare)
        {
            //Metod som sätter annonsens status till "Reserverad" & kopplar annonsen till studenten (köparen)
            Status = "Reserverad";
            //lägger till den "markerade" annonsen
            köpare.ReserveradeAnnonser.Add(this); 
        }

       
    }
}
