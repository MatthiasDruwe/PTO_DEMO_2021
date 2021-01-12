using AccessModifiers;
using System;

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Demo demo = new Demo();

            demo.IkBenEenPrivateMethode();
            demo.IkBenEenPublicMethode();
            demo.IkBenEenProtectedMethode();
            demo.IkBenEenInternalMethode();
            demo.IkBenEenProtectedInternalMethode();

        }
    }
}
