using oopTest.classes.dealer;
using oopTest.classes.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace oopTest.classes.blackJack
{
    internal class blackJack
    {
        private deck deck;
        public bool canPlay { get; set; } = true;
        public bool stand { get; set; } = false;
        public bool hit { get; set; } = false;
        public int TrainerPoints { get; set; } = 0;
        private bool originalAdviceWasHit = false;

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
            int dealerTotal = DealerHand.Sum(c => c.Value);

            int aceCount = DealerHand.Count(c => c.Rank == "ace");

            while (dealerTotal > 21 && aceCount > 0)
            {
                dealerTotal -= 10;
                aceCount--;
            }



            return dealerTotal;
        }
        public void Message( List<Card> DealerHand)
        {
            int dealerScore = CalculateScore(DealerHand);

            if (dealerScore >= 17)
            {
                originalAdviceWasHit = false;
                if (dealerScore <= 21)
                {
                    MessageBox.Show("it would be wise if you stand");
                }
                else if (dealerScore == 21)
                {
                    MessageBox.Show("wow you are super lucky dont take a risk like this to mush");
                }
            }
            else if (dealerScore < 17)
            {
                originalAdviceWasHit = true;
                MessageBox.Show("it would be wise if you hit");
            }
        }

        public bool CanPLayDealer(List<Card> DealerHand)
        {


            if (CalculateScore(DealerHand) > 21)
            {
                canPlay = false;
                MessageBox.Show("Player win dealer bust");
            }

            return canPlay;

        }
        public void DealerTrainer(List<Card> DealerHand)
        {
            // Calculate dealer score once
            int score = CalculateScore(DealerHand);

            if (stand)
            {
                // Player chose to stand
                if (originalAdviceWasHit)
                {
                    // Message advised HIT, but you stood against advice -> penalize
                    TrainerPoints -= 20;
                }
                else
                {
                    // Message advised STAND, you followed it -> reward based on outcome
                    if (score <= 16)
                    {
                        // Shouldn't have stood (dealer too low) -> penalize
                        TrainerPoints -= 20;
                    }
                    else if (score == 17)
                    {
                        TrainerPoints += 30;
                    }
                    else
                    {
                        TrainerPoints += 20;
                    }
                }
                // reset flag after scoring
                stand = false;
            }
            else if (hit)
            {
                // Player chose to hit
                if (originalAdviceWasHit)
                {
                    // Message advised HIT, you followed it -> reward
                    if (score <= 21)
                    {
                        TrainerPoints += 20;
                    }
                    else
                    {
                        // Bust (over 21)
                        TrainerPoints -= 15;
                    }
                }
                else
                {
                    // Message advised STAND, but you hit against advice -> penalize
                    TrainerPoints -= 15;
                }
                // reset flag after scoring
                hit = false;
            }
        }
    }
}