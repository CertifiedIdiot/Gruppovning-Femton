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

        public static void SaveScore(string name, int points)
        {
            MenuHighScore highscoreList = new();
            highscoreList.Add("player1", 1); //test

            //spara poängen, när spelaren eller datorn har 0 pix
        }
    }
    

}
