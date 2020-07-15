/* Poker Game v1
 *
 * GNU Public License v2
 *
 * davebowlin@gmail.com
 * __________________________*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Poker_Game
{
    public partial class formMain : Form
    {
        /* class-wide declarations */
        public Image[] cards = LoadCards.cards; // array to hold our card faces
        public Image[] cardbacks = new Image[6]; // array to hold the card backs
        public Random r = new Random(Guid.NewGuid().GetHashCode()); // generate randoms based on random seeds
        public List<int> values; // holds the values of our shuffled cards
        public Timer timer = new Timer(); // generic timer for start screen animations, etc
        public string statusMessage = "Welcome to Poker Game :)"; // status label used to display text information
        public int display = 0; // counter for displaying the face cards
        public int value1, value2, value3; // holds the values of the displayed cards for comparison
        public int bet, house, player, remaining = 0; // counters for money and cards remaining in deck
        public SoundPlayer sound = new SoundPlayer();

        public formMain()
        {
            InitializeComponent();

            card1.Parent = picTransparent; // a picturebox with a transparent image is used as the parent
            card2.Parent = picTransparent; // of whatever picturebox that needs to be transparent.
            card3.Parent = picTransparent; // stack the "child" picturebox on top of the "parent" one.
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            PlaySound("startup");
            labelStatus.Text = statusMessage;
            LoadCards.GetImages(); // calls the method to load the cards into the array
            CardBacks();
            Animate(750, 1);
        }

        // Start screen animation
        public void Animate(int v, int c) // v is the timer interval, c is start or stop timer
        {
            timer.Interval = v;
            timer.Tick += new EventHandler(Animate_Tick);

            if (c == 1)
            {
                timer.Start();
                panelBet.Enabled = false;
                buttonNewGame.BringToFront();
            }
            else
            {
                timer.Stop();
                timer.Dispose();
                panelBet.Enabled = true;
            }
        }

        private void PlaySound(string v)
        {
            switch (v)
            {
                case "startup":
                    sound = new SoundPlayer(Properties.Resources.startup);
                    break;

                case "startnewgame":
                    sound = new SoundPlayer(Properties.Resources.startnewgame);
                    break;

                case "bet":
                    sound = new SoundPlayer(Properties.Resources.bet);
                    break;

                case "deal":
                    sound = new SoundPlayer(Properties.Resources.deal);
                    break;

                case "doubleloss":
                    sound = new SoundPlayer(Properties.Resources.doubleloss);
                    break;

                case "losehand":
                    sound = new SoundPlayer(Properties.Resources.losehand);
                    break;

                case "lost":
                    sound = new SoundPlayer(Properties.Resources.lost);
                    break;

                case "shuffle":
                    sound = new SoundPlayer(Properties.Resources.shuffle);
                    break;

                case "win":
                    sound = new SoundPlayer(Properties.Resources.win);
                    break;

                case "winhand":
                    sound = new SoundPlayer(Properties.Resources.winhand);
                    break;

                default:
                    break;
            }
            sound.Stop();
            sound.Play();
            sound.Dispose();
        }

        private void Animate_Tick(object sender, EventArgs e)
        {
            card1.Image = cardbacks[r.Next(6)];
            card2.Image = cardbacks[r.Next(6)];
            card3.Image = cardbacks[r.Next(6)];
        }

        public void CardBacks()
        {
            Image bg1 = Properties.Resources.blue;
            Image bg2 = Properties.Resources.gray;
            Image bg3 = Properties.Resources.red;
            Image bg4 = Properties.Resources.yellow;
            Image bg5 = Properties.Resources.green;
            Image bg6 = Properties.Resources.purple;

            cardbacks[0] = bg1;
            cardbacks[1] = bg2;
            cardbacks[2] = bg3;
            cardbacks[3] = bg4;
            cardbacks[4] = bg5;
            cardbacks[5] = bg6;
        }

        // shuffle the cards
        private void Shuffle()
        {
            PlaySound("shuffle");
            labelStatus.Text = "Shuffling The Deck...";
            values = ShuffleCards.Shuffle();
            labelRemaining.Text = values.Count.ToString();
            genericTimer.Start();
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            PlaySound("deal");
            DisplayCards();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            PlaySound("startnewgame");
            startNewGame();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            display = 0;
            DisplayCards();
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        // Bet amounts
        private void button100_Click(object sender, EventArgs e)
        {
            AddBet(100);
        }

        private void buttonTwenty_Click(object sender, EventArgs e)
        {
            AddBet(20);
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            AddBet(5);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            AddBet(1);
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            bet = 0;

            if (house >= (player / 2))
            {
                AddBet(player / 2);
            }
            else
            {
                labelStatus.Text = "The house can't cover that bet. Try again.";
            }
        }

        private void genericTimer_Tick(object sender, EventArgs e)
        {
            labelStatus.Text = "Ready.";
            buttonDeal.BringToFront();
            genericTimer.Stop();

            DisplayCards();
        }

        private void startNewGame()
        {
            // set defaults for the new game, stop animation, and shuffle the cards
            player = 50;
            house = 950;
            bet = 0;

            PlaySound("startnewgame");
            UpdateAmounts();

            Animate(750, 2);
            Shuffle();
            panelBet.Enabled = true;
        }

        // update the amounts after the bets, check for winner and loser
        private void UpdateAmounts()
        {
            labelPlayer.Text = player.ToString("#,##");
            labelHouse.Text = house.ToString("#,##");
            labelBet.Text = bet.ToString("#,##");

            if (house <= 0)
            {
                Animate(750, 1);
                buttonNewGame.BringToFront();
                panelBet.Enabled = false;

                PlaySound("win");

                labelStatus.Text = "You beat the house! Congratulations, Champ! :)";
            }

            if (player <= 0)
            {
                Animate(750, 1);
                buttonNewGame.BringToFront();
                panelBet.Enabled = false;

                PlaySound("lost");

                labelStatus.Text = "You lost all your money. Play again?";
            }
        }

        // deal the cards, display them, etc
        private void DisplayCards()
        {
            if ((player > 0) && (house > 0))
            {
                display++;
                PlaySound("deal");
                labelRemaining.Text = values.Count.ToString();

                if ((display == 1) && (values.Count > 5))
                {
                    card3.Image = cardbacks[r.Next(6)];

                    // display card1
                    int card1Value = ShuffleCards.Draw();
                    card1.Image = cards[card1Value];
                    value1 = ShuffleCards.GetValues(card1Value);

                    // check if card1 is an ace, and ask player for input
                    if (value1 == 14)
                    {
                        DialogResult result = MessageBox.Show("You have been dealt an Ace first. Special instructions:"
                            + Environment.NewLine + Environment.NewLine + "Should this Ace be High?   Yes = 14, No = 1"
                            + Environment.NewLine + "(Aces are High by default.)", "High or Low",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            value1 = 1;
                        }
                    }

                    // display card2
                    int card2Value = ShuffleCards.Draw();
                    card2.Image = cards[card2Value];
                    value2 = ShuffleCards.GetValues(card2Value);

                    labelStatus.Text = "Bet or Pass?";

                    // code here to show the bet window and wait for instructions from player
                }
                else if (display == 2)
                {
                    // display card3
                    int card3Value = ShuffleCards.Draw();
                    card3.Image = cards[card3Value];
                    value3 = ShuffleCards.GetValues(card3Value);

                    // check the results
                    string result = GetResults.Results(value1, value2, value3);
                    switch (result)
                    {
                        case "winhand":
                            PlaySound("winhand");
                            house -= bet;
                            player += bet;
                            labelStatus.Text = "Winner - $" + bet + " added to your funds!";
                            break;

                        case "doubleloss":
                            PlaySound("doubleloss");
                            bet = bet * 2;
                            house += bet;
                            player -= bet;
                            labelStatus.Text = "Double Loss! $" + bet + " transferred to the house.";
                            break;

                        case "losthand":
                            PlaySound("losehand");
                            house += bet;
                            player -= bet;
                            labelStatus.Text = "Loss - $" + bet + " transferred to the house.";
                            break;

                        default:
                            break;
                    }

                    bet = 0;
                    display = 0;
                    UpdateAmounts();

                    if ((house > 0) && (player > 0))
                    {
                        genericTimer.Start();
                    }
                }
                else
                {
                    buttonShuffle.BringToFront();
                    labelStatus.Text = "Shuffle the deck to continue.";
                }
            }
        }

        // check the bet amounts, etc
        private void AddBet(int v)
        {
            int tempBet = bet;
            if (player > 1)
            {
                if ((tempBet + v) <= (player / 2))
                {
                    bet = tempBet + v;
                    labelBet.Text = bet.ToString("#,##");
                }
                else
                {
                    labelStatus.Text = "You don't have enough to cover that bet.";
                }
            }
            else
            {
                bet = 1;
                labelBet.Text = "1";
            }
        }
    }
}