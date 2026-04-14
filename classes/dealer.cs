using oopTest.classes;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace oopTest.classes.dealer
{
    
    internal class dealer
    {
        deck deck;
        public int hitCount { get; set; } = 0;

        public dealer() {

            deck = new deck();



        }
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

        public void Hit(List<Card> DealerHand)
        {
            if (deck.Cards.Count == 0)
                throw new Exception("Geen kaarten meer in het deck!");
            DealerHand.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
            //MessageBox.Show(DealerHand());
        }
        public void DealCards(List<Card> playerHand, List<Card> dealerHand)
        {
            if (deck.Cards.Count < 4)
                throw new Exception("Niet genoeg kaarten!");

            for (int i = 0; i < 2; i++)
            {
                playerHand.Add(deck.Cards[0]);
                deck.Cards.RemoveAt(0);
            }

            for (int i = 0; i < 2; i++)
            {
                dealerHand.Add(deck.Cards[0]);
                deck.Cards.RemoveAt(0);
            }

        }
    }
}
