using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    // Suit symbols 
    //  ♠       ♦       ♥       ♣
    public class DrawnCard
    {
        public string CardTop { get; set; } = "┌---------┐";
        public string CardNumberTop { get; set; } = "| #       |";
        public string CardMiddle { get; set; } = "|         |";
        public string CardMiddleSuit { get; set; } = "|    *    |";
        public string CardNumberBottom { get; set; } = "|       # |";
        public string CardBottom { get; set; } = "└---------┘";
        public string[] ConstructedCard { get; set; }
        
        public DrawnCard()
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
            // TODO: Code to get card value from drawn card and return. From chosen cards in game-class?
            return placeholderDelete;

        }

        public char GetSuit(char placeholderDelete)
        {
            // TODO: Code to get card suit from drawn card and return. From chosen cards in game-class?
            return placeholderDelete;
        }


        // Constructs card top to bottom.
        public string[] CardArray()
        {
            string[] constructedCard = { CardTop, CardNumberTop, CardMiddle, CardMiddleSuit, CardMiddle, CardNumberBottom, CardBottom };
            return constructedCard;

        }

    }
}
