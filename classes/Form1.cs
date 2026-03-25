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
            player.PlayerHand.Clear();
            dealer.DealerHand.Clear();
            // deal into those lists
            deck.DealCards(player.PlayerHand, dealer.DealerHand);

            // inform game of the lists (matches signatures that accept List<string>)


            //var cards = game.Cards();
            //if (cards == null || cards.Count < 3) return;



            if (player.PlayerHand.Count >= 2 && dealer.DealerHand.Count >= 1)
            {
                pictureBoxDealer1.Image = Image.FromFile("Images/" + dealer.DealerHand[0] + ".png");
                pictureBoxDealer2.Image = Image.FromFile("Images/back_of_card.png");
                //pictureBoxDealer2.Image = Image.FromFile("Images/" + dealer.DealerHand[1] + ".png");

                pictureBox1Player.Image = Image.FromFile("Images/" + player.PlayerHand[0] + ".png");
                pictureBox2Player.Image = Image.FromFile("Images/" + player.PlayerHand[1] + ".png");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
