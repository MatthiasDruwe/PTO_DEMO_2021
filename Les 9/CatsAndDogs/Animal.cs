using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogs
{
    abstract class Animal
    {
        double height;
        double weight;
        double length;
        Color[] colors;

        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Length { get => length; set => length = value; }
        public Color[] Colors { get => colors; set => colors = value; }

        internal void Sleep()
        {
            Console.WriteLine("I'm sleeping");
        }

        abstract internal void MakeNoise();
        abstract internal void Eat();
    }
}
