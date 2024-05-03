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
            this.karty_gracza_1 = new System.Windows.Forms.TextBox();
            this.talia_gracza_2 = new System.Windows.Forms.TextBox();
            this.karty_gracza1 = new System.Windows.Forms.Label();
            this.karty_gracza2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // karty_gracza_1
            // 
            this.karty_gracza_1.Location = new System.Drawing.Point(66, 321);
            this.karty_gracza_1.Name = "karty_gracza_1";
            this.karty_gracza_1.Size = new System.Drawing.Size(100, 31);
            this.karty_gracza_1.TabIndex = 0;
            this.karty_gracza_1.TextChanged += new System.EventHandler(this.karty_gracza_1_TextChanged);
            // 
            // talia_gracza_2
            // 
            this.talia_gracza_2.Location = new System.Drawing.Point(1008, 321);
            this.talia_gracza_2.Name = "talia_gracza_2";
            this.talia_gracza_2.Size = new System.Drawing.Size(100, 31);
            this.talia_gracza_2.TabIndex = 1;
            this.talia_gracza_2.TextChanged += new System.EventHandler(this.talia_gracza_2_TextChanged);
            // 
            // karty_gracza1
            // 
            this.karty_gracza1.AutoSize = true;
            this.karty_gracza1.Location = new System.Drawing.Point(12, 251);
            this.karty_gracza1.Name = "karty_gracza1";
            this.karty_gracza1.Size = new System.Drawing.Size(216, 25);
            this.karty_gracza1.TabIndex = 2;
            this.karty_gracza1.Text = "Pozostałe twoje karty";
            // 
            // karty_gracza2
            // 
            this.karty_gracza2.AutoSize = true;
            this.karty_gracza2.Location = new System.Drawing.Point(926, 251);
            this.karty_gracza2.Name = "karty_gracza2";
            this.karty_gracza2.Size = new System.Drawing.Size(267, 25);
            this.karty_gracza2.TabIndex = 3;
            this.karty_gracza2.Text = "Pozostałe karty komputera";
            // 
            // gra1os
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 712);
            this.Controls.Add(this.karty_gracza2);
            this.Controls.Add(this.karty_gracza1);
            this.Controls.Add(this.talia_gracza_2);
            this.Controls.Add(this.karty_gracza_1);
            this.Name = "gra1os";
            this.Text = "Gra 1-osobowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox karty_gracza_1;
        private System.Windows.Forms.TextBox talia_gracza_2;
        private System.Windows.Forms.Label karty_gracza1;
        private System.Windows.Forms.Label karty_gracza2;
    }
}