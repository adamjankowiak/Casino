namespace Kasyno
{
    partial class Blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.start_button = new System.Windows.Forms.Button();
            this.dealer_label = new System.Windows.Forms.Label();
            this.player_label = new System.Windows.Forms.Label();
            this.dealercards_label = new System.Windows.Forms.Label();
            this.playercards_label = new System.Windows.Forms.Label();
            this.hit_button = new System.Windows.Forms.Button();
            this.stand_button = new System.Windows.Forms.Button();
            this.player_points_label = new System.Windows.Forms.Label();
            this.dealer_points_label = new System.Windows.Forms.Label();
            this.player_points_value_label = new System.Windows.Forms.Label();
            this.dealer_points_value_label = new System.Windows.Forms.Label();
            this.balance_label = new System.Windows.Forms.Label();
            this.balance_value_label = new System.Windows.Forms.Label();
            this.bet_textBox = new System.Windows.Forms.TextBox();
            this.place_bet_label = new System.Windows.Forms.Label();
            this.players_bet_label = new System.Windows.Forms.Label();
            this.bet_value_label = new System.Windows.Forms.Label();
            this.place_bet_button = new System.Windows.Forms.Button();
            this.cheater_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.LemonChiffon;
            this.start_button.FlatAppearance.BorderSize = 0;
            this.start_button.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(448, 279);
            this.start_button.Margin = new System.Windows.Forms.Padding(4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(269, 90);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "PLAY";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // dealer_label
            // 
            this.dealer_label.AutoSize = true;
            this.dealer_label.BackColor = System.Drawing.Color.Transparent;
            this.dealer_label.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealer_label.ForeColor = System.Drawing.Color.Black;
            this.dealer_label.Location = new System.Drawing.Point(485, 9);
            this.dealer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealer_label.Name = "dealer_label";
            this.dealer_label.Size = new System.Drawing.Size(172, 47);
            this.dealer_label.TabIndex = 1;
            this.dealer_label.Text = "Dealer";
            // 
            // player_label
            // 
            this.player_label.AutoSize = true;
            this.player_label.BackColor = System.Drawing.Color.Transparent;
            this.player_label.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_label.ForeColor = System.Drawing.Color.White;
            this.player_label.Location = new System.Drawing.Point(485, 588);
            this.player_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_label.Name = "player_label";
            this.player_label.Size = new System.Drawing.Size(172, 47);
            this.player_label.TabIndex = 2;
            this.player_label.Text = "player";
            // 
            // dealercards_label
            // 
            this.dealercards_label.AutoSize = true;
            this.dealercards_label.BackColor = System.Drawing.Color.Transparent;
            this.dealercards_label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealercards_label.ForeColor = System.Drawing.Color.Black;
            this.dealercards_label.Location = new System.Drawing.Point(292, 206);
            this.dealercards_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealercards_label.MinimumSize = new System.Drawing.Size(600, 0);
            this.dealercards_label.Name = "dealercards_label";
            this.dealercards_label.Size = new System.Drawing.Size(600, 40);
            this.dealercards_label.TabIndex = 3;
            this.dealercards_label.Text = "dealer cards";
            this.dealercards_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dealercards_label.Visible = false;
            // 
            // playercards_label
            // 
            this.playercards_label.AutoSize = true;
            this.playercards_label.BackColor = System.Drawing.Color.Transparent;
            this.playercards_label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playercards_label.ForeColor = System.Drawing.Color.White;
            this.playercards_label.Location = new System.Drawing.Point(292, 409);
            this.playercards_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playercards_label.MinimumSize = new System.Drawing.Size(600, 0);
            this.playercards_label.Name = "playercards_label";
            this.playercards_label.Size = new System.Drawing.Size(600, 40);
            this.playercards_label.TabIndex = 4;
            this.playercards_label.Text = "playercards";
            this.playercards_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playercards_label.Visible = false;
            // 
            // hit_button
            // 
            this.hit_button.BackColor = System.Drawing.Color.LemonChiffon;
            this.hit_button.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit_button.Location = new System.Drawing.Point(900, 457);
            this.hit_button.Margin = new System.Windows.Forms.Padding(4);
            this.hit_button.Name = "hit_button";
            this.hit_button.Size = new System.Drawing.Size(219, 76);
            this.hit_button.TabIndex = 5;
            this.hit_button.Text = "HIT";
            this.hit_button.UseVisualStyleBackColor = false;
            this.hit_button.Visible = false;
            this.hit_button.Click += new System.EventHandler(this.hit_button_Click);
            // 
            // stand_button
            // 
            this.stand_button.BackColor = System.Drawing.Color.LemonChiffon;
            this.stand_button.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stand_button.Location = new System.Drawing.Point(900, 540);
            this.stand_button.Margin = new System.Windows.Forms.Padding(4);
            this.stand_button.Name = "stand_button";
            this.stand_button.Size = new System.Drawing.Size(219, 76);
            this.stand_button.TabIndex = 6;
            this.stand_button.Text = "STAND";
            this.stand_button.UseVisualStyleBackColor = false;
            this.stand_button.Visible = false;
            this.stand_button.Click += new System.EventHandler(this.stand_button_Click);
            // 
            // player_points_label
            // 
            this.player_points_label.AutoSize = true;
            this.player_points_label.BackColor = System.Drawing.Color.Transparent;
            this.player_points_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_points_label.ForeColor = System.Drawing.Color.White;
            this.player_points_label.Location = new System.Drawing.Point(16, 588);
            this.player_points_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_points_label.Name = "player_points_label";
            this.player_points_label.Size = new System.Drawing.Size(137, 35);
            this.player_points_label.TabIndex = 7;
            this.player_points_label.Text = "Points:";
            // 
            // dealer_points_label
            // 
            this.dealer_points_label.AutoSize = true;
            this.dealer_points_label.BackColor = System.Drawing.Color.Transparent;
            this.dealer_points_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealer_points_label.ForeColor = System.Drawing.Color.Black;
            this.dealer_points_label.Location = new System.Drawing.Point(16, 20);
            this.dealer_points_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealer_points_label.Name = "dealer_points_label";
            this.dealer_points_label.Size = new System.Drawing.Size(137, 35);
            this.dealer_points_label.TabIndex = 8;
            this.dealer_points_label.Text = "Points:";
            // 
            // player_points_value_label
            // 
            this.player_points_value_label.AutoSize = true;
            this.player_points_value_label.BackColor = System.Drawing.Color.Transparent;
            this.player_points_value_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_points_value_label.ForeColor = System.Drawing.Color.White;
            this.player_points_value_label.Location = new System.Drawing.Point(172, 588);
            this.player_points_value_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_points_value_label.Name = "player_points_value_label";
            this.player_points_value_label.Size = new System.Drawing.Size(33, 35);
            this.player_points_value_label.TabIndex = 9;
            this.player_points_value_label.Text = "0";
            this.player_points_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealer_points_value_label
            // 
            this.dealer_points_value_label.AutoSize = true;
            this.dealer_points_value_label.BackColor = System.Drawing.Color.Transparent;
            this.dealer_points_value_label.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealer_points_value_label.ForeColor = System.Drawing.Color.Black;
            this.dealer_points_value_label.Location = new System.Drawing.Point(172, 20);
            this.dealer_points_value_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealer_points_value_label.Name = "dealer_points_value_label";
            this.dealer_points_value_label.Size = new System.Drawing.Size(33, 35);
            this.dealer_points_value_label.TabIndex = 10;
            this.dealer_points_value_label.Text = "0";
            this.dealer_points_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.BackColor = System.Drawing.Color.Transparent;
            this.balance_label.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_label.ForeColor = System.Drawing.Color.White;
            this.balance_label.Location = new System.Drawing.Point(16, 549);
            this.balance_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(132, 29);
            this.balance_label.TabIndex = 11;
            this.balance_label.Text = "Balance:";
            // 
            // balance_value_label
            // 
            this.balance_value_label.AutoSize = true;
            this.balance_value_label.BackColor = System.Drawing.Color.Transparent;
            this.balance_value_label.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_value_label.ForeColor = System.Drawing.Color.White;
            this.balance_value_label.Location = new System.Drawing.Point(165, 549);
            this.balance_value_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balance_value_label.Name = "balance_value_label";
            this.balance_value_label.Size = new System.Drawing.Size(28, 29);
            this.balance_value_label.TabIndex = 12;
            this.balance_value_label.Text = "0";
            // 
            // bet_textBox
            // 
            this.bet_textBox.Location = new System.Drawing.Point(947, 107);
            this.bet_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.bet_textBox.Name = "bet_textBox";
            this.bet_textBox.Size = new System.Drawing.Size(171, 22);
            this.bet_textBox.TabIndex = 13;
            this.bet_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bet_textBox_KeyPress);
            // 
            // place_bet_label
            // 
            this.place_bet_label.AutoSize = true;
            this.place_bet_label.BackColor = System.Drawing.Color.Transparent;
            this.place_bet_label.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place_bet_label.ForeColor = System.Drawing.Color.White;
            this.place_bet_label.Location = new System.Drawing.Point(913, 76);
            this.place_bet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.place_bet_label.Name = "place_bet_label";
            this.place_bet_label.Size = new System.Drawing.Size(216, 29);
            this.place_bet_label.TabIndex = 14;
            this.place_bet_label.Text = "Place your bet";
            // 
            // players_bet_label
            // 
            this.players_bet_label.AutoSize = true;
            this.players_bet_label.BackColor = System.Drawing.Color.Transparent;
            this.players_bet_label.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.players_bet_label.ForeColor = System.Drawing.Color.White;
            this.players_bet_label.Location = new System.Drawing.Point(961, 172);
            this.players_bet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.players_bet_label.Name = "players_bet_label";
            this.players_bet_label.Size = new System.Drawing.Size(133, 29);
            this.players_bet_label.TabIndex = 15;
            this.players_bet_label.Text = "Your bet";
            // 
            // bet_value_label
            // 
            this.bet_value_label.AutoSize = true;
            this.bet_value_label.BackColor = System.Drawing.Color.Transparent;
            this.bet_value_label.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_value_label.ForeColor = System.Drawing.Color.White;
            this.bet_value_label.Location = new System.Drawing.Point(933, 206);
            this.bet_value_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bet_value_label.MinimumSize = new System.Drawing.Size(200, 0);
            this.bet_value_label.Name = "bet_value_label";
            this.bet_value_label.Size = new System.Drawing.Size(200, 29);
            this.bet_value_label.TabIndex = 16;
            this.bet_value_label.Text = "0";
            this.bet_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // place_bet_button
            // 
            this.place_bet_button.BackColor = System.Drawing.Color.LemonChiffon;
            this.place_bet_button.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place_bet_button.Location = new System.Drawing.Point(900, 373);
            this.place_bet_button.Margin = new System.Windows.Forms.Padding(4);
            this.place_bet_button.Name = "place_bet_button";
            this.place_bet_button.Size = new System.Drawing.Size(219, 76);
            this.place_bet_button.TabIndex = 17;
            this.place_bet_button.Text = "PLACE BET";
            this.place_bet_button.UseVisualStyleBackColor = false;
            this.place_bet_button.Click += new System.EventHandler(this.place_bet_button_Click);
            // 
            // cheater_label
            // 
            this.cheater_label.AutoSize = true;
            this.cheater_label.BackColor = System.Drawing.Color.Transparent;
            this.cheater_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cheater_label.Location = new System.Drawing.Point(46, 334);
            this.cheater_label.MinimumSize = new System.Drawing.Size(60, 50);
            this.cheater_label.Name = "cheater_label";
            this.cheater_label.Size = new System.Drawing.Size(60, 50);
            this.cheater_label.TabIndex = 18;
            this.cheater_label.Visible = false;
            this.cheater_label.Click += new System.EventHandler(this.cheater_label_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kasyno.Properties.Resources.bj_backgroud1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 646);
            this.Controls.Add(this.cheater_label);
            this.Controls.Add(this.place_bet_button);
            this.Controls.Add(this.bet_value_label);
            this.Controls.Add(this.players_bet_label);
            this.Controls.Add(this.place_bet_label);
            this.Controls.Add(this.bet_textBox);
            this.Controls.Add(this.balance_value_label);
            this.Controls.Add(this.balance_label);
            this.Controls.Add(this.dealer_points_value_label);
            this.Controls.Add(this.player_points_value_label);
            this.Controls.Add(this.dealer_points_label);
            this.Controls.Add(this.player_points_label);
            this.Controls.Add(this.stand_button);
            this.Controls.Add(this.hit_button);
            this.Controls.Add(this.playercards_label);
            this.Controls.Add(this.dealercards_label);
            this.Controls.Add(this.player_label);
            this.Controls.Add(this.dealer_label);
            this.Controls.Add(this.start_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Blackjack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Blackjack_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label dealer_label;
        private System.Windows.Forms.Label player_label;
        private System.Windows.Forms.Label dealercards_label;
        private System.Windows.Forms.Label playercards_label;
        private System.Windows.Forms.Button hit_button;
        private System.Windows.Forms.Button stand_button;
        private System.Windows.Forms.Label player_points_label;
        private System.Windows.Forms.Label dealer_points_label;
        private System.Windows.Forms.Label player_points_value_label;
        private System.Windows.Forms.Label dealer_points_value_label;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Label balance_value_label;
        private System.Windows.Forms.TextBox bet_textBox;
        private System.Windows.Forms.Label place_bet_label;
        private System.Windows.Forms.Label players_bet_label;
        private System.Windows.Forms.Label bet_value_label;
        private System.Windows.Forms.Button place_bet_button;
        private System.Windows.Forms.Label cheater_label;
    }
}