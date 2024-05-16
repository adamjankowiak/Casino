namespace Kasyno
{
    partial class DontGiveUp
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
            this.are_you_sure_label = new System.Windows.Forms.Label();
            this.back_to_the_game_label = new System.Windows.Forms.Label();
            this.i_quit_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // are_you_sure_label
            // 
            this.are_you_sure_label.AutoSize = true;
            this.are_you_sure_label.BackColor = System.Drawing.Color.Transparent;
            this.are_you_sure_label.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.are_you_sure_label.ForeColor = System.Drawing.Color.White;
            this.are_you_sure_label.Location = new System.Drawing.Point(228, 195);
            this.are_you_sure_label.Name = "are_you_sure_label";
            this.are_you_sure_label.Size = new System.Drawing.Size(220, 44);
            this.are_you_sure_label.TabIndex = 0;
            this.are_you_sure_label.Text = "Na pewno?";
            // 
            // back_to_the_game_label
            // 
            this.back_to_the_game_label.AutoSize = true;
            this.back_to_the_game_label.BackColor = System.Drawing.Color.Transparent;
            this.back_to_the_game_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_to_the_game_label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_to_the_game_label.ForeColor = System.Drawing.Color.White;
            this.back_to_the_game_label.Location = new System.Drawing.Point(274, 83);
            this.back_to_the_game_label.MinimumSize = new System.Drawing.Size(120, 50);
            this.back_to_the_game_label.Name = "back_to_the_game_label";
            this.back_to_the_game_label.Size = new System.Drawing.Size(174, 50);
            this.back_to_the_game_label.TabIndex = 1;
            this.back_to_the_game_label.Text = "GRAM DALEJ";
            this.back_to_the_game_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back_to_the_game_label.Click += new System.EventHandler(this.back_to_the_game_label_Click);
            // 
            // i_quit_label
            // 
            this.i_quit_label.AutoSize = true;
            this.i_quit_label.BackColor = System.Drawing.Color.Transparent;
            this.i_quit_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.i_quit_label.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_quit_label.ForeColor = System.Drawing.Color.White;
            this.i_quit_label.Location = new System.Drawing.Point(69, 337);
            this.i_quit_label.MinimumSize = new System.Drawing.Size(180, 50);
            this.i_quit_label.Name = "i_quit_label";
            this.i_quit_label.Size = new System.Drawing.Size(180, 50);
            this.i_quit_label.TabIndex = 2;
            this.i_quit_label.Text = "REZYGNUJE";
            this.i_quit_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.i_quit_label.Click += new System.EventHandler(this.i_quit_label_Click);
            // 
            // DontGiveUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kasyno.Properties.Resources.dontgiveup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 532);
            this.Controls.Add(this.i_quit_label);
            this.Controls.Add(this.back_to_the_game_label);
            this.Controls.Add(this.are_you_sure_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Kasyno.Properties.Resources.spades_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DontGiveUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dont Give Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DontGiveUp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label are_you_sure_label;
        private System.Windows.Forms.Label back_to_the_game_label;
        private System.Windows.Forms.Label i_quit_label;
    }
}