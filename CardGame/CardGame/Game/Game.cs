using System;
using System.Collections.Generic;
using Graphics;
using CardGame;

namespace Game
{
    class Game
    {
        public static PlayerStats Player = new();
        public static PlayerStats Computer = new();

        public static List<Card> PlayerGameBoard = new List<Card>(new Card[5]);
        public static List<Card> ComputerGameBoard = new List<Card>(new Card[5]);
     
        public static void Start()
        {
            Deck.ResetCards();
            Console.Clear();

            // <insert game loop here> 
            while (Deck.CheckCardsLeft(10))
            {
                CheckPixs();
                FillBoard();
                AddPoints();
                DisplayHelper.CenterPressEnterToContinue();
            }
        }

        public static void FillBoard()
        {
            //5 cards for the player
            for (int i = 0; i < 5; i++)
            {
                PlayerGameBoard[i] = Deck.DrawCard();
            }

            //5 cards for the computer
            for (int i = 0; i < 5; i++)
            {
                ComputerGameBoard[i] = Deck.DrawCard();
            }

            DisplayGameBoard.ShowBoard();

        }

        public static void AddPoints()
        {
            // Loopa gameboard och se kort
            // Kolla vem som har fått poäng, om någon alls
            // Dela ut rätt mängd pixs
            for (int i = 0; i < PlayerGameBoard.Count; i++)
            {
                Player.CardSum += PlayerGameBoard[i].Number;
                Computer.CardSum += ComputerGameBoard[i].Number;
            }

            if (Player.CardSum == 15 && Computer.CardSum != 15) // Spelaren vinner
            {
                Console.WriteLine("You won! You get one point."); //visas upp på grafik
                Player.Points++;
            }
            else if (Computer.CardSum == 15 && Player.CardSum != 15) // Datorn vinner
            {
                Console.WriteLine("Computer won! You get one point."); //visas upp på grafik
                Computer.Points++;
            }
            else if (Computer.CardSum == 15 && Player.CardSum == 15) // Båda vinner
            {
                Player.Points++;
                Computer.Points++;
            }

            if (Player.Points > Computer.Points)
            {
                Player.Pix += 100;
                Computer.Pix -= 100;
            }
            else if(Player.Points < Computer.Points)
            {
                Player.Pix -= 100;
                Computer.Pix += 100;
            }

            Computer.CardSum = 0;
            Player.CardSum = 0;
        }

        public static bool CheckPixs()
        {
            if (Player.Pix < 100 || Computer.Pix < 100)
            {
                DisplayHelper.CenterWriteLine("Pengar slut");
                return false;
            } 
            else
            {
                return true;
            }
        }

        public static void CheckCardsLeft()
        {
            if(!Deck.CheckCardsLeft(10))
            {
                EndGame();
            }
            // Har vi kort för att spela?
            // Om inte endgame.
        }

        public static void EndGame()
        {
            Console.Clear();
            Menus.MenuHighScore.SaveScore(Computer.Points, Player.Points);
            Menus.MenuMain.Start();
        }
    }
}
