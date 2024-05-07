namespace Kasyno
{
    partial class Gapa
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
            this.current_player = new System.Windows.Forms.Label();
            this.current_deck = new System.Windows.Forms.Label();
            this.playerLeft = new System.Windows.Forms.Label();
            this.playerTop = new System.Windows.Forms.Label();
            this.playerRight = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.selected_card = new System.Windows.Forms.TextBox();
            this.Select_card_text = new System.Windows.Forms.Label();
            this.radioPikButton = new System.Windows.Forms.RadioButton();
            this.radioKierButton = new System.Windows.Forms.RadioButton();
            this.radioKaroButton = new System.Windows.Forms.RadioButton();
            this.radioTreflButton = new System.Windows.Forms.RadioButton();
            this.acceptButton = new System.Windows.Forms.Button();
            this.player4_deck = new System.Windows.Forms.Label();
            this.player3_deck = new System.Windows.Forms.Label();
            this.player2_Deck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // current_player
            // 
            this.current_player.AutoSize = true;
            this.current_player.BackColor = System.Drawing.Color.Beige;
            this.current_player.Location = new System.Drawing.Point(365, 341);
            this.current_player.Name = "current_player";
            this.current_player.Size = new System.Drawing.Size(42, 13);
            this.current_player.TabIndex = 0;
            this.current_player.Text = "Player1";
            // 
            // current_deck
            // 
            this.current_deck.AutoSize = true;
            this.current_deck.BackColor = System.Drawing.Color.Beige;
            this.current_deck.Location = new System.Drawing.Point(365, 385);
            this.current_deck.Name = "current_deck";
            this.current_deck.Size = new System.Drawing.Size(33, 13);
            this.current_deck.TabIndex = 1;
            this.current_deck.Text = "Deck";
            // 
            // playerLeft
            // 
            this.playerLeft.AutoSize = true;
            this.playerLeft.BackColor = System.Drawing.Color.Yellow;
            this.playerLeft.Location = new System.Drawing.Point(40, 165);
            this.playerLeft.Name = "playerLeft";
            this.playerLeft.Size = new System.Drawing.Size(45, 13);
            this.playerLeft.TabIndex = 2;
            this.playerLeft.Text = "Player 4";
            // 
            // playerTop
            // 
            this.playerTop.AutoSize = true;
            this.playerTop.BackColor = System.Drawing.Color.Yellow;
            this.playerTop.Location = new System.Drawing.Point(365, 26);
            this.playerTop.Name = "playerTop";
            this.playerTop.Size = new System.Drawing.Size(45, 13);
            this.playerTop.TabIndex = 3;
            this.playerTop.Text = "Player 3";
            // 
            // playerRight
            // 
            this.playerRight.AutoSize = true;
            this.playerRight.BackColor = System.Drawing.Color.Yellow;
            this.playerRight.Location = new System.Drawing.Point(698, 165);
            this.playerRight.Name = "playerRight";
            this.playerRight.Size = new System.Drawing.Size(45, 13);
            this.playerRight.TabIndex = 4;
            this.playerRight.Text = "Player 2";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(322, 144);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(147, 54);
            this.button_Start.TabIndex = 5;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // selected_card
            // 
            this.selected_card.BackColor = System.Drawing.Color.Beige;
            this.selected_card.Location = new System.Drawing.Point(284, 266);
            this.selected_card.Name = "selected_card";
            this.selected_card.Size = new System.Drawing.Size(221, 20);
            this.selected_card.TabIndex = 6;
            this.selected_card.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selected_card.Visible = false;
            // 
            // Select_card_text
            // 
            this.Select_card_text.AutoSize = true;
            this.Select_card_text.BackColor = System.Drawing.Color.Beige;
            this.Select_card_text.Location = new System.Drawing.Point(355, 250);
            this.Select_card_text.Name = "Select_card_text";
            this.Select_card_text.Size = new System.Drawing.Size(72, 13);
            this.Select_card_text.TabIndex = 7;
            this.Select_card_text.Text = "Wybierz karte";
            this.Select_card_text.Visible = false;
            // 
            // radioPikButton
            // 
            this.radioPikButton.AutoSize = true;
            this.radioPikButton.BackColor = System.Drawing.Color.Teal;
            this.radioPikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPikButton.Location = new System.Drawing.Point(553, 233);
            this.radioPikButton.Name = "radioPikButton";
            this.radioPikButton.Size = new System.Drawing.Size(43, 22);
            this.radioPikButton.TabIndex = 8;
            this.radioPikButton.TabStop = true;
            this.radioPikButton.Text = "♠";
            this.radioPikButton.UseVisualStyleBackColor = false;
            this.radioPikButton.Visible = false;
            // 
            // radioKierButton
            // 
            this.radioKierButton.AutoSize = true;
            this.radioKierButton.BackColor = System.Drawing.Color.Teal;
            this.radioKierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioKierButton.ForeColor = System.Drawing.Color.Red;
            this.radioKierButton.Location = new System.Drawing.Point(553, 256);
            this.radioKierButton.Name = "radioKierButton";
            this.radioKierButton.Size = new System.Drawing.Size(44, 22);
            this.radioKierButton.TabIndex = 9;
            this.radioKierButton.TabStop = true;
            this.radioKierButton.Text = "♥";
            this.radioKierButton.UseVisualStyleBackColor = false;
            this.radioKierButton.Visible = false;
            // 
            // radioKaroButton
            // 
            this.radioKaroButton.AutoSize = true;
            this.radioKaroButton.BackColor = System.Drawing.Color.Teal;
            this.radioKaroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioKaroButton.ForeColor = System.Drawing.Color.Red;
            this.radioKaroButton.Location = new System.Drawing.Point(553, 279);
            this.radioKaroButton.Name = "radioKaroButton";
            this.radioKaroButton.Size = new System.Drawing.Size(42, 22);
            this.radioKaroButton.TabIndex = 10;
            this.radioKaroButton.TabStop = true;
            this.radioKaroButton.Text = "♦";
            this.radioKaroButton.UseVisualStyleBackColor = false;
            this.radioKaroButton.Visible = false;
            // 
            // radioTreflButton
            // 
            this.radioTreflButton.AutoSize = true;
            this.radioTreflButton.BackColor = System.Drawing.Color.Teal;
            this.radioTreflButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioTreflButton.Location = new System.Drawing.Point(553, 302);
            this.radioTreflButton.Name = "radioTreflButton";
            this.radioTreflButton.Size = new System.Drawing.Size(44, 22);
            this.radioTreflButton.TabIndex = 11;
            this.radioTreflButton.TabStop = true;
            this.radioTreflButton.Text = "♣";
            this.radioTreflButton.UseVisualStyleBackColor = false;
            this.radioTreflButton.Visible = false;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(546, 349);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(87, 36);
            this.acceptButton.TabIndex = 12;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // player4_deck
            // 
            this.player4_deck.AutoSize = true;
            this.player4_deck.BackColor = System.Drawing.Color.Beige;
            this.player4_deck.Location = new System.Drawing.Point(40, 198);
            this.player4_deck.Name = "player4_deck";
            this.player4_deck.Size = new System.Drawing.Size(0, 13);
            this.player4_deck.TabIndex = 13;
            // 
            // player3_deck
            // 
            this.player3_deck.AutoSize = true;
            this.player3_deck.BackColor = System.Drawing.Color.Beige;
            this.player3_deck.Location = new System.Drawing.Point(365, 53);
            this.player3_deck.Name = "player3_deck";
            this.player3_deck.Size = new System.Drawing.Size(0, 13);
            this.player3_deck.TabIndex = 14;
            // 
            // player2_Deck
            // 
            this.player2_Deck.AutoSize = true;
            this.player2_Deck.BackColor = System.Drawing.Color.Beige;
            this.player2_Deck.Location = new System.Drawing.Point(698, 198);
            this.player2_Deck.Name = "player2_Deck";
            this.player2_Deck.Size = new System.Drawing.Size(0, 13);
            this.player2_Deck.TabIndex = 15;
            // 
            // Gapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.player2_Deck);
            this.Controls.Add(this.player3_deck);
            this.Controls.Add(this.player4_deck);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.radioTreflButton);
            this.Controls.Add(this.radioKaroButton);
            this.Controls.Add(this.radioKierButton);
            this.Controls.Add(this.radioPikButton);
            this.Controls.Add(this.Select_card_text);
            this.Controls.Add(this.selected_card);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.playerRight);
            this.Controls.Add(this.playerTop);
            this.Controls.Add(this.playerLeft);
            this.Controls.Add(this.current_deck);
            this.Controls.Add(this.current_player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Gapa";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label current_player;
        private System.Windows.Forms.Label current_deck;
        private System.Windows.Forms.Label playerLeft;
        private System.Windows.Forms.Label playerTop;
        private System.Windows.Forms.Label playerRight;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TextBox selected_card;
        private System.Windows.Forms.Label Select_card_text;
        private System.Windows.Forms.RadioButton radioPikButton;
        private System.Windows.Forms.RadioButton radioKierButton;
        private System.Windows.Forms.RadioButton radioKaroButton;
        private System.Windows.Forms.RadioButton radioTreflButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label player4_deck;
        private System.Windows.Forms.Label player3_deck;
        private System.Windows.Forms.Label player2_Deck;
    }
}