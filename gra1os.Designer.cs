namespace Kasyno
{
    partial class gra1os
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
            this.score_Player_textbox = new System.Windows.Forms.TextBox();
            this.score_Computer_textBox = new System.Windows.Forms.TextBox();
            this.karty_gracza1 = new System.Windows.Forms.Label();
            this.karty_gracza2 = new System.Windows.Forms.Label();
            this.player_Card_textBox = new System.Windows.Forms.TextBox();
            this.computer_Card_textbox = new System.Windows.Forms.TextBox();
            this.aktualna_gracz1 = new System.Windows.Forms.Label();
            this.aktualna_komputer = new System.Windows.Forms.Label();
            this.bitwa_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score_Player_textbox
            // 
            this.score_Player_textbox.Location = new System.Drawing.Point(64, 219);
            this.score_Player_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.score_Player_textbox.Name = "score_Player_textbox";
            this.score_Player_textbox.ReadOnly = true;
            this.score_Player_textbox.Size = new System.Drawing.Size(100, 31);
            this.score_Player_textbox.TabIndex = 0;
            // 
            // score_Computer_textBox
            // 
            this.score_Computer_textBox.Location = new System.Drawing.Point(1000, 219);
            this.score_Computer_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.score_Computer_textBox.Name = "score_Computer_textBox";
            this.score_Computer_textBox.ReadOnly = true;
            this.score_Computer_textBox.Size = new System.Drawing.Size(100, 31);
            this.score_Computer_textBox.TabIndex = 1;
            // 
            // karty_gracza1
            // 
            this.karty_gracza1.AutoSize = true;
            this.karty_gracza1.Location = new System.Drawing.Point(24, 158);
            this.karty_gracza1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karty_gracza1.Name = "karty_gracza1";
            this.karty_gracza1.Size = new System.Drawing.Size(216, 25);
            this.karty_gracza1.TabIndex = 2;
            this.karty_gracza1.Text = "Pozostałe twoje karty";
            // 
            // karty_gracza2
            // 
            this.karty_gracza2.AutoSize = true;
            this.karty_gracza2.Location = new System.Drawing.Point(924, 158);
            this.karty_gracza2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karty_gracza2.Name = "karty_gracza2";
            this.karty_gracza2.Size = new System.Drawing.Size(267, 25);
            this.karty_gracza2.TabIndex = 3;
            this.karty_gracza2.Text = "Pozostałe karty komputera";
            // 
            // player_Card_textBox
            // 
            this.player_Card_textBox.Location = new System.Drawing.Point(356, 219);
            this.player_Card_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player_Card_textBox.Name = "player_Card_textBox";
            this.player_Card_textBox.ReadOnly = true;
            this.player_Card_textBox.Size = new System.Drawing.Size(100, 31);
            this.player_Card_textBox.TabIndex = 5;
            // 
            // computer_Card_textbox
            // 
            this.computer_Card_textbox.Location = new System.Drawing.Point(744, 219);
            this.computer_Card_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.computer_Card_textbox.Name = "computer_Card_textbox";
            this.computer_Card_textbox.ReadOnly = true;
            this.computer_Card_textbox.Size = new System.Drawing.Size(100, 31);
            this.computer_Card_textbox.TabIndex = 6;
            // 
            // aktualna_gracz1
            // 
            this.aktualna_gracz1.AutoSize = true;
            this.aktualna_gracz1.Location = new System.Drawing.Point(350, 158);
            this.aktualna_gracz1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aktualna_gracz1.Name = "aktualna_gracz1";
            this.aktualna_gracz1.Size = new System.Drawing.Size(150, 25);
            this.aktualna_gracz1.TabIndex = 7;
            this.aktualna_gracz1.Text = "Aktualna karta";
            // 
            // aktualna_komputer
            // 
            this.aktualna_komputer.AutoSize = true;
            this.aktualna_komputer.Location = new System.Drawing.Point(696, 158);
            this.aktualna_komputer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aktualna_komputer.Name = "aktualna_komputer";
            this.aktualna_komputer.Size = new System.Drawing.Size(150, 25);
            this.aktualna_komputer.TabIndex = 8;
            this.aktualna_komputer.Text = "Aktualna karta";
            // 
            // bitwa_Button
            // 
            this.bitwa_Button.Location = new System.Drawing.Point(12, 527);
            this.bitwa_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitwa_Button.Name = "bitwa_Button";
            this.bitwa_Button.Size = new System.Drawing.Size(1216, 85);
            this.bitwa_Button.TabIndex = 9;
            this.bitwa_Button.Text = "BITWA!";
            this.bitwa_Button.UseVisualStyleBackColor = true;
            this.bitwa_Button.Click += new System.EventHandler(this.bitwa_Button_Click);
            // 
            // gra1os
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 712);
            this.Controls.Add(this.bitwa_Button);
            this.Controls.Add(this.aktualna_komputer);
            this.Controls.Add(this.aktualna_gracz1);
            this.Controls.Add(this.computer_Card_textbox);
            this.Controls.Add(this.player_Card_textBox);
            this.Controls.Add(this.karty_gracza2);
            this.Controls.Add(this.karty_gracza1);
            this.Controls.Add(this.score_Computer_textBox);
            this.Controls.Add(this.score_Player_textbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gra1os";
            this.Text = "Gra 1-osobowa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gra1os_FormClosed);
            this.Load += new System.EventHandler(this.gra1os_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox score_Player_textbox;
        private System.Windows.Forms.TextBox score_Computer_textBox;
        private System.Windows.Forms.Label karty_gracza1;
        private System.Windows.Forms.Label karty_gracza2;
        private System.Windows.Forms.TextBox player_Card_textBox;
        private System.Windows.Forms.TextBox computer_Card_textbox;
        private System.Windows.Forms.Label aktualna_gracz1;
        private System.Windows.Forms.Label aktualna_komputer;
        private System.Windows.Forms.Button bitwa_Button;
    }
}