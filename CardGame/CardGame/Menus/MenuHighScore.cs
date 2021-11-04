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
            PrintHighScore();
            OrderHighScore();
            BackToMenu();
        }

        public static void SaveScore(int computerPoints, int playerPoints)
        {
            PlayerScore Score = new();

            if (playerPoints > computerPoints)
            {
                Score.Name = PlayerName;
                Score.Points = playerPoints;
            }
            if (computerPoints > playerPoints)
            {
                Score.Name = "Computer";
                Score.Points = computerPoints;              
            }

            HighScoreList.Add(Score);
            
        }

        //HighScoreList.OrderBy() => );

        // Sorterar ej korrect
        private static void OrderHighScore()
        {
            if(!HighScoreList.Any())
            {
                return;
            }

            bool changed = false;
            do
            {
                changed = false;
                for (int i = 0; i != HighScoreList.Count - 2; i++)
                {
                    if (HighScoreList[i].Points < HighScoreList[i + 1].Points)
                    {
                        var tempVar = HighScoreList[i].Points;
                        HighScoreList[i].Points = HighScoreList[i + 1].Points;
                        HighScoreList[i + 1].Points = tempVar;
                        changed = true;
                    }
                }
            } while (changed == true);

            //om den är mindre än tredje --> lägg den inte in i listan
        }

        //HighScoreList.Add("player1", 3); //test
        //HighScoreList.Add("player2", 2); 
        //HighScoreList.Add("player3", 1); 

        private static void PrintHighScore()
        {
            MenuHighScoreHeader();
            foreach (var score in HighScoreList)
            {
                Console.WriteLine("Name: " + score.Name + " Score: " + score.Points);
            }
        }

        private static void MenuHighScoreHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\tHIGHSCORE");
            Console.ResetColor();
        }

        private static void BackToMenu()
        {
            Console.WriteLine("\n\nPress any key to go back to MENU");
            Console.ReadKey();
            Console.Clear();
            Menus.MenuMain.Start();
        }
    }       
}
    
