using System;
using System.Collections.Generic;

namespace Models
{
    // Utkast 1
    internal class Program
    {
        static DataLager dataLager = new DataLager();
        

        public static void ReserveraAnnons(Student köpare, Annons annons)
        {
            annons.Reservera(köpare);
        }

        public static List<Annons> ListaAnnonser()
        {
            List<Annons> TillSalu = new List<Annons>();
            // Itererar över alla annonser och plockar ut de som är "Till salu"
            foreach (Annons annons in dataLager.annonser)
            {
                if (annons.Status == "Till salu")
                {
                    TillSalu.Add(annons);
                }
            }

            return TillSalu;
        }

        static void Main(string[] args)
        {
            // Testa ListaAnnonser - visar de annonser som hamnat i listan med "Till salu"
            List<Annons> annonser = ListaAnnonser();

            Student köpare = dataLager.studenter[1];

            Console.WriteLine("Ange siffra för den titel du vill reservera");
            for (int i = 0; i < annonser.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + annonser[i].Titel);
            }

            int val = int.Parse(Console.ReadLine());

            Annons valdAnnons = annonser[val - 1];

            ReserveraAnnons(köpare, valdAnnons);

            Console.WriteLine("Annonsen är nu reserverad.");
            Console.WriteLine("Ny status: " + valdAnnons.Status);
        }
    }

    // Exempeldata
    public class DataLager
    {
        public List<Annons> annonser = new List<Annons>();
        public List<Student> studenter = new List<Student>();
        public List<Kurs> kurser = new List<Kurs>();

        public DataLager()
        {
            // Studenter
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

            studenter.Add(student1);
            studenter.Add(student2);


            // Kurs
            Kurs kurs1 = new Kurs(
                "DA1234",
                "Objektorienterad programmering"
            );

            kurser.Add(kurs1);


            // Annonser
            Annons annons1 = new Annons(
                "Bok1",
                120,
                "Bra",
                new DateTime(2026, 9, 18),
                "Till salu",
                student1,
                kurs1
            );

            Annons annons2 = new Annons(
                "Bok2",
                200,
                "Okej",
                new DateTime(2026, 9, 18),
                "Reserverad",
                student2,
                kurs1
            );

            annonser.Add(annons1);
            annonser.Add(annons2);
        }
    }
}