using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDemo
{
    class Auto
    {
        public String merk;
        public String kleur;
        public int aantalDeuren;
        public DateTime bouwjaar;
        public String model;

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
