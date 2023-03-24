using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarneeb
{
    class Deck
    {
        public Deck()
        {
            Reset();
        }

        public List<Card> Cards { get; set; }

        public void Reset()
        {
            //Range for suits
            Cards = Enumerable.Range(1, 4)
                //Range for card number
                .SelectMany(s => Enumerable.Range(2, 14)

                                    .Select(c => new Card()
                                    {
                                        cardSuit = (Card.Suits)s,
                                        cardNumber = (Card.CardNumber)c


                                    }
                                            )
                            )
                   .ToList();
        }
        public void Shuffle()
        {
            //Shuffles list card of objects
            Cards = Cards.OrderBy(c => Guid.NewGuid())
                         .ToList();
        }

        public Card TakeCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);

            return card;
        }

        public List<Card> TakeCards(int numberOfCards)
        {
            var cards = Cards.Take(numberOfCards);

            //var takeCards = cards as Card[] ?? cards.ToArray();
            var takeCards = cards as List<Card> ?? cards.ToList();
            Cards.RemoveAll(takeCards.Contains);

            return takeCards;
        }

        public List<Card> Sort(List<Card> listOfCards)
        {
            List<Card> sorted = listOfCards.GroupBy(s => s.cardSuit).
                OrderByDescending(c => c.Count()).SelectMany(g => g.OrderByDescending(c => c.cardNumber)).ToList();

            return sorted;

        }
    }
}
