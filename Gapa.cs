using System;
using System.Collections;
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
    public partial class Gapa : Form
    {   
        private List<int> talia = new List<int> {1,2,3,4};
        private List<int> player1 = new List<int>();
        private List<int> player2 = new List<int>();
        public Gapa()
        {
            InitializeComponent();
            talia = shuffle(talia);
            playerDeck();
            showDeck();
        }
        private List<int>shuffle(List<int>tab1)
        {
            Random rnd = new Random();
            List<int> shuffledList = tab1.OrderBy(x => rnd.Next()).ToList();
            return shuffledList;
        }
        private void playerDeck()
        {
            for(int i = 0;i<talia.Count;i++)
            {
                if (i % 2 == 0)
                {
                    player1.Add(talia[i]);
                }
                else
                {
                    player2.Add(talia[i]);
                }
            }
        }
        private void showDeck()
        {
            string line = "";
            for(int i=0;i<player1.Count;i++)
            {
                line += player1[i].ToString() + "\n";
            }
            MessageBox.Show(line);
        }
    }
}
