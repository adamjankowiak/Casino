﻿using System;
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
        Dashboard dashboard;
        public Wojna(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
        }

        private void battle1_Click(object sender, EventArgs e)
        {
            gra1os wojna1 = new gra1os(this);
            wojna1.Show();
            this.Hide();
        }

        private void Wojna_Load(object sender, EventArgs e)
        {

        }

        private void Wojna_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard.Show();
        }
    }
}
