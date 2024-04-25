namespace Kasyno
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // wojna_button
            // 
            this.wojna_button.Location = new System.Drawing.Point(295, 193);
            this.wojna_button.Name = "wojna_button";
            this.wojna_button.Size = new System.Drawing.Size(225, 60);
            this.wojna_button.TabIndex = 0;
            this.wojna_button.Text = "Wojna";
            this.wojna_button.UseVisualStyleBackColor = true;
            this.wojna_button.Click += new System.EventHandler(this.wojna_button_Click);
            // 
            // blackjack_button
            // 
            this.blackjack_button.Location = new System.Drawing.Point(295, 277);
            this.blackjack_button.Name = "blackjack_button";
            this.blackjack_button.Size = new System.Drawing.Size(225, 60);
            this.blackjack_button.TabIndex = 1;
            this.blackjack_button.Text = "Blackjack";
            this.blackjack_button.UseVisualStyleBackColor = true;
            this.blackjack_button.Click += new System.EventHandler(this.blackjack_button_Click);
            // 
            // kasyno_label
            // 
            this.kasyno_label.AutoSize = true;
            this.kasyno_label.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasyno_label.Location = new System.Drawing.Point(171, 74);
            this.kasyno_label.Name = "kasyno_label";
            this.kasyno_label.Size = new System.Drawing.Size(490, 56);
            this.kasyno_label.TabIndex = 2;
            this.kasyno_label.Text = "Grube Inc. Kasyno";
            // 
            // kasyno2_label
            // 
            this.kasyno2_label.AutoSize = true;
            this.kasyno2_label.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasyno2_label.ForeColor = System.Drawing.Color.Firebrick;
            this.kasyno2_label.Location = new System.Drawing.Point(455, 130);
            this.kasyno2_label.Name = "kasyno2_label";
            this.kasyno2_label.Size = new System.Drawing.Size(172, 21);
            this.kasyno2_label.TabIndex = 3;
            this.kasyno2_label.Text = "SAME GRUBE RYBY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 545);
            this.Controls.Add(this.kasyno2_label);
            this.Controls.Add(this.kasyno_label);
            this.Controls.Add(this.blackjack_button);
            this.Controls.Add(this.wojna_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wojna_button;
        private System.Windows.Forms.Button blackjack_button;
        private System.Windows.Forms.Label kasyno_label;
        private System.Windows.Forms.Label kasyno2_label;
    }
}

