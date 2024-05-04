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
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 377);
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
    }
}