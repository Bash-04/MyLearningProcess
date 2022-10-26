using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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

        int[] deck = new int[52] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        int[] dealtCards = new int[52];
        int dealtCounter;

        List<int> dealerHand = new List<int>();
        List<int> playerHand = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            StartGame();
            dealtCounter = 0;
        }

        public void StartGame()
        {
            for (int i = 0; i < 2; i++)
            {
                randomKaart(dealerHand);

                randomKaart(playerHand);
            }

            int totalDealer = totalWorth(dealerHand);
            aasCheck(dealerHand, totalDealer);
            totalDealer = totalWorth(dealerHand);
            lblDealerTotal.Text = Convert.ToString(totalDealer - dealerHand[1]);

            lbDealer.Items.Clear();
            for (int i = 0; i < dealerHand.Count(); i++)
            {
                if (i != 1)
                {
                    lbDealer.Items.Add(dealerHand[i]);
                }
            }

            int totalPlayer = totalWorth(playerHand);
            aasCheck(playerHand, totalPlayer);
            totalPlayer = totalWorth(playerHand);
            lblPlayerTotal.Text = Convert.ToString(totalPlayer);

            lbPlayer.Items.Clear();
            for (int i = 0; i < playerHand.Count(); i++)
            {
                lbPlayer.Items.Add(playerHand[i]);
            }

            checkWorth();
        }

        public void randomKaart(List<int> person)
        {
            int kaart = 0;
            bool checkBool = false;
            while (checkBool == false)
            {
                randomFromDeck = random.Next(0, deck.Length);
                if (dealtCards.Contains(randomFromDeck) == false)
                {
                    dealtCards[dealtCounter] = randomFromDeck;
                    dealtCounter++;
                    checkBool = true;
                }
            }
            kaart = deck[randomFromDeck];
            person.Add(kaart);
        }

        public void aasCheck(List<int> person, int handWorth)
        {
            if (handWorth <= 11)
            {
                for (int i = 0; i < person.Count(); i++)
                {
                    if (person[i] == 1)
                    {
                        if (person == dealerHand)
                        {
                            dealerHand[i] = 11;
                        }
                        else if (person == playerHand)
                        {
                            playerHand[i] = 11;
                        }
                        return;
                    }
                }
            }
            if (handWorth > 21)
            {
                for (int i = 0; i < person.Count(); i++)
                {
                    if (person[i] == 11)
                    {
                        person[i] = 1;

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

        public int totalWorth(List<int> person)
        {
            int sum = 0;

            for (int i = 0; i < person.Count(); i++)
            {
                sum = sum + person[i];
            }
            return sum;
        }

        public void checkWorth()
        {
            int totalDealer = totalWorth(dealerHand);
            int totalPlayer = totalWorth(playerHand);

            if (totalPlayer == 21 && playerHand.Count == 2)
            {
                lblDealerTotal.Text = Convert.ToString(totalDealer);
                lbDealer.Items.Clear();
                for (int i = 0; i < dealerHand.Count(); i++)
                {
                    lbDealer.Items.Add(dealerHand[i]);
                }
                MessageBox.Show("YOU'VE GOT BLACKJACK");
                reset();
            }
            else if (totalDealer == 21 && dealerHand.Count == 2)
            {
                lblDealerTotal.Text = Convert.ToString(totalDealer);
                lbDealer.Items.Clear();
                for (int i = 0; i < dealerHand.Count(); i++)
                {
                    lbDealer.Items.Add(dealerHand[i]);
                }
                MessageBox.Show("THE DEALER HAS BLACKJACK");
                reset();
            }
            else if (totalPlayer > 21)
            {
                aasCheck(playerHand, totalPlayer);
                totalPlayer = totalWorth(playerHand);
                lblPlayerTotal.Text = Convert.ToString(totalPlayer);
                if (totalPlayer > 21)
                {
                    MessageBox.Show("YOU BUST");
                    reset();
                }
            }
            else if (totalDealer > 21)
            {
                aasCheck(dealerHand, totalDealer);
                totalDealer = totalWorth(dealerHand);
                lblDealerTotal.Text = Convert.ToString(totalDealer);
                if (totalDealer > 21)
                {
                    MessageBox.Show("DEALER BUST");
                    reset();
                }
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
            int totalDealer = totalWorth(dealerHand);
            int totalPlayer = totalWorth(playerHand);
            while (totalDealer < 17)
            {
                randomKaart(dealerHand);

                lblDealerTotal.Text = Convert.ToString(totalDealer - dealerHand[1]);

                lbDealer.Items.Clear();
                for (int i = 0; i < dealerHand.Count(); i++)
                {
                    lbDealer.Items.Add(dealerHand[i]);
                }

                aasCheck(dealerHand, totalDealer);
                totalDealer = totalWorth(dealerHand);
            }

            lblDealerTotal.Text = Convert.ToString(totalDealer);
            lbDealer.Items.Clear();
            for (int i = 0; i < dealerHand.Count(); i++)
            {
                lbDealer.Items.Add(dealerHand[i]);
            }

            if (totalPlayer < totalDealer && totalDealer <= 21)
            {
                MessageBox.Show("YOU HAVE LOST");
                reset();
            }
            else if (totalPlayer == totalDealer)
            {
                MessageBox.Show("THE DEALER GET'S THE OVERHAND! YOU'VE LOST.");
                reset();
            }
            else if (totalPlayer <= 21)
            {
                MessageBox.Show("YOU HAVE WON");
                reset();
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            randomKaart(playerHand);

            int totalPlayer = totalWorth(playerHand);
            aasCheck(playerHand, totalPlayer);
            totalPlayer = totalWorth(playerHand);
            lblPlayerTotal.Text = Convert.ToString(totalPlayer);

            lbPlayer.Items.Clear();
            for (int i = 0; i < playerHand.Count(); i++)
            {
                lbPlayer.Items.Add(playerHand[i]);
            }

            checkWorth();
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

        private void lblDealtCards_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
