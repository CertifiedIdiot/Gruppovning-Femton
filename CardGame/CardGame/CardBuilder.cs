using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcard.ArtAssets
{
    // Suit symbols 
    //  ♠       ♦       ♥       ♣
    public class CardBuilder
    {
        public string CardTop { get; set; } = "┌---------┐";
        public string CardNumberTop { get; set; } = "| #       |";
        public string CardMiddle { get; set; } = "|         |";
        public string CardMiddleSuit { get; set; } = "|    *    |";
        public string CardNumberBottom { get; set; } = "|       # |";
        public string CardBottom { get; set; } = "└---------┘";
        public string[] ConstructedCard { get; set; }

        public CardBuilder()
        {
            CardNumberTop = GetCardNumberTop();
            CardMiddleSuit = GetCardMiddleSuit();
            CardNumberBottom = GetCardNumberBottom();
            ConstructedCard = CardArray();
        }

        // Changes the value of the card constructed.
        public string GetCardNumberTop()
        {
            int cardNumber = GetValue(5);   // Manually added for now. To be automatically selected from drawn card
            string cardNumberTop = $"| {cardNumber}       |";
            return cardNumberTop;
        }

        public string GetCardNumberBottom()
        {
            int cardNumber = GetValue(5);   // Manually added for now. To be automatically selected from drawn card
            string cardNumberBottom = $"|       {cardNumber} |";
            return cardNumberBottom;
        }

        // Changes the suit of the card.
        public string GetCardMiddleSuit()
        {
            char cardSuit = GetSuit('♠');   // Manually added for now. To be automatically selected from drawn card
            string cardSuitString = $"|    {cardSuit}    |";
            return cardSuitString;
        }


        public int GetValue(int placeholderDelete)
        {
            // TODO: Code to get card value from drawn card and return
            return placeholderDelete;

        }

        public char GetSuit(char placeholderDelete)
        {
            // TODO: Code to get card suit from drawn card and return.
            return placeholderDelete;
        }

        public string[] CardArray()
        {
            string[] constructedCard = { CardTop, CardNumberTop, CardMiddle, CardMiddleSuit, CardMiddle, CardNumberBottom, CardBottom };
            return constructedCard;

        }

        // Needs better solution. Automatically change suit char + number?

        //public static string cardTop = "┌---------┐";
        //public static string cardNumberTop = "| 2       |";
        //public static string cardMiddle = "|         |";
        //public static string cardMiddleSuit = "|    ♠    |";
        //public static string cardNumberBottom = "|       z |";
        //public static string cardBottom = "└---------┘";

        //public static string[] cardArray = {cardTop, cardNumberTop,
        //                                   cardMiddle,
        //                                   cardMiddleSuit,
        //                                   cardMiddle,
        //                                   cardNumberBottom, cardBottom  };

    }
}
