namespace Kasyno
{
    partial class wojna_gra
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
            this.SuspendLayout();
            // 
            // karty_gracza_1
            // 
            this.karty_gracza_1.Location = new System.Drawing.Point(23, 111);
            this.karty_gracza_1.Name = "karty_gracza_1";
            this.karty_gracza_1.Size = new System.Drawing.Size(100, 31);
            this.karty_gracza_1.TabIndex = 0;
            this.karty_gracza_1.TextChanged += new System.EventHandler(this.karty_gracza_1_TextChanged);
            // 
            // talia_gracza_2
            // 
            this.talia_gracza_2.Location = new System.Drawing.Point(581, 111);
            this.talia_gracza_2.Name = "talia_gracza_2";
            this.talia_gracza_2.Size = new System.Drawing.Size(100, 31);
            this.talia_gracza_2.TabIndex = 1;
            // 
            // wojna_gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.talia_gracza_2);
            this.Controls.Add(this.karty_gracza_1);
            this.Name = "wojna_gra";
            this.Text = "wojna_gra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox karty_gracza_1;
        private System.Windows.Forms.TextBox talia_gracza_2;
    }
}