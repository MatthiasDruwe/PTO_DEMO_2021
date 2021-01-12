using System;
using System.Collections.Generic;

namespace EasyBank
{
    abstract class Rekening
    {
        // Private members
        List<double> verrichtingen = new List<double>();
        string naam;

        // Constructor 
        public Rekening(string naam)
        {
            this.naam = naam;
        }

        // Props
        protected List<double> Verrichtingen { get => verrichtingen; set => verrichtingen = value; }
        protected string Naam { get => naam; set => naam = value; }

        public abstract void ToonMenu();

        public virtual string Print()
        {
            return $"rekening {naam}: {BerekenTotaalSaldo()}";
        }

        protected void ToonVerrichtingen()
        {
            Console.WriteLine("Een lijst van verrichtingen");
        }

        protected void GeldStorten()
        {
            Console.WriteLine("Hoeveel wil je storten?");

            double bedrag = Convert.ToDouble(Console.ReadLine());
            bedrag = Math.Round(bedrag, 2);
            verrichtingen.Add(bedrag);

            Console.WriteLine("Storting OK: " + bedrag + " gestort op rekening " + naam);
            ToonSaldo();
        }

        protected void ToonSaldo()
        {
            Console.WriteLine($"Uw saldo bedraagt: {BerekenTotaalSaldo()}");
        }

        protected double BerekenTotaalSaldo()
        {
            double totaalSaldo = 0;

            foreach (double verrichting in verrichtingen)
            {
                totaalSaldo += verrichting;
            }

            return totaalSaldo;
        }

        public bool OverschrijvenNaar(Rekening rekening, double bedrag)
        {
            if(BerekenTotaalSaldo() < bedrag)
            {
                return false;
            }
            bedrag = Math.Round(bedrag, 2);
            verrichtingen.Add(-bedrag);

            rekening.GeldStorten(bedrag);
            return true;
        }

        public void GeldStorten(double bedrag)
        {
            verrichtingen.Add(bedrag);
        }
    }
}
