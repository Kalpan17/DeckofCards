using System;
using System.Collections.Generic;
using System.Linq;


namespace DeckofCards
{
    public class Deck : IDeck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            foreach (var suit in new[] { "Spades", "Hearts", "Clubs", "Diamonds" })
            {
                Console.WriteLine("^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%^%  Suit -- " + suit);
                for (var cardNumber = 13; cardNumber > 0; cardNumber -= 1)
                {
                    Card newcard = new Card(cardNumber, suit);
                    Cards.Add(newcard);
                }
            }
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
