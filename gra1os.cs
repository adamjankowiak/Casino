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
namespace Kasyno
{
    public partial class gra1os : Form
    {
        List<int> gracz_1 = new List<int> ();
        List<int> komputer = new List<int> ();
        public List<Karta> karty = new List<Karta>();

        public class Karta
        {
            public int wartosc;
            public string kolor;
            public Karta(int wartosc, string kolor)
            {
                this.wartosc = wartosc;
                this.kolor = kolor;
            }
        }
        public class Talia
        {
            public List<Karta> karty = new List<Karta>();
            public Talia()
            {
                for (int i = 2; i < 15; i++)
                {
                    karty.Add(new Karta(i, "Kier"));
                    karty.Add(new Karta(i, "Karo"));
                    karty.Add(new Karta(i, "Trefl"));
                    karty.Add(new Karta(i, "Pik"));
                }
            }
        }
        public void Tasowanie()
        {
            Random random = new Random();
            int n = karty.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Karta value = karty[k];
                karty[k] = karty[n];
                karty[n] = value;
            }
        }
        public gra1os()
        {
            InitializeComponent();
            Talia talia = new Talia();
            karty = talia.karty;
            Tasowanie();
            for (int i=0;i<talia.karty.Count;i++)
            {
                if (i % 2 == 0)
                {
                    gracz_1.Add(talia.karty[i].wartosc);
                }
                else
                {
                    komputer.Add(talia.karty[i].wartosc);
                }
            }
        }

        private void karty_gracza_1_TextChanged(object sender, EventArgs e)
        {
            karty_gracza_1.Text = "gracz_1.Count";
        }

        private void talia_gracza_2_TextChanged(object sender, EventArgs e)
        {
            talia_gracza_2.Text = "komputer.Count";
        }
    }
}
