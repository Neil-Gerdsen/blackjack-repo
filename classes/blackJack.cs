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

        public int CalculateScoreOfDealer(List<Card> DealerHand)
        {
            int total = DealerHand.Sum(c => c.Value);

            int aceCount = DealerHand.Count(c => c.Rank == "ace");

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }
        public int CalculateScoreOfPlayer(List<Card> PlayerHand)
        {
            int total = PlayerHand.Sum(c => c.Value);

            int aceCount = PlayerHand.Count(c => c.Rank == "ace");

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }
    }
}
