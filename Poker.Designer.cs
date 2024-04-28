namespace Kasyno
{
    partial class Poker
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
            this.pokerStartButton = new System.Windows.Forms.Button();
            this.poker_info_button = new System.Windows.Forms.Button();
            this.player3_label = new System.Windows.Forms.Label();
            this.player2_label = new System.Windows.Forms.Label();
            this.player4_label = new System.Windows.Forms.Label();
            this.player1_label = new System.Windows.Forms.Label();
            this.player1_money_text = new System.Windows.Forms.Label();
            this.player1_money_label = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.RadioButton();
            this.passButton = new System.Windows.Forms.RadioButton();
            this.player2_money_text = new System.Windows.Forms.Label();
            this.player2_money_label = new System.Windows.Forms.Label();
            this.player3_money_label = new System.Windows.Forms.Label();
            this.player4_money_label = new System.Windows.Forms.Label();
            this.player3_money_text = new System.Windows.Forms.Label();
            this.player4_money_text = new System.Windows.Forms.Label();
            this.player1_deck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pokerStartButton
            // 
            this.pokerStartButton.Location = new System.Drawing.Point(321, 109);
            this.pokerStartButton.Name = "pokerStartButton";
            this.pokerStartButton.Size = new System.Drawing.Size(107, 54);
            this.pokerStartButton.TabIndex = 0;
            this.pokerStartButton.Text = "Start";
            this.pokerStartButton.UseVisualStyleBackColor = true;
            this.pokerStartButton.Click += new System.EventHandler(this.pokerStartButton_Click);
            // 
            // poker_info_button
            // 
            this.poker_info_button.Location = new System.Drawing.Point(321, 242);
            this.poker_info_button.Name = "poker_info_button";
            this.poker_info_button.Size = new System.Drawing.Size(107, 54);
            this.poker_info_button.TabIndex = 1;
            this.poker_info_button.Text = "Info";
            this.poker_info_button.UseVisualStyleBackColor = true;
            this.poker_info_button.Click += new System.EventHandler(this.poker_info_button_Click);
            // 
            // player3_label
            // 
            this.player3_label.AutoSize = true;
            this.player3_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_label.Location = new System.Drawing.Point(335, 9);
            this.player3_label.Name = "player3_label";
            this.player3_label.Size = new System.Drawing.Size(85, 25);
            this.player3_label.TabIndex = 2;
            this.player3_label.Text = "Player3";
            this.player3_label.Visible = false;
            // 
            // player2_label
            // 
            this.player2_label.AutoSize = true;
            this.player2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_label.Location = new System.Drawing.Point(37, 176);
            this.player2_label.Name = "player2_label";
            this.player2_label.Size = new System.Drawing.Size(85, 25);
            this.player2_label.TabIndex = 3;
            this.player2_label.Text = "Player2";
            this.player2_label.Visible = false;
            // 
            // player4_label
            // 
            this.player4_label.AutoSize = true;
            this.player4_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player4_label.Location = new System.Drawing.Point(651, 176);
            this.player4_label.Name = "player4_label";
            this.player4_label.Size = new System.Drawing.Size(85, 25);
            this.player4_label.TabIndex = 4;
            this.player4_label.Text = "Player4";
            this.player4_label.Visible = false;
            // 
            // player1_label
            // 
            this.player1_label.AutoSize = true;
            this.player1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_label.Location = new System.Drawing.Point(335, 335);
            this.player1_label.Name = "player1_label";
            this.player1_label.Size = new System.Drawing.Size(85, 25);
            this.player1_label.TabIndex = 5;
            this.player1_label.Text = "Player1";
            this.player1_label.Visible = false;
            // 
            // player1_money_text
            // 
            this.player1_money_text.AutoSize = true;
            this.player1_money_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_money_text.Location = new System.Drawing.Point(200, 342);
            this.player1_money_text.Name = "player1_money_text";
            this.player1_money_text.Size = new System.Drawing.Size(90, 16);
            this.player1_money_text.TabIndex = 6;
            this.player1_money_text.Text = "Player money";
            this.player1_money_text.Visible = false;
            // 
            // player1_money_label
            // 
            this.player1_money_label.AutoSize = true;
            this.player1_money_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_money_label.Location = new System.Drawing.Point(225, 368);
            this.player1_money_label.Name = "player1_money_label";
            this.player1_money_label.Size = new System.Drawing.Size(35, 16);
            this.player1_money_label.TabIndex = 7;
            this.player1_money_label.Text = "300$";
            this.player1_money_label.Visible = false;
            // 
            // betButton
            // 
            this.betButton.AutoSize = true;
            this.betButton.Location = new System.Drawing.Point(499, 305);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(41, 17);
            this.betButton.TabIndex = 8;
            this.betButton.TabStop = true;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Visible = false;
            // 
            // checkButton
            // 
            this.checkButton.AutoSize = true;
            this.checkButton.Location = new System.Drawing.Point(499, 328);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(56, 17);
            this.checkButton.TabIndex = 9;
            this.checkButton.TabStop = true;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Visible = false;
            // 
            // passButton
            // 
            this.passButton.AutoSize = true;
            this.passButton.Location = new System.Drawing.Point(499, 351);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(48, 17);
            this.passButton.TabIndex = 10;
            this.passButton.TabStop = true;
            this.passButton.Text = "Pass";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Visible = false;
            // 
            // player2_money_text
            // 
            this.player2_money_text.AutoSize = true;
            this.player2_money_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_money_text.Location = new System.Drawing.Point(32, 223);
            this.player2_money_text.Name = "player2_money_text";
            this.player2_money_text.Size = new System.Drawing.Size(90, 16);
            this.player2_money_text.TabIndex = 11;
            this.player2_money_text.Text = "Player money";
            this.player2_money_text.Visible = false;
            // 
            // player2_money_label
            // 
            this.player2_money_label.AutoSize = true;
            this.player2_money_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_money_label.Location = new System.Drawing.Point(54, 242);
            this.player2_money_label.Name = "player2_money_label";
            this.player2_money_label.Size = new System.Drawing.Size(35, 16);
            this.player2_money_label.TabIndex = 12;
            this.player2_money_label.Text = "300$";
            this.player2_money_label.Visible = false;
            // 
            // player3_money_label
            // 
            this.player3_money_label.AutoSize = true;
            this.player3_money_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_money_label.Location = new System.Drawing.Point(362, 62);
            this.player3_money_label.Name = "player3_money_label";
            this.player3_money_label.Size = new System.Drawing.Size(35, 16);
            this.player3_money_label.TabIndex = 13;
            this.player3_money_label.Text = "300$";
            this.player3_money_label.Visible = false;
            // 
            // player4_money_label
            // 
            this.player4_money_label.AutoSize = true;
            this.player4_money_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player4_money_label.Location = new System.Drawing.Point(675, 242);
            this.player4_money_label.Name = "player4_money_label";
            this.player4_money_label.Size = new System.Drawing.Size(35, 16);
            this.player4_money_label.TabIndex = 14;
            this.player4_money_label.Text = "300$";
            this.player4_money_label.Visible = false;
            // 
            // player3_money_text
            // 
            this.player3_money_text.AutoSize = true;
            this.player3_money_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_money_text.Location = new System.Drawing.Point(337, 46);
            this.player3_money_text.Name = "player3_money_text";
            this.player3_money_text.Size = new System.Drawing.Size(90, 16);
            this.player3_money_text.TabIndex = 15;
            this.player3_money_text.Text = "Player money";
            this.player3_money_text.Visible = false;
            // 
            // player4_money_text
            // 
            this.player4_money_text.AutoSize = true;
            this.player4_money_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player4_money_text.Location = new System.Drawing.Point(646, 223);
            this.player4_money_text.Name = "player4_money_text";
            this.player4_money_text.Size = new System.Drawing.Size(90, 16);
            this.player4_money_text.TabIndex = 16;
            this.player4_money_text.Text = "Player money";
            this.player4_money_text.Visible = false;
            // 
            // player1_deck
            // 
            this.player1_deck.AutoSize = true;
            this.player1_deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_deck.Location = new System.Drawing.Point(335, 387);
            this.player1_deck.Name = "player1_deck";
            this.player1_deck.Size = new System.Drawing.Size(87, 25);
            this.player1_deck.TabIndex = 17;
            this.player1_deck.Text = "AS , AD";
            this.player1_deck.Visible = false;
            // 
            // Poker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kasyno.Properties.Resources.Blackjack_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player1_deck);
            this.Controls.Add(this.player4_money_text);
            this.Controls.Add(this.player3_money_text);
            this.Controls.Add(this.player4_money_label);
            this.Controls.Add(this.player3_money_label);
            this.Controls.Add(this.player2_money_label);
            this.Controls.Add(this.player2_money_text);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.player1_money_label);
            this.Controls.Add(this.player1_money_text);
            this.Controls.Add(this.player1_label);
            this.Controls.Add(this.player4_label);
            this.Controls.Add(this.player2_label);
            this.Controls.Add(this.player3_label);
            this.Controls.Add(this.poker_info_button);
            this.Controls.Add(this.pokerStartButton);
            this.Name = "Poker";
            this.Text = "Poker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pokerStartButton;
        private System.Windows.Forms.Button poker_info_button;
        private System.Windows.Forms.Label player3_label;
        private System.Windows.Forms.Label player2_label;
        private System.Windows.Forms.Label player4_label;
        private System.Windows.Forms.Label player1_label;
        private System.Windows.Forms.Label player1_money_text;
        private System.Windows.Forms.Label player1_money_label;
        private System.Windows.Forms.RadioButton betButton;
        private System.Windows.Forms.RadioButton checkButton;
        private System.Windows.Forms.RadioButton passButton;
        private System.Windows.Forms.Label player2_money_text;
        private System.Windows.Forms.Label player2_money_label;
        private System.Windows.Forms.Label player3_money_label;
        private System.Windows.Forms.Label player4_money_label;
        private System.Windows.Forms.Label player3_money_text;
        private System.Windows.Forms.Label player4_money_text;
        private System.Windows.Forms.Label player1_deck;
    }
}