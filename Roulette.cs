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
using System.Collections.ObjectModel;
using WMPLib;

namespace Kasyno
{
    public partial class Roulette : Form
    {
        string roulette_path;
        int bet = 0, roll;
        int[] red = {1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36};
        Dashboard dashboard;
        Button clicked;
        // Collection<string> bets = new Collection<string>();
        // Collection<int> bet_values = new Collection<int>();
        public Roulette(Dashboard dash)
        {
            InitializeComponent();
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            roulette_path = executablePath.Substring(0, executablePath.Length - 9) + "Resources\\Roulette\\";
            /*Player.stretchToFit = true;
            Player.uiMode = "none";
            Player.Visible = false;*/
            roulette_picture.Image = Image.FromFile(roulette_path + "Roulette_0.jpg");
            roulette_picture.Refresh();
            betting_table.Image = Image.FromFile("..\\..\\Resources\\Roulette_Table\\Roulette_table.jpg");
            dashboard = dash;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            /*Player.Ctlcontrols.stop();*/
            Random rng = new Random();
            roll = rng.Next(0, 36);
            string path = roulette_path + "Roulette_" + roll.ToString() + ".mp4";
            /*Player.URL = path;
            roulette_picture.Visible = false;
            Player.Visible = true;
            Player.Ctlcontrols.play();*/
            roulette_picture.Image = Image.FromFile(roulette_path + "Roulette_" + roll.ToString() + ".jpg");
            roulette_picture.Refresh();
        }

        /*private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                roulette_picture.Visible = true;
                Player.Visible = false;
                if(bet >= 0)
                {
                    if (bet == roll)
                    {
                        MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    switch (bet)
                    {
                        case -3:
                            if (roll%3 == 0)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -1:
                            if (roll % 3 == 1)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -2:
                            if (roll % 3 == 2)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -4:
                            if (roll%2 == 0)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -5:
                            if (roll%2 == 1)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -12:
                            if (roll > 0 && roll <= 12)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -24:
                            if (roll > 12 && roll <= 24)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -36:
                            if (roll > 24 && roll <= 36)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -18:
                            if (roll > 0 && roll <= 18)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -19:
                            if (roll > 18 && roll <= 36)
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -6:
                            if (red.Contains(roll))
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case -7:
                            if (!red.Contains(roll))
                            {
                                MessageBox.Show("You have won", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("You have lost", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        default:
                            break;
                    }
                }
                roulette_picture.Image = Image.FromFile(roulette_path + "Roulette_0.jpg");
                roulette_picture.Refresh();
            }
        }*/

        private void bet_1_Click(object sender, EventArgs e)
        {
            bet = 1;
        }

        private void bet_2_Click(object sender, EventArgs e)
        {
            bet = 2;
        }

        private void bet_3_Click(object sender, EventArgs e)
        {
            bet = 3;
        }

        private void bet_4_Click(object sender, EventArgs e)
        {
            bet = 4;
        }

        private void bet_5_Click(object sender, EventArgs e)
        {
            bet = 5;
        }

        private void bet_6_Click(object sender, EventArgs e)
        {
            bet = 6;
        }

        private void bet_7_Click(object sender, EventArgs e)
        {
            bet = 7;
        }

        private void bet_8_Click(object sender, EventArgs e)
        {
            bet = 8;
        }

        private void bet_9_Click(object sender, EventArgs e)
        {
            bet = 9;
        }

        private void bet_10_Click(object sender, EventArgs e)
        {
            bet = 10;
        }

        private void bet_11_Click(object sender, EventArgs e)
        {
            bet = 11;
        }

        private void bet_12_Click(object sender, EventArgs e)
        {
            bet = 12;
        }

        private void bet_13_Click(object sender, EventArgs e)
        {
            bet = 13;
        }

        private void bet_14_Click(object sender, EventArgs e)
        {
            bet = 14;
        }

        private void bet_15_Click(object sender, EventArgs e)
        {
            bet = 15;
        }

        private void bet_16_Click(object sender, EventArgs e)
        {
            bet = 16;
        }

        private void bet_17_Click(object sender, EventArgs e)
        {
            bet = 17;
        }

        private void bet_18_Click(object sender, EventArgs e)
        {
            bet = 18;
        }

        private void bet_19_Click(object sender, EventArgs e)
        {
            bet = 19;
        }

        private void bet_20_Click(object sender, EventArgs e)
        {
            bet = 20;
        }

        private void bet_21_Click(object sender, EventArgs e)
        {
            bet = 21;
        }

        private void bet_22_Click(object sender, EventArgs e)
        {
            bet = 22;
        }

        private void bet_23_Click(object sender, EventArgs e)
        {
            bet = 23;
        }

        private void bet_24_Click(object sender, EventArgs e)
        {
            bet = 24;
        }

        private void bet_25_Click(object sender, EventArgs e)
        {
            bet = 25;
        }

        private void bet_26_Click(object sender, EventArgs e)
        {
            bet = 26;
        }

        private void bet_27_Click(object sender, EventArgs e)
        {
            bet = 27;
        }

        private void bet_28_Click(object sender, EventArgs e)
        {
            bet = 28;
        }

        private void bet_29_Click(object sender, EventArgs e)
        {
            bet = 29;
        }

        private void bet_30_Click(object sender, EventArgs e)
        {
            bet = 30;
        }

        private void bet_31_Click(object sender, EventArgs e)
        {
            bet = 31;
        }

        private void bet_32_Click(object sender, EventArgs e)
        {
            bet = 32;
        }

        private void bet_33_Click(object sender, EventArgs e)
        {
            bet = 33;
        }

        private void bet_34_Click(object sender, EventArgs e)
        {
            bet = 34;
        }

        private void bet_35_Click(object sender, EventArgs e)
        {
            bet = 35;
        }

        private void bet_36_Click(object sender, EventArgs e)
        {
            bet = 36;
        }

        private void bet_2to1_bottom_Click(object sender, EventArgs e)
        {
            bet = -1;
        }

        private void bet_2to1_middle_Click(object sender, EventArgs e)
        {
            bet = -2;
        }

        private void bet_2to1_top_Click(object sender, EventArgs e)
        {
            bet = -3;
        }

        private void bet_1st12_Click(object sender, EventArgs e)
        {
            bet = -12;
        }

        private void bet_2nd12_Click(object sender, EventArgs e)
        {
            bet = -24;
        }

        private void bet_3rd12_Click(object sender, EventArgs e)
        {
            bet = -36;
        }

        private void bet_1to18_Click(object sender, EventArgs e)
        {
            bet = -18;
        }

        private void bet_19to36_Click(object sender, EventArgs e)
        {
            bet = -19;
        }

        private void bet_even_Click(object sender, EventArgs e)
        {
            bet = -4;        
        }

        private void bet_odd_Click(object sender, EventArgs e)
        {
            bet = -5;
        }

        private void bet_red_Click(object sender, EventArgs e)
        {
            bet = -6;
        }

        private void bet_black_Click(object sender, EventArgs e)
        {
            bet = -7;
        }

        private void bet_button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button != null && button != clicked)
            {
                button.BringToFront();
                button.FlatAppearance.BorderSize = 3;
                button.FlatAppearance.BorderColor = Color.Orange;
            }
        }

        private void bet_button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null && button != clicked)
            {
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void bet_button_2_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null && button != clicked)
            {
                button.FlatAppearance.BorderSize = 0;
            }
        }

        private void bet_button_Enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            clicked = button;
            button.FlatAppearance.BorderSize = 3;
            button.FlatAppearance.BorderColor = Color.Blue;
        }

        private void bet_button_Leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.White;
        }

        private void Roulette_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard.Show();
        }

        private void bet_button_2_Leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.FlatAppearance.BorderSize = 0;
        }
    }
}
