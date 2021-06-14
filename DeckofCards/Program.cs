using System;
using System.Collections.Generic;
using System.Linq;


namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = 3;

            foreach (String arg in args)
            {
                if (!string.IsNullOrEmpty(arg))
                    turns = Convert.ToInt32(arg);
            }

            Deck PlayDeck = new Deck();
            //PlayDeck.Shuffle();
            Console.WriteLine(" Total Cards - " + PlayDeck.Cards.Count);
            Console.WriteLine(" *******************");

            for (int i = 0; i < turns; i++)
            {
            
                Console.WriteLine("Turn " + (i + 1));
                Card TakenCard = PlayDeck.TakeCard();
                Utility.CardNumberEnum Cenum = (Utility.CardNumberEnum)TakenCard.CardNumber;

                Console.WriteLine("{0} Value {1}", TakenCard.CardName, TakenCard.CardValue);
                Console.WriteLine("*******************");
                Console.WriteLine("Cards Left in Deck - " + PlayDeck.Cards.Count);
            
            }

            Console.WriteLine(" *******************");
            Console.WriteLine(" Resetting the Deck for next game.");

            PlayDeck = PlayDeck.Reset();

            Console.WriteLine(" Total Cards - " + PlayDeck.Cards.Count);
            Console.WriteLine(" *******************");

            Console.ReadLine();
            
        }
    }

    

   

   

   

}
