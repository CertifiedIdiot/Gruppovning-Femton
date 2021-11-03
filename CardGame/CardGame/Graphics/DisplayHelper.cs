using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    public class DisplayHelper
    {
        public static void WriteLineColour(string text, ConsoleColor foregroundColour, ConsoleColor backgroundColour = ConsoleColor.Black)
        {
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColour;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void CenterWriteLine(string text)
        {
            //*If the text exceeds the console windowwidth -n (for good measure), writes it normally, otherwise centers text.
            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var textInHalf = text.Length / 2;
            if (text.Length >= maxStringLength - 2)
                Console.WriteLine(text);
            else
            {
                Console.CursorLeft = consoleCenter - textInHalf;
                Console.WriteLine(text);
            }
        }

        public static void CenterPressEnterToContinue()
        {
            CenterWriteLine("Press [Enter] to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MiddleWriteLine(string text)
        {

            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var consoleMiddle = Console.WindowHeight / 2;

            if (text.Length >= maxStringLength - 2)
                Console.WriteLine(text);
            else
            {
                Console.CursorLeft = consoleCenter - (text.Length / 2);
                Console.CursorTop = consoleMiddle;
                Console.WriteLine(text);
            }
        }
    }
}
