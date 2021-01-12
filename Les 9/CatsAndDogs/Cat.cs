using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogs
{
    class Cat: Animal
    {

        internal void Meow()
        {
            Console.WriteLine("Meow");
        }

        internal void CoughUpFurBalls()
        {
            Console.WriteLine("....");
        }

        internal override void MakeNoise()
        {
            Meow();
        }

        internal override void Eat()
        {
            Console.WriteLine("I'm eating catfood");
        }
    }
}
