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
    public partial class DontGiveUp : Form
    {
        Dashboard dashboard;
        public DontGiveUp(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
        }

        private void DontGiveUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard.Show();
        }

        private void back_to_the_game_label_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }

        private void i_quit_label_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Close();
        }
    }
}
