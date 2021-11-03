using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    class MenuHighScore
    {
       static Dictionary<string, int>> highScoreList = new();

        public static void Start()
        {

        }

        public static void SaveScore(string name, int score) //spara poängen, när spelaren eller datorn har 0 pix
        {
            name = Game.Game.EndGame();
            score = Game.Game.EndGame();

            MenuHighScore highscoreList = new();
           
            highscoreList.Add("player1", 1); //test
            highscoreList.Add("player2", 2); //test
         
        }
    }
    

}
