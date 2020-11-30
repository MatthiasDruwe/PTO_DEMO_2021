using System;

namespace AutoDemo
{
    class Auto
    {
        private string merk;
        private int aantalDeuren;
        private DateTime bouwjaar;
        private string model;
        private string kleur;

        public Auto(string merk, string model, DateTime bouwjaar, int aantalDeuren)
        {
            this.merk = merk;
            this.model = model;
            this.bouwjaar = bouwjaar;
            this.aantalDeuren = aantalDeuren;
        }

        public Auto()
        {
            merk = "default";
            model = "default";
            bouwjaar = DateTime.Today;
            aantalDeuren = 5;
        }
        public string Merk
        {
            get { return merk; }
        }

        public int AantalDeuren
        {
            get { return aantalDeuren; }
        }

        public DateTime Bouwjaar
        {
            get { return bouwjaar;}
        }

        public string Model
        {
            get { return model; }
        }

        public string Kleur
        {
            get { return kleur; }
            set { kleur = value; }
        }

       /* // SETTER
        public void SetKleur(string kleur)
        {
            this.kleur = kleur;
        }*/

        //// GETTERS
        //public string GetMerk()
        //{
        //    return merk;
        //}

        //public string GetModel()
        //{
        //    return merk;
        //}

        //public string GetKleur()
        //{
        //    return kleur;
        //}

        //public int GetAantalDeuren()
        //{
        //    return aantalDeuren;
        //}

        //public DateTime GetBouwjaar()
        //{
        //    return bouwjaar;
        //}



        // METHODS

        public void RijdVoorwaarts()
        {
            Console.WriteLine($"{merk} {model} Rijdt voorwaarts");
        }

        public void RijdAchterwaarts()
        {
            Console.WriteLine($"{merk} {model} Rijdt achterwaarts");
        }

        public void Remmen()
        {
            Console.WriteLine($"{merk} {model} remt!");
        }
    }
}
