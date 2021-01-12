using System;

namespace AccessModifiers
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
            demo.IkBenEenPrivateProtectedMethode();
            demo.IkBenEenProtectedInternalMethode();

        }

    }
}
