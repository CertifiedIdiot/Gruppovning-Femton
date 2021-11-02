using System;
using testcard.ArtAssets;
using static testcard.ArtAssets.CardBuilder;
using static testcard.DisplayHelper;
using static testcard.CardArt;

namespace testcard
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLineColour(artCardTable, ConsoleColor.DarkGreen);
            //Card width + 4 spaces increase for each card
            // Top row
            PrintTopCardCount(5);
            PrintComputerScore(97, 10);
            PrintCard(20, 7);
            PrintCard(35, 7);
            PrintCard(50, 7);
            PrintCard(65, 7);
            PrintCard(80, 7);
            // Bottom row
            PrintBottomCardCount(16);
            PrintPlayerScore(97, 21);
            PrintCard(20, 18);
            PrintCard(35, 18);
            PrintCard(50, 18);
            PrintCard(65, 18);
            PrintCard(80, 18);

            Console.WriteLine();
            Console.WriteLine();
            CenterWriteLine("Press [Enter] to get a card.");
        }

        private static void PrintCard(int posY, int posX)
        {
            // Each card has 7 rows
            foreach (var cardRow in cardArray)
            {
                Console.SetCursorPosition(posY, posX++);
                Console.WriteLine(cardRow);
            }
        }

        private static void PrintPlayerScore(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            Console.WriteLine($"[Your pix: 200  ]");
        }
        private static void PrintComputerScore(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            Console.WriteLine($"[Opponent pix: 700  ]");
        }

        private static void PrintTopCardCount(int posY)
        {

            Console.CursorTop = posY;
            CenterWriteLine("[  Card Value: 10  ]");
        }
        private static void PrintBottomCardCount(int posY)
        {
            Console.CursorTop = posY;
            CenterWriteLine("[  Card Value: 10  ]");
        }
    }
}
