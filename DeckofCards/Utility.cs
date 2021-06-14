using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    class Utility
    {
        public enum CardNumberEnum
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }


        public static Dictionary<string, int> CardValues = new Dictionary<string, int>()
        {
            {"Ace", 1},
            {"Two", 2},
            {"Four", 4},
            {"Five", 5},
            {"Seven", 7},
            {"Eight", 8},
            { "Nine", 9},
            {"Ten", 10},
            {"Jack", 10},
            { "Queen", 10},
            { "King", 10},

        };

       

    }
}
