using System;
using System.Collections.Generic;

namespace Game
{
    class Game
    {
        public static int PointsPlayer = 0, PixsPlayer = 500, CardSumPlayer=0;
        public static int PointsComputer = 0, PixsComputer = 500, CardSumComputer=0;

        public static List<Card> GameBoard = new List<Card>();
     
        public static void Start()
        {
            AddPoints();
            CheckPixs();
            ResetBoard();
        }

        public static void AddPoints()
        {
            // Kolla vem som har fått poäng, om någon alls
            // Dela ut rätt mängd pixs
        }

        public static void ResetBoard()
        {
            // Ränsa spel yta och ladda in nya kort från GetCards
            Console.Clear();
            Deck.DrawCard();
            // Skicka värden på cards till graphics för att ladda in 
            // en ny spel yta
        }

        public static void CheckPixs()
        {
            // Kan spelaren/datorn spela?
        }

        public static void CheckCards()
        {
            // Har vi kort för att spela?
        }

        public static void EndGame()
        {
            // Ladda upp slut poäng och namn i metod inom HighScore.
            // InputHandler.ConsoleToFullName (kan vara smidigt)
        }
    }
}
