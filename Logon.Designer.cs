namespace Kasyno
{
    partial class Logon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.create_label = new System.Windows.Forms.Label();
            this.exit_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(186, 141);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(176, 26);
            this.username.TabIndex = 0;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(17, 141);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(137, 29);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "Username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(186, 196);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(176, 26);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSystemPasswordChar = true;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(17, 193);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(137, 29);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Password";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.White;
            this.login_label.Location = new System.Drawing.Point(123, 413);
            this.login_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_label.MinimumSize = new System.Drawing.Size(170, 55);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(170, 55);
            this.login_label.TabIndex = 7;
            this.login_label.Text = "LOG IN";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // create_label
            // 
            this.create_label.AutoSize = true;
            this.create_label.BackColor = System.Drawing.Color.Transparent;
            this.create_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_label.ForeColor = System.Drawing.Color.White;
            this.create_label.Location = new System.Drawing.Point(123, 491);
            this.create_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.create_label.MinimumSize = new System.Drawing.Size(170, 55);
            this.create_label.Name = "create_label";
            this.create_label.Size = new System.Drawing.Size(170, 55);
            this.create_label.TabIndex = 8;
            this.create_label.Text = "CREATE";
            this.create_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_label.Click += new System.EventHandler(this.create_label_Click);
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.BackColor = System.Drawing.Color.Transparent;
            this.exit_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_label.ForeColor = System.Drawing.Color.White;
            this.exit_label.Location = new System.Drawing.Point(123, 565);
            this.exit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exit_label.MinimumSize = new System.Drawing.Size(170, 55);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(170, 55);
            this.exit_label.TabIndex = 9;
            this.exit_label.Text = "EXIT";
            this.exit_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_label.Click += new System.EventHandler(this.exit_label_Click);
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kasyno.Properties.Resources.login_backgroud2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 653);
            this.Controls.Add(this.exit_label);
            this.Controls.Add(this.create_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Kasyno.Properties.Resources.spades_icon;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(150, 55);
            this.Name = "Logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label create_label;
        private System.Windows.Forms.Label exit_label;
    }
}