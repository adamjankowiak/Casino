﻿namespace Kasyno
{
    partial class Wojna
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
            this.Ilosc_graczy = new System.Windows.Forms.Label();
            this.battle1 = new System.Windows.Forms.Button();
            this.battle2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ilosc_graczy
            // 
            this.Ilosc_graczy.AutoSize = true;
            this.Ilosc_graczy.BackColor = System.Drawing.SystemColors.Info;
            this.Ilosc_graczy.Location = new System.Drawing.Point(504, 130);
            this.Ilosc_graczy.Name = "Ilosc_graczy";
            this.Ilosc_graczy.Size = new System.Drawing.Size(210, 25);
            this.Ilosc_graczy.TabIndex = 0;
            this.Ilosc_graczy.Text = "Wybierz ilosc graczy";
            // 
            // battle1
            // 
            this.battle1.Location = new System.Drawing.Point(509, 221);
            this.battle1.Name = "battle1";
            this.battle1.Size = new System.Drawing.Size(205, 69);
            this.battle1.TabIndex = 1;
            this.battle1.Text = "1 osoba";
            this.battle1.UseVisualStyleBackColor = true;
            this.battle1.Click += new System.EventHandler(this.battle1_Click);
            // 
            // battle2
            // 
            this.battle2.Location = new System.Drawing.Point(509, 335);
            this.battle2.Name = "battle2";
            this.battle2.Size = new System.Drawing.Size(205, 69);
            this.battle2.TabIndex = 2;
            this.battle2.Text = "2 osoby";
            this.battle2.UseVisualStyleBackColor = true;
            this.battle2.Click += new System.EventHandler(this.battle2_Click);
            // 
            // Wojna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 757);
            this.Controls.Add(this.battle2);
            this.Controls.Add(this.battle1);
            this.Controls.Add(this.Ilosc_graczy);
            this.Name = "Wojna";
            this.Text = "Wojna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ilosc_graczy;
        private System.Windows.Forms.Button battle1;
        private System.Windows.Forms.Button battle2;
    }
}