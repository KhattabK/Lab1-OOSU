using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Servicelager
{
    public class Datalager
    {
        public List<Student> Studenter { get; private set; }
        public List<Administratör> Administratörer { get; private set; }
        public List<Annons> Annonser { get; private set; }
        public List<Kurs> Kurser { get; private set; }
        public List<Affär> Affärer { get; private set; }

        public Datalager()
        {
            Studenter = new List<Student>();
            Administratörer = new List<Administratör>();
            Annonser = new List<Annons>();
            Kurser = new List<Kurs>();
            Affärer = new List<Affär>();

            // Exempeldata: studenter (användarnamn, lösenord, förnamn, efternamn, epost, telefon)
            Student student1 = new Student("anna", "anna123", "Anna", "Andersson", "anna@mail.com", "0701234567");
            Student student2 = new Student("erik", "erik123", "Erik", "Eriksson", "erik@mail.com", "0707654321");
            Student student3 = new Student("lisa", "lisa123", "Lisa", "Jonsson", "lisa@mail.com", "0724567890");
            Student student4 = new Student("oscar", "oscar123", "Oscar", "Lind","oscar@mail.com", "0731112233");
            Student student5 = new Student("emma", "emma123", "Emma", "Berg","emma@mail.com", "0734445566");

            Studenter.Add(student1);
            Studenter.Add(student2);
            Studenter.Add(student3);
            Studenter.Add(student4);
            Studenter.Add(student5); 

            // Exempeldata: administratör
            Administratör admin1 = new Administratör("admin", "admin123", "Sara", "Svensson", "admin@bookswap.se");
            Administratörer.Add(admin1);

            // Exempeldata: kurser
            Kurs kurs1 = new Kurs("DA1234", "Objektorienterad programmering");
            Kurs kurs2 = new Kurs("CA5678", "Databasteknik");
            Kurs kurs3 = new Kurs("DV2020", "Webbutveckling");
            Kurs kurs4 = new Kurs("MA1010", "Matematik");

            Kurser.Add(kurs1);
            Kurser.Add(kurs2);
            Kurser.Add(kurs3);
            Kurser.Add(kurs4);


            // Exempeldata: annonser
            #region Exempeldata Annonser
            Annons annons1 = new Kursbok(
                "C# från grunden",
                120,
                Skick.Slitet,
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
                2025);

            //reserverad annons
            Annons annons4 = new Kursbok(
                "Grunder i Databasteknik",
                120,
                Skick.Bra,
                new DateTime(2026, 10, 19),
                Status.Reserverad,
                student2,
                kurs2,
                 "918-9876567890",
                 "Sofia Svensson",
                 2
                );

            Annons annons5 = new Kompendium(
                "Databaskompendium",
                70, 
                Skick.Bra,
                new DateTime(2026, 10, 10), 
                Status.Reserverad,
                student3,
                kurs2, 
                85, 
                2025);

            Annons annons6 = new DigitalResurs(
                "Webbutveckling - övningar", 
                50, 
                Skick.Nyskick,
                new DateTime(2026, 10, 11),
                Status.Reserverad,
                student1, 
                kurs3, 
                "PDF", 
                "Nedladdningslänk");

            Annons annons7 = new Kursbok(
                "Diskret matematik", 
                150, 
                Skick.Bra,
                new DateTime(2026, 10, 12), 
                Status.Reserverad,
                student4, 
                kurs4,
                "978-1111111111", 
                "Karin Karlsson", 
                3);

            Annons annons8 = new Kompendium(
                "Webbprogrammering", 
                90, Skick.Nyskick,
                new DateTime(2026, 10, 13), 
                Status.Reserverad,
                student5, 
                kurs3, 
                100, 
                2026);

            Annons annons9 = new Kursbok(
                "Databaser i praktiken", 
                180, 
                Skick.Bra,
                new DateTime(2026, 10, 14), 
                Status.TillSalu,
                student3, 
                kurs2,
                "978-2222222222", 
                "Lars Larsson",
                1);

            Annons annons10 = new Kursbok(
                "Modern webbutveckling", 
                200, 
                Skick.Nyskick,
                new DateTime(2026, 10, 16), 
                Status.TillSalu,
                student5, 
                kurs3,
                "978-3333333333", 
                "Eva Eriksson", 
                1);


            Annonser.Add(annons1);
            Annonser.Add(annons2);
            Annonser.Add(annons3);
            Annonser.Add(annons4);
            Annonser.Add(annons5);
            Annonser.Add(annons6);
            Annonser.Add(annons7);
            Annonser.Add(annons8);
            Annonser.Add(annons9);
            Annonser.Add(annons10);

            #endregion 

            //Exempeldata: affärer
            #region Exempeldata Affärer
            Affär affär1 = new Affär(
                student1,
                student2,
                annons4,
                new DateTime(2026, 10, 19));

            Affär affär2 = new Affär(
                student2, 
                student3, 
                annons5,
                new DateTime(2026, 10, 19));

            Affär affär3 = new Affär(
                student3, 
                student1, 
                annons6,
                new DateTime(2026, 10, 19));

            Affär affär4 = new Affär(
                student5, 
                student4, 
                annons7,
                new DateTime(2026, 10, 19));

            Affär affär5 = new Affär(
                student2, 
                student5, 
                annons8,
                new DateTime(2026, 10, 20));

            Affärer.Add(affär1);
            Affärer.Add(affär2);
            Affärer.Add(affär3);
            Affärer.Add(affär4);
            Affärer.Add(affär5);
            #endregion 
        }

        // Hämtar och returnerar samtliga annonser i Annonser-listan
        public List<Annons> HämtaAnnonser()
        {
            return Annonser;
        }

        public List<Affär> HämtaAffärer()
        {
            return Affärer;
        }

        // Lägger till en ny affär i Affärer-listan
        public void LäggTillAffär(Affär affär)
        {
            Affärer.Add(affär);
        }

        

        // Lägger till en ny student i Studenter-listan
        public void LäggTillStudent(Student student)
        {
            Studenter.Add(student);
        }

        // Lägger till en ny annons i Annonser-listan
        public void LäggTillAnnons(Annons annons)
        {
            Annonser.Add(annons);
        }

        // Tar bort en annons, både från Annonser-listan 
        public void TaBortAnnons(Annons annons)
        {
            Annonser.Remove(annons);
            
        }

        //hämtar en annons enligt annonsID
        public Annons HämtaAnnons(int annonsId)
        {
            foreach (Annons annons in Annonser)
            {
                if (annons.Id == annonsId)
                {
                    return annons;
                }
            }

            return null;
        }

        // Lägger till en ny kurs i Kurser-listan
        public void LäggTillKurs(Kurs kurs)
        {
            Kurser.Add(kurs);
        }

        // Tar bort en kurs från Kurser-listan
        public void TaBortKurs(Kurs kurs)
        {
            Kurser.Remove(kurs);
        }
    }
}