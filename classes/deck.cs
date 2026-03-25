using oopTest.classes.dealer;
using oopTest.classes.player;
using System;
using System.Collections.Generic;
using System.Text;
//using oopTest.classes.dealer;
using System.Linq;
using oopTest.classes;

namespace oopTest.classes
{
    
    internal class deck
    {

        public deck()
        {
            CreateDeck();
            Shuffle();
        }
        string[] suits = { "hearts", "diamonds", "clubs", "spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
        public List<string> Cards { get; set; } = new List<string>();
     
            
        public void CreateDeck()
        {
            foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Cards.Add($"{rank}_of_{suit}");
            }
         }
        }



        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = Cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);

                var temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
           
        }

        public void DealCards(List<string> playerHand, List<string> dealerHand)
        {
            if (Cards.Count < 4)
                throw new Exception("Niet genoeg kaarten!");

            for (int i = 0; i < 2; i++)
            {
                playerHand.Add(Cards[0]);
                Cards.RemoveAt(0);
            }

            for (int i = 0; i < 2; i++)
            {
                dealerHand.Add(Cards[0]);
                Cards.RemoveAt(0);
            }
        }
    }
}
