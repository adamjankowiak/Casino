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
        List<int> gracz_1 = new List<int>();
        List<int> komputer = new List<int>();
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
                for (int i = 2; i < 16; i++)
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
        }

        private void karty_gracza_1_TextChanged(object sender, EventArgs e)
        {
            karty_gracza_1.Text = gracz_1.Count.ToString();
        }

        private void talia_gracza_2_TextChanged(object sender, EventArgs e)
        {
            talia_gracza_2.Text = komputer.Count.ToString();
        }

        private void START_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Talia talia = new Talia();
            karty = talia.karty;
            Tasowanie();
            for (int i = 0; i < talia.karty.Count; i++)
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
            AktualizujIloscKart();
        }

        private void aktualna_karta_gracza_TextChanged(object sender, EventArgs e)
        {
            if (gracz_1.Count > 0)
            {
                aktualna_karta_gracza.Text = gracz_1[0].ToString();
            }
            else
            {
                aktualna_karta_gracza.Text = "Brak kart";
                MessageBox.Show("Przegrałeś wojne");
            }
        }

        private void aktualna_karta_komputera_TextChanged(object sender, EventArgs e)
        {
            if (komputer.Count > 0)
            {
                aktualna_karta_komputera.Text = komputer[0].ToString();
            }
            else
            {
                aktualna_karta_komputera.Text = "Brak kart";
                MessageBox.Show("Wygrałeś wojne");
            }
        }

        private void AktualizujIloscKart()
        {
            karty_gracza_1.Text = gracz_1.Count.ToString();
            talia_gracza_2.Text = komputer.Count.ToString();
        }

        private void bitwa_Click(object sender, EventArgs e)
        {
            int karta_gracza = gracz_1[0];
            int karta_komputera = komputer[0];
            aktualna_karta_gracza.Text = karta_gracza.ToString();
            aktualna_karta_komputera.Text = karta_komputera.ToString();
            AktualizujIloscKart();
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Start();
            timer.Tick += (s, a) =>
            {
                timer.Stop();
            };
            if (karta_gracza > karta_komputera)
            {
                gracz_1.Add(karta_komputera);
                gracz_1.Add(karta_gracza);
                gracz_1.RemoveAt(0);
                komputer.RemoveAt(0);
                MessageBox.Show("Wygrałeś bitwe");
            }
            else if (karta_gracza < karta_komputera)
            {
                komputer.Add(karta_gracza);
                komputer.Add(karta_komputera);
                gracz_1.RemoveAt(0);
                komputer.RemoveAt(0);
                MessageBox.Show("Komputer wygrał bitwe");
            }
            else if (karta_gracza == karta_komputera)
            {
                if (gracz_1.Count >= 2 && komputer.Count >= 2)
                {
                    int karta_gracza2 = gracz_1[1];
                    int karta_komputera2 = komputer[1];
                    if (karta_gracza2 > karta_komputera2)
                    {
                        gracz_1.Add(karta_komputera);
                        gracz_1.Add(karta_gracza);
                        gracz_1.Add(karta_komputera2);
                        gracz_1.Add(karta_gracza2);
                        gracz_1.RemoveAt(0);
                        gracz_1.RemoveAt(0);
                        komputer.RemoveAt(0);
                        komputer.RemoveAt(0);
                    }
                    else if (karta_gracza2 < karta_komputera2)
                    {
                        komputer.Add(karta_gracza);
                        komputer.Add(karta_komputera);
                        komputer.Add(karta_gracza2);
                        komputer.Add(karta_komputera2);
                        gracz_1.RemoveAt(0);
                        gracz_1.RemoveAt(0);
                        komputer.RemoveAt(0);
                        komputer.RemoveAt(0);
                    }

                }

            }
        }
    }
}
