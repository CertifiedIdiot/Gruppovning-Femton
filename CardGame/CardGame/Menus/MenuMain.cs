using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    static class MenuMain
    {
        public static void Start()
        {
            PrintMenu();

            var menuInput = 0;
            int.TryParse(Console.ReadLine(), out menuInput);

            switch (menuInput)
            {
                case 1: Game.Game.Start(); break;
                case 2: MenuHighScore.Start(); break;
                case 3: Console.WriteLine("Thank you for playing!"); Environment.Exit(0); break;
                default: Console.WriteLine("Invalid input"); break;
            }

        }

        private static void PrintMenu() //kommer att göra den lite snyggare
        {
            MenuHeader();
            Console.WriteLine("1. Start game");
            Console.WriteLine("2. High score");
            Console.WriteLine("3. Exit");
            Console.WriteLine(">> ");
        }

        private static void MenuHeader()
        {
            Console.WriteLine("\tMENU");
        }
    }
}
