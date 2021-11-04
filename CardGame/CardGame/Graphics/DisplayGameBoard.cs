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
            Console.CursorVisible = false;
            // Each card stored in ComputerGameBoard and PlayerGameBoard gets stored in an array with room for 5 elements. ComputerGameBoard/PlayerGameBoard does not need to contain precisely 5 cards anymore.
            DrawnCard[] computerDrawCards = PopulateComputerCardArray();
            DrawnCard[] playerDrawCards = PopulatePlayerCardArray();

            // Print background ASCII
            WriteLineColour(artCardTable, ConsoleColor.DarkGreen);

            // Prints the computer/player card graphics + value + pix. Requires an array of "DrawnCard" cards, which the method will draw on screen.
            PrintComputerSide(computerDrawCards);
            PrintPlayerSide(playerDrawCards);

            // Padding for the "press enter" button under the green game board.
            Console.WriteLine();
            Console.WriteLine();

        }

        // Each card currently in the list gets added to an array with room for 5 cards. Returns the populated array.
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
                //List<object> tempList = new(new object[5]);
                computerDrawCards[i] = new(ComputerGameBoard[i]);
            }
            return computerDrawCards;
        }

        private static void PrintPlayerSide(DrawnCard[] drawPlayerCards)
        {
            // Card width + 4 spaces increase for each card
            PrintPlayerCardSum(16); // Prints Player Card Value
            PrintPlayerPix(97, 21); // Prints player pix
            PrintPlayerPoints(97, 18); //Print player points

            // If the array index is not null, prints the corresponding card at the chosen position (if the array does not have anything in it at that position, nothing will be printed)
            if (drawPlayerCards[0] != null)
            {
                PrintCard(21, 18, drawPlayerCards[0].ConstructedCard);
            }
            if (drawPlayerCards[1] != null)
            {
                PrintCard(36, 18, drawPlayerCards[1].ConstructedCard);
            }
            if (drawPlayerCards[2] != null)
            {
                PrintCard(51, 18, drawPlayerCards[2].ConstructedCard);
            }
            if (drawPlayerCards[3] != null)
            {
                PrintCard(66, 18, drawPlayerCards[3].ConstructedCard);
            }
            if (drawPlayerCards[4] != null)
            {
                PrintCard(81, 18, drawPlayerCards[4].ConstructedCard);
            }
        }

        private static void PrintComputerSide(DrawnCard[] drawComputerCards)
        {
            PrintComputerCardSum(5);
            PrintComputerPix(97, 10);
            PrintComputerPoints(97, 7);

            if (drawComputerCards[0] != null)
            {
                PrintCard(21, 7, drawComputerCards[0].ConstructedCard);
            }
            if (drawComputerCards[1] != null)
            {
                PrintCard(36, 7, drawComputerCards[1].ConstructedCard);
            }
            if (drawComputerCards[2] != null)
            {
                PrintCard(51, 7, drawComputerCards[2].ConstructedCard);
            }
            if (drawComputerCards[3] != null)
            {
                PrintCard(66, 7, drawComputerCards[3].ConstructedCard);
            }
            if (drawComputerCards[4] != null)
            {
                PrintCard(81, 7, drawComputerCards[4].ConstructedCard);
            }
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
            WriteLineColour($"Your Pix:", ConsoleColor.DarkCyan);
            Console.SetCursorPosition(posY, posX + 1);
            WriteLineColour($"[{Player.Pix}]", ConsoleColor.Yellow);
        }

        private static void PrintComputerPix(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            WriteLineColour($"Opponent Pix:", ConsoleColor.Red);
            Console.SetCursorPosition(posY, posX + 1);
            WriteLineColour($"[{Computer.Pix}]", ConsoleColor.Yellow);
        }

        private static void PrintPlayerPoints(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            WriteLineColour($"Your Points:", ConsoleColor.DarkCyan);
            Console.SetCursorPosition(posY, posX + 1);
            WriteLineColour($"[{Player.Points}]", ConsoleColor.Yellow);
        }

        private static void PrintComputerPoints(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            WriteLineColour($"Opponent Points:", ConsoleColor.Red);
            Console.SetCursorPosition(posY, posX + 1);
            WriteLineColour($"[{Computer.Points}]", ConsoleColor.Yellow);
        }

        private static void PrintComputerCardSum(int posY)
        {
            Console.CursorTop = posY;
            CenterWriteLineColour($"[  Card Value: {Computer.CardSum}  ]", ConsoleColor.Red); 
        }
        private static void PrintPlayerCardSum(int posY)
        {
            Console.CursorTop = posY;
            CenterWriteLineColour($"[  Card Value: {Player.CardSum}  ]", ConsoleColor.DarkCyan); 
        }
    }
}
