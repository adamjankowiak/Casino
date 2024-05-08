using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Kasyno
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
            this.password_label.BringToFront();
        }


        private void login_label_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines("..\\..\\userdata\\logon.csv");
            Collection<string> username_list = new Collection<string>(), password_list = new Collection<string>();
            Collection<int> balance_list = new Collection<int>();
            foreach (string line in data)
            {
                string[] split = line.Split(',');
                username_list.Add(split[0]);
                password_list.Add(split[1]);
                balance_list.Add(int.Parse(split[2]));
            }
            if (!username_list.Contains(username.Text.ToLower()))
            {
                MessageBox.Show("username does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < username_list.Count; ++i)
            {
                if (username.Text.ToLower() == username_list[i] && password.Text == password_list[i])
                {
                    Dashboard dashboard = new Dashboard(this, username.Text.ToLower(), balance_list[i]);
                    this.Hide();
                    dashboard.Show();
                    return;
                }
            }
            MessageBox.Show("password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void create_label_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
            {
                MessageBox.Show("username cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] data = File.ReadAllLines("..\\..\\userdata\\logon.csv");
            Collection<string> username_list = new Collection<string>();
            foreach (string line in data)
            {
                string[] split = line.Split(',');
                username_list.Add(split[0]);
            }
            if (username_list.Contains(username.Text.ToLower()))
            {
                MessageBox.Show("username already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.AppendAllText("..\\..\\userdata\\logon.csv", username.Text.ToLower() + ',' + password.Text + ",500" + Environment.NewLine);
            MessageBox.Show("user added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            login_label_Click(sender, e);
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login_label_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
