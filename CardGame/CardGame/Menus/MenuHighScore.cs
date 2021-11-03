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
            ScoreBoard();
        }

        public static void SaveScore(string name, int computerScore, int playerScore)
        {
            playerScore Score = new playerScore();

            if (playerScore > computerScore)
            {
               
            }
            if (computerScore > playerScore)
            {
                
            }

            //spara namn och score på listan

            //jämför den nya scoren med alla andra på listan

            //om den är högre än första, andra eller tredje --> lägg den i listan
        }

        private static void UpdateHighScore() 
        {
            if (playerScore >= HighScoreList[2])
            {
                HighScoreList.Add(name, playerScore); //sparar till listan, men ersätter inte något?
            }
            //om den är mindre än tredje --> lägg den inte in i listan
        }

            //HighScoreList.Add("player1", 3); //test
            //HighScoreList.Add("player2", 2); 
            //HighScoreList.Add("player3", 1); 
         
        }

        private static void ScoreBoard() 
        {
            Console.WriteLine("\tHIGHSCORE");

            foreach (var score in HighScoreList)
            {
                Console.WriteLine("Name: " + score.Key + " Score: " + score.Value);
            }
            
        }
    }
    

}
