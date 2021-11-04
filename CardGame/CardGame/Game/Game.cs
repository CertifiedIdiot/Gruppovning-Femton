using System;
using System.Collections.Generic;
using Graphics;
using CardGame;
using System.Diagnostics;

namespace Game
{
    class Game
    {
        public static PlayerStats Player = new();
        public static PlayerStats Computer = new();

        public static List<Card> PlayerGameBoard = new List<Card>();
        public static List<Card> ComputerGameBoard = new List<Card>();
     
        public static void Start()
        {
            Deck.ResetCards();
            Console.Clear();

            while (Deck.CheckCardsLeft(10))
            {
                CheckPixs();
                FillBoard();
                AddPoints();
                DisplayGameBoard.ShowBoard();
                
                
                PlayerGameBoard = new List<Card>();
                ComputerGameBoard = new List<Card>();
                Computer.CardSum = 0;
                Player.CardSum = 0;

                DisplayHelper.CenterPressEnterToContinue();
            }

            EndGame();
        }

        public static void FillBoard()
        {
            bool playerTurn = false;
            foreach (var card in Deck.DrawCard(10))
            {

                if (playerTurn && Player.CardSum < 15)
                {
                    Player.CardSum += card.Number;
                    PlayerGameBoard.Add(card);

                    playerTurn = false;
                }
                else if(!playerTurn && Computer.CardSum < 15)
                {
                    Computer.CardSum += card.Number;
                    ComputerGameBoard.Add(card);

                    playerTurn = true;
                }

                DisplayGameBoard.ShowBoard();
                DisplayHelper.CenterPressEnterToContinue();

                if (Computer.CardSum >= 15)
                    playerTurn = true;
                if (Player.CardSum >= 15)
                    playerTurn = false;
                if (Player.CardSum >= 15 && Computer.CardSum >= 15)
                    break;
            }
        }

        public static void AddPoints()
        {
            if (Player.CardSum == 15 && Computer.CardSum != 15) // Spelaren vann en runda
            {
                Console.WriteLine("You won! You get one point.");
                Player.Points++;
                Player.Pix += 100;
                Computer.Pix -= 100;
            }
            else if (Computer.CardSum == 15 && Player.CardSum != 15) // Datorn vann en runda
            {
                Console.WriteLine("Computer won!");
                Computer.Points++;
                Player.Pix -= 100;
                Computer.Pix += 100;
            }
            else if (Computer.CardSum == 15 && Player.CardSum == 15) // Båda vinner
            {
                Player.Points++;
                Computer.Points++;
            }
        }

        public static bool CheckPixs()
        {
            if (Player.Pix < 100 || Computer.Pix < 100)
            {
                DisplayHelper.CenterWriteLine("Pengar slut");

                EndGame();

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
                DisplayHelper.CenterWriteLine("Slut på kort");

                EndGame();
            }
        }

        public static void EndGame()
        {
            Console.Clear();
            if(Player.Points > Computer.Points)
            {
                DisplayHelper.CenterWriteLine("Congratulations! You Won\n");
            }
            else if(Computer.Points > Player.Points)
            {
                Console.WriteLine("You Lost... Better Luck Next Time\n");
            }
            else
            {
                DisplayHelper.CenterWriteLine("Nobody Wins, Its A Draw\n");
            }
            
            DisplayHelper.CenterPressEnterToContinue();
            Menus.MenuHighScore.SaveScore(Computer.Points, Player.Points);
            Menus.MenuMain.Start();
        }
    }
}
