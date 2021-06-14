using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DeckofCards;
using static DeckofCards.Utility;

namespace DeckofCards.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CorrectNumberOfCards()
        {
            var deck = new Deck();
            Assert.AreEqual(52, deck.Cards.Count);
        }

        [TestMethod]
        public void CorrectNumberSuits()
        {
            var deck = new Deck();
            Assert.AreEqual(4, SuitEnum.GetNames(typeof(SuitEnum)).Length);
            
        }


        [TestMethod]
        public void CorrectNumberOfCardsPerSuit()
        {
            var deck = new Deck();
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit == SuitEnum.Club));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit == SuitEnum.Diamond));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit == SuitEnum.Heart));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit == SuitEnum.Spades));
        }


        [TestMethod]
        public void CorrectValueofCards()
        {
            var deck = new Deck();
            Assert.AreEqual(10, (from s in deck.Cards
                                where s.CardNumber > (CardNumberEnum)9 select s.CardValue).FirstOrDefault());
            

        }

    }
}
