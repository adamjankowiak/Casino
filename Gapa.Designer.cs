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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // current_player
            // 
            this.current_player.AutoSize = true;
            this.current_player.BackColor = System.Drawing.Color.Beige;
            this.current_player.Location = new System.Drawing.Point(369, 330);
            this.current_player.Name = "current_player";
            this.current_player.Size = new System.Drawing.Size(35, 13);
            this.current_player.TabIndex = 0;
            this.current_player.Text = "label1";
            // 
            // current_deck
            // 
            this.current_deck.AutoSize = true;
            this.current_deck.BackColor = System.Drawing.Color.Beige;
            this.current_deck.Location = new System.Drawing.Point(369, 385);
            this.current_deck.Name = "current_deck";
            this.current_deck.Size = new System.Drawing.Size(35, 13);
            this.current_deck.TabIndex = 1;
            this.current_deck.Text = "label2";
            // 
            // playerLeft
            // 
            this.playerLeft.AutoSize = true;
            this.playerLeft.Location = new System.Drawing.Point(40, 165);
            this.playerLeft.Name = "playerLeft";
            this.playerLeft.Size = new System.Drawing.Size(35, 13);
            this.playerLeft.TabIndex = 2;
            this.playerLeft.Text = "label3";
            // 
            // playerTop
            // 
            this.playerTop.AutoSize = true;
            this.playerTop.Location = new System.Drawing.Point(369, 31);
            this.playerTop.Name = "playerTop";
            this.playerTop.Size = new System.Drawing.Size(35, 13);
            this.playerTop.TabIndex = 3;
            this.playerTop.Text = "label4";
            // 
            // playerRight
            // 
            this.playerRight.AutoSize = true;
            this.playerRight.Location = new System.Drawing.Point(697, 156);
            this.playerRight.Name = "playerRight";
            this.playerRight.Size = new System.Drawing.Size(35, 13);
            this.playerRight.TabIndex = 4;
            this.playerRight.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerRight);
            this.Controls.Add(this.playerTop);
            this.Controls.Add(this.playerLeft);
            this.Controls.Add(this.current_deck);
            this.Controls.Add(this.current_player);
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
        private System.Windows.Forms.Button button1;
    }
}