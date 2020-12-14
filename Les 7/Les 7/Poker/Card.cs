using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    class Card
    {
        Suit suit;
        int value;
        static int totalNumberOfCards = 52;

        public Card(Suit suit, int value)
        {
            this.suit = suit;
            this.value = value;
            removeCardFromDeck();
        }

        public Suit Suit { get => suit; set => suit = value; }
        public int Value { get => value; set => this.value = value; }
        public static int TotalNumberOfCards { get => totalNumberOfCards; set => totalNumberOfCards = value; }


        public override string ToString()
        {
            string suitString = "";

            switch(suit)
            {
                case Suit.Hearts:
                    suitString = "Harten";
                    break;
                case Suit.Spades:
                    suitString = "Schopen";
                    break;
                case Suit.Diamonds:
                    suitString = "Ruiten";
                    break;
                case Suit.Clubs:
                    suitString = "Klaveren";
                    break;
            }

            return $"{suitString} {value}";
        }

        private void removeCardFromDeck()
        {
            totalNumberOfCards--;
        }
    }
}
