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
        
        private static List<double> rekeningen = new List<double>();
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de bank!");
            char keuze;
            do
            {
                Console.WriteLine("a. Nieuwe rekening aanmaken.");
                Console.WriteLine("b. Rekening kiezen. ");
                Console.WriteLine("d. Afsluiten");
                keuze = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToLower());
                Console.WriteLine();
                keuzeMenu1(keuze);
            }
            while (keuze != 'd');
            Console.WriteLine(" Bedankt en tot ziens!");
            Console.ReadKey();
        }

        private static void keuzeMenu1 (char keuze)
        {
            if (keuze == 'a')
            {
                aanmakenRekening();
            }
            else if (keuze == 'b')
            {
                int rekening = kiezenRekening();
                bankMenu(rekening);
            }

        }
  
        private static int kiezenRekening()
        {
            //voor elke rekening een apparte variabele maken van saldo?
            Console.WriteLine("welke rekening wil je gebruiken? ");

            int rekeningCounter = 0;
            foreach (double rekening in rekeningen)
            {
                rekeningCounter++;
                Console.WriteLine("-Rekening " + rekeningCounter + " met saldo: " + rekening);
            }
            int rekeningKeuze = Convert.ToInt32(Console.ReadLine());
            return rekeningKeuze;

        }

        private static void aanmakenRekening()
        {
            rekeningen.Add(0);
        }

        private static void bankMenu(int rekening)
        {
            char keuze;
            do
            {
                Console.WriteLine("a. Afhalen.");
                Console.WriteLine("b. Storten.");
                Console.WriteLine("c. Check saldo.");
                Console.WriteLine("d. Terug naar hoofdmenu.");
                keuze = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToLower());
                Console.WriteLine();
                keuzeMenu2(keuze, rekening);
            }
            while (keuze != 'd');
        }

        private static void keuzeMenu2(char keuze, int rekening)
        {
            if (keuze == 'a')
            {
                geldAfhalen(rekening);
            }
            else if (keuze == 'b')
            {
                geldStorten(rekening);
            }
            else if (keuze == 'c')
            {
                toonSaldo(rekening);
            }
        }

        private static void geldAfhalen(int rekening)
        {

            Console.WriteLine("Hoeveel wil je afhalen?");
            double bedrag = Convert.ToDouble(Console.ReadLine());
            bedrag = Math.Round(bedrag, 2);

            if (bedrag > rekeningen[rekening])
            {
                Console.WriteLine("Saldo ontoereikend op rekening " + rekening);
            }
            else
            {
                rekeningen[rekening] -= bedrag;
                Console.WriteLine("afhaling OK: " + bedrag + " afgehaald van rekening " + rekening);
                toonSaldo(rekening);
            }
        }
        private static void geldStorten(int rekening)
        {
            Console.WriteLine("Hoeveel wil je storten?");
            
            double bedrag = Convert.ToDouble(Console.ReadLine());
            bedrag = Math.Round(bedrag, 2);
            rekeningen[rekening] += bedrag;

            Console.WriteLine("Storting OK: " + bedrag + " gestort op rekening " + rekening);
            toonSaldo(rekening);
        }

        private static void toonSaldo(int rekening)
        {
            Console.WriteLine($"Uw saldo bedraagt: {rekeningen[rekening]:c}");
        }
    }
}
