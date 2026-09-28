
using System;
using System.Collections.Generic;

namespace Bookswap
{
    
    internal class Program
    {

        //metod som skriver ut alla annonser som finns i listan
        // används för att inte behöva upprepa samma kod i case 1 och case 2
        // kanske borde flyttas någon annanstans
        static void VisaAnnonser(List<Annons> annonser)
        {
            int nummer = 1;
            foreach (Annons annons in annonser)
            {
                Console.WriteLine(nummer + "." + annons.SkrivUt());
                nummer = nummer + 1;
            }
        }
        static void Main(string[] args)
        {

            Datalager datalager = new Datalager();
            ReserveraAnnonsController controller = new ReserveraAnnonsController(datalager);


            Student inloggadStudent = datalager.Studenter[2];

            bool kör = true;

            while (kör)
            {
                Console.Clear();
                Console.WriteLine("---Meny----");
                Console.WriteLine("1. Visa Tillgängliga annonser");
                Console.WriteLine("2. Reservera annons");
                Console.WriteLine("0. Avsluta");
                Console.WriteLine();

                Console.Write("Välj ett alternativ: ");


                string val = Console.ReadLine();

                switch (val)
                {

                    case "1":
                        // visar alla tillgängliga annonser
                        Console.Clear();
                        Console.WriteLine("Tillgängliga Annonser: ");

                        List<Annons> tillgängliga = controller.ListaTillgängligaAnnonser();
                        VisaAnnonser(tillgängliga);
                        Console.ReadKey();

                        break;

                    case "2":
                        // visar alla tillgängliga annonser och läser in input (användarens val)
                        Console.Clear();
                        List<Annons> tillgängligaAnnonser = controller.ListaTillgängligaAnnonser();
                        Console.WriteLine("---Välj Annons---");
                        VisaAnnonser(tillgängligaAnnonser);
                        Console.WriteLine();
                        Console.Write("Ange siffran för den annons du vill reservera: ");
                        Console.WriteLine();

                        // saknas felhantering som kontrollerar att det är en siffra + att numret faktiskt finns i listan
                        int input = int.Parse(Console.ReadLine());

                        Annons valdAnnons = tillgängligaAnnonser[input - 1];

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
                        break;

                    case "0":
                        // avslutar programmet
                        Console.WriteLine("Avslutar");
                        kör = false;
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Välj 1, 2 eller 0.");
                        Console.ReadKey();
                        break;
                }

            }
        }
    }

}