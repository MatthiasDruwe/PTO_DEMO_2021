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
            Console.WriteLine("#######################");
            Console.WriteLine("# Welkom bij de bank! #");
            Console.WriteLine("#######################");

            char keuze;

            do
            {
                Console.WriteLine("a. Nieuwe rekening aanmaken.");
                Console.WriteLine("b. Rekening kiezen. ");
                Console.WriteLine("c. Afsluiten");
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
                Rekening rekening = kiezenRekening();
                rekening.ToonMenu();
            }

        }

        private static Rekening kiezenRekening()
        {
            //voor elke rekening een apparte variabele maken van saldo?
            Console.WriteLine("welke rekening wil je gebruiken? ");

            int rekeningCounter = 0;
            foreach (Rekening rekening in rekeningen)
            {
                rekeningCounter++;
                Console.WriteLine( $"{rekeningCounter}) {rekening.Print()}");
            }
            int rekeningKeuze = Convert.ToInt32(Console.ReadLine());

            return rekeningen[rekeningKeuze-1];

        }

        private static void aanmakenRekening()
        {
            Console.WriteLine("Welke naam wil je de rekening geven?");
            string naam = Console.ReadLine();

            Rekening nieweRekening = new Rekening(naam);
            rekeningen.Add(nieweRekening);
        }
    }
}
