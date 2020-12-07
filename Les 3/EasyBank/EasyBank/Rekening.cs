using System;
using System.Collections.Generic;

namespace EasyBank
{
    class Rekening
    {
        // Private members
        List<double> verrichtingen = new List<double>();
        string naam;

        // Constructor 
        public Rekening(string naam)
        {
            this.naam = naam;
        }

        public void ToonMenu()
        {
            char keuze;
            do
            {
                Console.Clear();
                Console.WriteLine("a. Afhalen.");
                Console.WriteLine("b. Storten.");
                Console.WriteLine("c. Check saldo.");
                Console.WriteLine("d. Bekijk laatste 10 verrichtingen");
                Console.WriteLine("e. Terug naar hoofdmenu.");

                keuze = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToLower());
                Console.WriteLine();

                VoerActieUit(keuze);
                Console.ReadKey();
            } while (keuze != 'e');
        }

        public string Print()
        {
            return $"rekening {naam}: {BerekenTotaalSaldo()}";
        }

        private void VoerActieUit(char keuze)
        {
            if (keuze == 'a')
            {
                GeldAfhalen();
            }
            else if (keuze == 'b')
            {
                GeldStorten();
            }
            else if (keuze == 'c')
            {
                ToonSaldo();
            } else if (keuze == 'd')
            {
                ToonVerrichting();
            }
        }

        private void ToonVerrichting()
        {
            Console.WriteLine("Een lijst van verrichtingen");
        }

        private void GeldAfhalen()
        {

            Console.WriteLine("Hoeveel wil je afhalen?");
            double bedrag = Convert.ToDouble(Console.ReadLine());
            bedrag = Math.Round(bedrag, 2);

            if (bedrag > BerekenTotaalSaldo())
            {
                Console.WriteLine("Saldo ontoereikend op rekening " + naam);
            }
            else
            {
                verrichtingen.Add(-bedrag);
                Console.WriteLine("afhaling OK: " + bedrag + " afgehaald van rekening " + naam);
                ToonSaldo();
            }
        }

        private void GeldStorten()
        {
            Console.WriteLine("Hoeveel wil je storten?");

            double bedrag = Convert.ToDouble(Console.ReadLine());
            bedrag = Math.Round(bedrag, 2);
            verrichtingen.Add(bedrag);

            Console.WriteLine("Storting OK: " + bedrag + " gestort op rekening " + naam);
            ToonSaldo();
        }

        private void ToonSaldo()
        {
            Console.WriteLine($"Uw saldo bedraagt: {BerekenTotaalSaldo()}");
        }

        private double BerekenTotaalSaldo()
        {
            double totaalSaldo = 0;

            foreach (double verrichting in verrichtingen)
            {
                totaalSaldo += verrichting;
            }

            return totaalSaldo;
        }
    }
}
