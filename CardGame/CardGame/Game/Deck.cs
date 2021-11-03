﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    static class Deck
    {
        static List<Card> Cards = new List<Card>();
        private static Random rng = new Random();



        //Printa kort

        public static Card GetCards()
        {
            Card card = new Card();
            card=Cards[Cards.Count - 1];
            Cards.RemoveAt(Cards.Count - 1);

            return card;
        }

        public static void ResetCards()
        {
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

        public static bool CheckAnyCardsLeft()
        {
            if (Cards.Count <= 0)
                return false;
            else
                return true;
        }

        private static void FillDeck()
        {
            int suitNumber = 1;
            int cardNumber = 1;
            for (int i = 0; i <= 52; i++)
            {
                if (cardNumber > 13)
                {
                    cardNumber = 1;
                    suitNumber++;
                }

                Cards.Add(new Card() { Number = cardNumber, Suit = GetSuit(suitNumber) });

                cardNumber++;
            }
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