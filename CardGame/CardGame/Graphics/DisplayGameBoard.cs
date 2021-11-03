using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Graphics
{

    class DisplayGameBoard
    {

        public static void ShowBoard()
        {

            CardBuilder fiveOfSpadesTest = new();

            WriteLineColour(artCardTable, ConsoleColor.DarkGreen);
            //Card width + 4 spaces increase for each card
            // Top row
            PrintTopCardCount(5);
            PrintComputerScore(97, 10);
            PrintCard(20, 7, fiveOfSpadesTest.ConstructedCard);     // Temp solution, meant to be more automated.
            PrintCard(35, 7, fiveOfSpadesTest.ConstructedCard);
            PrintCard(50, 7, fiveOfSpadesTest.ConstructedCard);
            PrintCard(65, 7, fiveOfSpadesTest.ConstructedCard);
            PrintCard(80, 7, fiveOfSpadesTest.ConstructedCard);
            // Bottom row
            PrintBottomCardCount(16);
            PrintPlayerScore(97, 21);
            PrintCard(20, 18, fiveOfSpadesTest.ConstructedCard);
            PrintCard(35, 18, fiveOfSpadesTest.ConstructedCard);
            PrintCard(50, 18, fiveOfSpadesTest.ConstructedCard);
            PrintCard(65, 18, fiveOfSpadesTest.ConstructedCard);
            PrintCard(80, 18, fiveOfSpadesTest.ConstructedCard);

            Console.WriteLine();

            Console.WriteLine();

            CenterWriteLine("Press [Enter] to get a card.");
        }



        private static void PrintCard(int posY, int posX, string[] card)
        {
            // Each card has 7 rows
            foreach (var cardRow in card)
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
