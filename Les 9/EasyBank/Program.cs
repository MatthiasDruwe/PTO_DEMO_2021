using System;
using System.Collections.Generic;


/* Opdracht
 * 
 * Maak het mogelijk nieuwe rekeningen te maken
 * Maak het mogelijk een rekening te kiezen en hier acties op uit te voeren
 *  -Geld storten
 *  -Geld afhalen
 *  -saldo raadplegen
 *  Wisselen van rekening (aka terug naar het hoofdmenu gaan)
 *  
 *  BONUS: Hou transacties bij  ;-)
 */

namespace EasyBank
{
    class Program
    {

        private static List<Rekening> rekeningen = new List<Rekening>();

        static void Main(string[] args)
        {
            char keuze;

            do
            {
                Console.Clear();
                Console.WriteLine("#######################");
                Console.WriteLine("# Welkom bij de bank! #");
                Console.WriteLine("#######################");

                Console.WriteLine("a. Nieuwe rekening aanmaken.");
                Console.WriteLine("b. Rekening kiezen. ");
                Console.WriteLine("c. Overschrijven.");
                Console.WriteLine("d. Afsluiten");
                keuze = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToLower());
                Console.WriteLine();
                VoerActieUit(keuze);
            } while (keuze != 'd');

            Console.WriteLine(" Bedankt en tot ziens!");
            Console.ReadKey();
        }

        private static void VoerActieUit(char keuze)
        {
            if (keuze == 'a')
            {
                aanmakenRekening();
            }
            else if (keuze == 'b')
            {
                kiezenRekening();
            }
            else if (keuze == 'c')
            {
                geldStorten();
            }

        }

        private static void geldStorten()
        {
            Console.WriteLine("Kies een zender?");
            PrintRekeningen();
            int rekeningKeuze = Convert.ToInt32(Console.ReadLine());
            Rekening zender;
            if (rekeningKeuze > rekeningen.Count)
            {
                zender = rekeningen[rekeningKeuze - 1];
            }
            else
            {
                zender = rekeningen[rekeningKeuze - 1];
            }

            Console.WriteLine("Kies een ontvanger?");
            PrintRekeningen();
            rekeningKeuze = Convert.ToInt32(Console.ReadLine());
            Rekening ontvanger;
            if (rekeningKeuze > rekeningen.Count)
            {
                ontvanger = rekeningen[rekeningKeuze - 1];
            }
            else
            {
                ontvanger = rekeningen[rekeningKeuze - 1];
            }

            Console.WriteLine("Welk bedrag wil je verzenden?");
            double bedrag = Convert.ToDouble(Console.ReadLine());

            zender.OverschrijvenNaar(ontvanger, bedrag);
        }

        private static void PrintRekeningen()
        {

            int rekeningCounter = 0;
            Console.WriteLine("Rekeningen:");
            Console.WriteLine("----------------:");

            foreach (Rekening rekening in rekeningen)
            {
                rekeningCounter++;
                Console.WriteLine($"   {rekeningCounter}) {rekening.Print()}");
            }

        }

        private static void kiezenRekening()
        {
            Console.WriteLine("welke rekening wil je gebruiken? ");
            PrintRekeningen();
            //voor elke rekening een apparte variabele maken van saldo?

            int rekeningKeuze = Convert.ToInt32(Console.ReadLine());
            Rekening r = rekeningen[rekeningKeuze - 1];
            r.ToonMenu();
        }

        private static void aanmakenRekening()
        {
            Console.WriteLine("Welk type rekening wil je maken?");
            Console.WriteLine("a) zichtrekening");
            Console.WriteLine("b) spaarrekening");

            string rekeningType = Console.ReadLine();

            Console.WriteLine("Welke naam wil je de rekening geven?");
            string naam = Console.ReadLine();

            if (rekeningType == "a")
            {
                ZichtRekening nieuweRekening = new ZichtRekening(naam);
                rekeningen.Add(nieuweRekening);
            }
            else
            {
                SpaarRekening nieuweRekening = new SpaarRekening(naam);
                rekeningen.Add(nieuweRekening);
            }
        }
    }
}
