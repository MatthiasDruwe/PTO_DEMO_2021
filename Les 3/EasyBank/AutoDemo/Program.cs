using System;
using System.Collections.Generic;

namespace AutoDemo
{
    class Program
    {
        private static List<Auto> alleAutos = new List<Auto>();

        static void Main(string[] args)
        {
            Auto mijnAuto = new Auto("Ford", "Focus", new DateTime(2010, 10, 1), 5);
            //alleAutos.Add(mijnAuto);
            mijnAuto.Kleur = "groen";

            mijnAuto = null;
            mijnAuto.RijdVoorwaarts();
            mijnAuto.RijdAchterwaarts();
            mijnAuto.Remmen();

            Auto tomZijnAuto = new Auto();
    
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
                // printAuto(auto);
            }
        }

/*        static void printAuto(Auto auto)
        {
            Console.WriteLine($"Je rijdt met een {auto.merk} {auto.model}");
        }*/
    }
}
