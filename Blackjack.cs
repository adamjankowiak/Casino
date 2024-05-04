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
    public partial class Blackjack : Form
    {
        Dashboard dashboard;
        public Blackjack(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {

        }
    }
}
