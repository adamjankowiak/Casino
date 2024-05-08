using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasyno
{
    public partial class Blackjack : Form
    {
        Dashboard dashboard;
        int playercardSum = 0;
        int dealercardSum = 0;
        private List<string> deck = new List<string>();
        private List<string> playerHand = new List<string>();
        private List<string> dealersHand = new List<string>();
        private Dictionary<string,int> cardsValue = new Dictionary<string, int>()
        {
            {"2",2},{"3",3}, {"4",4}, {"5",5}, {"6",6},{"7",7},{"8",8},{"9",9},{"10",10},
            {"J",10},{"Q",10},{"K",10},{"A",11}
        };
        
        public Blackjack(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
            //this.balance = balance;
            //this.username = username;
            //player_label.Text = username.ToString();
            //balance_value_label.Text = balance.ToString();

        }
        private void Blackjack_FormClosed(object sender, FormClosedEventArgs e)
        {
            //dashboard.change_balance(balance);
            dashboard.Show();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(bet_textBox.Text))
            {
                MessageBox.Show("Input bet amount", "Input bet amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newGame();
                start_button.Enabled = false;
                start_button.Visible = false;
                playercards_label.Visible = true;
                dealercards_label.Visible = true;
                hit_button.Visible = true;
                stand_button.Visible = true;
            }
        }
        private void shuffleDeck()
        {
            Random rnd = new Random();

            int n = this.deck.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                string value = deck[k];
                this.deck[k] = deck[n];
                this.deck[n] = value;
            }
        }

        private void firstDeal()
        {
            playerHand.Add(deck[0]);
            deck.Remove(deck[0]);
            playercardSum += cardsValue[playerHand[0].Substring(0, playerHand[0].Length-1)];
            player_points_value_label.Text = playercardSum.ToString();
            dealersHand.Add(deck[0]);
            deck.Remove(deck[0]);
            dealercardSum += cardsValue[dealersHand[0].Substring(0, dealersHand[0].Length - 1)];
            dealer_points_value_label.Text = dealercardSum.ToString();
            playercards_label.Text = playerHand[0];
            dealercards_label.Text = dealersHand[0];

        }

        private void newGame()
        {
            //bet_value_label.Text = betValue.ToString();
            //balance_value_label.Text = balance.ToString();
            this.deck = dashboard.getDeck();
            shuffleDeck();
            playercardSum = 0;
            dealercardSum = 0;
            player_points_value_label.Text = "0";
            dealer_points_value_label.Text = "0";
            playercards_label.Text = null;
            dealercards_label.Text = null;
            playerHand.Clear();
            dealersHand.Clear();
            firstDeal();
        }
        

        private void hit_button_Click(object sender, EventArgs e)
        {
            playerHand.Add(deck[0]);
            deck.Remove(deck[0]);
            playercardSum += cardsValue[playerHand[playerHand.Count-1].Substring(0, playerHand[playerHand.Count-1].Length - 1)];
            player_points_value_label.Text = playercardSum.ToString();
            playercards_label.Text += " " + playerHand[playerHand.Count - 1];
            if (playercardSum > 21)
            {
                for (int i = 0; i < playerHand.Count; i++)
                {
                    if (playerHand[i].Substring(0, playerHand[i].Length - 1) == "A")
                    {
                        playercardSum -= 10;
                        player_points_value_label.Text = playercardSum.ToString();
                        playerHand.RemoveAt(i);
                        break;
                    }
                }
                if(playercardSum > 21)
                {
                    MessageBox.Show("You lost", "You lost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newGame();
                }
            }
            if (playercardSum == 21)
            {
                MessageBox.Show("YOU WIN", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newGame();
            }
            
        }

        private void stand_button_Click(object sender, EventArgs e)
        {
            do
            {
                dealersHand.Add(deck[0]);
                deck.Remove(deck[0]);
                dealercardSum += cardsValue[dealersHand[dealersHand.Count - 1].Substring(0, dealersHand[dealersHand.Count - 1].Length - 1)];
                dealer_points_value_label.Text = dealercardSum.ToString();
                dealercards_label.Text += " " + dealersHand[dealersHand.Count - 1];
                if (dealercardSum > 21)
                {
                    for (int i = 0; i < dealersHand.Count; i++)
                    {
                        if (dealersHand[i].Substring(0, dealersHand[i].Length - 1) == "A")
                        {
                            dealercardSum -= 10;
                            dealer_points_value_label.Text = dealercardSum.ToString();
                            dealersHand.RemoveAt(i);
                            break;
                        }
                    }
                    if (dealercardSum > 21)
                    {
                        MessageBox.Show("YOU WIN", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        newGame();
                        break;
                    }
                }
                if (dealercardSum == 21)
                {
                    MessageBox.Show("You lost", "You lost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newGame();
                    break;
                }
                if (dealercardSum < 21 && dealercardSum > playercardSum)
                {
                    MessageBox.Show("You lost", "You lost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newGame();
                    break;
                }

            } while (dealercardSum<21);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /*
        private void place_bet_button_Click(object sender, EventArgs e)
        {
            if(int.Parse(bet_textBox.Text) > balance)
            {
                MessageBox.Show("You dont have enough money to bet", "You dont have enough money to bet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if you've managed too fool casino
            if(int.Parse(bet_textBox.Text) < 0)
            {
                MessageBox.Show("You cant fool casino", "You cant fool casino", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(balance >= 100)
                {
                    MessageBox.Show("Penalty -100", "Penalty -100", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            //no you havent
        }
        */
    }
}


