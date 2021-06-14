using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    public class Card
    {

        public string Suit { get; set; }
        public int CardNumber { get; set; }


        public Card(int cardNumber, string suit)
        {
            this.CardNumber = cardNumber;
            this.Suit = suit;
            Utility.CardNumberEnum Cenum = (Utility.CardNumberEnum)cardNumber;
            Console.WriteLine(" {0} of {1} ", Cenum.ToString(), this.Suit);

        }



    }
}
