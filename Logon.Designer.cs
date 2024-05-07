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
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
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
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(159, 423);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(98, 37);
            this.login.TabIndex = 2;
            this.login.Text = "Log in";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
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
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(159, 574);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(98, 37);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.Location = new System.Drawing.Point(159, 498);
            this.create.Margin = new System.Windows.Forms.Padding(2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(98, 37);
            this.create.TabIndex = 3;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kasyno.Properties.Resources.login_backgroud2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 653);
            this.Controls.Add(this.create);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button create;
    }
}