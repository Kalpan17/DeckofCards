using System;
using System.Collections.Generic;
using System.Linq;
using static DeckofCards.Utility;

namespace DeckofCards
{
    public class Deck : IDeck
    {
        public List<Card> Cards { get; set; }

        //public Deck()
        //{
        //    Cards = new List<Card>();

        //    foreach (var suit in new[] { "Spades", "Hearts", "Clubs", "Diamonds" })
        //    {
        //        Console.WriteLine("^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%  Suit -- " + suit);
        //        for (var cardNumber = 1; cardNumber <= 13; cardNumber++)
        //        {
        //            Card newcard = new Card(cardNumber, suit);
        //            Cards.Add(newcard);
        //        }
        //    }
        //}

        public Deck()
        {
            Cards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                                    .Select(c => new Card()
                                    {
                                        Suit = (SuitEnum)s,
                                        CardNumber = (CardNumberEnum)c,
                                        CardValue = (CardValues(c))
                                    }
                                 )
                            )
                   .ToList();
        }

        private int CardValues(int c)
        {
            if (c < 11 )
                return c;
            else
                return 10;
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid())
                         .ToList();
        }

        public Card TakeCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);

            return card;
        }

        public Deck Reset()
        {
            Deck CDeck = new Deck();
            //CDeck.Cards.Clear(); to make zero cards left..
            return CDeck;
        }

     
    }
}
