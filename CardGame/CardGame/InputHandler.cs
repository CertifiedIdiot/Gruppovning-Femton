using System;
using Menus;

namespace CardGame
{
    class InputHandler
    {

        public static string[] ConsoleToFullName()
        {
            while(true)
            {
                string firstName = "";
                string lastName = "";

                Console.WriteLine("\nPlease write a First name.");
                firstName = ConsoleToString();

                Console.WriteLine("\nPlease write a Last name.");
                lastName = ConsoleToString();

                Console.WriteLine($"\nIs \"{firstName} {lastName}\" correct?");
                if (YesNoChoice() == true)
                {
                    string[] fullName = { firstName, lastName };
                    return fullName;
                }
                else
                {
                    Console.WriteLine("\nLets try this again.");
                }
            }
        }

        public static bool YesNoChoice()
        {
            Console.WriteLine("y/n?");
            while(true)
            {
                string yesNoChoice = Console.ReadLine().ToLower();
                if (yesNoChoice == "y")
                {
                    return true;
                }
                if (yesNoChoice == "n")
                {
                    return false;
                }

                Console.WriteLine("\nPlease choose either \"y\" for yes or \"n\" for no.");
            }
        }

        public static string ConsoleToString(bool obligatoryInput = true, bool singleInput = false)
        {
            string strInput = "";

            if (obligatoryInput || singleInput)
            {
                if (obligatoryInput && singleInput != true)
                {
                    while(true)
                    {
                        strInput = Console.ReadLine();

                        if (strInput == "")
                        {
                            Console.WriteLine("\nYou have to enter something.");
                        }
                        else
                        {
                            return strInput;
                        }
                    }
                }
                else
                {
                    strInput = Console.ReadLine();

                    if (strInput == "" && strInput.Length == 1)
                    {
                        Console.WriteLine("\nYou have to enter something and it must be a single character.");
                    }
                    else
                    {
                        return strInput;
                    }
                }
            }

            return Console.ReadLine();
        }

        public static int ConsoleToInt()
        {
            while (true)
            {
                int number = -1;
                string consoleInput = Console.ReadLine();
                bool validInput = int.TryParse(consoleInput, out number);

                if (validInput && number > -1)
                {
                    return number;
                }
                Console.WriteLine("\nPlease type a valid number.");
            }
        }

        public static void MenuReset()
        {
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            MenuMain.Start();
        }
    }
}