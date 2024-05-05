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
    public partial class Poker : Form
    {
        List<string> deck = new List<string>();
        List<string> player1Deck = new List<string>();
        List<string> player2Deck = new List<string>();
        List<string> player3Deck = new List<string>();
        List<string> player4Deck = new List<string>();
        List<bool>   inGame = new List<bool> {true,true,true,true};
        int current_players = 4;
        string startingMoney = "500$";
        string player1Money;
        string player2Money;
        string player3Money;
        string player4Money;
        int round = 0;
        Dictionary<string, int> CardsValue = new Dictionary<string, int>()
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
        public Poker(Dashboard dashboard)
        {
            InitializeComponent();
            player1Money = startingMoney;
            player2Money = startingMoney;
            player3Money = startingMoney;
            player4Money = startingMoney;
            player1_money_label.Text = player1Money + "$";
            player2_money_label.Text = player2Money + "$";
            player3_money_label.Text = player3Money + "$";
            player4_money_label.Text = player4Money + "$";
            deck=dashboard.deck;
            shuffleDeck();
            GetCards();
            CardOnTable();
        }

        private void pokerStartButton_Click(object sender, EventArgs e)
        {
            pokerStartButton.Visible = false;
            poker_info_button.Visible = false;
            player1_label.Visible = true;
            player2_label.Visible = true;
            player3_label.Visible = true;
            player4_label.Visible = true;
            player1_deck_left.Visible = true;
            player1_deck_right.Visible = true;
            player1_money_text.Visible = true;
            player1_money_label.Visible = true;
            player1_money_label.Text = startingMoney;
            player2_money_text.Visible = true;
            player2_money_label.Visible = true;
            player2_money_label.Text = startingMoney;
            player3_money_text.Visible = true;
            player3_money_label.Visible = true;
            player3_money_label.Text = startingMoney;
            player4_money_text.Visible = true;
            player4_money_label.Visible = true;
            player4_money_label.Text = startingMoney;
            betButton.Visible = true;
            checkButton.Visible = true;
            passButton.Visible = true;
            betPrice.Visible = true;
            acceptButton.Visible = true;
        }

        private void poker_info_button_Click(object sender, EventArgs e)
        {

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
        private void GetCards()
        {
            for (int i = 0; i < 2*current_players; i++)
            {
                int num = i % 4;
                if (num == 0)
                {
                    player1Deck.Add(this.deck[0]);
                    deck.Remove(player1Deck[player1Deck.Count - 1]);
                    continue;
                }
                if (num == 1)
                {
                    player2Deck.Add(this.deck[0]);
                    deck.Remove(player2Deck[player2Deck.Count - 1]);
                    continue;
                }
                if (num == 2)
                {
                    player3Deck.Add(this.deck[0]);
                    deck.Remove(player3Deck[player3Deck.Count - 1]);
                    continue;
                }
                if (num == 3)
                {
                    player4Deck.Add(this.deck[0]);
                    deck.Remove(player4Deck[player4Deck.Count - 1]);
                    continue;
                }
            }
            player1_deck_left.Text = player1Deck[0];
            if (player1Deck[0].Contains("♣") || player1Deck[0].Contains("♠"))
            {
                player1_deck_left.ForeColor = Color.Black;
            }
            else
            {
                player1_deck_left.ForeColor = Color.Red;
            }
            player1_deck_right.Text = player1Deck[1];
            if (player1Deck[0].Contains("♣") || player1Deck[0].Contains("♠"))
            {
                player1_deck_right.ForeColor = Color.Black;
            }
            else
            {
                player1_deck_right.ForeColor = Color.Red;
            }
        }

        private void CardOnTable()
        {
            card1Label.Text = deck[0];
            if (deck[0].Contains("♣") || deck[0].Contains("♠"))
            {
                card1Label.ForeColor = Color.Black;
            }
            else
            {
                card1Label.ForeColor = Color.Red;
            }
            card2Label.Text = deck[1];
            if (deck[1].Contains("♣") || deck[1].Contains("♠"))
            {
                card2Label.ForeColor = Color.Black;
            }
            else
            {
                card2Label.ForeColor = Color.Red;
            }
            card3Label.Text = deck[2];
            if (deck[2].Contains("♣") || deck[2].Contains("♠"))
            {
                card3Label.ForeColor = Color.Black;
            }
            else
            {
                card3Label.ForeColor = Color.Red;
            }
            card4Label.Text = deck[3];
            if (deck[3].Contains("♣") || deck[3].Contains("♠"))
            {
                card3Label.ForeColor = Color.Black;
            }
            else
            {
                card3Label.ForeColor = Color.Red;
            }
            card5Label.Text = deck[4];
            if (deck[4].Contains("♣") || deck[4].Contains("♠"))
            {
                card4Label.ForeColor = Color.Black;
            }
            else
            {
                card4Label.ForeColor = Color.Red;
            }
            deck.Remove(deck[0]);
            deck.Remove(deck[1]);
            deck.Remove(deck[2]);
            deck.Remove(deck[3]);
            deck.Remove(deck[4]);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            int betMoney;
            int []allMoney = {0,0,0,0};
            if (betButton.Checked && betPrice.Text != null)
            {
                try
                {
                    betMoney = int.Parse(betPrice.Text);

                }catch (Exception ex) {
                    MessageBox.Show("zla cena");
                    return;
                }
                if (betMoney >= int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1)))
                {
                    betMoney = int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1));
                    MessageBox.Show("All in");
                    allMoney[0] += int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1));
                    player1_money_label.Text = "0$";
                }
                else
                {
                    int currMoney = int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1));
                    allMoney[0] += betMoney;
                    player1_money_label.Text = (currMoney-betMoney).ToString()+"$";
                }
                if (inGame[1])
                {
                    int chooseBot;
                    Random random = new Random();
                    //chooseBot = random.Next(1,3);
                    chooseBot = 0;
                    if (chooseBot == 0)
                    {
                        if(int.Parse(player2_money_label.Text.Substring(0, player2_money_label.Text.Length - 1))>0)
                        {
                            int currPlayerMoney = int.Parse(player2_money_label.Text.Substring(0, player2_money_label.Text.Length - 1));
                            int delMoney;
                            Random randomBet = new Random();
                            delMoney = randomBet.Next(allMoney[0], currPlayerMoney + 1);
                            allMoney[1] += delMoney;
                            player2_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[1] = false;
                        }
                        
                    }
                    else if (chooseBot == 3)
                    {
                        inGame[1] = false;
                    }
                }
                if (inGame[2])
                {
                    int chooseBot;
                    Random random = new Random();
                    //chooseBot = random.Next(1, 3);
                    chooseBot = 0;
                    if (chooseBot == 0)
                    {
                        if (int.Parse(player3_money_label.Text.Substring(0, player3_money_label.Text.Length - 1)) > 0)
                        {
                            int currPlayerMoney = int.Parse(player3_money_label.Text.Substring(0, player3_money_label.Text.Length - 1));
                            int delMoney;
                            Random randomBet = new Random();
                            delMoney = randomBet.Next(allMoney[1], currPlayerMoney+1);
                            allMoney[2] += delMoney;
                            player3_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[2] = false;
                        }
                        
                    }
                    else if (chooseBot == 3)
                    {
                        inGame[2] = false;
                    }
                }
                if (inGame[3])
                {
                    int chooseBot;
                    Random random = new Random();
                    //chooseBot = random.Next(1, 3);
                    chooseBot = 0;
                    if (chooseBot == 0)
                    {

                        if (int.Parse(player4_money_label.Text.Substring(0, player4_money_label.Text.Length - 1)) > 0)
                        {
                            int currPlayerMoney = int.Parse(player4_money_label.Text.Substring(0, player4_money_label.Text.Length - 1));
                            int delMoney;
                            Random randomBet = new Random();
                            delMoney = randomBet.Next(allMoney[2], currPlayerMoney+1);
                            allMoney[3] += delMoney;
                            player4_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[3]=false;
                        } 
                    }
                    else if (chooseBot == 3)
                    {
                        inGame[3] = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Niepoprawne dane");
                return;
            }
            int maxBet = allMoney.Max();
            
            string pulla="";
            for(int i = 0;i<4;i++)
            {
                pulla += allMoney[i].ToString() + "\n";
            }
            MessageBox.Show(pulla);
        }
    }
}
