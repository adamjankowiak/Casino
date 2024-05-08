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
using System.Runtime.CompilerServices;

namespace Kasyno
{
    public partial class Poker : Form
    {
        List<string> deck = new List<string>();
        List<string> player1Deck = new List<string>();
        List<string> player2Deck = new List<string>();
        List<string> player3Deck = new List<string>();
        List<string> player4Deck = new List<string>();
        List<bool> inGame = new List<bool> { true, true, true, true };
        int current_players = 4;
        string startingMoney = "500$";
        string player1Money;
        string player2Money;
        string player3Money;
        string player4Money;
        //int round = 0;
        int round = 3;
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
        Dictionary<string, int> colorsValue = new Dictionary<string, int>()
        {
            {"♣",1},
            {"♦",2},
            {"♥",3},
            {"♠",4}
        };
        private int[] allPlayersMoney = { 0, 0, 0, 0 };
        private int pot = 0;
        int maxBet;
        Winner winner = new Winner();
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
            deck = dashboard.deck;
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
            for (int i = 0; i < 2 * current_players; i++)
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
            if (player1Deck[1].Contains("♣") || player1Deck[1].Contains("♠"))
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
                card4Label.ForeColor = Color.Black;
            }
            else
            {
                card4Label.ForeColor = Color.Red;
            }
            card5Label.Text = deck[4];
            if (deck[4].Contains("♣") || deck[4].Contains("♠"))
            {
                card5Label.ForeColor = Color.Black;
            }
            else
            {
                card5Label.ForeColor = Color.Red;
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
                if (inGame[0])
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
                        player1_bet_label.Text = betMoney.ToString() + "$";
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
                        if (int.Parse(player2_money_label.Text.Substring(0, player2_money_label.Text.Length - 1)) > 0)
                        {
                            int currPlayerMoney = int.Parse(player2_money_label.Text.Substring(0, player2_money_label.Text.Length - 1));
                            int delMoney;
                            Random randomBet = new Random();
                            delMoney = randomBet.Next(allPlayersMoney[0], currPlayerMoney + 1);
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
            else if (checkButton.Checked)
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
            else if (passButton.Checked)
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
                        player1_bet_label.Text = maxBet.ToString() + "$";
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
                        player2_bet_label.Text = maxBet.ToString() + "$";
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
                        player3_bet_label.Text = maxBet.ToString() + "$";
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
                        player4_bet_label.Text = maxBet.ToString() + "$";
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
            for (int i = 0; i < 4; i++)
            {
                if (inGame[i])
                {
                    counterPlayers++;
                    indexWinner = i + 1;
                }
            }
            if (counterPlayers == 1)
            {
                MessageBox.Show("Wygrana Gracza " + indexWinner.ToString());
                this.Close();
            }
            if (round == 0)
            {
                card1Label.Visible = true;
                card2Label.Visible = true;
                card3Label.Visible = true;
            }
            if (round == 1)
            {
                card4Label.Visible = true;
            }
            if (round == 2)
            {
                card5Label.Visible = true;
            }
            if (round == 3)
            {
                /*
                List<string> tableCards = new List<string>();
                tableCards.Add(card1Label.Text);
                tableCards.Add(card2Label.Text);
                tableCards.Add(card3Label.Text);
                tableCards.Add(card4Label.Text);
                tableCards.Add(card5Label.Text);
                List<string> currentDeck = new List<string>();
                for(int i=0;i< tableCards.Count;i++)
                {
                    currentDeck.Add(tableCards[i]);
                }
                */
                int max = 0;
                //int playerIndex = 0;
                //♠ ♥ ♦ ♣
                List<string> currentDeck = new List<string> { "A♣", "K♣", "10♣", "9♣", "8♣", "7♣", "6♣" };
                string WinnerHandCards = "";
                for (int i = 0; i < 4; i++)
                {
                    if (inGame[i])
                    {
                        /*
                        if(i==0)
                        {
                            currentDeck.Add(player1Deck[0]);
                            currentDeck.Add(player1Deck[1]);
                        }
                        if(i==1)
                        {
                            currentDeck.Add(player2Deck[0]);
                            currentDeck.Add(player2Deck[1]);
                        }
                        if(i==2)
                        {
                            currentDeck.Add(player3Deck[0]);
                            currentDeck.Add(player3Deck[1]);
                        }
                        if(i==3)
                        {
                            currentDeck.Add(player4Deck[0]);
                            currentDeck.Add(player4Deck[1]);
                        }
                        */
                        string tmp = pokerHands(currentDeck);
                        MessageBox.Show(tmp);
                        int value = handsValue[tmp];
                        if (value > max)
                        {
                            WinnerHandCards = tmp;
                            max = value;
                            winner.setWinnerCards(currentDeck);
                        }
                        else if (value == max)
                        {
                            List<string> currentWinnerCards = new List<string>(winner.getWinnerCards());
                            if (tmp == "High Card")
                            {
                                string highestCard = "2♣";
                                foreach (string currentCard in currentWinnerCards)
                                {
                                    string cardValue = currentCard.Substring(0, currentCard.Length - 1);
                                    int currentCardValue = cardsValue[cardValue];
                                    if (cardsValue[highestCard.Substring(0, highestCard.Length - 1)] < currentCardValue)
                                    {
                                        highestCard = currentCard;
                                    }
                                    else if (cardsValue[highestCard.Substring(0, highestCard.Length - 1)] == currentCardValue)
                                    {
                                        string color = currentCard.Substring(currentCard.Length - 1);
                                        int colorCardValue = colorsValue[color];
                                        if (colorsValue[highestCard.Substring(highestCard.Length - 1)] < colorCardValue)
                                        {
                                            highestCard = currentCard;
                                        }
                                    }
                                }
                                string currenthighestCard = "2♣";
                                foreach (string currentCard in currentDeck)
                                {
                                    string cardValue = currentCard.Substring(0, currentCard.Length - 1);
                                    int currentCardValue = cardsValue[cardValue];
                                    if (cardsValue[currenthighestCard.Substring(0, currenthighestCard.Length - 1)] < currentCardValue)
                                    {
                                        currenthighestCard = currentCard;
                                    }
                                    else if (cardsValue[currenthighestCard.Substring(0, currenthighestCard.Length - 1)] == currentCardValue)
                                    {
                                        string color = currentCard.Substring(currentCard.Length - 1);
                                        int colorCardValue = colorsValue[color];
                                        if (colorsValue[currenthighestCard.Substring(currenthighestCard.Length - 1)] < colorCardValue)
                                        {
                                            currenthighestCard = currentCard;
                                        }
                                    }
                                }
                                if (cardsValue[currenthighestCard.Substring(0, currenthighestCard.Length - 1)] > cardsValue[highestCard.Substring(0, highestCard.Length - 1)])
                                {
                                    winner.setWinnerCards(currentDeck);
                                }
                                else if (cardsValue[currenthighestCard.Substring(0, currenthighestCard.Length - 1)] == cardsValue[highestCard.Substring(0, highestCard.Length - 1)])
                                {
                                    if (colorsValue[currenthighestCard.Substring(currenthighestCard.Length - 1)] > colorsValue[highestCard.Substring(highestCard.Length - 1)])
                                    {
                                        winner.setWinnerCards(currentDeck);
                                    }
                                }
                            }
                            if (tmp == "Pair")
                            {
                                bool found = false;
                                List<string> currentHighestPair = new List<string>();
                                List<string> potentialHighestPair = new List<string>();
                                for (int j = 0; j < currentWinnerCards.Count - 1; j++)
                                {
                                    for (int k = j + 1; k < currentWinnerCards.Count; k++)
                                    {
                                        if (currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[k].Substring(0, currentWinnerCards[k].Length - 1))
                                        {
                                            currentHighestPair.Add(currentWinnerCards[j]);
                                            currentHighestPair.Add(currentWinnerCards[k]);
                                            found = true;
                                            break;
                                        }
                                    }
                                    if (found)
                                    {
                                        break;
                                    }
                                }
                                found = false;
                                for (int j = 0; j < currentDeck.Count - 1; j++)
                                {
                                    for (int k = j + 1; k < currentDeck.Count; k++)
                                    {
                                        if (currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[k].Substring(0, currentDeck[k].Length - 1))
                                        {
                                            potentialHighestPair.Add(currentDeck[j]);
                                            potentialHighestPair.Add(currentDeck[k]);
                                            found = true;
                                            break;
                                        }
                                        if (found)
                                        {
                                            break;
                                        }
                                    }
                                }
                                string firstPlayerFirstCard = currentHighestPair[0];
                                string firstPlayerSecondCard = currentHighestPair[1];
                                string secoundPlayerFirstCard = potentialHighestPair[0];
                                string secoundPlayerSecoundtCard = potentialHighestPair[1];
                                if (firstPlayerFirstCard.Substring(0, firstPlayerFirstCard.Length - 1) == secoundPlayerFirstCard.Substring(0, secoundPlayerFirstCard.Length - 1))
                                {
                                    if (secoundPlayerFirstCard.Contains("♠") || secoundPlayerSecoundtCard.Contains("♠"))
                                    {
                                        winner.setWinnerCards(currentDeck);
                                    }
                                }
                                else if (cardsValue[firstPlayerFirstCard.Substring(0, firstPlayerFirstCard.Length - 1)] < cardsValue[secoundPlayerFirstCard.Substring(0, secoundPlayerFirstCard.Length - 1)])
                                {
                                    winner.setWinnerCards(currentDeck);
                                }
                            }
                            if (tmp == "Two Pair")
                            {
                                List<string> currentHighestDoublePair = new List<string>();
                                List<string> potentialHighestDoublePair = new List<string>();
                                for (int j = 0; j < currentWinnerCards.Count - 1; j++)
                                {
                                    for (int k = j + 1; k < currentWinnerCards.Count; k++)
                                    {
                                        if (currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[k].Substring(0, currentWinnerCards[k].Length - 1))
                                        {
                                            currentHighestDoublePair.Add(currentWinnerCards[j]);
                                            currentHighestDoublePair.Add(currentWinnerCards[k]);
                                        }
                                    }
                                }
                                for (int j = 0; j < currentDeck.Count - 1; j++)
                                {
                                    for (int k = j + 1; k < currentDeck.Count; k++)
                                    {
                                        if (currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[k].Substring(0, currentDeck[k].Length - 1))
                                        {
                                            potentialHighestDoublePair.Add(currentDeck[j]);
                                            potentialHighestDoublePair.Add(currentDeck[k]);
                                        }
                                    }
                                }
                                string currHighest = currentHighestDoublePair[0];
                                string potHighest = potentialHighestDoublePair[0];
                                string currSmallest="";
                                string potSmallest="";
                                foreach(string card in currentHighestDoublePair)
                                {
                                    if (cardsValue[card.Substring(0, card.Length - 1)] >= cardsValue[currHighest.Substring(0, currHighest.Length-1)])
                                    {
                                        currHighest = card;
                                    }
                                    else
                                    {
                                        currSmallest = card;
                                    }
                                }
                                foreach (string card in potentialHighestDoublePair)
                                {
                                    if (cardsValue[card.Substring(0, card.Length - 1)] >= cardsValue[potHighest.Substring(0, potHighest.Length-1)])
                                    {
                                        potHighest = card;
                                    }
                                    else
                                    {
                                        potSmallest = card;
                                    }
                                }
                                if (cardsValue[potHighest.Substring(0,potHighest.Length-1)] > cardsValue[currHighest.Substring(0, currHighest.Length-1)])
                                {
                                    winner.setWinnerCards(currentDeck);
                                }
                                else if(cardsValue[potHighest.Substring(0,potHighest.Length - 1)] == cardsValue[currHighest.Substring(0, currHighest.Length - 1)])
                                {
                                    if (cardsValue[potSmallest.Substring(0, potSmallest.Length-1)] > cardsValue[currSmallest.Substring(0, currSmallest.Length - 1)])
                                    {
                                        winner.setWinnerCards(currentDeck);
                                    }
                                    else if(cardsValue[potSmallest.Substring(0, potSmallest.Length - 1)] == cardsValue[currSmallest.Substring(0, currSmallest.Length - 1)])
                                    {
                                        if(potentialHighestDoublePair.Contains("♠"))
                                        {
                                            winner.setWinnerCards(currentDeck);
                                        }
                                    }
                                }

                            }
                            if (tmp == "Three of a Kind")
                            {
                                List<string> currHighest = new List<string>();
                                List<string> potHighest = new List<string>();
                                bool found = false;
                                for (int j = 0; j < currentWinnerCards.Count - 3; j++)
                                {
                                    for (int k = j + 1; k < currentWinnerCards.Count - 2; k++)
                                    {
                                        for (int l = k + 1; l < currentWinnerCards.Count; l++)
                                        {
                                            if (currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[k].Substring(0, currentWinnerCards[k].Length - 1) && currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[l].Substring(0, currentWinnerCards[l].Length - 1))
                                            {
                                                found = true;
                                                currHighest.Add(currentDeck[j]);
                                                currHighest.Add(currentDeck[k]);
                                                currHighest.Add(currentDeck[l]);
                                                break;

                                            }
                                        }
                                        if (found)
                                        {
                                            break;
                                        }
                                    }
                                    if (found)
                                    {
                                        break;
                                    }
                                }
                                found = false;
                                for (int j = 0; j < currentDeck.Count - 3; j++)
                                {
                                    for (int k = j + 1; k < currentDeck.Count - 2; k++)
                                    {
                                        for (int l = k + 1; l < currentDeck.Count; l++)
                                        {
                                            if (currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[k].Substring(0, currentDeck[k].Length - 1) && currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[l].Substring(0, currentDeck[l].Length - 1))
                                            {
                                                found = true;
                                                potHighest.Add(currentDeck[j]);
                                                potHighest.Add(currentDeck[k]);
                                                potHighest.Add(currentDeck[l]);
                                                break;

                                            }
                                        }
                                        if (found)
                                        {
                                            break;
                                        }
                                    }
                                    if (found)
                                    {
                                        break;
                                    }
                                }
                                if (cardsValue[potHighest[0].Substring(0, potHighest[0].Length - 1)] >= cardsValue[currHighest[0].Substring(0, currHighest[0].Length - 1)])
                                {
                                    winner.setWinnerCards(currentDeck);
                                }

                            }
                            if (tmp == "Straight")
                            {
                                string maxCurr = currentWinnerCards[0];
                                foreach (string card in currentWinnerCards)
                                {
                                    if (cardsValue[card.Substring(0, card.Length - 1)] > cardsValue[maxCurr.Substring(0, maxCurr.Length - 1)])
                                    {
                                        maxCurr = card;
                                    }
                                }
                                string maxPot = currentDeck[0];
                                foreach (string card in currentDeck)
                                {
                                    if (cardsValue[card.Substring(0, card.Length - 1)] > cardsValue[maxPot.Substring(0, maxPot.Length - 1)])
                                    {
                                        maxPot = card;
                                    }
                                }
                                if (cardsValue[maxPot.Substring(0, maxPot.Length - 1)] > cardsValue[maxCurr.Substring(0, maxCurr.Length - 1)])
                                {
                                    winner.setWinnerCards(currentDeck);
                                }
                                else if (cardsValue[maxPot.Substring(0, maxPot.Length - 1)] == cardsValue[maxCurr.Substring(0, maxCurr.Length - 1)])
                                {
                                    if (colorsValue[maxPot.Substring(maxPot.Length - 1)] > colorsValue[maxCurr.Substring(maxCurr.Length - 1)])
                                    {
                                        winner.setWinnerCards(currentDeck);
                                    }
                                }
                            }
                            if (tmp == "Flush")
                            {
                                string HighestColor = "";
                                for (int j = 0; j < currentWinnerCards.Count - 5; j++)
                                {
                                    for (int k = j + 1; k < currentWinnerCards.Count - 4; k++)
                                    {
                                        for (int l = k + 1; l < currentWinnerCards.Count - 3; l++)
                                        {
                                            for (int m = l + 1; m < currentWinnerCards.Count - 2; m++)
                                            {
                                                for (int n = m + 1; n < currentWinnerCards.Count; n++)
                                                {
                                                    if (currentWinnerCards[j].Substring(currentWinnerCards[j].Length - 1) == currentWinnerCards[k].Substring(currentWinnerCards[k].Length - 1) && currentWinnerCards[j].Substring(currentWinnerCards[j].Length - 1) == currentWinnerCards[l].Substring(currentWinnerCards[l].Length - 1) && currentWinnerCards[j].Substring(currentWinnerCards[j].Length - 1) == currentWinnerCards[m].Substring(currentWinnerCards[m].Length - 1) && currentWinnerCards[j].Substring(currentWinnerCards[j].Length - 1) == currentWinnerCards[n].Substring(currentWinnerCards[n].Length - 1))
                                                    {
                                                        HighestColor = currentWinnerCards[j].Substring(currentWinnerCards[j].Length - 1);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                string potencialHighestColor = "";
                                for (int j = 0; j < currentDeck.Count - 5; j++)
                                {
                                    for (int k = j + 1; k < currentDeck.Count - 4; k++)
                                    {
                                        for (int l = k + 1; l < currentDeck.Count - 3; l++)
                                        {
                                            for (int m = l + 1; m < currentDeck.Count - 2; m++)
                                            {
                                                for (int n = m + 1; n < currentDeck.Count; n++)
                                                {
                                                    if (currentDeck[j].Substring(currentDeck[j].Length - 1) == currentDeck[k].Substring(currentDeck[k].Length - 1) && currentDeck[j].Substring(currentDeck[j].Length - 1) == currentDeck[l].Substring(currentDeck[l].Length - 1) && currentDeck[j].Substring(currentDeck[j].Length - 1) == currentDeck[m].Substring(currentDeck[m].Length - 1) && currentDeck[j].Substring(currentDeck[j].Length - 1) == currentDeck[n].Substring(currentDeck[n].Length - 1))
                                                    {
                                                        potencialHighestColor = currentDeck[j].Substring(currentDeck[j].Length - 1);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (colorsValue[HighestColor] <= colorsValue[potencialHighestColor])
                                {
                                    winner.setWinnerCards(currentDeck);
                                }

                            }
                            if (tmp == "Full House")
                            {
                                List<string> currHighest = new List<string>();
                                List<string> potHighest = new List<string>();
                                bool found = false;
                                for (int j = 0; j < currentWinnerCards.Count - 3; j++)
                                {
                                    for (int k = j + 1; k < currentWinnerCards.Count - 2; k++)
                                    {
                                        for (int l = k + 1; l < currentWinnerCards.Count; l++)
                                        {
                                            if (currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[k].Substring(0, currentWinnerCards[k].Length - 1) && currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[l].Substring(0, currentWinnerCards[l].Length - 1))
                                            {
                                                found = true;
                                                currHighest.Add(currentDeck[j]);
                                                currHighest.Add(currentDeck[k]);
                                                currHighest.Add(currentDeck[l]);
                                                break;

                                            }
                                        }
                                        if (found)
                                        {
                                            break;
                                        }
                                    }
                                    if (found)
                                    {
                                        break;
                                    }
                                }
                                found = false;
                                for (int j = 0; j < currentDeck.Count - 3; j++)
                                {
                                    for (int k = j + 1; k < currentDeck.Count - 2; k++)
                                    {
                                        for (int l = k + 1; l < currentDeck.Count; l++)
                                        {
                                            if (currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[k].Substring(0, currentDeck[k].Length - 1) && currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[l].Substring(0, currentDeck[l].Length - 1))
                                            {
                                                found = true;
                                                potHighest.Add(currentDeck[j]);
                                                potHighest.Add(currentDeck[k]);
                                                potHighest.Add(currentDeck[l]);
                                                break;

                                            }
                                        }
                                        if (found)
                                        {
                                            break;
                                        }
                                    }
                                    if (found)
                                    {
                                        break;
                                    }
                                }
                                if (cardsValue[potHighest[0].Substring(0, potHighest[0].Length - 1)] >= cardsValue[currHighest[0].Substring(0, currHighest[0].Length - 1)])
                                {
                                    winner.setWinnerCards(currentDeck);
                                }
                                else
                                {
                                    found = false;
                                    List<string> currentHighestPair = new List<string>();
                                    List<string> potentialHighestPair = new List<string>();
                                    for (int j = 0; j < currentWinnerCards.Count - 1; j++)
                                    {
                                        for (int k = j + 1; k < currentWinnerCards.Count; k++)
                                        {
                                            if (currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[k].Substring(0, currentWinnerCards[k].Length - 1))
                                            {
                                                currentHighestPair.Add(currentWinnerCards[j]);
                                                currentHighestPair.Add(currentWinnerCards[k]);
                                                found = true;
                                                break;
                                            }
                                        }
                                        if (found)
                                        {
                                            break;
                                        }
                                    }
                                    found = false;
                                    for (int j = 0; j < currentDeck.Count - 1; j++)
                                    {
                                        for (int k = j + 1; k < currentDeck.Count; k++)
                                        {
                                            if (currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[k].Substring(0, currentDeck[k].Length - 1))
                                            {
                                                potentialHighestPair.Add(currentDeck[j]);
                                                potentialHighestPair.Add(currentDeck[k]);
                                                found = true;
                                                break;
                                            }
                                            if (found)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    string firstPlayerFirstCard = currentHighestPair[0];
                                    string firstPlayerSecoundCard = currentHighestPair[1];
                                    string secoundPlayerFirstCard = potentialHighestPair[0];
                                    string secoundPlayerSecoundtCard = potentialHighestPair[1];
                                    if (firstPlayerFirstCard.Substring(0, firstPlayerFirstCard.Length - 1) == secoundPlayerFirstCard.Substring(0, secoundPlayerFirstCard.Length - 1))
                                    {
                                        if (secoundPlayerFirstCard.Contains("♠") || secoundPlayerSecoundtCard.Contains("♠"))
                                        {
                                            winner.setWinnerCards(currentDeck);
                                        }
                                    }
                                    else if (cardsValue[firstPlayerFirstCard.Substring(0, firstPlayerFirstCard.Length - 1)] < cardsValue[secoundPlayerFirstCard.Substring(0, secoundPlayerFirstCard.Length - 1)])
                                    {
                                        winner.setWinnerCards(currentDeck);
                                    }
                                }
                            }
                            if (tmp == "Four of a Kind")
                            {
                                string HighestColor = "";
                                for (int j = 0; j < currentWinnerCards.Count - 4; j++)
                                {
                                    for (int k = j + 1; k < currentWinnerCards.Count - 3; k++)
                                    {
                                        for (int l = k + 1; l < currentWinnerCards.Count - 2; l++)
                                        {
                                            for (int m = l + 1; m < currentWinnerCards.Count; m++)
                                            {
                                                if (currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[k].Substring(0, currentWinnerCards[k].Length - 1) && currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[l].Substring(0, currentWinnerCards[l].Length - 1) && currentWinnerCards[j].Substring(0, currentWinnerCards[j].Length - 1) == currentWinnerCards[m].Substring(0, currentWinnerCards[m].Length - 1))
                                                {
                                                    HighestColor = currentDeck[j].Substring(0, currentDeck[j].Length - 1);
                                                }
                                            }
                                        }
                                    }
                                }
                                string potencialHighestColor = "";
                                for (int j = 0; j < currentDeck.Count - 4; j++)
                                {
                                    for (int k = j + 1; k < currentDeck.Count - 3; k++)
                                    {
                                        for (int l = k + 1; l < currentDeck.Count - 2; l++)
                                        {
                                            for (int m = l + 1; m < currentDeck.Count; m++)
                                            {
                                                if (currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[k].Substring(0, currentDeck[k].Length - 1) && currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[l].Substring(0, currentDeck[l].Length - 1) && currentDeck[j].Substring(0, currentDeck[j].Length - 1) == currentDeck[m].Substring(0, currentDeck[m].Length - 1))
                                                {
                                                    potencialHighestColor = currentDeck[j].Substring(0, currentDeck[j].Length - 1);
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cardsValue[potencialHighestColor] >= cardsValue[HighestColor])
                                {
                                    winner.setWinnerCards(currentDeck);
                                }

                            }
                            if (tmp == "Straight Flush")
                            {
                                int[] mostColor = { 0, 0, 0, 0, 0 };
                                for (int j = 0; j < currentWinnerCards.Count; j++)
                                {
                                    int color = colorsValue[currentWinnerCards[j].Substring(currentWinnerCards[j].Length - 1)];
                                    mostColor[color] += 1;
                                }
                                int[] potencialMostColor = { 0, 0, 0, 0 };
                                for (int j = 0; j < currentDeck.Count; j++)
                                {
                                    int color = colorsValue[currentDeck[j].Substring(currentDeck[j].Length - 1)];
                                    mostColor[color] += 1;
                                }
                                for (int j = 0; j < 4; j++)
                                {
                                    if (potencialMostColor[j] >= mostColor[j] && potencialMostColor[j] >= 5)
                                    {
                                        winner.setWinnerCards(currentDeck);
                                    }
                                }
                            }
                            if (tmp == "Royal Flush")
                            {
                                int[] mostColor = { 0, 0, 0, 0, 0 };
                                for (int j = 0; j < currentWinnerCards.Count; j++)
                                {
                                    int color = colorsValue[currentWinnerCards[j].Substring(currentWinnerCards[j].Length - 1)];
                                    mostColor[color] += 1;
                                }
                                int[] potencialMostColor = { 0, 0, 0, 0, 0 };
                                for (int j = 0; j < currentDeck.Count; j++)
                                {
                                    int color = colorsValue[currentDeck[j].Substring(currentDeck[j].Length - 1)];
                                    mostColor[color] += 1;
                                }
                                for (int j = 0; j < 4; j++)
                                {
                                    if (potencialMostColor[j] >= mostColor[j] && potencialMostColor[j] >= 5)
                                    {
                                        winner.setWinnerCards(currentDeck);
                                    }
                                }
                            }

                        }
                    }
                    //currentDeck.Clear();
                    //currentDeck = new List<string>(tableCards);
                }
                List<string> winningLine = new List<string>(winner.getWinnerCards());
                if (winningLine.Contains(currentDeck[0]))//player1Deck[0]))
                {
                    MessageBox.Show("Wygrałeś Przez " + WinnerHandCards);
                    this.Close();
                }
                else if (winningLine.Contains(player2Deck[0]))
                {
                    MessageBox.Show("Wygrał Gracz 2 Przez " + WinnerHandCards);
                    this.Close();
                }
                else if (winningLine.Contains(player3Deck[0]))
                {
                    MessageBox.Show("Wygrał Gracz 3 Przez " + WinnerHandCards);
                    this.Close();
                }
                else if (winningLine.Contains(player4Deck[0]))
                {
                    MessageBox.Show("Wygrał Gracz 4 Przez: " + WinnerHandCards);
                    this.Close();
                }
            }
            for (int i = 0; i < allPlayersMoney.Length; i++)
            {
                pot += allPlayersMoney[i];
            }
            if (round != 3)
            {
                MessageBox.Show("Stawka do wygrania " + pot.ToString());
            }
            for (int i = 0; i < allPlayersMoney.Length; i++)
            {
                allPlayersMoney[i] = 0;
            }
            round++;
        }

        private string pokerHands(List<string> deck)
        {
            List<string> playerHand = new List<string>(deck);
            playerHand.Sort();
            if (royalFlush(playerHand))
            {
                return "Royal Flush";
            }
            else if (straightFlush(playerHand))
            {
                return "Straight Flush";
            }
            else if (fourOfaKind(playerHand))
            {
                return "Four of a Kind";
            }
            else if (fullHouse(playerHand))
            {
                return "Full House";
            }
            else if (flush(playerHand))
            {
                return "Flush";
            }
            else if (straight(playerHand))
            {
                return "Straight";
            }
            else if (threeOfaKind(playerHand))
            {
                return "Three of a Kind";
            }
            else if (twoPair(playerHand))
            {
                return "Two Pair";
            }
            else if (pair(playerHand))
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
            for (int i = 0; i < hand.Count - 1; i++)
            {
                string firstCard = hand[i].Substring(0, hand[i].Length - 1);
                string secoundCard = hand[i + 1].Substring(0, hand[i + 1].Length - 1);
                if (firstCard == secoundCard)
                {
                    pairCounter++;
                    if (pairCounter == 2)
                    {
                        break;
                    }
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
            int[] cardsNumber = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < hand.Count; i++)
            {
                string card = hand[i].Substring(0, hand[i].Length - 1);
                int value = cardsValue[card];
                cardsNumber[value] += 1;
            }
            for (int i = 0; i < 9; i++)
            {
                if (cardsNumber[i] >= 1 && cardsNumber[i + 1] >= 1 && cardsNumber[i + 2] >= 1 && cardsNumber[i + 3] >= 1 && cardsNumber[i + 4] >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        private bool flush(List<string> hand)
        {
            int[] colors = { 0, 0, 0, 0 };
            for (int i = 0; i < hand.Count; i++)
            {
                string currentColor = hand[i].Substring(hand[i].Length - 1);
                if (currentColor == "♠")
                {
                    colors[0] += 1;
                    continue;
                }
                if (currentColor == "♦")
                {
                    colors[1] += 1;
                    continue;
                }
                if (currentColor == "♥")
                {
                    colors[2] += 1;
                    continue;
                }
                if (currentColor == "♣")
                {
                    colors[3] += 1;
                    continue;
                }
            }
            foreach (int counter in colors)
            {
                if (counter >= 5)
                {
                    return true;
                }
            }
            return false;
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
            string firstCard;
            string secoundCard;
            string thirdCard;
            string fourthCard;     
            for (int i = 0; i < hand.Count - 3; i++)
            {
                firstCard = hand[i].Substring(0, hand[i].Length - 1);
                secoundCard = hand[i + 1].Substring(0, hand[i + 1].Length - 1);
                thirdCard = hand[i + 2].Substring(0, hand[i + 2].Length - 1);
                fourthCard = hand[i + 3].Substring(0, hand[i + 3].Length - 1);
                if (firstCard == secoundCard && firstCard == thirdCard && firstCard == fourthCard)
                {
                    return true;
                }
            }
            return false;
        }
        private bool straightFlush(List<string> hand)
        {
            string[] colors = { "♠", "♥", "♦", "♣" };
            int[] cardsNumber = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>
            {
                { "♠", new List<string>() },
                { "♣", new List<string>() },
                { "♥", new List<string>() },
                { "♦", new List<string>() }
            };
            foreach (string card in hand)
            {
                if(!card.Contains("A"))
                {
                    cards[card.Substring(card.Length - 1)].Add(card);
                }
            }
            List<string> straight = new List<string>();
            foreach (string color in colors)
            {
                cards[color].Sort();
                if (cards[color].Count >= 5)
                {
                    for (int i = 0; i < cards[color].Count; i++)
                    {
                        straight.Add(cards[color][i]);
                    }
                    if (straight.Count >= 5)
                    {
                        for (int i = 0; i < straight.Count; i++)
                        {
                            cardsNumber[cardsValue[straight[i].Substring(0, straight[i].Length - 1)]] += 1;
                        }
                        for (int i = 0; i < cardsNumber.Length - 4; i++)
                        {
                            if (cardsNumber[i] == 1 && cardsNumber[i + 1] == 1 && cardsNumber[i + 2] == 1 && cardsNumber[i + 3] == 1 && cardsNumber[i + 4] == 1)
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        straight.Clear();
                    }
                }
            }
            return false;
        }
        private bool royalFlush(List<string> hand)
        {
            string[] colors = { "♠", "♥", "♦", "♣" };
            string winerLine = "10AJKQ";
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>
            {
                { "♠", new List<string>() },
                { "♣", new List<string>() },
                { "♥", new List<string>() },
                { "♦", new List<string>() }
            };
            foreach (string card in hand)
            {
                if(card.Contains("A") || card.Contains("K") || card.Contains("Q") || card.Contains("J") || card.Contains("10"))
                {
                    cards[card.Substring(card.Length - 1)].Add(card);
                }
                else
                {
                    continue;
                }
            }
            foreach (string color in colors)
            {
                cards[color].Sort();
            }
            foreach(string color in colors)
            {
                string line = "";
                if(cards[color].Count >= 5)
                {
                    for (int i = 0; i < cards[color].Count; i++)
                    {
                        line += cards[color][i].Substring(0, cards[color][i].Length-1);
                    }
                    if(line == winerLine)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        class Winner
        {
            private List<string> winnerCards = new List<string>();
            public void setWinnerCards(List<string> playerHand)
            {
                this.winnerCards.Clear();
                for (int i = 0; i < playerHand.Count; i++)
                {
                    this.winnerCards.Add(playerHand[i]);
                }
            }
            public List<string> getWinnerCards()
            {
                return this.winnerCards;
            }
        }
    }
}
