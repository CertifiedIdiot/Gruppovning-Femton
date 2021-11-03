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

            DrawnCard KortEtt = new(); //Gameboard index in constructor perhaps
            DrawnCard KortTvå = new();

            WriteLineColour(artCardTable, ConsoleColor.DarkGreen);
            //Card width + 4 spaces increase for each card
            // Top row
            PrintTopCardCount(5);
            PrintComputerPix(97, 10);
            // Måla upp kort för varje position. Behöver ny DrawnCard instansiering för varje kort. Onödigt.
            PrintCard(20, 7, KortEtt.ConstructedCard);     
            PrintCard(35, 7, KortTvå.ConstructedCard);
            PrintCard(50, 7, KortEtt.ConstructedCard);
            PrintCard(65, 7, KortEtt.ConstructedCard);
            PrintCard(80, 7, KortEtt.ConstructedCard);
            // Bottom row
            PrintBottomCardCount(16);
            PrintPlayerPix(97, 21);
            PrintCard(20, 18, KortEtt.ConstructedCard);
            PrintCard(35, 18, KortEtt.ConstructedCard);
            PrintCard(50, 18, KortEtt.ConstructedCard);
            PrintCard(65, 18, KortEtt.ConstructedCard);
            PrintCard(80, 18, KortEtt.ConstructedCard);

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



        private static void PrintPlayerPix(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            Console.WriteLine($"[Your pix: {Game.Game.PixsPlayer}  ]");
        }

        private static void PrintComputerPix(int posY, int posX)
        {
            Console.SetCursorPosition(posY, posX);
            Console.WriteLine($"[Opponent pix: {Game.Game.PixsComputer}  ]");
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
