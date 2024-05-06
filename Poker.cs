using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Policy;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
        Dictionary<string, int> handsValue = new Dictionary<string, int>()
        {
            {"High Card",1},
            {"Pair",2},
            {"Two Pair",3},
            {"Three of a Kind",4},
            {"Straight",5},
            {"Flush",6},
            {"Full House",7},
            {"Four of a Kind",8},
            {"Straight Flush",9},
            {"Royal Flush",10}
        };
        Dictionary<string, int> cardsValue = new Dictionary<string, int>()
        {
            {"2",0},
            {"3",1},
            {"4",2},
            {"5",3},
            {"6",4},
            {"7",5},
            {"8",6},
            {"9",7},
            {"10",8},
            {"J",9},
            {"Q",10},
            {"K",11},
            {"A",12}
        };
        private int[] allPlayersMoney = { 0, 0, 0, 0 };
        private int pot = 0;
        int maxBet;
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
            if (betButton.Checked && betPrice.Text != null)
            {
                if(inGame[0])
                {
                    try
                    {
                        betMoney = int.Parse(betPrice.Text);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("zla cena");
                        return;
                    }
                    betPrice.Text = "";
                    if (betMoney >= int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1)))
                    {
                        betMoney = int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1));
                        MessageBox.Show("All in");
                        allPlayersMoney[0] += int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1));
                        player1_money_label.Text = "0$";
                    }
                    else
                    {
                        int currMoney = int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1));
                        allPlayersMoney[0] += betMoney;
                        player1_bet_label.Visible = true;
                        player1_bet_label.Text = betMoney.ToString() + "$";
                        player1_money_label.Text = (currMoney - betMoney).ToString() + "$";
                    }
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
                            delMoney = randomBet.Next(allPlayersMoney[0], currPlayerMoney + 1);
                            player2_bet_label.Text = delMoney.ToString() + "$";
                            player2_bet_label.Visible= true;
                            allPlayersMoney[1] += delMoney;
                            player2_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[1] = false;
                            pass_player2_label.Visible = true;
                        }
                        
                    }
                    else if (chooseBot == 3)
                    {
                        inGame[1] = false;
                        pass_player2_label.Visible = true;
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
                            delMoney = randomBet.Next(1, currPlayerMoney+1);
                            player3_bet_label.Text = delMoney.ToString() + "$";
                            player3_bet_label.Visible = true;
                            allPlayersMoney[2] += delMoney;
                            player3_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[2] = false;
                            pass_player3_label.Visible = true;
                        }
                        
                    }
                    else if (chooseBot == 3)
                    {
                        inGame[2] = false;
                        pass_player3_label.Visible = true;
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
                            delMoney = randomBet.Next(1, currPlayerMoney+1);
                            player4_bet_label.Text = delMoney.ToString() + "$";
                            player4_bet_label.Visible = true;
                            allPlayersMoney[3] += delMoney;
                            player4_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[3]=false;
                            pass_player4_label.Visible = true;
                        } 
                    }
                    else if (chooseBot == 3)
                    {
                        inGame[3] = false;
                        pass_player4_label.Visible = true;
                    }
                }
            }
            else if(checkButton.Checked)
            {
                player1_bet_label.Text = "0$";
                player1_bet_label.Visible = true;
                if (inGame[1])
                {
                    int chooseBot;
                    Random random = new Random();
                    //chooseBot = random.Next(1,3);
                    chooseBot = 0;
                    if (chooseBot == 0)
                    {
                        if (int.Parse(player2_money_label.Text.Substring(0, player2_money_label.Text.Length - 1)) > 0)
                        {
                            int currPlayerMoney = int.Parse(player2_money_label.Text.Substring(0, player2_money_label.Text.Length - 1));
                            int delMoney;
                            Random randomBet = new Random();
                            delMoney = randomBet.Next(1, currPlayerMoney + 1);
                            player2_bet_label.Text = delMoney.ToString() + "$";
                            player2_bet_label.Visible = true;
                            allPlayersMoney[1] += delMoney;
                            player2_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[1] = false;
                            pass_player2_label.Visible = true;
                        }

                    }
                    else if (chooseBot == 3)
                    {
                        inGame[1] = false;
                        pass_player2_label.Visible = true;
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
                            delMoney = randomBet.Next(1, currPlayerMoney + 1);
                            player3_bet_label.Text = delMoney.ToString() + "$";
                            player3_bet_label.Visible = true;
                            allPlayersMoney[2] += delMoney;
                            player3_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[2] = false;
                            pass_player3_label.Visible = true;
                        }

                    }
                    else if (chooseBot == 3)
                    {
                        inGame[2] = false;
                        pass_player3_label.Visible = true;
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
                            delMoney = randomBet.Next(1, currPlayerMoney + 1);
                            player4_bet_label.Text = delMoney.ToString() + "$";
                            player4_bet_label.Visible = true;
                            allPlayersMoney[3] += delMoney;
                            player4_money_label.Text = (currPlayerMoney - delMoney).ToString() + "$";
                        }
                        else
                        {
                            inGame[3] = false;
                            pass_player4_label.Visible = true;
                        }
                    }
                    else if (chooseBot == 3)
                    {
                        inGame[3] = false;
                        pass_player4_label.Visible = true;
                    }
                }
            }
            else if(passButton.Checked)
            {
                inGame[0] = false;
                pass_player1_label.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane");
                return;
            }
            maxBet = allPlayersMoney.Max();
            checkButton.Checked = false;
            betButton.Checked = false;
            passButton.Checked = false;
            if (maxBet > allPlayersMoney[0])
            {
                if (inGame[0])
                {
                    DialogResult result = MessageBox.Show("Czy Dobijasz do stawki?", "Wybór", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int price = int.Parse(player1_money_label.Text.Substring(0, player1_money_label.Text.Length - 1));
                        price += allPlayersMoney[0];
                        player1_money_label.Text = (price - maxBet).ToString() + "$";
                        player1_bet_label.Text = maxBet.ToString();
                        allPlayersMoney[0] = maxBet;
                    }
                    else if (result == DialogResult.No)
                    {
                        inGame[0] = false;
                        pass_player1_label.Visible = true;
                    }
                } 
            }
            if (inGame[1])
            {
                if (maxBet > allPlayersMoney[1])
                {
                    Random rand = new Random();
                    int choose = rand.Next(0, 2);
                    if (choose == 0)
                    {
                        int price = int.Parse(player2_money_label.Text.Substring(0, player2_money_label.Text.Length - 1));
                        price += allPlayersMoney[1];
                        player2_money_label.Text = (price - maxBet).ToString() + "$";
                        player2_bet_label.Text = maxBet.ToString();
                        allPlayersMoney[1] = maxBet;
                    }
                    else
                    {
                        inGame[1] = false;
                        pass_player2_label.Visible = true;
                    }
                }
            }
            if (inGame[2])
            {
                if (maxBet > allPlayersMoney[2])
                {
                    Random rand = new Random();
                    int choose = rand.Next(0, 2);
                    if (choose == 0)
                    {
                        int price = int.Parse(player3_money_label.Text.Substring(0, player3_money_label.Text.Length - 1));
                        price += allPlayersMoney[2];
                        player3_money_label.Text = (price - maxBet).ToString() + "$";
                        player3_bet_label.Text = maxBet.ToString();
                        allPlayersMoney[2] = maxBet;
                    }
                    else
                    {
                        inGame[2] = false;
                        pass_player3_label.Visible = true;
                    }
                }
            }
            if (inGame[3])
            {
                if (maxBet > allPlayersMoney[3])
                {
                    Random rand = new Random();
                    int choose = rand.Next(0, 2);
                    if (choose == 0)
                    {
                        int price = int.Parse(player4_money_label.Text.Substring(0, player4_money_label.Text.Length - 1));
                        price += allPlayersMoney[3];
                        player4_money_label.Text = (price - maxBet).ToString() + "$";
                        player4_bet_label.Text = maxBet.ToString();
                        allPlayersMoney[3] = maxBet;
                    }
                    else
                    {
                        inGame[3] = false;
                        pass_player4_label.Visible = true;
                    }
                }
            }
            int counterPlayers = 0;
            int indexWinner = 0;
            for(int i=0;i<4;i++)
            {
                if (inGame[i])
                {
                    counterPlayers++;
                    indexWinner = i + 1;
                }
            }
            if(counterPlayers == 1)
            {
                MessageBox.Show("Wygrana "+ indexWinner.ToString());
                this.Close();
            }
            if(round==0)
            {
                card1Label.Visible = true;
                card2Label.Visible = true;
                card3Label.Visible = true;
            }
            if(round==1)
            {
                card4Label.Visible= true;
            }
            if(round==2)
            {
                card5Label.Visible= true;
            }
            if(round==3)
            {
                List<string> tableCards = new List<string>();
                tableCards.Add(card1Label.Text);
                tableCards.Add(card2Label.Text);
                tableCards.Add(card3Label.Text);
                tableCards.Add(card4Label.Text);
                tableCards.Add(card5Label.Text);
                List<string> currentDeck = new List<string>(tableCards);
                int max = 0;
                int playerIndex = 0;
                for (int i=0;i<4;i++)
                {
                    if (inGame[i])
                    {
                        switch (i)
                        {
                            case 0:
                                currentDeck.Add(player1Deck[0]);
                                currentDeck.Add(player1Deck[1]);
                                break;
                            case 1:
                                currentDeck.Add(player2Deck[0]);
                                currentDeck.Add(player2Deck[1]);
                                break;
                            case 2:
                                currentDeck.Add(player3Deck[0]);
                                currentDeck.Add(player3Deck[1]);
                                break;
                            case 3:
                                currentDeck.Add(player4Deck[0]);
                                currentDeck.Add(player4Deck[1]);
                                break;
                        }                     
                        string tmp = pokerHands(currentDeck);
                        int value = handsValue[tmp];
                        if (value>max)
                        {
                            max = value;
                            playerIndex = i;
                        }
                        else if(value == max)
                        {
                            //dsjnandjasadsjnsajdnasdjndjnasdjnsadjnjndasasd
                        }
                    }
                    
                }
            }
            for(int i=0;i<allPlayersMoney.Length;i++)
            {
                pot += allPlayersMoney[i];
            }
            MessageBox.Show("Stawka do wygrania " + pot.ToString());
            for (int i = 0; i < allPlayersMoney.Length; i++)
            {
                allPlayersMoney[i] = 0;
            }
            round++;
        }

        private string pokerHands(List<string>deck)
        {
            List<string> playerHand = new List<string>(deck);
            playerHand.Sort();
            if(royalFlush(playerHand))
            {
                return "Royal Flush";
            }
            else if(straightFlush(playerHand))
            {
                return "Straight Flush";
            }
            else if(fourOfaKind(playerHand))
            {
                return "Four of a Kind";
            }
            else if(fullHouse(playerHand))
            {
                return "Full House";
            }
            else if(flush(playerHand))
            {
                return "Flush";
            }
            else if(straight(playerHand))
            {
                return "Straight";
            }
            else if(threeOfaKind(playerHand))
            {
                return "Three of a Kind";
            }
            else if(twoPair(playerHand))
            {
                return "Two Pair";
            }
            else if(pair(playerHand))
            {
                return "Pair";
            }
            else
            {
                return "High Card";
            }   
        }
        private bool pair(List<string> hand)
        {
            for (int i = 0; i < hand.Count - 1; i++)
            {
                string firstCard = hand[i].Substring(0, hand[i].Length - 1);
                string secoundCard = hand[i + 1].Substring(0, hand[i + 1].Length - 1);
                if (firstCard == secoundCard)
                {
                    return true;
                }
            }
            return false;
        }
        private bool twoPair(List<string> hand)
        {
            int pairCounter = 0;
            for(int i=0;i<hand.Count-1;i++)
            {
                string firstCard = hand[i].Substring(0, hand[i].Length-1);
                string secoundCard = hand[i + 1].Substring(0, hand[i + 1].Length - 1);
                if (firstCard == secoundCard)
                {
                    pairCounter++;
                }
            }
            return pairCounter == 2;
        }
        private bool threeOfaKind(List<string> hand)
        {
            Dictionary<char, int> cardCounts = new Dictionary<char, int>();
            foreach (var card in hand)
            {
                char value = card[0];

                if (cardCounts.ContainsKey(value))
                {
                    cardCounts[value]++;
                }
                else
                {
                    cardCounts[value] = 1;
                }
            }
            foreach (var count in cardCounts.Values)
            {
                if (count == 3)
                {
                    return true;
                }
            }
            return false;
        }
        private bool straight(List<string> hand)
        {
            int[] cardsNumber = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; 
            for(int i=0;i<hand.Count;i++)
            {
                string card = hand[i].Substring(0, hand[i].Length-1);
                int value = cardsValue[card];
                cardsNumber[value] +=1;
            }
            for(int i=0;i<9;i++)
            {
                if (cardsNumber[i]==1 && cardsNumber[i+1] == 1 && cardsNumber[i+2] == 1 && cardsNumber[i+3] == 1 && cardsNumber[i+4] == 1 && cardsNumber[i+5] == 1)
                {
                    return true;
                }
            }
            return false;
        }
        private bool flush(List<string> hand)
        {
            string color = hand[0].Substring(hand[0].Length-1);
            for(int i=0;i<hand.Count;i++)
            {
                if(color != hand[i].Substring(hand[i].Length-1))
                {
                    return false;
                }
            }
            return true;
        }
        private bool fullHouse(List<string> hand)
        {
            Dictionary<char, int> cardCounts = new Dictionary<char, int>();
            foreach (var card in hand)
            {
                char value = card[0];

                if (cardCounts.ContainsKey(value))
                {
                    cardCounts[value]++;
                }
                else
                {
                    cardCounts[value] = 1;
                }
            }
            bool hasThreeOfAKind = false;
            bool hasPair = false;
            foreach (var count in cardCounts.Values)
            {
                if (count == 3)
                {
                    hasThreeOfAKind = true;
                }
                else if (count == 2)
                {
                    hasPair = true;
                }
            }
            return hasThreeOfAKind && hasPair;
        }
        private bool fourOfaKind(List<string> hand)
        {
            int counter = 1;
            for(int i=0; i<hand.Count; i++)
            {
                for(int j=0; j < hand.Count;j++)
                {
                    if(i==j)
                    {
                        continue;
                    }
                    if (hand[i].Substring(0,1) == hand[j].Substring(0,1))
                    {
                        counter++;
                    }
                }
                if(counter==4)
                {
                    return true;
                }
                counter = 1;
            }
            return false;
        }
        private bool straightFlush(List<string> hand)
        {
            string[] tab = { "10", "7", "8", "9", "J"};
            string color = hand[0].Substring(hand[0].Length - 1);
            for (int i = 0; i < hand.Count; i++)
            {
                if (!hand[i].Contains(tab[i]) || hand[i].Substring(hand[i].Length - 1) != color)
                {
                    return false;
                }
            }
            return true;
        }
        private bool royalFlush(List<string> hand)
        {
            string[] tab = { "10", "A", "J", "K", "Q" };
            string color = hand[0].Substring(hand[0].Length - 1);
            for (int i = 0; i < hand.Count; i++)
            {
                if (!hand[i].Contains(tab[i]) || hand[i].Substring(hand[i].Length - 1) != color)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
