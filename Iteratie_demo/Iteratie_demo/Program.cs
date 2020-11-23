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
                ShowHeightOfPyramid();
            }
            else if (choice == "p")
            {
                ShowNumberOfLayers();
            }
            else
            {
                Console.WriteLine("Geen geldige keuze");
            }

            Console.ReadKey();
        }

        private static void ShowHeightOfPyramid()
        {
            Console.WriteLine("Hoe hoog wil je de piramide?");

            int height = Convert.ToInt32(Console.ReadLine());
            int numberOfBlocks = CalculateNumberOfBlocks(height);

            Console.WriteLine($"Je hebt {numberOfBlocks} blokken nodig voor een piramide van {height} hoog");
        }

        private static int CalculateNumberOfBlocks(int height)
        {
            int numberOfBlocks = 0;

            for (int i = 1; i <= height; i++)
            {
                int numberOfBlocksInLayer = i * i;
                numberOfBlocks = numberOfBlocks + numberOfBlocksInLayer;
            }

            return numberOfBlocks;
        }

        private static void ShowNumberOfLayers()
        {
            Console.WriteLine("Hoeveel blokken heb je te beschikking");
            int numberOfBlocks = Convert.ToInt32(Console.ReadLine());
            int layers = CalculateNumberOfLayers(numberOfBlocks);


            Console.WriteLine($"Je kan {layers} lagen maken met {numberOfBlocks} blokken. " +
                $"Je hebt nog {numberOfBlocks - CalculateNumberOfBlocks(layers)} blokken over");
        }

        private static int CalculateNumberOfLayers(int numberOfBlocks)
        {
            int remainingNumberBlocks = numberOfBlocks;
            int layer = 0;

            while (remainingNumberBlocks > 0)
            {
                layer++;
                int numberOfBlocksInLayer = layer * layer;

                if (remainingNumberBlocks < numberOfBlocksInLayer)
                {
                    layer--;
                }

                remainingNumberBlocks = remainingNumberBlocks - numberOfBlocksInLayer;
            }

            return layer;
        }
    }
}
