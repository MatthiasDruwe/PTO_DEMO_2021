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
            myFirstBook.Reader = "Matthias";

            char action;

            do
            {
                Console.WriteLine("Welk boek wil je lezen?");
                action = Console.ReadKey().KeyChar;
                switch (action)
                {
                    case '1':
                        books[0].StartReading();
                        break;
                    case '2':
                        books[1].StartReading();
                        break;
                }

            } while (action != 'x');
           
        }
    }
}
