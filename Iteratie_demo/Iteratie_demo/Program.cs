using System;

namespace Iteratie_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wil je bereken hoeveel (b)lokken je nodig hebt of hoe hoog je (p)iramide kan worden?");

            string choice = Console.ReadLine();

            if (choice == "b")
            {
                Console.WriteLine("Hoe hoog wil je de piramide");
                int height = Convert.ToInt32(Console.ReadLine());

                int numberOfBlocks = 0;

                for (int i = 1; i <= height; i++)
                {
                    int numberOfBlocksInLayer = i * i;
                    numberOfBlocks = numberOfBlocks + numberOfBlocksInLayer; 
                }

                Console.WriteLine($"Je hebt {numberOfBlocks} blokken nodig voor een piramide van {height} hoog");
            }
            else if (choice == "p")
            {
                Console.WriteLine("Hoeveel blokken heb je te beschikking");
                int numberOfBlocks = Convert.ToInt32(Console.ReadLine());
                int remainingNumberBlocks = numberOfBlocks;
                int remaining = 0;
                int layer = 0;

                while (remainingNumberBlocks > 0)
                {
                    layer++;
                    int numberOfBlocksInLayer = layer * layer;
                    
                    if (remainingNumberBlocks < numberOfBlocksInLayer)
                    {
                        layer--;
                        remaining = remainingNumberBlocks;
                    }

                    remainingNumberBlocks = remainingNumberBlocks - numberOfBlocksInLayer;
                }

                Console.WriteLine($"Je kan {layer} lagen maken met {numberOfBlocks} blokken. " +
                    $"Je hebt nog {remaining} blokken over");
            }
            else
            {
                Console.WriteLine("Geen geldige keuze");
            }

            Console.ReadKey();
        }
    }
}
