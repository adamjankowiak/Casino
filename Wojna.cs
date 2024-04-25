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
            wojna_gra wojna1 = new wojna_gra(1,true);
            wojna1.Show();
            this.Hide();
        }

        private void battle2_Click(object sender, EventArgs e)
        {
            wojna_gra wojna1 = new wojna_gra(1, false);
            wojna1.Show();
            this.Hide();
        }
    }
}
