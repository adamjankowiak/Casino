using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kasyno
{
    public partial class gra1os : Form
    {
        //Dashboard dashboard;
        Wojna wojna;
        private List<string> deck = new List<string>(/*dashboard.getDeck()*/);
        private List<string> playerDeck = new List<string>();
        private List<string> computerDeck = new List<string>();
        private Dictionary<string, int> cardsValue = new Dictionary<string, int>()
        {
            {"2",2},
            {"3",3},
            {"4",4},
            {"5",5},
            {"6",6},
            {"7",7},
            {"8",8},
            {"9",9},
            {"10",10},
            {"J",11},
            {"Q",12},
            {"K",13},
            {"A",14}
        };
        public gra1os(/*Dashboard dashboard*/ Wojna wojna)
        {
            InitializeComponent();
            //this.dashboard = dashboard;
            this.wojna = wojna;
            createDeck();
            shuffleDeck();
            divisionDeck();
        }
        private void createDeck()
        {
            List<string> suits = new List<string> { "♣", "♦", "♥", "♠" };
            List<string> values = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            foreach (string s in suits)
            {
                foreach (string v in values)
                {
                    string card = v + s;
                    deck.Add(card);
                }
            }
        }
        private void divisionDeck()
        {
            for(int i = 0; i < deck.Count;i++)
            {
                if(i%2==0)
                {
                    playerDeck.Add(deck[i]);
                }
                else
                {
                    computerDeck.Add(deck[i]);
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

        private void bitwa_Button_Click(object sender, EventArgs e)
        {
            score_Player_textbox.Text = playerDeck.Count.ToString();
            score_Computer_textBox.Text = computerDeck.Count.ToString();
            if (playerDeck.Count == 0)
            {
                MessageBox.Show("Computer Win!");
                this.Close();
            }
            if (computerDeck.Count == 0)
            {
                MessageBox.Show("You Win!");
                this.Close();
            }
            List<string> list = new List<string>();
            player_Card_textBox.Text = playerDeck[0];
            computer_Card_textbox.Text = computerDeck[0];
            list.Add(playerDeck[0]);
            list.Add(computerDeck[0]);
            playerDeck.Remove(playerDeck[0]);
            computerDeck.Remove(computerDeck[0]);
            if (cardsValue[list[0].Substring(0, list[0].Length-1)] > cardsValue[list[1].Substring(0, list[1].Length - 1)])
            {
                MessageBox.Show("You Win!");
                foreach(string card in list)
                {
                    playerDeck.Add(card);
                }
                list.Clear();
            }
            else if(cardsValue[list[0].Substring(0, list[0].Length - 1)] < cardsValue[list[1].Substring(0, list[1].Length - 1)])
            {
                MessageBox.Show("Computer Win!");
                foreach (string card in list)
                {
                    computerDeck.Add(card);
                }
                list.Clear();
            }
            else if(cardsValue[list[0].Substring(0, list[0].Length - 1)] == cardsValue[list[1].Substring(0, list[1].Length - 1)])
            {
                if (playerDeck.Count == 0)
                {
                    MessageBox.Show("Computer Win!");
                    this.Close();
                }
                if (computerDeck.Count == 0)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                }
                MessageBox.Show("Remis");
                int playerCounter = 0;
                int computerCounter = 0;
                while(playerCounter == computerCounter)
                {
                    list.Add(playerDeck[0]);
                    list.Add(computerDeck[0]);
                    if (playerDeck.Count == 0)
                    {
                        MessageBox.Show("Computer Win!");
                        this.Close();
                    }
                    if (computerDeck.Count == 0)
                    {
                        MessageBox.Show("You Win!");
                        this.Close();
                    }
                    playerDeck.Remove(playerDeck[0]);
                    computerDeck.Remove(computerDeck[0]);
                    if (playerDeck.Count == 0)
                    {
                        MessageBox.Show("Computer Win!");
                        this.Close();
                    }
                    if (computerDeck.Count == 0)
                    {
                        MessageBox.Show("You Win!");
                        this.Close();
                    }
                    list.Add(playerDeck[0]);
                    list.Add(computerDeck[0]);
                    player_Card_textBox.Text = list[list.Count-2];
                    computer_Card_textbox.Text = list[list.Count-1];
                    if (cardsValue[player_Card_textBox.Text.Substring(0, player_Card_textBox.Text.Length-1)] > cardsValue[computer_Card_textbox.Text.Substring(0, computer_Card_textbox.Text.Length - 1)])
                    {
                        MessageBox.Show("You Win!");
                        playerCounter = 1;
                        foreach (string card in list)
                        {
                            playerDeck.Add(card);
                        }
                    }
                    if(cardsValue[player_Card_textBox.Text.Substring(0, computer_Card_textbox.Text.Length - 1)] < cardsValue[computer_Card_textbox.Text.Substring(0, player_Card_textBox.Text.Length - 1)])
                    {
                        MessageBox.Show("Computer Win!");
                        computerCounter = 1;
                        foreach (string card in list)
                        {
                            computerDeck.Add(card);
                        }
                    }
                }
            }
            score_Player_textbox.Text = playerDeck.Count.ToString();
            score_Computer_textBox.Text = computerDeck.Count.ToString();
        }

        private void gra1os_FormClosed(object sender, FormClosedEventArgs e)
        {
            wojna.Show();
        }
    }
}
