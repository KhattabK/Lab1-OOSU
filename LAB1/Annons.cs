
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwap
{
    public abstract class Annons
    {
        //de har satts till protected för att kunna användas av SkrivUt() i subklasserna
        protected string Titel { get; private set; }
        protected decimal Pris { get; private set; }

        protected Skick Skick { get; private set; }
        protected Kurs Kurs { get; private set; }

        //private för att de ej är nödvändiga i SkrivUt()
        private DateTime Publiceringsdatum;
        public Student Säljare { get; private set; }

        //public eftersom den används i andra klasser
        public Status Status { get; private set; }

        public Annons(string titel, decimal pris, Skick skick, DateTime publiceringsdatum, Status status, Student säljare, Kurs kurs)
        {
            Titel = titel;
            Pris = pris;
            Skick = skick;
            Publiceringsdatum = publiceringsdatum;
            Status = status;
            Säljare = säljare;
            Kurs = kurs;

        }

        public bool Reservera(Student köpare)
        {
            //kontrollerar att statusen verkligen är TillSalu och returnerar antingen true eller false
            if (Status != Status.TillSalu)
            {
                return false;
            }

            //Sätter annonsens status till "Reserverad"
            Status = Status.Reserverad;

            //lägger till den "valda" annonsen i köparens "Reserverad" lista
            köpare.LäggTillReserveradAnnons(this);

            return true;
        }

        public virtual string SkrivUt()
        {
            return $"{Titel} - {Pris} kr - Skick: {Skick} - Kurs: {Kurs.Namn}";
        }


    }
}
