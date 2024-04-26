using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasyno
{
    public partial class Gapa : Form
    {

        private List<string> deck = new List<string>();
        private List<string> player1 = new List<string>();
        private List<string> player2 = new List<string>();
        private List<string> player3 = new List<string>();
        private List<string> player4 = new List<string>();
        private int round = 1;
        public Gapa()
        {
            InitializeComponent();
            createDeck();
            shuffleDeck();
            division_players();
            gameplay();
        }

        private void createDeck()
        {

            List<string> suits = new List<string> { "♣", "♦", "♥", "♠" };
            List<string> values = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "W", "D", "K", "A" };
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    string curr = value + suit;
                    deck.Add(curr);
                }
            }
        }
        private void shuffleDeck()
        {
            Random rnd = new Random();

            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                string value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        private void division_players()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                int num = i % 4;
                if (num == 0)
                {
                    player1.Add(deck[i]);
                    continue;
                }
                if (num == 1)
                {
                    player2.Add(deck[i]);
                    continue;
                }
                if (num == 2)
                {
                    player3.Add(deck[i]);
                    continue;
                }
                if (num == 3)
                {
                    player4.Add(deck[i]);
                    continue;
                }
            }
        }

        void showDeck(int playerNumber)
        {
            string cards = "";
            if (playerNumber == 1)
            {
                player1.Sort();
                foreach(string card in player1)
                {
                    cards += card +" , ";
                }
                playerLeft.Text = "Player 4";
                playerRight.Text = "Player 2";
                playerTop.Text = "Player 3";
                current_player.Text = "Player " + playerNumber;
                current_deck.Text = cards;
                current_deck.Location = new Point((this.ClientSize.Width - current_deck.Width) / 2, 382 - current_deck.Height / 2);
            }
            else if (playerNumber == 2)
            {
                player2.Sort();
                foreach (string card in player2)
                {
                    cards += card + " , ";
                }
                playerLeft.Text = "Player 1";
                playerRight.Text = "Player 3";
                playerTop.Text = "Player 4";
                current_player.Text = "Player " + playerNumber;
                current_deck.Text = cards;
            }
            else if(playerNumber == 3)
            {
                player3.Sort();
                foreach (string card in player3)
                {
                    cards += card + " , ";
                }
                playerLeft.Text = "Player 2";
                playerRight.Text = "Player 4";
                playerTop.Text = "Player 1";
                current_player.Text = "Player " + playerNumber;
                current_deck.Text = cards;
            }
            else if (playerNumber == 4)
            {
                player4.Sort();
                foreach (string card in player4)
                {
                    cards += card + " , ";
                }
                playerLeft.Text = "Player 3";
                playerRight.Text = "Player 1";
                playerTop.Text = "Player 2";
                current_player.Text = "Player " + playerNumber;
                current_deck.Text = cards;
            }       
        }

        void gameplay()
        {
            showDeck(round);
            round++;
            if(round == 5)
            {
                round = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameplay();
        }
    }
}
