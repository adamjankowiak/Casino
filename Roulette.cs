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
using WMPLib;

namespace Kasyno
{
    public partial class Roulette : Form
    {
        string roulette_path;
        public Roulette()
        {
            InitializeComponent();
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            roulette_path = executablePath.Substring(0, executablePath.Length - 9) + "Resources\\Roulette\\";
            Player.stretchToFit = true;
            Player.uiMode = "none";
            Player.Visible = false;
            betting_table.Image = Image.FromFile("..\\..\\Resources\\Roulette_Table\\Roulette_table.jpg");
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            Random rng = new Random();
            int number = rng.Next(0, 36);
            string path = roulette_path + "Roulette_" + number.ToString() + ".mp4";
            Player.URL = path;
            Player.Visible = true;
            Player.Ctlcontrols.play();
        }

        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Player.Visible = false;
            }
        }
    }
}
