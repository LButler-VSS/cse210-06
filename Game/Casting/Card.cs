using System;

namespace cse210_06.Game.Casting
{
    public class Card : Actor
    {

        private Image image;

        public Card()
        {

        }
        public string Symbol
        { get; set; }

        public string Suit
        { get; set; }

        public int Value
        { get; set; }

        public int AceValue
        { get; set; }
    }
}
