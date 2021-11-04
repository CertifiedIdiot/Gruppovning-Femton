using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using Game;

namespace Menus
{
    static class MenuMain
    {
        public static PlayerStats player = new();
        public static PlayerStats computer = new();
        public static void Start()
        {
            PrintMenu();

            
            while (true)
            {
                switch (InputHandler.ConsoleToInt())
                    {
                        case 1:
                            Console.WriteLine("What is your name?");
                            Menus.MenuHighScore.PlayerName = InputHandler.ConsoleToFullName();
                            Game.Game.Start();
                            return;

                        case 2:
                            MenuHighScore.Start();
                            return;

                        case 3:
                            Console.WriteLine("Thank you for playing!"); Environment.Exit(0);
                            return;

                        default:
                            Console.WriteLine("Invalid Menu Choice.\n");
                            break;
                    }
            }

        }

        private static void PrintMenu() //kommer att göra den lite snyggare
        {
            MenuHeader();
            Console.WriteLine("Welcome to this card game! Each round costs 100 pix.");
            Console.WriteLine("1. Start game");
            Console.WriteLine("2. High score");
            Console.WriteLine("3. Exit\n");
            Console.Write(">> ");
        }

        private static void MenuHeader()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tMENU");
            Console.ResetColor();
        }
    }
}
