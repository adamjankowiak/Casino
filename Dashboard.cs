using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        int balance;
        private List<string>deck = new List<string>();
        public Dashboard(Logon log, string username, int money)
        {
            InitializeComponent();
            createDeck();
            logon = log;
            user = username;
            balance = money;
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

        public void change_balance(int new_balance)
        {
            balance = new_balance;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            string[] data = File.ReadAllLines("..\\..\\userdata\\logon.csv");
            string output = "";
            foreach(string line in data)
            {
                string[] split = line.Split(',');
                if(user == split[0])
                {
                    output += split[0] + ',' + split[1] + ',' + balance.ToString() + Environment.NewLine;
                }
                else
                {
                    output += line + Environment.NewLine;
                }
            }
            File.WriteAllText("..\\..\\userdata\\logon.csv", output);
            logon.Close();
        }

        private void blackjack_label_Click(object sender, EventArgs e)
        {
            Blackjack bj = new Blackjack(this);
            this.Hide();
            bj.Show();
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            DontGiveUp dgu = new DontGiveUp(this);
            this.Hide();
            dgu.Show();
        }

        private void gapa_label_Click(object sender, EventArgs e)
        {
            Gapa gapa = new Gapa(this);
            gapa.Show();
        }

        private void poker_label_Click(object sender, EventArgs e)
        {
            Poker poker = new Poker(this);
            poker.Show();
        }

        private void ruletka_label_Click(object sender, EventArgs e)
        {
            Roulette roulette = new Roulette(this, balance);
            this.Hide();
            roulette.Show();
        }

        private void wojna_label_Click(object sender, EventArgs e)
        {
            Wojna wojna = new Wojna(this);
            this.Hide();
            wojna.Show();
        }

        private void info_label_Click(object sender, EventArgs e)
        {

        }

        private void add_credits_label_Click(object sender, EventArgs e)
        {

        }
    }
}
