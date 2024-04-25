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
        public Dashboard(Logon log, string username)
        {
            InitializeComponent();
            logon = log;
            user = username;
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
    }
}
