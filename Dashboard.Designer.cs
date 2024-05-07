namespace Kasyno
{
    partial class Dashboard
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
            this.wojna_button = new System.Windows.Forms.Button();
            this.blackjack_button = new System.Windows.Forms.Button();
            this.kasyno_label = new System.Windows.Forms.Label();
            this.kasyno2_label = new System.Windows.Forms.Label();
            this.gapa_button = new System.Windows.Forms.Button();
            this.roulette_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wojna_button
            // 
            this.wojna_button.Location = new System.Drawing.Point(221, 307);
            this.wojna_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.wojna_button.Name = "wojna_button";
            this.wojna_button.Size = new System.Drawing.Size(169, 21);
            this.wojna_button.TabIndex = 0;
            this.wojna_button.Text = "Wojna";
            this.wojna_button.UseVisualStyleBackColor = true;
            this.wojna_button.Click += new System.EventHandler(this.wojna_button_Click);
            // 
            // blackjack_button
            // 
            this.blackjack_button.Location = new System.Drawing.Point(221, 334);
            this.blackjack_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.blackjack_button.Name = "blackjack_button";
            this.blackjack_button.Size = new System.Drawing.Size(169, 22);
            this.blackjack_button.TabIndex = 1;
            this.blackjack_button.Text = "Blackjack";
            this.blackjack_button.UseVisualStyleBackColor = true;
            this.blackjack_button.Click += new System.EventHandler(this.blackjack_button_Click);
            // 
            // kasyno_label
            // 
            this.kasyno_label.AutoSize = true;
            this.kasyno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasyno_label.Location = new System.Drawing.Point(128, 60);
            this.kasyno_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kasyno_label.Name = "kasyno_label";
            this.kasyno_label.Size = new System.Drawing.Size(348, 44);
            this.kasyno_label.TabIndex = 2;
            this.kasyno_label.Text = "Tłuste Inc. Kasyno";
            // 
            // kasyno2_label
            // 
            this.kasyno2_label.AutoSize = true;
            this.kasyno2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasyno2_label.ForeColor = System.Drawing.Color.Firebrick;
            this.kasyno2_label.Location = new System.Drawing.Point(341, 105);
            this.kasyno2_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kasyno2_label.Name = "kasyno2_label";
            this.kasyno2_label.Size = new System.Drawing.Size(151, 18);
            this.kasyno2_label.TabIndex = 3;
            this.kasyno2_label.Text = "SAME GRUBE RYBY";
            // 
            // gapa_button
            // 
            this.gapa_button.Location = new System.Drawing.Point(221, 362);
            this.gapa_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gapa_button.Name = "gapa_button";
            this.gapa_button.Size = new System.Drawing.Size(169, 23);
            this.gapa_button.TabIndex = 4;
            this.gapa_button.Text = "Gapa";
            this.gapa_button.UseVisualStyleBackColor = true;
            this.gapa_button.Click += new System.EventHandler(this.gapa_button_Click);
            // 
            // roulette_button
            // 
            this.roulette_button.Location = new System.Drawing.Point(165, 173);
            this.roulette_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.roulette_button.Name = "roulette_button";
            this.roulette_button.Size = new System.Drawing.Size(281, 74);
            this.roulette_button.TabIndex = 5;
            this.roulette_button.Text = "Ruleta";
            this.roulette_button.UseVisualStyleBackColor = true;
            this.roulette_button.Click += new System.EventHandler(this.roulette_button_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 443);
            this.Controls.Add(this.roulette_button);
            this.Controls.Add(this.gapa_button);
            this.Controls.Add(this.kasyno2_label);
            this.Controls.Add(this.kasyno_label);
            this.Controls.Add(this.blackjack_button);
            this.Controls.Add(this.wojna_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wojna_button;
        private System.Windows.Forms.Button blackjack_button;
        private System.Windows.Forms.Label kasyno_label;
        private System.Windows.Forms.Label kasyno2_label;
        private System.Windows.Forms.Button gapa_button;
        private System.Windows.Forms.Button roulette_button;
    }
}

