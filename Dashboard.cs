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
    public partial class Dashboard : Form
    {
        string user = "";
        Logon logon = new Logon();
        private List<string>deck = new List<string>();
        public Dashboard(Logon log, string username)
        {
            InitializeComponent();
            createDeck();
            logon = log;
            user = username;
        }
        private void createDeck()
        {
            List<string> suits = new List<string> { "♣", "♦", "♥", "♠" };
            List<string> values = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10","J", "Q", "K", "A" };
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    string curr = value + suit;
                    deck.Add(curr);
                }
            }
        }
        public List<string> getDeck()
        {
            List<string> tempDeck = new List<string>();
            for (int i = 0; i < this.deck.Count; i++)
            {
                tempDeck.Add(this.deck[i]);
            }
            return tempDeck;
        }

        public void SetUser(string username)
        {
            user = username;
        }
        private void wojna_button_Click(object sender, EventArgs e)
        {

        }

        private void blackjack_button_Click(object sender, EventArgs e)
        {
            Blackjack bj = new Blackjack(this);
            this.Hide();
            bj.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            logon.Close();
        }

        private void gapa_button_Click(object sender, EventArgs e)
        {
            Gapa gapa = new Gapa(this);
            gapa.Show();
        }

        private void pokerButton_Click(object sender, EventArgs e)
        {
            Poker poker = new Poker(this);
            poker.Show();
        }
    }


}
