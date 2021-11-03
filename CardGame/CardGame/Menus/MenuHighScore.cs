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

        public static void Start()
        {
            PrintHighScore();
            UpdateHighScore();
            BackToMenu();
        }

        public static void SaveScore(string name, int computerPoints, int playerPoints)
        {
            PlayerScore Score = new();

            if (playerPoints > computerPoints)
            {
                Score.Name = name;
                Score.Points = playerPoints;
            }
            if (computerPoints > playerPoints)
            {
                Score.Name = "Computer";
                Score.Points = computerPoints;              
            }

            HighScoreList.Add(Score);
            
        }

        private static void UpdateHighScore() //HighScoreList.OrderBy(q => q.Points);
        {
            bool changed = false;
            do
            {
                changed = false;
                for (int i = 0; i != HighScoreList.Count - 1; i++)
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
            Console.WriteLine("\tHIGHSCORE");

            foreach (var score in HighScoreList)
            {
                Console.WriteLine("Name: " + score.Name + " Score: " + score.Points);
            }
        }

        private static void BackToMenu()
        {
            Console.WriteLine("Press any key to go back to MENU");
            Console.ReadLine();
            return;
        }
    }       
}
    
