using System;
using System.Collections.Generic;
using System.Text;

namespace oopTest.classes.blackJack
{
    internal class blackJack
    {
        private deck deck;

        public blackJack(deck deck)
        {
            this.deck = deck;
        }

        public int CalculateScore(List<Card> hand)
        {
            int total = hand.Sum(c => c.Value);

            int aceCount = hand.Count(c => c.Rank == "ace");

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }
    }
}
