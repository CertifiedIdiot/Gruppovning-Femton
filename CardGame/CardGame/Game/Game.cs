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

        public static List<Card> PlayerGameBoard = new List<Card>();//(new Card[5]);
        public static List<Card> ComputerGameBoard = new List<Card>();//(new Card[5]);
     
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
                DisplayGameBoard.ShowBoard();
                
                
                PlayerGameBoard = new List<Card>();
                ComputerGameBoard = new List<Card>();
                Computer.CardSum = 0;
                Player.CardSum = 0;

                DisplayHelper.CenterPressEnterToContinue();


                Deck.ResetCards();


                /*
                CheckPixs();
                FillBoard();
                AddPoints();
                DisplayGameBoard.ShowBoard();
                DisplayHelper.CenterPressEnterToContinue();

                Computer.CardSum = 0;
                Player.CardSum = 0;
                */
            }
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
                else if(!playerTurn && Computer.CardSum < 15)//(Computer.CardSum != 15)
                {
                    Computer.CardSum += card.Number;
                    ComputerGameBoard.Add(card);

                    playerTurn = true;
                }

                Debug.Write("List Count: " + PlayerGameBoard.Count + " | Card Sum: " + Player.CardSum);
                Debug.WriteLine("");
                DisplayGameBoard.ShowBoard();
                DisplayHelper.CenterPressEnterToContinue();

                if (Computer.CardSum >= 15)
                    playerTurn = true;
                if (Player.CardSum >= 15)
                    playerTurn = false;
                if (Player.CardSum >= 15 && Computer.CardSum >= 15)
                    break;
            }
             
             
             /*
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
             */

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


                /*
                 * ***** Spelet slut här *****
                 *    Registrera highscore ***
                 *    ************************
                 */
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
            Menus.MenuHighScore.SaveScore(Computer.Points, Player.Points);
            Menus.MenuMain.Start();
        }
    }
}
