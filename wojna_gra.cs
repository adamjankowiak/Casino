using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;

namespace Kasyno
{
    public partial class wojna_gra : Form
    {
        List<int> talia = new List<int>{ 1,2,3,4};
        int ilosc_graczy = 0;
        List<int> gracz_1 = new List<int> ();
        List<int> gracz_2 = new List<int> ();
        public wojna_gra(int opcja)
        {
            InitializeComponent();
            ilosc_graczy = opcja;
            Random rand = new Random();

            for (int i = 0; i < talia.Count; i++)
            {
                int randomIndex = rand.Next(i, talia.Count);
                int temp = talia[i];
                talia[i] = talia[randomIndex];
                talia[randomIndex] = temp;
            }
            for (int i = 0; i < talia.Count; i++)
            {
                if (i % 2 == 0)
                {
                    gracz_1.Add(talia[i]);
                }
                else
                {
                    gracz_2.Add(talia[i]);
                }
            }


        }

        private void karty_gracza_1_TextChanged(object sender, EventArgs e)
        {
            gracz_1
        }
    }
}
