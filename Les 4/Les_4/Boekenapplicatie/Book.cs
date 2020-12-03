using System;

namespace Boekenapplicatie
{
    class Book
    {
        // Private members / class attributes / class variables
        private string title;
        private string author;
        private int totalNumberOfPages;
        private int currentPageReading;
        private string reader;


        // Constructor 
        public Book(string title, string author, int totalNumberOfPages)
        {
            this.title = title;
            this.author = author;
            this.totalNumberOfPages = totalNumberOfPages;
            this.currentPageReading = 0;
        }


        public Book(string title, string author, int totalNumberOfPages, string reader)
        {
            this.title = title;
            this.author = author;
            this.totalNumberOfPages = totalNumberOfPages;
            this.currentPageReading = 0;
            this.reader = reader;
        }

        // Properties / getters & setters

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        public int TotalNumberOfPages
        {
            get { return totalNumberOfPages; }
        }

        public string Reader
        {
            get { return reader; }
            set { reader = value; }
        }

 


        // Methodes (public & private)
        public string NextPage()
        {
            if (currentPageReading < totalNumberOfPages)
            {
                currentPageReading++;
                return $"Pagina {currentPageReading} van de {totalNumberOfPages} in het boek {title}";
            }

            return "Einde van het boek!";
        }

        public void StartReading()
        {
            do
            {
                Console.WriteLine(NextPage());
            } while (Console.ReadKey().KeyChar != 'x');
            
        }

        public string ToString()
        {
            return $"{title} - {author}"; 
        }

    }
}
