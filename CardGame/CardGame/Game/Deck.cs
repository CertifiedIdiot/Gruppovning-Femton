using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    static class Deck
    {
        private static List<Card> Cards = new List<Card>();
        private static Random rng = new Random();

        public static IEnumerable<Card> DrawCard(int numberOfCards)
        {
            Card card = new Card();
            int limit = Cards.Count - numberOfCards - 1;

            for(int i = Cards.Count-1; i > limit; i--)
            {
                card = Cards[i];
                Cards.RemoveAt(i);

                yield return card;
            }
        }
         
        public static Card DrawCard()
        {
            Card card = Cards[Cards.Count - 1];
            Cards.RemoveAt(Cards.Count - 1);

            return card;
        }

        public static void ResetCards()
        {
            RemoveCards();
            FillDeck();
            Cards.Shuffle();
        }

        public static Suits GetSuit(int value)
        {
            Suits suit;

            switch (value)
            {
                case 0:
                    suit = Suits.Diamonds;
                    break;
                case 1:
                    suit = Suits.Clubs;
                    break;
                case 2:
                    suit = Suits.Hearts;
                    break;
                case 3:
                    suit = Suits.Spade;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("WRONG SUIT VALUE");
            }

            return suit;
        }

        public static void PrintCard()
        {

        }

        public static bool CheckCardsLeft(int cardsLeft=1)
        {
            if (Cards.Count < cardsLeft)
                return false;
            else
                return true;
        }

        private static void FillDeck()
        {
                      
            int suitNumber = 0;
            int cardNumber = 1;
            for (int i = 0; i <= 52; i++)
            {
                if (cardNumber > 13)
                {
                    cardNumber = 1;
                    suitNumber++;
                }

                if(suitNumber>3)
                {
                    suitNumber = 0;
                }

                Cards.Add(new Card() { Number = cardNumber, Suit = GetSuit(suitNumber) });

                cardNumber++;
            }
        }

        private static void RemoveCards()
        {
            Cards = new List<Card>();
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
