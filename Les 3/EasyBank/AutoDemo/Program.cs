using System;
using System.Collections.Generic;

namespace AutoDemo
{
    class Program
    {
        private static List<Auto> alleAutos = new List<Auto>();

        static void Main(string[] args)
        {
            Auto mijnAuto = new Auto();
            mijnAuto.merk = "Ford";
            mijnAuto.model = "Focus";
            mijnAuto.bouwjaar = new DateTime(2010, 10, 1);
            mijnAuto.kleur = "Grijs";
            mijnAuto.aantalDeuren = 5;
            alleAutos.Add(mijnAuto);

            mijnAuto.RijdVoorwaarts();
            mijnAuto.RijdAchterwaarts();
            mijnAuto.Remmen();

            Auto tomZijnAuto = new Auto();
            tomZijnAuto.merk = "Opel";
            tomZijnAuto.model = "Corsa";
            tomZijnAuto.bouwjaar = new DateTime(2020, 10, 1);
            tomZijnAuto.kleur = "Groene";
            tomZijnAuto.aantalDeuren = 3;
            alleAutos.Add(tomZijnAuto);


            tomZijnAuto.RijdVoorwaarts();
            tomZijnAuto.RijdAchterwaarts();
            tomZijnAuto.Remmen();

            // printAlleAutos();

            Console.ReadKey();

        }


        static void printAlleAutos()
        {
            foreach (Auto auto in alleAutos)
            {
                printAuto(auto);
            }
        }

        static void printAuto(Auto auto)
        {
            Console.WriteLine($"Je rijdt met een {auto.merk} {auto.model}");
        }
    }
}
