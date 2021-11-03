using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Suits
{
    Diamonds=0,
    Clubs,
    Hearts,
    Spade
}

namespace Game
{
    class Card
    {
        private int number;
        private Suits suit;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 0)
                    value = 1;
                if (value > 13)
                    value = 14;

                number = value;
            }
        }
        
        public Suits Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }
    }
}
