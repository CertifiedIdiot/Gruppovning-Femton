using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    class MenuHighScore
    {
        static List<PlayerScore> HighScoreList = new();
        public static string PlayerName = "";

        public static void Start()
        {
            HighScoreList=HighScoreList.OrderByDescending(x => x.Points).ToList();
            PrintHighScore();
            BackToMenuMain();
        }

        public static void SaveScore(int computerPoints, int playerPoints)
        {
            PlayerScore Score = new();
            bool update = false;

            if (playerPoints > computerPoints)
            {
                Score.Name = PlayerName;
                Score.Points = playerPoints;
                update = true;
            }
            if (computerPoints > playerPoints)
            {
                Score.Name = "Computer";
                Score.Points = computerPoints;  
                update = true;            
            }
            if(update)
            {
                HighScoreList.Add(Score);
            }
        }
        
        //HighScoreList.Add("player1", 3); //test
        //HighScoreList.Add("player2", 2); 
        //HighScoreList.Add("player3", 1); 

        private static void PrintHighScore()
        {
            MenuHighScoreHeader();

            foreach (var score in HighScoreList)
            {
                Console.WriteLine("Name:\"" + score.Name + "\" Score: " + score.Points);
            }
        }

        private static void MenuHighScoreHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\tHIGHSCORE");
            Console.ResetColor();
        }

        private static void BackToMenuMain()
        {
            Console.WriteLine("\n\nPress any key to go back to MENU");
            Console.ReadKey();
            Console.Clear();
            Menus.MenuMain.Start();
        }
    }       
}
    
