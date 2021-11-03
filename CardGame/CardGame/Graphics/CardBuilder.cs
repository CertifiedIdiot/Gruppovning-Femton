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
        internal Game.Card ChosenCard { get; set; }
        
        internal DrawnCard(Game.Card chosenCard)
        {
            ChosenCard = chosenCard;
            CardNumberTop = GetCardNumberTop();
            CardMiddleSuit = GetCardMiddleSuit();
            CardNumberBottom = GetCardNumberBottom();
            ConstructedCard = CardArray();
            
        }

        // Changes the value of the card constructed.
        public string GetCardNumberTop()
        {
            int cardNumber = GetValue();  
            string cardNumberTop = $"| {cardNumber}       |";
            if (cardNumber == 10)
                return string cardNumberBottom = $"|      {cardNumber} |"; // OM tio, tar bort en space char från kortet, tänkte jag.
            else
                return cardNumberTop;
        }

        public string GetCardNumberBottom()
        {
            string cardNumber = GetValue();
            string cardNumberBottom = $"|       {cardNumber} |";
            if (cardNumber == "10")
                return string cardNumberBottom = $"|      {cardNumber} |";
            else
                return cardNumberBottom;
        }

        // Changes the suit of the card.
        public string GetCardMiddleSuit()
        {
            char cardSuit = GetSuit();   
            string cardSuitString = $"|    {cardSuit}    |";
            return cardSuitString;
        }


        public string GetValue()
        {
            var value = ChosenCard.Number.ToString();
            if (value == "11")
                return "J";
            else if (value == "12")
                return "Q";
            else if (value == "13")
                return "K";
            else
            return value;
        }

        public char GetSuit()
        {
            var suit = ChosenCard.Suit;
            if (suit == Suits.Diamonds)
                return '♦';
            else if (suit == Suits.Clubs)
                return '♣';
            else if (suit == Suits.Hearts)
                return '♥';
            else if (suit == Suits.Spade)
                return '♠';
            else
            return '#';
        }


        // Constructs card top to bottom.
        public string[] CardArray()
        {
            string[] constructedCard = { CardTop, CardNumberTop, CardMiddle, CardMiddleSuit, CardMiddle, CardNumberBottom, CardBottom };
            return constructedCard;

        }

    }
}
