using System;

namespace cse210_06.Game.Casting
{
    public class Card : Actor
    {
        private Body body;

        private Image image;
        private string symbol;
        private string suit;
        private int value;


        public Card(Body body, Image image, string symbol, string suit, int value, bool debug = false) : base(debug)
        {
            this.body = body;
            this.image = image;
            this.symbol = symbol;
            this.suit = suit;
            this.value = value;
        }
        
        public Body GetBody()
        {
            return body;
        }

        public Image GetImage()
        {
            return image;
        }

        public int GetValue()
        {
            return value;
        }
    }
}
