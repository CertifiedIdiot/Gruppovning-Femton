using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    class MenuHighScore
    {
       static List<string, int> HighScoreList = new();

        public static void Start()
        {
            ScoreBoard();
            HighScoreList.Sort();
        }

        public static void SaveScore(string name, int score) //spara poängen, när spelaren eller datorn har 0 pix
        {
            name = Game.Game.EndGame();
            score = Game.Game.EndGame();

            //spara namn och score på listan
            //jämför den nya scoren med alla andra på listan
                //om den är högre än första, andra eller tredje --> lägg den i listan
                if (score > )
                //om den är mindre än tredje --> lägg den inte in i listan

            MenuHighScore highscoreList = new();
           
            highscoreList.Add("player1", 3);
            highscoreList.Add("player2", 2); 
            highscoreList.Add("player3", 1); 
         
        }

        private static void ScoreBoard() //preliminär
        {
            Console.WriteLine("\tHIGHSCORE");
            Console.WriteLine([0]);
            Console.WriteLine([1]);
            Console.WriteLine([2]);
        }
    }
    

}
