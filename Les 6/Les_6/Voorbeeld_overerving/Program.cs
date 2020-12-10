using System;

namespace Voorbeeld_overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageMessage imageMessageWithArguments = new ImageMessage("demo", "demodemodemo", DateTime.Now, "demo", "demo");
            ImageMessage imageMessageWithoutArguments = new ImageMessage("demo");

            Message m = imageMessageWithArguments;

            if(m is ImageMessage)
            {
                ImageMessage im = (ImageMessage)m;
                Console.WriteLine("Correct");
            }

            switch (m)
            {
                case ImageMessage im:
                    Console.WriteLine(im.Receiver);
                    break;
                case Message im:
                    Console.WriteLine(im.Receiver);
                    break;
            }

            Console.WriteLine(imageMessageWithArguments);
            Console.ReadKey();
        }
    }
}
