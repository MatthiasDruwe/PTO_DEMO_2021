using System;
using System.Collections.Generic;

namespace Demo_swap_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create list with hardcoded data
            List<int> nummers = new List<int>();
            nummers.Add(1);
            nummers.Add(2);
            nummers.Add(3);
            nummers.Add(4);

            PrintList(nummers);


            // Swap 2 numbers
            int temp = nummers[1];
            nummers[1] = nummers[2];
            nummers[2] = temp;

            PrintList(nummers);

            // To top 
            temp = nummers[3];
            nummers.RemoveAt(3);
            nummers.Insert(0, temp);

            PrintList(nummers);

            Console.ReadKey();
        }

        private static void PrintList(List<int> nummers)
        {
            foreach (int nummer in nummers)
            {
                Console.WriteLine(nummer);
            }
            Console.WriteLine("------");
        }
    }
}
