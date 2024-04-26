using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Gapa()
        {
            InitializeComponent();
            createDeck();
            shuffleDeck();
            division_players();
        }

        private void createDeck()
        {
            List<string> suits = new List<string> { "Trefl", "Karo", "Kier", "Pik" };
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
            for(int i = 0;i < deck.Count; i++)
            {
                int num = i % 4;
                if(num == 0)
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
}
