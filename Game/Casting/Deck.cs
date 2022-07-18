using System;
using System.Collections.Generic;
using System.Linq;

namespace cse210_06.Game.Casting
{
    public class Deck : Actor
    {
        List<Card> deck = new List<Card>();
        List<Card> dealt = new List<Card>();
        private static Random rng = new Random();

        public Deck(bool debug = false) : base(debug)
        {
            
        }

        public void AddCard(Card card)
        {
            deck.Add(card);
        }

        public void Shuffle()
        {
            int n = deck.Count;
            List<Card> list = new List<Card>();

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                list.Add(deck[k]);
                deck[k] = deck[n];
                deck[n] = list[0];
                list.RemoveAt(0);
            }
            /*
            foreach (var value in deck)
            {
                Console.WriteLine($"{value.Symbol} of {value.Suit}");
            }
            */
        }

        public List<Card> GetDeck()
        {
            return deck;
        }

        public List<Card> GetDealt()
        {
            return dealt;
        }

        public void Deal(int i)
        {
            for (int j = 0; j < i; j++)
            {
                dealt.Add(deck[0]);
                deck.RemoveAt(0);
            }
        }
    }

}
