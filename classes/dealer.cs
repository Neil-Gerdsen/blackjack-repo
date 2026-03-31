using System;
using System.Collections.Generic;
using System.Text;
using oopTest.classes;

namespace oopTest.classes.dealer
{
    
    internal class dealer
    {
        Card card = new Card();
        public List<Card> DealerHand { get; set; } = new List<Card>();
        bool hit; 
        bool stand;
        bool suffle;
        bool endOfGame;
        //int totalValue = 0;


        //static void Hit(List<Card> deck, List<Card> hand)
        //{
        //    hand.Add(deck[0]);
        //    deck.RemoveAt(0);
        //    //int total = hand.Sum(c => c.Value);

        //    //if (total > 21 && hand.Any(c => c.Rank == "ace"))
        //    //{
        //    //    total -= 10;
        //    //}
        //}

        public void dealerHandCards()
        {
            int totalValue = DealerHand.Sum(card => card.Value);

            int aceCount = DealerHand.Count(card => card.Rank == "ace");

            while (totalValue > 21 && aceCount > 0)
            {
                totalValue -= 10;
                aceCount--;
            }

            //return totalValue;
        
        }    
        //static void Stand()
        //{
        //    stand = true;
        //    endOfGame = true;

            


        //}

    }
}
