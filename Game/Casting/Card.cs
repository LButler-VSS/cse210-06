using System;

namespace cse210_06.Game.Casting
{
    public class Card : Actor
    {
        private Body body;

        private Image image;

        public Card(Body body, Image image)
        {
            this.body = body;
            this.image = image;
        }
        public string Symbol
        { get; set; }

        public string Suit
        { get; set; }

        public int Value
        { get; set; }

        public Body GetBody()
        {
            return body;
        }
    }
}
