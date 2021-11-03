using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Graphics.DisplayHelper;
using static Graphics.CardArt;
using static Game.Game;

namespace Graphics
{

    class DisplayGameBoard
    {
        // Prints out the entire gameboard with updated cards.
        public static void ShowBoard()
        {

            // Each card stored in ComputerGameBoard and PlayerGameBoard gets stored in an array with room for 5 elements.
            DrawnCard[] computerDrawCards = PopulateComputerCardArray();

            DrawnCard[] playerDrawCards = PopulatePlayerCardArray();

            // Print background ASCII
            WriteLineColour(artCardTable, ConsoleColor.DarkGreen);

            // Prints the computer card graphics + value + pix
            PrintComputerSide(computerDrawCards);

            // Prints the player card graphics + value + pix
            PrintPlayerSide(playerDrawCards);

            Console.WriteLine();

            Console.WriteLine();

        }


        private static DrawnCard[] PopulatePlayerCardArray()
        {
            DrawnCard[] playerDrawCards = new DrawnCard[5];
            for (int i = 0; i < PlayerGameBoard.Count; i++)
            {
                playerDrawCards[i] = new(PlayerGameBoard[i]);
            }
            return playerDrawCards;
        }

        private static DrawnCard[] PopulateComputerCardArray()
        {
            DrawnCard[] computerDrawCards = new DrawnCard[5];
            for (int i = 0; i < ComputerGameBoard.Count; i++)
            {
                computerDrawCards[i] = new(ComputerGameBoard[i]);
            }
            return computerDrawCards;
        }



        private static void PrintPlayerSide(DrawnCard[] drawPlayerCards)
        {
            // Card width + 4 spaces increase for each card
            PrintPlayerCardSum(16); // Prints Player Card Value
            PrintPlayerPix(97, 21); // Prints player pix
            
            // If the array index is not null, prints the corresponding card at the chosen position.
            if (drawPlayerCards[0] != null)
                PrintCard(20, 18, drawPlayerCards[0].ConstructedCard);
            if (drawPlayerCards[1] != null)
                PrintCard(35, 18, drawPlayerCards[1].ConstructedCard);
            if (drawPlayerCards[2] != null)
                PrintCard(50, 18, drawPlayerCards[2].ConstructedCard);
            if (drawPlayerCards[3] != null)
                PrintCard(65, 18, drawPlayerCards[3].ConstructedCard);
            if (drawPlayerCards[4] != null)
                PrintCard(80, 18, drawPlayerCards[4].ConstructedCard);
        }

        private static void PrintComputerSide(DrawnCard[] drawComputerCards)
        {
            PrintComputerCardSum(5);
            PrintComputerPix(97, 10);
            
            if (drawComputerCards[0] != null)
                PrintCard(20, 7, drawComputerCards[0].ConstructedCard);
            if (drawComputerCards[1] != null)
                PrintCard(35, 7, drawComputerCards[1].ConstructedCard);
            if (drawComputerCards[2] != null)
                PrintCard(50, 7, drawComputerCards[2].ConstructedCard);
            if (drawComputerCards[3] != null)
                PrintCard(65, 7, drawComputerCards[3].ConstructedCard);
            if (drawComputerCards[4] != null)
                PrintCard(80, 7, drawComputerCards[4].ConstructedCard);
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



        private static void PrintPlayerPix(int posY, int posX)
        {
            
            Console.SetCursorPosition(posY, posX);
            Console.WriteLine($"[Your pix: {Player.Pix}  ]"); 
        }

        private static void PrintComputerPix(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            Console.WriteLine($"[Opponent pix: {Computer.Pix}  ]"); 
        }

        private static void PrintComputerCardSum(int posY)
        {

            Console.CursorTop = posY;
            CenterWriteLine($"[  Card Value: {Computer.CardSum}  ]"); 
        }
        private static void PrintPlayerCardSum(int posY)
        {
            Console.CursorTop = posY;
            CenterWriteLine($"[  Card Value: {Player.CardSum}  ]"); 
        }
        

    }
}
