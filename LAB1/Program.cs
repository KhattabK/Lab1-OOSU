using System;
using System.Collections.Generic;
using Models;
using Servicelager;

namespace BookSwap
{

    internal class Program
    {
        static Student inloggadStudent;
        static ReserveraAnnonsController controller;


        //metod som skriver ut alla annonser som finns i listan
        // används för att inte behöva upprepa samma kod i case 1 och case 2
        // kanske borde flyttas någon annanstans
        static void VisaAnnonser(List<Annons> annonser)
        {
            foreach (Annons annons in annonser)
            {
                Console.WriteLine(annons.SkrivUt());
            }
        }
        static void Main(string[] args)
        {

            Datalager datalager = new Datalager();
            controller = new ReserveraAnnonsController(datalager);


            inloggadStudent = datalager.Studenter[2];

            bool kör = true;

            while (kör)
            {
                Console.Clear();
                Console.WriteLine("---Meny----");
                Console.WriteLine("1. Visa Tillgängliga annonser");
                Console.WriteLine("2. Reservera annons");
                Console.WriteLine("3. Avsluta");
                Console.WriteLine();

                Console.Write("Välj ett alternativ: ");


                if (int.TryParse(Console.ReadLine(), out int val))
                {

                    switch (val)
                    {

                        case 1:
                            VisaTillgängligaAnnonser();
                            break;

                        case 2:
                            AnnonsReservation();
                            break;

                        case 3:
                            // avslutar programmet
                            Console.WriteLine("Avslutar");
                            kör = false;
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("Ogiltigt val. Välj 1, 2 eller 3.");
                            Console.ReadKey();
                            break;
                    }
                }

            }
        }
        static void VisaTillgängligaAnnonser()
        {
            // visar alla tillgängliga annonser
          
            Console.WriteLine("Tillgängliga Annonser: ");

            List<Annons> tillgängliga = controller.ListaTillgängligaAnnonser();
          
            VisaAnnonser(tillgängliga);
            Console.ReadKey();
        }

        static void AnnonsReservation()
        {
            // visar alla tillgängliga annonser och läser in input (användarens val)
            Console.Clear();
            List<Annons> tillgängligaAnnonser = controller.ListaTillgängligaAnnonser();
            Console.WriteLine("---Välj Annons---");
            VisaAnnonser(tillgängligaAnnonser);
            Console.WriteLine();
            Console.Write("Ange ID för den annons du vill reservera: ");
            Console.WriteLine();

            // kontrollerar att inmatningen är en siffra 
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Ogiltigt val.");
                Console.ReadKey();
                return;
            }

            Annons valdAnnons = null;
            // hämtar annons
            foreach (Annons annons in tillgängligaAnnonser)
            {
                if (annons.Id == input)
                {
                    valdAnnons = annons;
                    break;
                }
            }

            if (valdAnnons == null)
            {
                Console.WriteLine("Det finns ingen tillgänglig annons med detta ID.");
                Console.ReadKey();
                return;
            }


            // true eller false returneras beroende på om reservationen lyckas, används för att skriva ut meddelande
            bool lyckadReservation = controller.ReserveraAnnons(valdAnnons, inloggadStudent);

            if (lyckadReservation)
            {
                Console.WriteLine("Annonsen är reserverad.");
            }
            else
            {
                Console.WriteLine("Annonsen kunde inte reserveras.");
            }
            Console.ReadKey();
        }

    }

}