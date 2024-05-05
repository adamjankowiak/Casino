using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        Dictionary<string, string> winningLine = new Dictionary<string, string>()
        {
            {"A","AAAA"},
            {"K","KKKK"},
            {"Q","QQQQ"},
            {"J","JJJJ"}
        };
        bool win = false;
        public Gapa(Dashboard dashboard)
        {
            InitializeComponent();
            Image image = Image.FromFile("..\\..\\Resources\\Table.jpg");
            this.BackgroundImage = image;
            playerTop.Location = new Point(365, 26);
            radioPikButton.BackColor= SystemColors.Control;
            radioKierButton.BackColor = SystemColors.Control;
            radioKaroButton.BackColor = SystemColors.Control;
            radioTreflButton.BackColor = SystemColors.Control;
            this.deck = dashboard.getDeck();
            modifyDeck();
            shuffleDeck();
            division_players();
        }

        private void modifyDeck()
        {
            List<string>tempdeck = new List<string>();
            for(int i = 0;i<this.deck.Count;i++)
            {
                if (this.deck[i].Substring(0,1)=="A" || this.deck[i].Substring(0, 1) == "K" || this.deck[i].Substring(0, 1) == "Q" || this.deck[i].Substring(0, 1) == "J")
                {
                    tempdeck.Add(this.deck[i]);
                }
            }
            this.deck=tempdeck;
        }

        private void EndGame(string playerName)
        {
            if(win)
            {
                //axWindowsMediaPlayer1_Enter(this, EventArgs.Empty);
                MessageBox.Show(playerName + " Win!");
                this.Close();
            }
            else
            {
                return;
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

        private void division_players()
        {
            for (int i = 0; i < this.deck.Count; i++)
            {
                int num = i % 4;
                if (num == 0)
                {
                    player1.Add(this.deck[i]);
                    continue;
                }
                if (num == 1)
                {
                    player2.Add(this.deck[i]);
                    continue;
                }
                if (num == 2)
                {
                    player3.Add(this.deck[i]);
                    continue;
                }
                if (num == 3)
                {
                    player4.Add(this.deck[i]);
                    continue;
                }
            }
        }

        void showDeck()
        {
            string cards = "";
            player1.Sort();
            foreach(string card in player1)
            {
                if(card == player1.Last())
                {
                    cards += card;
                }
                else
                {
                    cards += card + " , ";
                }      
            }
            current_deck.Text = cards;
            current_deck.Location = new Point((this.ClientSize.Width - current_deck.Width) / 2-15, 382 - current_deck.Height / 2);
            cards = "";
            player2.Sort();
            foreach (string card in player2)
            {
                if (card == player2.Last())
                {
                    cards += card;
                }
                else
                {
                    cards += card + " , ";
                }
            }
            player2_Deck.Text = cards;
            cards = "";
            player3.Sort();
            foreach (string card in player3)
            {
                if (card == player3.Last())
                {
                    cards += card;
                }
                else
                {
                    cards += card + " , ";
                }
            }
            player3_deck.Text = cards;
            cards = "";
            player4.Sort();
            foreach (string card in player4)
            {
                if (card == player4.Last())
                {
                    cards += card;
                }
                else
                {
                    cards += card + " , ";
                }
            }
            player4_deck.Text = cards;

        }

        void gameplay()
        {
            showDeck();
            Select_card_text.Visible=true;
            selected_card.Visible = true;
            radioPikButton.Visible = true;
            radioKierButton.Visible = true;
            radioKaroButton.Visible=true;
            radioTreflButton.Visible = true;
            button_Start.Visible = false;
            acceptButton.Visible = true;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            gameplay();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string selectedCardFromDeck = selected_card.Text.ToUpper();
            if(selectedCardFromDeck == "WIN")
            {
                win = true;
                EndGame("Test");
            }
            if (radioPikButton.Checked && selectedCardFromDeck!="")
            {
                selectedCardFromDeck += "♠";
            }
            else if (radioKierButton.Checked && selectedCardFromDeck != "")
            {
                selectedCardFromDeck += "♥";
            }
            else if (radioKaroButton.Checked && selectedCardFromDeck != "")
            {
                selectedCardFromDeck += "♦";
            }
            else if (radioTreflButton.Checked && selectedCardFromDeck != "")
            {
                selectedCardFromDeck += "♣";
                
            }
            else if(radioPikButton.Checked == false && radioKierButton.Checked==false && radioKaroButton.Checked==false && radioTreflButton.Checked==false)
            {
                MessageBox.Show("Nie wybrano koloru");
                return;
            }
            else if(selectedCardFromDeck == "")
            {
                MessageBox.Show("Nie wybrano karty");
                return;
            }
            selected_card.Text = selectedCardFromDeck;
            if (selected_card.Text != "")
            {
                MessageBox.Show("Wybrano " + selected_card.Text);
                if(player1.Contains(selected_card.Text))
                {
                    string currplayerCard = selected_card.Text;
                    player1.Remove(currplayerCard);
                    string player2Card = "";
                    string player3Card = "";
                    string player4Card = "";
                    Random random = new Random();
                    int card_chosen = random.Next(0,player2.Count);
                    player2Card = player2[card_chosen];
                    player2.Remove(player2Card);
                    card_chosen = random.Next(0, player3.Count);
                    player3Card = player3[card_chosen];
                    player3.Remove(player3Card);
                    card_chosen = random.Next(0, player4.Count);
                    player4Card = player4[card_chosen];
                    player4.Remove(player4Card);
                    player1.Add(player2Card);
                    player2.Add(player3Card);
                    player3.Add(player4Card);
                    player4.Add(currplayerCard);
                    showDeck();
                    string playerCards = "";
                    string combination = "";
                    for (int i = 0;i<player1.Count;i++)
                    {
                        playerCards += player1[i].Substring(0, 1);
                        if(playerCards.Length == 1)
                        {
                            combination = winningLine[playerCards];
                        }
                    }
                    if(playerCards == combination)
                    {
                        win = true;
                        EndGame(current_player.Text);
                    }
                    playerCards = "";
                    combination = "";
                    for (int i = 0; i < player2.Count; i++)
                    {
                        playerCards += player2[i].Substring(0, 1);
                        if (playerCards.Length == 1)
                        {
                            combination = winningLine[playerCards];
                        }
                    }
                    if (playerCards == combination)
                    {
                        win = true;
                        EndGame(playerRight.Text);
                    }
                    playerCards = "";
                    combination = "";
                    for (int i = 0; i < player3.Count; i++)
                    {
                        playerCards += player3[i].Substring(0, 1);
                        if (playerCards.Length == 1)
                        {
                            combination = winningLine[playerCards];
                        }
                    }
                    if (playerCards == combination)
                    {
                        win = true;
                        EndGame(playerTop.Text);
                    }
                    playerCards = "";
                    combination = "";
                    for (int i = 0; i < player4.Count; i++)
                    {
                        playerCards += player4[i].Substring(0, 1);
                        if (playerCards.Length == 1)
                        {
                            combination = winningLine[playerCards];
                        }
                    }
                    if (playerCards == combination)
                    {
                        win = true;
                        EndGame(playerLeft.Text);
                    }
                    selected_card.Text = "";
                }
                else
                {
                    MessageBox.Show("Nie ma takiej karty w twojej talii");
                    selected_card.Text = "";
                }
            }
            else
            {
                return;
            }
            selected_card.Text = "";
        }
        /*

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            VideoWin.Visible = true;
            string filepath = "C:\\Users\\mjwoj\\Desktop\\FIlm.mp4";
            VideoWin.URL=filepath;
            VideoWin.Size = new System.Drawing.Size(853, 521);
            VideoWin.Location = new System.Drawing.Point(-16, -1);
        }
        */
    }
}
