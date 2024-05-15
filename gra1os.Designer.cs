namespace Kasyno
{
    partial class Gra1os
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gra1os));
            this.karty_gracza1 = new System.Windows.Forms.Label();
            this.karty_gracza2 = new System.Windows.Forms.Label();
            this.aktualna_gracz1 = new System.Windows.Forms.Label();
            this.aktualna_komputer = new System.Windows.Forms.Label();
            this.bitwa_Button = new System.Windows.Forms.Button();
            this.player_card_label = new System.Windows.Forms.Label();
            this.computer_card_label = new System.Windows.Forms.Label();
            this.score_player_label = new System.Windows.Forms.Label();
            this.score_computer_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // karty_gracza1
            // 
            this.karty_gracza1.AutoSize = true;
            this.karty_gracza1.BackColor = System.Drawing.Color.Transparent;
            this.karty_gracza1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karty_gracza1.ForeColor = System.Drawing.Color.White;
            this.karty_gracza1.Location = new System.Drawing.Point(11, 30);
            this.karty_gracza1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.karty_gracza1.Name = "karty_gracza1";
            this.karty_gracza1.Size = new System.Drawing.Size(242, 22);
            this.karty_gracza1.TabIndex = 2;
            this.karty_gracza1.Text = "Pozostale twoje karty";
            // 
            // karty_gracza2
            // 
            this.karty_gracza2.AutoSize = true;
            this.karty_gracza2.BackColor = System.Drawing.Color.Transparent;
            this.karty_gracza2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karty_gracza2.ForeColor = System.Drawing.Color.White;
            this.karty_gracza2.Location = new System.Drawing.Point(314, 30);
            this.karty_gracza2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.karty_gracza2.Name = "karty_gracza2";
            this.karty_gracza2.Size = new System.Drawing.Size(295, 22);
            this.karty_gracza2.TabIndex = 3;
            this.karty_gracza2.Text = "Pozostale karty komputera";
            // 
            // aktualna_gracz1
            // 
            this.aktualna_gracz1.AutoSize = true;
            this.aktualna_gracz1.BackColor = System.Drawing.Color.Transparent;
            this.aktualna_gracz1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualna_gracz1.ForeColor = System.Drawing.Color.White;
            this.aktualna_gracz1.Location = new System.Drawing.Point(100, 129);
            this.aktualna_gracz1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aktualna_gracz1.Name = "aktualna_gracz1";
            this.aktualna_gracz1.Size = new System.Drawing.Size(174, 22);
            this.aktualna_gracz1.TabIndex = 7;
            this.aktualna_gracz1.Text = "Aktualna karta";
            // 
            // aktualna_komputer
            // 
            this.aktualna_komputer.AutoSize = true;
            this.aktualna_komputer.BackColor = System.Drawing.Color.Transparent;
            this.aktualna_komputer.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualna_komputer.ForeColor = System.Drawing.Color.White;
            this.aktualna_komputer.Location = new System.Drawing.Point(348, 129);
            this.aktualna_komputer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aktualna_komputer.Name = "aktualna_komputer";
            this.aktualna_komputer.Size = new System.Drawing.Size(174, 22);
            this.aktualna_komputer.TabIndex = 8;
            this.aktualna_komputer.Text = "Aktualna karta";
            // 
            // bitwa_Button
            // 
            this.bitwa_Button.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitwa_Button.Location = new System.Drawing.Point(165, 278);
            this.bitwa_Button.Margin = new System.Windows.Forms.Padding(2);
            this.bitwa_Button.Name = "bitwa_Button";
            this.bitwa_Button.Size = new System.Drawing.Size(281, 44);
            this.bitwa_Button.TabIndex = 9;
            this.bitwa_Button.Text = "BITWA!";
            this.bitwa_Button.UseVisualStyleBackColor = true;
            this.bitwa_Button.Click += new System.EventHandler(this.bitwa_Button_Click);
            // 
            // player_card_label
            // 
            this.player_card_label.AutoSize = true;
            this.player_card_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.player_card_label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_card_label.ForeColor = System.Drawing.Color.Black;
            this.player_card_label.Location = new System.Drawing.Point(148, 170);
            this.player_card_label.MinimumSize = new System.Drawing.Size(40, 50);
            this.player_card_label.Name = "player_card_label";
            this.player_card_label.Size = new System.Drawing.Size(40, 50);
            this.player_card_label.TabIndex = 10;
            this.player_card_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computer_card_label
            // 
            this.computer_card_label.AutoSize = true;
            this.computer_card_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.computer_card_label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_card_label.ForeColor = System.Drawing.Color.Black;
            this.computer_card_label.Location = new System.Drawing.Point(416, 170);
            this.computer_card_label.MinimumSize = new System.Drawing.Size(40, 50);
            this.computer_card_label.Name = "computer_card_label";
            this.computer_card_label.Size = new System.Drawing.Size(40, 50);
            this.computer_card_label.TabIndex = 11;
            this.computer_card_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_player_label
            // 
            this.score_player_label.AutoSize = true;
            this.score_player_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.score_player_label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_player_label.ForeColor = System.Drawing.Color.Black;
            this.score_player_label.Location = new System.Drawing.Point(98, 61);
            this.score_player_label.MinimumSize = new System.Drawing.Size(40, 40);
            this.score_player_label.Name = "score_player_label";
            this.score_player_label.Size = new System.Drawing.Size(40, 40);
            this.score_player_label.TabIndex = 12;
            // 
            // score_computer_label
            // 
            this.score_computer_label.AutoSize = true;
            this.score_computer_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.score_computer_label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_computer_label.ForeColor = System.Drawing.Color.Black;
            this.score_computer_label.Location = new System.Drawing.Point(443, 61);
            this.score_computer_label.MinimumSize = new System.Drawing.Size(40, 40);
            this.score_computer_label.Name = "score_computer_label";
            this.score_computer_label.Size = new System.Drawing.Size(40, 40);
            this.score_computer_label.TabIndex = 13;
            // 
            // Gra1os
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kasyno.Properties.Resources.Blackjack_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 370);
            this.Controls.Add(this.score_computer_label);
            this.Controls.Add(this.score_player_label);
            this.Controls.Add(this.computer_card_label);
            this.Controls.Add(this.player_card_label);
            this.Controls.Add(this.bitwa_Button);
            this.Controls.Add(this.aktualna_komputer);
            this.Controls.Add(this.aktualna_gracz1);
            this.Controls.Add(this.karty_gracza2);
            this.Controls.Add(this.karty_gracza1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gra1os";
            this.Text = "Gra 1-osobowa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gra1os_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label karty_gracza1;
        private System.Windows.Forms.Label karty_gracza2;
        private System.Windows.Forms.Label aktualna_gracz1;
        private System.Windows.Forms.Label aktualna_komputer;
        private System.Windows.Forms.Button bitwa_Button;
        private System.Windows.Forms.Label player_card_label;
        private System.Windows.Forms.Label computer_card_label;
        private System.Windows.Forms.Label score_player_label;
        private System.Windows.Forms.Label score_computer_label;
    }
}