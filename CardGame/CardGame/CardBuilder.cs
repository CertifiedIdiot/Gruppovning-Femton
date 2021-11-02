using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcard.ArtAssets
{
    public class CardBuilder
    {
        // Suit symbols 
        //  ♠       ♦       ♥       ♣


        // Needs better solution. Automatically change suit char + number?

        public static string cardTop = "┌---------┐";
        public static string cardNumberTop = "| 2       |";
        public static string cardMiddle = "|         |";
        public static string cardMiddleSuit = "|    ♠    |";
        public static string cardNumberBottom = "|       z |";
        public static string cardBottom = "└---------┘";

        public static string[] cardArray = {cardTop, cardNumberTop,
                                           cardMiddle,
                                           cardMiddleSuit,
                                           cardMiddle,
                                           cardNumberBottom, cardBottom  };

    }
}
