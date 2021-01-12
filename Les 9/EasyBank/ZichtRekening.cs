using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBank
{
    class ZichtRekening: Rekening
    {

        public ZichtRekening(string naam):base(naam)
        {

        }

        public override void ToonMenu()
        {
            char keuze;
            do
            {
               
                Console.Clear();
                Console.WriteLine("ZICHTREKENING: " + Naam);
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
            }
            else if (keuze == 'd')
            {
                ToonVerrichtingen();
            }
        }

        private void GeldAfhalen()
        {

            Console.WriteLine("Hoeveel wil je afhalen?");
            double bedrag = Convert.ToDouble(Console.ReadLine());
            bedrag = Math.Round(bedrag, 2);

            if (bedrag > BerekenTotaalSaldo())
            {
                Console.WriteLine("Saldo ontoereikend op rekening " + Naam);
            }
            else
            {
                Verrichtingen.Add(-bedrag);
                Console.WriteLine("afhaling OK: " + bedrag + " afgehaald van rekening " + Naam);
                ToonSaldo();
            }
        }

    }
}
