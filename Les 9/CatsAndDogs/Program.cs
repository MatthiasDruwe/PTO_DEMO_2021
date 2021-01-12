using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Animal animal1 = new Cat();
            animal1.MakeNoise();
            animal1.Eat();

            Animal animal2 = new Dog();
            animal2.MakeNoise();
            animal2.Eat();

            Console.ReadKey();
        }
    }
}
