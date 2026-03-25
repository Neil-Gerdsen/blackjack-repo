using System;
using System.Collections.Generic;
using System.Text;

namespace oopTest.classes.dealer
{
    internal class dealer
    {
        public List<string> DealerHand { get; set; } = new List<string>();
        bool hit; 
        bool stand;
        bool suffle;
        static void Hit(List<string> deck, List<string> hand)
        {
            hand.Add(deck[0]);
            deck.RemoveAt(0);
        }

    }
}
