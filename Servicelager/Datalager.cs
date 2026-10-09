using System;
using System.Collections.Generic;
using System.Text;
using Models;
namespace Servicelager
{
    public class Datalager
    {
        public List<Student> Studenter { get; private set; }
        public List<Annons> Annonser { get; private set; }
        public List<Kurs> Kurser { get; private set; }
        public List<Affär> Affärer { get; private set; }

        public Datalager()
        {

            //Exempeldata
            Studenter = new List<Student>();
            Annonser = new List<Annons>();
            Kurser = new List<Kurs>();
            Affärer = new List<Affär>();


            Student student1 = new Student(
                "Anna",
                "Andersson",
                "anna@mail.com",
                "0701234567"
            );

            Student student2 = new Student(
                "Erik",
                "Eriksson",
                "erik@mail.com",
                "0707654321"
            );

            Student student3 = new Student(
                "Lisa",
                "Jonsson",
                "lisa@mail.com",
                "0724567890"
             );

            Studenter.Add(student1);
            Studenter.Add(student2);
            Studenter.Add(student3);



            Kurs kurs1 = new Kurs(
                "DA1234",
                "Objektorienterad programmering"
            );

            Kurser.Add(kurs1);



            Annons annons1 = new Kursbok(
                "Bok1",
                120,
                Skick.Bra,
                new DateTime(2026, 9, 18),
                Status.TillSalu,
                student1,
                kurs1,
                "978-1234567890",
                "Anders Andersson",
                2);

            Annons annons2 = new DigitalResurs(
                "Programmering online",
                80,
                Skick.Bra,
                new DateTime(2026, 9, 18),
                Status.TillSalu,
                student2,
                kurs1,
                "PDF",
                "E-post");

            Annons annons3 = new Kompendium(
                "Programmeringskompendium",
                100,
                Skick.Nyskick,
                new DateTime(2026, 9, 18),
                Status.TillSalu,
                student1,
                kurs1,
                120,
                2025
                );

            Annonser.Add(annons1);
            Annonser.Add(annons2);
            Annonser.Add(annons3);
        }

        //Hämtar och returnerar samtliga annonser i Annonser listan. 
        public List<Annons> HämtaAnnonser()
        {
            return Annonser;
        }

        //Lägger till en ny affär i Affärer listan.
        public void LäggTillAffär(Affär affär)
        {
            Affärer.Add(affär);
        }


    }
}