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
            deck.DealCards(player.PlayerHand, dealer.DealerHand);

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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dealerScore = game.CalculateScoreOfDealer(dealer.DealerHand);
            string result;


            deck.Hit(dealer.DealerHand);
            //pictureBoxDealer2.Image = Image.FromFile("Images/" + dealer.DealerHand[1].Image);
            pictureBoxDealer3.Image = Image.FromFile("Images/" + dealer.DealerHand[2].Image);

            if (dealerScore > 21)
            {
                result = "Dealer bust! speler wint!";
                MessageBox.Show(result);
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            int playerScore = game.CalculateScoreOfPlayer(player.PlayerHand);
            int dealerScore = game.CalculateScoreOfDealer(dealer.DealerHand);

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

            MessageBox.Show(result);
            player.PlayerHand.Clear();
            dealer.DealerHand.Clear();
            playerScore = 0; dealerScore = 0;
            pictureBoxDealer1.Image = null;
            pictureBoxDealer2.Image = null;
            pictureBoxDealer3.Image = null;


            // Player picture boxes clearen
            pictureBox1Player.Image = null;
            pictureBox2Player.Image = null;



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
    }
}
