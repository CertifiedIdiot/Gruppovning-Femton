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
            DrawnCard datorCard1, datorCard2, datorCard3, datorCard4, datorCard5;
            GetComputerCards(out datorCard1, out datorCard2, out datorCard3, out datorCard4, out datorCard5);
            DrawnCard playerCard1, playerCard2, playerCard3, playerCard4, playerCard5;
            GetPlayerCards(out playerCard1, out playerCard2, out playerCard3, out playerCard4, out playerCard5);

            // Print background ASCII
            WriteLineColour(artCardTable, ConsoleColor.DarkGreen);
            // Prints the computer card graphics + value + pix
            PrintComputerSide(datorCard1, datorCard2, datorCard3, datorCard4, datorCard5);
            // Prints the player card graphics + value + pix
            PrintPlayerSide(playerCard1, playerCard2, playerCard3, playerCard4, playerCard5);

            Console.WriteLine();

            Console.WriteLine();

        }




        // Refactored mess.
        private static void GetPlayerCards(out DrawnCard playerCard1, out DrawnCard playerCard2, out DrawnCard playerCard3, out DrawnCard playerCard4, out DrawnCard playerCard5)
        {
            playerCard1 = new(PlayerGameBoard[0]);
            playerCard2 = new(PlayerGameBoard[1]);
            playerCard3 = new(PlayerGameBoard[2]);
            playerCard4 = new(PlayerGameBoard[3]);
            playerCard5 = new(PlayerGameBoard[4]);
        }

        private static void GetComputerCards(out DrawnCard datorCard1, out DrawnCard datorCard2, out DrawnCard datorCard3, out DrawnCard datorCard4, out DrawnCard datorCard5)
        {
            datorCard1 = new(ComputerGameBoard[0]);
            datorCard2 = new(ComputerGameBoard[1]);
            datorCard3 = new(ComputerGameBoard[2]);
            datorCard4 = new(ComputerGameBoard[3]);
            datorCard5 = new(ComputerGameBoard[4]);
        }



        private static void PrintPlayerSide(DrawnCard playerCard1, DrawnCard playerCard2, DrawnCard playerCard3, DrawnCard playerCard4, DrawnCard playerCard5)
        {
            PrintPlayerCards(16);
            PrintPlayerPix(97, 21);
            // Card width + 4 spaces increase for each card
            PrintCard(20, 18, playerCard1.ConstructedCard);
            PrintCard(35, 18, playerCard2.ConstructedCard);
            PrintCard(50, 18, playerCard3.ConstructedCard);
            PrintCard(65, 18, playerCard4.ConstructedCard);
            PrintCard(80, 18, playerCard5.ConstructedCard);
        }

        private static void PrintComputerSide(DrawnCard datorCard1, DrawnCard datorCard2, DrawnCard datorCard3, DrawnCard datorCard4, DrawnCard datorCard5)
        {
            PrintComputerCards(5);
            PrintComputerPix(97, 10);
            // Card width + 4 spaces increase for each card
            PrintCard(20, 7, datorCard1.ConstructedCard);
            PrintCard(35, 7, datorCard2.ConstructedCard);
            PrintCard(50, 7, datorCard3.ConstructedCard);
            PrintCard(65, 7, datorCard4.ConstructedCard);
            PrintCard(80, 7, datorCard5.ConstructedCard);
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

        private static void PrintComputerCards(int posY)
        {

            Console.CursorTop = posY;
            CenterWriteLine($"[  Card Value: {Computer.CardSum}  ]"); 
        }
        private static void PrintPlayerCards(int posY)
        {
            Console.CursorTop = posY;
            CenterWriteLine($"[  Card Value: {Player.CardSum}  ]"); 
        }
        

    }
}
