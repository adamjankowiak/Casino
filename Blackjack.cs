﻿using System;
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
            newGame();
        }
        private void Blackjack_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard.Show();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = false;
            start_button.Visible = false;
            playercards_label.Visible = true;
            dealercards_label.Visible = true;
            hit_button.Visible = true;
            stand_button.Visible = true;
            
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
            dealersHand.Add(deck[0]);
            deck.Remove(deck[0]);
            dealercardSum += cardsValue[dealersHand[0].Substring(0, dealersHand[0].Length - 1)];
            playercards_label.Text = playerHand[0];
            dealercards_label.Text = dealersHand[0];

        }

        private void newGame()
        {
            
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

    }
}


