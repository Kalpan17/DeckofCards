﻿using System;
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
        public int CardValue { get; set; }
        public string CardName { get; set; }

        public Card(int cardNumber, string suit)
        {
            this.CardNumber = cardNumber;
            this.Suit = suit;
            Utility.CardNumberEnum Cenum = (Utility.CardNumberEnum)cardNumber;
            this.CardName = Cenum.ToString() + " of " + suit;

            var CVal = Utility.CardValues.FirstOrDefault(x => x.Key == Cenum.ToString()).Value;
            this.CardValue = CVal;
            
            Console.WriteLine("{0} Value {1}", this.CardName, this.CardValue);
          

        }



    }
}
