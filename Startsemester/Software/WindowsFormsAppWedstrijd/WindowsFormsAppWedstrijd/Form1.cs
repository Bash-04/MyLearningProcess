using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWedstrijd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int randomFromDeck;
        int kaart;

        int[] deck = new int[52] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        int[] dealtCards = new int[52];
        int dealtCounter;

        List<int> dealerHand = new List<int>();
        List<int> playerHand = new List<int>();
        int playerCounter;
        int dealerCounter;

        int sum;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            dealtCounter = 0;
            playerCounter = 0;
            dealerCounter = 0;
            StartGame();
        }

        public void StartGame()
        {
            lbDealer.Items.Clear();
            lbPlayer.Items.Clear();
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    randomKaart();
                    while (dealtCards.Contains(randomFromDeck) == true)
                    {
                        randomKaart();
                    }
                    dealCard(lbDealer, dealerHand, dealerCounter);
                }

                randomKaart();
                while (dealtCards.Contains(randomFromDeck) == true)
                {
                    randomKaart();
                }
                dealCard(lbPlayer, playerHand, playerCounter);
            }

            totalWorth(dealerHand);
            aasCheck(dealerHand);
            lblDealerTotal.Text = Convert.ToString(sum);

            totalWorth(playerHand);
            aasCheck(playerHand);
            lblPlayerTotal.Text = Convert.ToString(sum);

            checkWorth();
        }

        public void randomKaart()
        {
            randomFromDeck = random.Next(0, deck.Length);
            kaart = deck[randomFromDeck];
        }

        public void dealCard(ListBox choose, List<int> person, int counter)
        {
            if (dealtCards.Contains(randomFromDeck) == false)
            {
                if (person == dealerHand)
                {
                    counter = dealerCounter;
                }
                else if (person == playerHand)
                {
                    counter = playerCounter;
                }
                person.Add(kaart);
                choose.Items.Add(kaart);
                dealtCards[dealtCounter] = randomFromDeck;
                dealtCounter++;
                counter++;
                if (person == dealerHand)
                {
                    dealerCounter = counter;
                    return;
                }
                else if(person == playerHand)
                {
                    playerCounter = counter;
                    return;
                }
            }
        }

        public void aasCheck(List<int> person)
        {
            if (sum <= 11)
            {
                for (int i = 0; i < person.Count(); i++)
                {
                    if (person[i] == 1)
                    {
                        person[i] = 11;

                        totalWorth(person);

                        if (person == dealerHand)
                        {
                            lbDealer.Items.Clear();
                            for (int j = 0; j < person.Count(); j++)
                            {
                                lbDealer.Items.Add(person[j]);
                            }
                        }
                        else if (person == playerHand)
                        {
                            lbPlayer.Items.Clear();
                            for (int j = 0; j < person.Count(); j++)
                            {
                                lbPlayer.Items.Add(person[j]);
                            }
                        }
                        return;
                    }
                }
            }
        }

        public void totalWorth(List<int> person)
        {
            sum = 0;

            for (int i = 0; i < person.Count(); i++)
            {
                sum = sum + person[i];
            }
        }

        public void checkWorth()
        {
            if (Convert.ToInt32(lblPlayerTotal.Text) == 21)
            {
                MessageBox.Show("YOU'VE GOT BLACKJACK");
                reset();
            }
            else if (Convert.ToInt32(lblDealerTotal.Text) == 21)
            {
                MessageBox.Show("THE DEALER HAS BLACKJACK");
                reset();
            }
            if (Convert.ToInt32(lblPlayerTotal.Text) > 21)
            {
                MessageBox.Show("YOU BUST");
                reset();
            }
            else if(Convert.ToInt32(lblDealerTotal.Text) > 21)
            {
                MessageBox.Show("DEALER BUST");
                reset();
            }
        }

        void reset()
        {
            Array.Clear(dealtCards, 0, 52);
            dealerHand.Clear();
            playerHand.Clear();
            btnStart.Visible = true;
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (Convert.ToInt32(lblDealerTotal.Text) < 17)
            {
                randomKaart();
                while (dealtCards.Contains(randomFromDeck) == true)
                {
                    randomKaart();
                }
                dealCard(lbDealer, dealerHand, dealerCounter);

                totalWorth(dealerHand);
                lblDealerTotal.Text = Convert.ToString(sum);

                checkWorth();
                aasCheck(dealerHand);
            } 

            if (Convert.ToInt32(lblPlayerTotal.Text) < Convert.ToInt32(lblDealerTotal.Text) && Convert.ToInt32(lblDealerTotal.Text) <= 21)
            {
                MessageBox.Show("YOU HAVE LOST");
                reset();
            }
            else if(Convert.ToInt32(lblPlayerTotal.Text) == Convert.ToInt32(lblDealerTotal.Text))
            {
                MessageBox.Show("YOU HAVE DRAWN");
                reset();
            }
            else
            {
                MessageBox.Show("YOU HAVE WON");
                reset();
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            randomKaart();
            while (dealtCards.Contains(randomFromDeck) == true)
            {
                randomKaart();
            }
            dealCard(lbPlayer, playerHand, playerCounter);

            totalWorth(playerHand);
            lblPlayerTotal.Text = Convert.ToString(sum);

            checkWorth();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < 2; i++)
            {
                if (playerHand[0] == playerHand[1])
                {
                    randomKaart();
                    dealCard(lbPlayer, playerHand, playerCounter);
                    checkWorth();
                }
                else
                {
                    checkWorth();
                    return;
                }
            }*/
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            reset();
        }

        #region onzin
        private void lbDealer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDealerTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerTotal_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
