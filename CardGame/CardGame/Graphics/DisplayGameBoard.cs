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
       
        public static void ShowBoard()
        {

            
            DrawnCard datorCard1 = new(ComputerGameBoard[0]);
            DrawnCard datorCard2 = new(ComputerGameBoard[1]);
            DrawnCard datorCard3 = new(ComputerGameBoard[2]);
            DrawnCard datorCard4 = new(ComputerGameBoard[3]);
            DrawnCard datorCard5 = new(ComputerGameBoard[4]);

            DrawnCard playerCard1 = new(PlayerGameBoard[0]);
            DrawnCard playerCard2 = new(PlayerGameBoard[1]);
            DrawnCard playerCard3 = new(PlayerGameBoard[2]);
            DrawnCard playerCard4 = new(PlayerGameBoard[3]);
            DrawnCard playerCard5 = new(PlayerGameBoard[4]);
            

            WriteLineColour(artCardTable, ConsoleColor.DarkGreen);
            //Card width + 4 spaces increase for each card
            // Top row
            PrintTopCardCount(5);
            PrintComputerPix(97, 10);
            // Måla upp kort för varje position. Behöver ny DrawnCard instansiering för varje kort. Onödigt.
            PrintCard(20, 7, datorCard1.ConstructedCard);     
            PrintCard(35, 7, datorCard2.ConstructedCard);
            PrintCard(50, 7, datorCard3.ConstructedCard);
            PrintCard(65, 7, datorCard4.ConstructedCard);
            PrintCard(80, 7, datorCard5.ConstructedCard);
            // Bottom row
            PrintBottomCardCount(16);
            PrintPlayerPix(97, 21);
            PrintCard(20, 18, playerCard1.ConstructedCard);
            PrintCard(35, 18, playerCard2.ConstructedCard);
            PrintCard(50, 18, playerCard3.ConstructedCard);
            PrintCard(65, 18, playerCard4.ConstructedCard);
            PrintCard(80, 18, playerCard5.ConstructedCard);

            Console.WriteLine();
            
            Console.WriteLine();

            CenterWriteLine("Text placeholder");
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
            Console.WriteLine($"[Your pix: {PixsPlayer}  ]");
        }

        private static void PrintComputerPix(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            Console.WriteLine($"[Opponent pix: {PixsComputer}  ]");
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
