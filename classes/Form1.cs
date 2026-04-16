using oopTest.classes;
using oopTest.classes.blackJack;
using oopTest.classes.dealer;
using oopTest.classes.player;

namespace oopTest
{

    public partial class Form1 : Form
    {

        blackJack game;
        deck deck;
        player player;
        dealer dealer;

        public Form1()
        {
            InitializeComponent();
            deck = new deck();
            game = new blackJack(deck);
            player = new player();
            dealer = new dealer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deck.Shuffle();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            // create containers for the hands
            //var player = new List<string>();
            //var dealer = new List<string>();
            //player.PlayerHand.Clear();
            //dealer.DealerHand.Clear();

            // deal into those lists
            dealer.DealCards(player.PlayerHand, dealer.DealerHand);

            // inform game of the lists (matches signatures that accept List<string>)


            //var cards = game.Cards();
            //if (cards == null || cards.Count < 3) return;



            if (player.PlayerHand.Count >= 2 && dealer.DealerHand.Count >= 1)
            {
                pictureBoxDealer1.Image = Image.FromFile("Images/" + dealer.DealerHand[0].Image);
                //pictureBoxDealer2.Image = Image.FromFile("Images/back_of_card.png");
                pictureBoxDealer2.Image = Image.FromFile("Images/" + dealer.DealerHand[1].Image);

                pictureBox1Player.Image = Image.FromFile("Images/" + player.PlayerHand[0].Image);
                pictureBox2Player.Image = Image.FromFile("Images/" + player.PlayerHand[1].Image);

            }
            game.Message(dealer.DealerHand);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dealerScore = game.CalculateScore(dealer.DealerHand);
            bool canDealerPlay = game.CanPLayDealer(dealer.DealerHand);
            string result;
            string feedback;
            int hitCount = dealer.hitCount;
            
            
           
            dealer.Hit(dealer.DealerHand);
            // mark that a hit action occurred so trainer can score it
            game.hit = true;
            game.stand = false;
            // recompute dealer score after hit
            dealerScore = game.CalculateScore(dealer.DealerHand);
            game.DealerTrainer(dealer.DealerHand);
            //pictureBoxDealer2.Image = Image.FromFile("Images/" + dealer.DealerHand[1].Image);

            if (hitCount == 0)
            {
                pictureBoxDealer3.Image = Image.FromFile("Images/" + dealer.DealerHand[2].Image);
                dealer.hitCount = 1;
            }
            else if (hitCount == 1)
            {
                pictureBoxDealer4.Image = Image.FromFile("Images/" + dealer.DealerHand[3].Image);

            }

           
            if (dealerScore > 21)
            {
                result = "Dealer bust! speler wint!";
                MessageBox.Show(result);

                // apply trainer scoring for the hit that caused the bust
                game.DealerTrainer(dealer.DealerHand);
                MessageBox.Show($"Trainer points: {game.TrainerPoints}");

                // reset for new round
                ResetRound();
                return;
            }

            // update UI and trainer for this hit
            game.Message(dealer.DealerHand);
            

        }

        private void standButton_Click(object sender, EventArgs e)
        {
            int playerScore = game.CalculateScore(player.PlayerHand);
            int dealerScore = game.CalculateScore(dealer.DealerHand);

            // Dealer speelt

            //while (dealerScore < 17)
            //{
            //    dealer.DealerHand.Add(deck.Cards[0]);
            //    deck.Cards.RemoveAt(0);

            //    dealerScore = game.CalculateScore(dealer.DealerHand);
            //}

            // Laat 2e kaart zien
            //pictureBoxDealer2.Image = Image.FromFile("Images/" + dealer.DealerHand[1].Image);


            Console.WriteLine($"Dealer value: {dealerScore}");
            Console.WriteLine($"Player value: {playerScore}");

            MessageBox.Show($"Dealer value: {dealerScore} Player value: {playerScore}");
            // Winnaar bepalen
            string result;

            if (dealerScore > 21)
                result = "Dealer bust! speler wint!";
            else if (playerScore > dealerScore)
                result = "speler wint!";
            else if (playerScore < dealerScore)
                result = "Dealer wint!";
            else
                result = "Gelijkspel!";
            game.DealerTrainer(dealer.DealerHand);
            MessageBox.Show(result);
            MessageBox.Show(game.TrainerPoints.ToString());
            // reset UI and hands for a new round
            ResetRound();



        }

        // Reset hands, UI and relevant flags to start a new round
        private void ResetRound()
        {
            player.PlayerHand.Clear();
            dealer.DealerHand.Clear();

            // reset picture boxes
            pictureBoxDealer1.Image = null;
            pictureBoxDealer2.Image = null;
            pictureBoxDealer3.Image = null;
            pictureBoxDealer4.Image = null;
            pictureBox1Player.Image = null;
            pictureBox2Player.Image = null;

            // reset counters and flags
            dealer.hitCount = 0;
            game.hit = false;
            game.stand = false;

            // reshuffle deck for a fresh round
            deck.Shuffle();
        }


        private void pictureBox2Player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1Player_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxDealer1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxDealer2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxDealer3_Click(object sender, EventArgs e)
        {

        }
        

        private void pictureBoxDealer4_Click(object sender, EventArgs e)
        {

        }
    }
}
