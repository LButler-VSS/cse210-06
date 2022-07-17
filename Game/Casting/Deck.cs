using System;
using System.Collections.Generic;
using System.Linq;

namespace cse210_06.Game.Casting
{
    public class Deck : Actor
    {
        List<Card> deck = new List<Card>();
        private static Random rng = new Random();

        public Deck()
        {
            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 1:
                        {
                            int cardValue = 0;
                            for (int i = 0; i < 13; i++)
                            {
                                Card card = new Card();
                                cardValue++;
                                if (cardValue == 1)
                                {
                                    card.Symbol = "Ace";
                                }
                                else if (cardValue == 11)
                                {
                                    card.Symbol = "Jack";
                                }
                                else if (cardValue == 12)
                                {
                                    card.Symbol = "Queen";
                                }
                                else if (cardValue == 13)
                                {
                                    card.Symbol = "King";
                                }
                                else
                                {
                                    card.Symbol = Convert.ToString(cardValue);
                                }
                                card.Suit = "Hearts";
                                card.Value = cardValue;
                                deck.Add(card);
                            }
                            break;
                        }
                    case 2:
                        {

                            int cardValue = 0;
                            for (int i = 0; i < 13; i++)
                            {
                                Card card = new Card();
                                cardValue++;
                                if (cardValue == 1)
                                {
                                    card.Symbol = "Ace";
                                }
                                else if (cardValue == 11)
                                {
                                    card.Symbol = "Jack";
                                }
                                else if (cardValue == 12)
                                {
                                    card.Symbol = "Queen";
                                }
                                else if (cardValue == 13)
                                {
                                    card.Symbol = "King";
                                }
                                else
                                {
                                    card.Symbol = Convert.ToString(cardValue);
                                }
                                card.Suit = "Spades";
                                card.Value = cardValue;
                                deck.Add(card);
                            }
                            break;
                        }
                    case 3:
                        {
                            int cardValue = 0;
                            for (int i = 0; i < 13; i++)
                            {
                                Card card = new Card();
                                cardValue++;
                                if (cardValue == 1)
                                {
                                    card.Symbol = "Ace";
                                }
                                else if (cardValue == 11)
                                {
                                    card.Symbol = "Jack";
                                }
                                else if (cardValue == 12)
                                {
                                    card.Symbol = "Queen";
                                }
                                else if (cardValue == 13)
                                {
                                    card.Symbol = "King";
                                }
                                else
                                {
                                    card.Symbol = Convert.ToString(cardValue);
                                }
                                card.Suit = "Diamonds";
                                card.Value = cardValue;
                                deck.Add(card);
                            }
                            break;
                        }
                    case 4:
                        {
                            int cardValue = 0;
                            for (int i = 0; i < 13; i++)
                            {
                                Card card = new Card();
                                cardValue++;
                                if (cardValue == 1)
                                {
                                    card.Symbol = "Ace";
                                }
                                else if (cardValue == 11)
                                {
                                    card.Symbol = "Jack";
                                    card.Value = 10;
                                }
                                else if (cardValue == 12)
                                {
                                    card.Symbol = "Queen";
                                }
                                else if (cardValue == 13)
                                {
                                    card.Symbol = "King";
                                }
                                else
                                {
                                    card.Symbol = Convert.ToString(cardValue);
                                }
                                card.Suit = "Clubs";
                                card.Value = cardValue;
                                deck.Add(card);
                            }
                            break;
                        }
                    default:
                        break;
                };
            }
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

        public List<Card> Deal(int i)
        {
            List<Card> dealtCards = new List<Card>();
            for (int j = 0; j < i; j++)
            {
                dealtCards.Add(deck[0]);
                deck.RemoveAt(0);
            }
            return dealtCards;
        }
    }

}
