using System;


namespace EasyBank
{
    class Program
    {
        private static double saldo = 500.00; 

        static void Main(string[] args)
        {
            char keuze;
            do
            {
                Console.WriteLine("Welkom bij de bank!");
                Console.WriteLine("a. Afhalen.");
                Console.WriteLine("b. Storten.");
                Console.WriteLine("c. Check saldo.");
                Console.WriteLine("d. Afsluiten");
                keuze = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToLower());
                Console.WriteLine();
                keuzeMenu(keuze);
            }
            while (keuze != 'd');
            Console.WriteLine(" Bedankt en tot ziens!");
            Console.ReadKey();
        }

        private static void keuzeMenu(char keuze)
        {
            if (keuze == 'a')
            {
                geldAfhalen();
            }
            else if (keuze == 'b')
            {
                geldStorten();
            }
            else if (keuze == 'c')
            {
                toonSaldo();
            }
        }

        private static void geldAfhalen()
        {

            Console.WriteLine("Hoeveel wil je afhalen?");
            double bedrag = Convert.ToDouble(Console.ReadLine());
            bedrag = Math.Round(bedrag, 2);

            if (bedrag > saldo)
            {
                Console.WriteLine("Saldo ontoereikend.");
            }
            else
            {
                saldo -= bedrag;
                Console.WriteLine("afhaling OK: " + bedrag + " afgehaald");
                toonSaldo();
            }
        }
        private static void geldStorten()
        {
            Console.WriteLine("Hoeveel wil je storten?");
            
            double bedrag = Convert.ToDouble(Console.ReadLine());
            bedrag = Math.Round(bedrag, 2);
            saldo += bedrag;

            Console.WriteLine("Storting OK: " + bedrag + " gestort");
            toonSaldo();
        }

        private static void toonSaldo()
        {
            Console.WriteLine("Uw saldo bedraagt: " + Math.Round(saldo, 2));
        }

    }
}
