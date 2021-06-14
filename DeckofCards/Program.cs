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

            Console.ReadLine();
            
        }
    }

    

   

   

   

}
