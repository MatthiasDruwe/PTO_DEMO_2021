using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogs
{
    class Dog: Animal
    {
        internal void Bark()
        {
            Console.WriteLine("Woof Woof");
        }

        internal void Sit()
        {
            Console.WriteLine("I'm sitting");
        }

        internal override void MakeNoise()
        {
            Bark();
        }

        internal override void Eat()
        {
            Console.WriteLine("I'm eating dogfood");
        }
    }
}
