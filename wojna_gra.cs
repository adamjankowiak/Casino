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
        bool tryb=true;
        public wojna_gra(int opcja, bool tryb)
        {
            InitializeComponent();
            this.tryb = tryb;
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
            if(tryb == true)
            {
                karty_gracza_1.Visible = true;
                karty_gracza1.Visible = true;
                talia_gracza_2.Visible = false;
                karty_gracza2.Visible = false;
            }
            else
            {
                karty_gracza_1.Visible = true;
                karty_gracza1.Visible = true;
                talia_gracza_2.Visible = true;
                karty_gracza2.Visible = true;
            }
        }

        private void karty_gracza_1_TextChanged(object sender, EventArgs e)
        {
            if (gracz_1.Count > 0)
            {
                karty_gracza_1.AppendText(gracz_1[0].ToString());
            }
            else
            {
                karty_gracza_1.AppendText("Gracz 1 nie ma więcej kart.");
            }
        }
    }
}
