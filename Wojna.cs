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
    public partial class Wojna : Form
    {
        public Wojna()
        {
            InitializeComponent();
        }

        private void battle1_Click(object sender, EventArgs e)
        {
            gra1os wojna1 = new gra1os();
            wojna1.Show();
            this.Hide();
        }

        private void battle2_Click(object sender, EventArgs e)
        {
            gra2os wojna2 = new gra2os();
            wojna2.Show();
            this.Hide();
        }

        private void Wojna_Load(object sender, EventArgs e)
        {

        }
    }
}
