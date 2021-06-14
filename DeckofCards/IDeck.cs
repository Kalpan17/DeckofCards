using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    public interface IDeck
    {
        Card TakeCard();
        void Shuffle();
        
        Deck Reset();
    }
}
