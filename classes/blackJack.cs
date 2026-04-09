using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using oopTest.classes.dealer;
using oopTest.classes.player;

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
        public void Message(List<Card> PlayerHand, List<Card> DealerHand)
        {
            if (CalculateScore(DealerHand) >= 17)
                {
                    if (CalculateScore(DealerHand) == 21)
                    {
                        MessageBox.Show("it would be wise if you stand");
                    }
                    else
                    {
                        MessageBox.Show("wow you are super lucky dont take a risk like this to mush");
                    }
            } 
            else if (CalculateScore(DealerHand) < 17)
                {
                    MessageBox.Show("it would be wise if you hit");
            }

        }
    }
}
//if (dealerScore >= 17 && dealerScore < 21)
//{
//    if (dealerScore == 21)
//    {
//        feedback = "wow you are super lucky dont take a risk like this to mush";
//    }
//    else
//    {
//        feedback = "you are lucky it would be wise to stand now";
//    }

//    MessageBox.Show(feedback);

//}