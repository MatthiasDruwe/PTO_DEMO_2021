using System;
using System.Collections.Generic;

namespace Boekenapplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myFirstBook = new Book("De Kleine Prins", "Blabla", 10);
            Book mySecondBook = new Book("Harry Potter", "Blabla", 10);

            List<Book> books = new List<Book>();
            books.Add(myFirstBook);
            books.Add(mySecondBook);

            Console.WriteLine($"Ik lees momenteel \"{myFirstBook.ToString()}\"");


            Console.WriteLine($"{myFirstBook.Reader} leest het boek");

            myFirstBook.Reader = "Matthias";

            Console.WriteLine($"{myFirstBook.Reader} leest het boek");


            while (true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.Clear();
                if (c == '1')
                {
                    Console.WriteLine(myFirstBook.NextPage());
                }
                else if (c == '2')
                {
                    Console.WriteLine(mySecondBook.NextPage());
                }
            }
        }
    }
}
