﻿namespace Kasyno
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
            this.start_button = new System.Windows.Forms.Button();
            this.dealer_label = new System.Windows.Forms.Label();
            this.player_label = new System.Windows.Forms.Label();
            this.dealercards_label = new System.Windows.Forms.Label();
            this.playercards_label = new System.Windows.Forms.Label();
            this.hit_button = new System.Windows.Forms.Button();
            this.stand_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(201, 154);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(144, 45);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Zagraj";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // dealer_label
            // 
            this.dealer_label.AutoSize = true;
            this.dealer_label.BackColor = System.Drawing.Color.Transparent;
            this.dealer_label.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealer_label.Location = new System.Drawing.Point(225, 9);
            this.dealer_label.Name = "dealer_label";
            this.dealer_label.Size = new System.Drawing.Size(94, 22);
            this.dealer_label.TabIndex = 1;
            this.dealer_label.Text = "Krupier";
            // 
            // player_label
            // 
            this.player_label.AutoSize = true;
            this.player_label.BackColor = System.Drawing.Color.Transparent;
            this.player_label.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_label.Location = new System.Drawing.Point(236, 335);
            this.player_label.Name = "player_label";
            this.player_label.Size = new System.Drawing.Size(68, 22);
            this.player_label.TabIndex = 2;
            this.player_label.Text = "Gracz";
            // 
            // dealercards_label
            // 
            this.dealercards_label.AutoSize = true;
            this.dealercards_label.BackColor = System.Drawing.Color.Transparent;
            this.dealercards_label.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealercards_label.Location = new System.Drawing.Point(196, 76);
            this.dealercards_label.Name = "dealercards_label";
            this.dealercards_label.Size = new System.Drawing.Size(160, 25);
            this.dealercards_label.TabIndex = 3;
            this.dealercards_label.Text = "dealer cards";
            this.dealercards_label.Visible = false;
            // 
            // playercards_label
            // 
            this.playercards_label.AutoSize = true;
            this.playercards_label.BackColor = System.Drawing.Color.Transparent;
            this.playercards_label.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playercards_label.Location = new System.Drawing.Point(196, 270);
            this.playercards_label.Name = "playercards_label";
            this.playercards_label.Size = new System.Drawing.Size(155, 25);
            this.playercards_label.TabIndex = 4;
            this.playercards_label.Text = "playercards";
            this.playercards_label.Visible = false;
            // 
            // hit_button
            // 
            this.hit_button.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit_button.Location = new System.Drawing.Point(429, 230);
            this.hit_button.Name = "hit_button";
            this.hit_button.Size = new System.Drawing.Size(128, 42);
            this.hit_button.TabIndex = 5;
            this.hit_button.Text = "HIT";
            this.hit_button.UseVisualStyleBackColor = true;
            this.hit_button.Visible = false;
            this.hit_button.Click += new System.EventHandler(this.hit_button_Click);
            // 
            // stand_button
            // 
            this.stand_button.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stand_button.Location = new System.Drawing.Point(429, 289);
            this.stand_button.Name = "stand_button";
            this.stand_button.Size = new System.Drawing.Size(128, 42);
            this.stand_button.TabIndex = 6;
            this.stand_button.Text = "STAND";
            this.stand_button.UseVisualStyleBackColor = true;
            this.stand_button.Visible = false;
            this.stand_button.Click += new System.EventHandler(this.stand_button_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kasyno.Properties.Resources.Blackjack_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.stand_button);
            this.Controls.Add(this.hit_button);
            this.Controls.Add(this.playercards_label);
            this.Controls.Add(this.dealercards_label);
            this.Controls.Add(this.player_label);
            this.Controls.Add(this.dealer_label);
            this.Controls.Add(this.start_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Blackjack";
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
    }
}