using System.Drawing;

namespace Kasyno
{
    partial class Roulette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roulette));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Play = new System.Windows.Forms.Button();
            this.betting_table = new System.Windows.Forms.PictureBox();
            this.bet_1 = new System.Windows.Forms.Button();
            this.bet_2 = new System.Windows.Forms.Button();
            this.bet_3 = new System.Windows.Forms.Button();
            this.bet_4 = new System.Windows.Forms.Button();
            this.bet_5 = new System.Windows.Forms.Button();
            this.bet_6 = new System.Windows.Forms.Button();
            this.bet_7 = new System.Windows.Forms.Button();
            this.bet_8 = new System.Windows.Forms.Button();
            this.bet_9 = new System.Windows.Forms.Button();
            this.bet_10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betting_table)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(25, 28);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(300, 300);
            this.Player.TabIndex = 0;
            this.Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_PlayStateChange);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(124, 334);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // betting_table
            // 
            this.betting_table.Image = ((System.Drawing.Image)(resources.GetObject("betting_table.Image")));
            this.betting_table.ImageLocation = "";
            this.betting_table.InitialImage = null;
            this.betting_table.Location = new System.Drawing.Point(331, 28);
            this.betting_table.Name = "betting_table";
            this.betting_table.Size = new System.Drawing.Size(506, 300);
            this.betting_table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.betting_table.TabIndex = 2;
            this.betting_table.TabStop = false;
            // 
            // bet_1
            // 
            this.bet_1.BackColor = System.Drawing.Color.Transparent;
            this.bet_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_1.BackgroundImage")));
            this.bet_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_1.ForeColor = System.Drawing.Color.Transparent;
            this.bet_1.Location = new System.Drawing.Point(397, 168);
            this.bet_1.Name = "bet_1";
            this.bet_1.Size = new System.Drawing.Size(35, 51);
            this.bet_1.TabIndex = 5;
            this.bet_1.UseVisualStyleBackColor = false;
            // 
            // bet_2
            // 
            this.bet_2.BackColor = System.Drawing.Color.Transparent;
            this.bet_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_2.BackgroundImage")));
            this.bet_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_2.ForeColor = System.Drawing.Color.Transparent;
            this.bet_2.Location = new System.Drawing.Point(397, 118);
            this.bet_2.Name = "bet_2";
            this.bet_2.Size = new System.Drawing.Size(35, 51);
            this.bet_2.TabIndex = 6;
            this.bet_2.UseVisualStyleBackColor = false;
            // 
            // bet_3
            // 
            this.bet_3.BackColor = System.Drawing.Color.Transparent;
            this.bet_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_3.BackgroundImage")));
            this.bet_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_3.ForeColor = System.Drawing.Color.Transparent;
            this.bet_3.Location = new System.Drawing.Point(397, 69);
            this.bet_3.Name = "bet_3";
            this.bet_3.Size = new System.Drawing.Size(35, 51);
            this.bet_3.TabIndex = 7;
            this.bet_3.UseVisualStyleBackColor = false;
            // 
            // bet_4
            // 
            this.bet_4.BackColor = System.Drawing.Color.Transparent;
            this.bet_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_4.BackgroundImage")));
            this.bet_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_4.ForeColor = System.Drawing.Color.Transparent;
            this.bet_4.Location = new System.Drawing.Point(430, 168);
            this.bet_4.Name = "bet_4";
            this.bet_4.Size = new System.Drawing.Size(34, 51);
            this.bet_4.TabIndex = 8;
            this.bet_4.UseVisualStyleBackColor = false;
            // 
            // bet_5
            // 
            this.bet_5.BackColor = System.Drawing.Color.Transparent;
            this.bet_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_5.BackgroundImage")));
            this.bet_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_5.ForeColor = System.Drawing.Color.Transparent;
            this.bet_5.Location = new System.Drawing.Point(430, 118);
            this.bet_5.Name = "bet_5";
            this.bet_5.Size = new System.Drawing.Size(34, 51);
            this.bet_5.TabIndex = 9;
            this.bet_5.UseVisualStyleBackColor = false;
            // 
            // bet_6
            // 
            this.bet_6.BackColor = System.Drawing.Color.Transparent;
            this.bet_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_6.BackgroundImage")));
            this.bet_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_6.ForeColor = System.Drawing.Color.Transparent;
            this.bet_6.Location = new System.Drawing.Point(430, 69);
            this.bet_6.Name = "bet_6";
            this.bet_6.Size = new System.Drawing.Size(34, 51);
            this.bet_6.TabIndex = 10;
            this.bet_6.UseVisualStyleBackColor = false;
            // 
            // bet_7
            // 
            this.bet_7.BackColor = System.Drawing.Color.Transparent;
            this.bet_7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_7.BackgroundImage")));
            this.bet_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_7.ForeColor = System.Drawing.Color.Transparent;
            this.bet_7.Location = new System.Drawing.Point(462, 168);
            this.bet_7.Name = "bet_7";
            this.bet_7.Size = new System.Drawing.Size(34, 51);
            this.bet_7.TabIndex = 11;
            this.bet_7.UseVisualStyleBackColor = false;
            // 
            // bet_8
            // 
            this.bet_8.BackColor = System.Drawing.Color.Transparent;
            this.bet_8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_8.BackgroundImage")));
            this.bet_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_8.ForeColor = System.Drawing.Color.Transparent;
            this.bet_8.Location = new System.Drawing.Point(462, 118);
            this.bet_8.Name = "bet_8";
            this.bet_8.Size = new System.Drawing.Size(34, 51);
            this.bet_8.TabIndex = 12;
            this.bet_8.UseVisualStyleBackColor = false;
            // 
            // bet_9
            // 
            this.bet_9.BackColor = System.Drawing.Color.Transparent;
            this.bet_9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_9.BackgroundImage")));
            this.bet_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_9.ForeColor = System.Drawing.Color.Transparent;
            this.bet_9.Location = new System.Drawing.Point(462, 69);
            this.bet_9.Name = "bet_9";
            this.bet_9.Size = new System.Drawing.Size(34, 51);
            this.bet_9.TabIndex = 13;
            this.bet_9.UseVisualStyleBackColor = false;
            // 
            // bet_10
            // 
            this.bet_10.BackColor = System.Drawing.Color.Transparent;
            this.bet_10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_10.BackgroundImage")));
            this.bet_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_10.ForeColor = System.Drawing.Color.Transparent;
            this.bet_10.Location = new System.Drawing.Point(494, 168);
            this.bet_10.Name = "bet_10";
            this.bet_10.Size = new System.Drawing.Size(35, 51);
            this.bet_10.TabIndex = 14;
            this.bet_10.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(494, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 51);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(494, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 51);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bet_10);
            this.Controls.Add(this.bet_9);
            this.Controls.Add(this.bet_8);
            this.Controls.Add(this.bet_7);
            this.Controls.Add(this.bet_6);
            this.Controls.Add(this.bet_5);
            this.Controls.Add(this.bet_4);
            this.Controls.Add(this.bet_3);
            this.Controls.Add(this.bet_2);
            this.Controls.Add(this.bet_1);
            this.Controls.Add(this.betting_table);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Player);
            this.Name = "Roulette";
            this.Text = "Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betting_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.PictureBox betting_table;
        private System.Windows.Forms.Button bet_1;
        private System.Windows.Forms.Button bet_2;
        private System.Windows.Forms.Button bet_3;
        private System.Windows.Forms.Button bet_4;
        private System.Windows.Forms.Button bet_5;
        private System.Windows.Forms.Button bet_6;
        private System.Windows.Forms.Button bet_7;
        private System.Windows.Forms.Button bet_8;
        private System.Windows.Forms.Button bet_9;
        private System.Windows.Forms.Button bet_10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}