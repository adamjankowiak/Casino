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
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines("..\\..\\userdata\\logon.csv");
            Collection<string> username_list = new Collection<string>(), password_list = new Collection<string>();
            foreach (string line in data)
            {
                string[] split = line.Split(',');
                username_list.Add(split[0]);
                password_list.Add(split[1]);
            }
            if (!username_list.Contains(username.Text.ToLower()))
            {
                MessageBox.Show("username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!password_list.Contains(password.Text))
            {
                MessageBox.Show("password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dashboard form = new Dashboard();
            form.Show();
            this.Hide();
        }

        private void create_Click(object sender, EventArgs e)
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
            File.AppendAllText("..\\..\\userdata\\logon.csv", username.Text.ToLower() + ',' + password.Text);
            MessageBox.Show("user added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
