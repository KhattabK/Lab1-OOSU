using System;

namespace Models
{
    public class Affär
    {
        public DateTime Reservationsdatum { get; private set; }
        public AffärStatus Status { get; private set; }
        public Student Köpare { get; private set; }
        public Student Säljare { get; private set; }
        public Annons Annons { get; private set; }

        public Affär(Student köpare, Student säljare, Annons annons, DateTime reservationsdatum)
        {
            Köpare = köpare;
            Säljare = säljare;
            Annons = annons;
            Reservationsdatum = reservationsdatum;
            Status = AffärStatus.Reserverad;
        }

        public void Genomför()
        {
            Status = AffärStatus.Genomförd;
        }
    }
}