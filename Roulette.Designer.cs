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
            // this.Player = new AxWMPLib.AxWindowsMediaPlayer();
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
            this.bet_11 = new System.Windows.Forms.Button();
            this.bet_12 = new System.Windows.Forms.Button();
            this.bet_13 = new System.Windows.Forms.Button();
            this.bet_14 = new System.Windows.Forms.Button();
            this.bet_15 = new System.Windows.Forms.Button();
            this.bet_16 = new System.Windows.Forms.Button();
            this.bet_17 = new System.Windows.Forms.Button();
            this.bet_18 = new System.Windows.Forms.Button();
            this.bet_19 = new System.Windows.Forms.Button();
            this.bet_20 = new System.Windows.Forms.Button();
            this.bet_21 = new System.Windows.Forms.Button();
            this.bet_22 = new System.Windows.Forms.Button();
            this.bet_23 = new System.Windows.Forms.Button();
            this.bet_24 = new System.Windows.Forms.Button();
            this.bet_25 = new System.Windows.Forms.Button();
            this.bet_26 = new System.Windows.Forms.Button();
            this.bet_27 = new System.Windows.Forms.Button();
            this.bet_28 = new System.Windows.Forms.Button();
            this.bet_29 = new System.Windows.Forms.Button();
            this.bet_30 = new System.Windows.Forms.Button();
            this.bet_31 = new System.Windows.Forms.Button();
            this.bet_32 = new System.Windows.Forms.Button();
            this.bet_33 = new System.Windows.Forms.Button();
            this.bet_34 = new System.Windows.Forms.Button();
            this.bet_35 = new System.Windows.Forms.Button();
            this.bet_36 = new System.Windows.Forms.Button();
            this.bet_2to1_bottom = new System.Windows.Forms.Button();
            this.bet_2to1_middle = new System.Windows.Forms.Button();
            this.bet_2to1_top = new System.Windows.Forms.Button();
            this.bet_2nd12 = new System.Windows.Forms.Button();
            this.bet_1st12 = new System.Windows.Forms.Button();
            this.bet_3rd12 = new System.Windows.Forms.Button();
            this.roulette_picture = new System.Windows.Forms.PictureBox();
            this.bet_red = new System.Windows.Forms.Button();
            this.bet_black = new System.Windows.Forms.Button();
            this.bet_odd = new System.Windows.Forms.Button();
            this.bet_even = new System.Windows.Forms.Button();
            this.bet_1to18 = new System.Windows.Forms.Button();
            this.bet_19to36 = new System.Windows.Forms.Button();
            // ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betting_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roulette_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            /*this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(25, 28);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(300, 300);
            this.Player.TabIndex = 0;*/
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(130, 334);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // betting_table
            // 
            this.betting_table.BackColor = System.Drawing.Color.Transparent;
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
            this.bet_1.Click += new System.EventHandler(this.bet_1_Click);
            this.bet_1.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_1.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_1.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_1.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_2.Click += new System.EventHandler(this.bet_2_Click);
            this.bet_2.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_2.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_2.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_2.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_3.Click += new System.EventHandler(this.bet_3_Click);
            this.bet_3.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_3.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_3.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_3.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_4.Click += new System.EventHandler(this.bet_4_Click);
            this.bet_4.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_4.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_4.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_4.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_5.Click += new System.EventHandler(this.bet_5_Click);
            this.bet_5.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_5.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_5.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_5.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_6.Click += new System.EventHandler(this.bet_6_Click);
            this.bet_6.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_6.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_6.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_6.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_7.Click += new System.EventHandler(this.bet_7_Click);
            this.bet_7.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_7.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_7.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_7.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_8.Click += new System.EventHandler(this.bet_8_Click);
            this.bet_8.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_8.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_8.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_8.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_9.Click += new System.EventHandler(this.bet_9_Click);
            this.bet_9.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_9.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_9.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_9.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
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
            this.bet_10.Click += new System.EventHandler(this.bet_10_Click);
            this.bet_10.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_10.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_10.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_10.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_11
            // 
            this.bet_11.BackColor = System.Drawing.Color.Transparent;
            this.bet_11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_11.BackgroundImage")));
            this.bet_11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_11.ForeColor = System.Drawing.Color.Transparent;
            this.bet_11.Location = new System.Drawing.Point(494, 118);
            this.bet_11.Name = "bet_11";
            this.bet_11.Size = new System.Drawing.Size(35, 51);
            this.bet_11.TabIndex = 15;
            this.bet_11.UseVisualStyleBackColor = false;
            this.bet_11.Click += new System.EventHandler(this.bet_11_Click);
            this.bet_11.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_11.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_11.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_11.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_12
            // 
            this.bet_12.BackColor = System.Drawing.Color.Transparent;
            this.bet_12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_12.BackgroundImage")));
            this.bet_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_12.ForeColor = System.Drawing.Color.Transparent;
            this.bet_12.Location = new System.Drawing.Point(494, 69);
            this.bet_12.Name = "bet_12";
            this.bet_12.Size = new System.Drawing.Size(35, 51);
            this.bet_12.TabIndex = 16;
            this.bet_12.UseVisualStyleBackColor = false;
            this.bet_12.Click += new System.EventHandler(this.bet_12_Click);
            this.bet_12.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_12.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_12.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_12.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_13
            // 
            this.bet_13.BackColor = System.Drawing.Color.Transparent;
            this.bet_13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_13.BackgroundImage")));
            this.bet_13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_13.ForeColor = System.Drawing.Color.Transparent;
            this.bet_13.Location = new System.Drawing.Point(527, 168);
            this.bet_13.Name = "bet_13";
            this.bet_13.Size = new System.Drawing.Size(34, 51);
            this.bet_13.TabIndex = 17;
            this.bet_13.UseVisualStyleBackColor = false;
            this.bet_13.Click += new System.EventHandler(this.bet_13_Click);
            this.bet_13.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_13.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_13.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_13.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_14
            // 
            this.bet_14.BackColor = System.Drawing.Color.Transparent;
            this.bet_14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_14.BackgroundImage")));
            this.bet_14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_14.ForeColor = System.Drawing.Color.Transparent;
            this.bet_14.Location = new System.Drawing.Point(527, 118);
            this.bet_14.Name = "bet_14";
            this.bet_14.Size = new System.Drawing.Size(34, 51);
            this.bet_14.TabIndex = 18;
            this.bet_14.UseVisualStyleBackColor = false;
            this.bet_14.Click += new System.EventHandler(this.bet_14_Click);
            this.bet_14.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_14.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_14.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_14.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_15
            // 
            this.bet_15.BackColor = System.Drawing.Color.Transparent;
            this.bet_15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_15.BackgroundImage")));
            this.bet_15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_15.ForeColor = System.Drawing.Color.Transparent;
            this.bet_15.Location = new System.Drawing.Point(527, 69);
            this.bet_15.Name = "bet_15";
            this.bet_15.Size = new System.Drawing.Size(34, 51);
            this.bet_15.TabIndex = 19;
            this.bet_15.UseVisualStyleBackColor = false;
            this.bet_15.Click += new System.EventHandler(this.bet_15_Click);
            this.bet_15.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_15.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_15.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_15.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_16
            // 
            this.bet_16.BackColor = System.Drawing.Color.Transparent;
            this.bet_16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_16.BackgroundImage")));
            this.bet_16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_16.ForeColor = System.Drawing.Color.Transparent;
            this.bet_16.Location = new System.Drawing.Point(559, 168);
            this.bet_16.Name = "bet_16";
            this.bet_16.Size = new System.Drawing.Size(34, 51);
            this.bet_16.TabIndex = 20;
            this.bet_16.UseVisualStyleBackColor = false;
            this.bet_16.Click += new System.EventHandler(this.bet_16_Click);
            this.bet_16.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_16.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_16.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_16.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_17
            // 
            this.bet_17.BackColor = System.Drawing.Color.Transparent;
            this.bet_17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_17.BackgroundImage")));
            this.bet_17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_17.ForeColor = System.Drawing.Color.Transparent;
            this.bet_17.Location = new System.Drawing.Point(559, 118);
            this.bet_17.Name = "bet_17";
            this.bet_17.Size = new System.Drawing.Size(34, 51);
            this.bet_17.TabIndex = 21;
            this.bet_17.UseVisualStyleBackColor = false;
            this.bet_17.Click += new System.EventHandler(this.bet_17_Click);
            this.bet_17.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_17.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_17.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_17.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_18
            // 
            this.bet_18.BackColor = System.Drawing.Color.Transparent;
            this.bet_18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_18.BackgroundImage")));
            this.bet_18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_18.ForeColor = System.Drawing.Color.Transparent;
            this.bet_18.Location = new System.Drawing.Point(559, 69);
            this.bet_18.Name = "bet_18";
            this.bet_18.Size = new System.Drawing.Size(34, 51);
            this.bet_18.TabIndex = 22;
            this.bet_18.UseVisualStyleBackColor = false;
            this.bet_18.Click += new System.EventHandler(this.bet_18_Click);
            this.bet_18.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_18.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_18.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_18.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_19
            // 
            this.bet_19.BackColor = System.Drawing.Color.Transparent;
            this.bet_19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_19.BackgroundImage")));
            this.bet_19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_19.ForeColor = System.Drawing.Color.Transparent;
            this.bet_19.Location = new System.Drawing.Point(592, 168);
            this.bet_19.Name = "bet_19";
            this.bet_19.Size = new System.Drawing.Size(34, 51);
            this.bet_19.TabIndex = 23;
            this.bet_19.UseVisualStyleBackColor = false;
            this.bet_19.Click += new System.EventHandler(this.bet_19_Click);
            this.bet_19.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_19.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_19.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_19.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_20
            // 
            this.bet_20.BackColor = System.Drawing.Color.Transparent;
            this.bet_20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_20.BackgroundImage")));
            this.bet_20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_20.ForeColor = System.Drawing.Color.Transparent;
            this.bet_20.Location = new System.Drawing.Point(592, 118);
            this.bet_20.Name = "bet_20";
            this.bet_20.Size = new System.Drawing.Size(34, 51);
            this.bet_20.TabIndex = 24;
            this.bet_20.UseVisualStyleBackColor = false;
            this.bet_20.Click += new System.EventHandler(this.bet_20_Click);
            this.bet_20.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_20.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_20.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_20.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_21
            // 
            this.bet_21.BackColor = System.Drawing.Color.Transparent;
            this.bet_21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_21.BackgroundImage")));
            this.bet_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_21.ForeColor = System.Drawing.Color.Transparent;
            this.bet_21.Location = new System.Drawing.Point(592, 69);
            this.bet_21.Name = "bet_21";
            this.bet_21.Size = new System.Drawing.Size(34, 51);
            this.bet_21.TabIndex = 25;
            this.bet_21.UseVisualStyleBackColor = false;
            this.bet_21.Click += new System.EventHandler(this.bet_21_Click);
            this.bet_21.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_21.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_21.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_21.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_22
            // 
            this.bet_22.BackColor = System.Drawing.Color.Transparent;
            this.bet_22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_22.BackgroundImage")));
            this.bet_22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_22.ForeColor = System.Drawing.Color.Transparent;
            this.bet_22.Location = new System.Drawing.Point(624, 168);
            this.bet_22.Name = "bet_22";
            this.bet_22.Size = new System.Drawing.Size(34, 51);
            this.bet_22.TabIndex = 26;
            this.bet_22.UseVisualStyleBackColor = false;
            this.bet_22.Click += new System.EventHandler(this.bet_22_Click);
            this.bet_22.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_22.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_22.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_22.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_23
            // 
            this.bet_23.BackColor = System.Drawing.Color.Transparent;
            this.bet_23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_23.BackgroundImage")));
            this.bet_23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_23.ForeColor = System.Drawing.Color.Transparent;
            this.bet_23.Location = new System.Drawing.Point(624, 118);
            this.bet_23.Name = "bet_23";
            this.bet_23.Size = new System.Drawing.Size(34, 51);
            this.bet_23.TabIndex = 27;
            this.bet_23.UseVisualStyleBackColor = false;
            this.bet_23.Click += new System.EventHandler(this.bet_23_Click);
            this.bet_23.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_23.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_23.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_23.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_24
            // 
            this.bet_24.BackColor = System.Drawing.Color.Transparent;
            this.bet_24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_24.BackgroundImage")));
            this.bet_24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_24.ForeColor = System.Drawing.Color.Transparent;
            this.bet_24.Location = new System.Drawing.Point(624, 69);
            this.bet_24.Name = "bet_24";
            this.bet_24.Size = new System.Drawing.Size(34, 51);
            this.bet_24.TabIndex = 28;
            this.bet_24.UseVisualStyleBackColor = false;
            this.bet_24.Click += new System.EventHandler(this.bet_24_Click);
            this.bet_24.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_24.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_24.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_24.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_25
            // 
            this.bet_25.BackColor = System.Drawing.Color.Transparent;
            this.bet_25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_25.BackgroundImage")));
            this.bet_25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_25.ForeColor = System.Drawing.Color.Transparent;
            this.bet_25.Location = new System.Drawing.Point(656, 168);
            this.bet_25.Name = "bet_25";
            this.bet_25.Size = new System.Drawing.Size(34, 51);
            this.bet_25.TabIndex = 29;
            this.bet_25.UseVisualStyleBackColor = false;
            this.bet_25.Click += new System.EventHandler(this.bet_25_Click);
            this.bet_25.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_25.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_25.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_25.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_26
            // 
            this.bet_26.BackColor = System.Drawing.Color.Transparent;
            this.bet_26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_26.BackgroundImage")));
            this.bet_26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_26.ForeColor = System.Drawing.Color.Transparent;
            this.bet_26.Location = new System.Drawing.Point(656, 118);
            this.bet_26.Name = "bet_26";
            this.bet_26.Size = new System.Drawing.Size(34, 51);
            this.bet_26.TabIndex = 30;
            this.bet_26.UseVisualStyleBackColor = false;
            this.bet_26.Click += new System.EventHandler(this.bet_26_Click);
            this.bet_26.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_26.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_26.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_26.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_27
            // 
            this.bet_27.BackColor = System.Drawing.Color.Transparent;
            this.bet_27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_27.BackgroundImage")));
            this.bet_27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_27.ForeColor = System.Drawing.Color.Transparent;
            this.bet_27.Location = new System.Drawing.Point(656, 69);
            this.bet_27.Name = "bet_27";
            this.bet_27.Size = new System.Drawing.Size(34, 51);
            this.bet_27.TabIndex = 31;
            this.bet_27.UseVisualStyleBackColor = false;
            this.bet_27.Click += new System.EventHandler(this.bet_27_Click);
            this.bet_27.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_27.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_27.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_27.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_28
            // 
            this.bet_28.BackColor = System.Drawing.Color.Transparent;
            this.bet_28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_28.BackgroundImage")));
            this.bet_28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_28.ForeColor = System.Drawing.Color.Transparent;
            this.bet_28.Location = new System.Drawing.Point(688, 168);
            this.bet_28.Name = "bet_28";
            this.bet_28.Size = new System.Drawing.Size(35, 51);
            this.bet_28.TabIndex = 32;
            this.bet_28.UseVisualStyleBackColor = false;
            this.bet_28.Click += new System.EventHandler(this.bet_28_Click);
            this.bet_28.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_28.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_28.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_28.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_29
            // 
            this.bet_29.BackColor = System.Drawing.Color.Transparent;
            this.bet_29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_29.BackgroundImage")));
            this.bet_29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_29.ForeColor = System.Drawing.Color.Transparent;
            this.bet_29.Location = new System.Drawing.Point(688, 118);
            this.bet_29.Name = "bet_29";
            this.bet_29.Size = new System.Drawing.Size(35, 51);
            this.bet_29.TabIndex = 33;
            this.bet_29.UseVisualStyleBackColor = false;
            this.bet_29.Click += new System.EventHandler(this.bet_29_Click);
            this.bet_29.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_29.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_29.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_29.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_30
            // 
            this.bet_30.BackColor = System.Drawing.Color.Transparent;
            this.bet_30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_30.BackgroundImage")));
            this.bet_30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_30.ForeColor = System.Drawing.Color.Transparent;
            this.bet_30.Location = new System.Drawing.Point(688, 69);
            this.bet_30.Name = "bet_30";
            this.bet_30.Size = new System.Drawing.Size(35, 51);
            this.bet_30.TabIndex = 34;
            this.bet_30.UseVisualStyleBackColor = false;
            this.bet_30.Click += new System.EventHandler(this.bet_30_Click);
            this.bet_30.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_30.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_30.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_30.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_31
            // 
            this.bet_31.BackColor = System.Drawing.Color.Transparent;
            this.bet_31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_31.BackgroundImage")));
            this.bet_31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_31.ForeColor = System.Drawing.Color.Transparent;
            this.bet_31.Location = new System.Drawing.Point(721, 168);
            this.bet_31.Name = "bet_31";
            this.bet_31.Size = new System.Drawing.Size(34, 51);
            this.bet_31.TabIndex = 35;
            this.bet_31.UseVisualStyleBackColor = false;
            this.bet_31.Click += new System.EventHandler(this.bet_31_Click);
            this.bet_31.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_31.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_31.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_31.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_32
            // 
            this.bet_32.BackColor = System.Drawing.Color.Transparent;
            this.bet_32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_32.BackgroundImage")));
            this.bet_32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_32.ForeColor = System.Drawing.Color.Transparent;
            this.bet_32.Location = new System.Drawing.Point(721, 118);
            this.bet_32.Name = "bet_32";
            this.bet_32.Size = new System.Drawing.Size(34, 51);
            this.bet_32.TabIndex = 36;
            this.bet_32.UseVisualStyleBackColor = false;
            this.bet_32.Click += new System.EventHandler(this.bet_32_Click);
            this.bet_32.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_32.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_32.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_32.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_33
            // 
            this.bet_33.BackColor = System.Drawing.Color.Transparent;
            this.bet_33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_33.BackgroundImage")));
            this.bet_33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_33.ForeColor = System.Drawing.Color.Transparent;
            this.bet_33.Location = new System.Drawing.Point(721, 69);
            this.bet_33.Name = "bet_33";
            this.bet_33.Size = new System.Drawing.Size(34, 51);
            this.bet_33.TabIndex = 37;
            this.bet_33.UseVisualStyleBackColor = false;
            this.bet_33.Click += new System.EventHandler(this.bet_33_Click);
            this.bet_33.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_33.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_33.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_33.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_34
            // 
            this.bet_34.BackColor = System.Drawing.Color.Transparent;
            this.bet_34.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_34.BackgroundImage")));
            this.bet_34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_34.ForeColor = System.Drawing.Color.Transparent;
            this.bet_34.Location = new System.Drawing.Point(753, 168);
            this.bet_34.Name = "bet_34";
            this.bet_34.Size = new System.Drawing.Size(34, 51);
            this.bet_34.TabIndex = 38;
            this.bet_34.UseVisualStyleBackColor = false;
            this.bet_34.Click += new System.EventHandler(this.bet_34_Click);
            this.bet_34.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_34.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_34.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_34.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_35
            // 
            this.bet_35.BackColor = System.Drawing.Color.Transparent;
            this.bet_35.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_35.BackgroundImage")));
            this.bet_35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_35.ForeColor = System.Drawing.Color.Transparent;
            this.bet_35.Location = new System.Drawing.Point(753, 118);
            this.bet_35.Name = "bet_35";
            this.bet_35.Size = new System.Drawing.Size(34, 51);
            this.bet_35.TabIndex = 39;
            this.bet_35.UseVisualStyleBackColor = false;
            this.bet_35.Click += new System.EventHandler(this.bet_35_Click);
            this.bet_35.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_35.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_35.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_35.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_36
            // 
            this.bet_36.BackColor = System.Drawing.Color.Transparent;
            this.bet_36.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_36.BackgroundImage")));
            this.bet_36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_36.ForeColor = System.Drawing.Color.Transparent;
            this.bet_36.Location = new System.Drawing.Point(753, 69);
            this.bet_36.Name = "bet_36";
            this.bet_36.Size = new System.Drawing.Size(34, 51);
            this.bet_36.TabIndex = 40;
            this.bet_36.UseVisualStyleBackColor = false;
            this.bet_36.Click += new System.EventHandler(this.bet_36_Click);
            this.bet_36.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_36.Leave += new System.EventHandler(this.bet_button_Leave);
            this.bet_36.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_36.MouseLeave += new System.EventHandler(this.bet_button_MouseLeave);
            // 
            // bet_2to1_bottom
            // 
            this.bet_2to1_bottom.BackColor = System.Drawing.Color.Transparent;
            this.bet_2to1_bottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_2to1_bottom.BackgroundImage")));
            this.bet_2to1_bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_2to1_bottom.FlatAppearance.BorderSize = 0;
            this.bet_2to1_bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_2to1_bottom.ForeColor = System.Drawing.Color.Transparent;
            this.bet_2to1_bottom.Location = new System.Drawing.Point(786, 169);
            this.bet_2to1_bottom.Name = "bet_2to1_bottom";
            this.bet_2to1_bottom.Size = new System.Drawing.Size(33, 49);
            this.bet_2to1_bottom.TabIndex = 41;
            this.bet_2to1_bottom.UseVisualStyleBackColor = false;
            this.bet_2to1_bottom.Click += new System.EventHandler(this.bet_2to1_bottom_Click);
            this.bet_2to1_bottom.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_2to1_bottom.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_2to1_bottom.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_2to1_bottom.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_2to1_middle
            // 
            this.bet_2to1_middle.BackColor = System.Drawing.Color.Transparent;
            this.bet_2to1_middle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_2to1_middle.BackgroundImage")));
            this.bet_2to1_middle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_2to1_middle.FlatAppearance.BorderSize = 0;
            this.bet_2to1_middle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_2to1_middle.ForeColor = System.Drawing.Color.Transparent;
            this.bet_2to1_middle.Location = new System.Drawing.Point(786, 119);
            this.bet_2to1_middle.Name = "bet_2to1_middle";
            this.bet_2to1_middle.Size = new System.Drawing.Size(33, 49);
            this.bet_2to1_middle.TabIndex = 42;
            this.bet_2to1_middle.UseVisualStyleBackColor = false;
            this.bet_2to1_middle.Click += new System.EventHandler(this.bet_2to1_middle_Click);
            this.bet_2to1_middle.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_2to1_middle.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_2to1_middle.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_2to1_middle.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_2to1_top
            // 
            this.bet_2to1_top.BackColor = System.Drawing.Color.Transparent;
            this.bet_2to1_top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_2to1_top.BackgroundImage")));
            this.bet_2to1_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_2to1_top.FlatAppearance.BorderSize = 0;
            this.bet_2to1_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_2to1_top.ForeColor = System.Drawing.Color.Transparent;
            this.bet_2to1_top.Location = new System.Drawing.Point(786, 70);
            this.bet_2to1_top.Name = "bet_2to1_top";
            this.bet_2to1_top.Size = new System.Drawing.Size(33, 49);
            this.bet_2to1_top.TabIndex = 43;
            this.bet_2to1_top.UseVisualStyleBackColor = false;
            this.bet_2to1_top.Click += new System.EventHandler(this.bet_2to1_top_Click);
            this.bet_2to1_top.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_2to1_top.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_2to1_top.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_2to1_top.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_2nd12
            // 
            this.bet_2nd12.BackColor = System.Drawing.Color.Transparent;
            this.bet_2nd12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_2nd12.BackgroundImage")));
            this.bet_2nd12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_2nd12.FlatAppearance.BorderSize = 0;
            this.bet_2nd12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_2nd12.ForeColor = System.Drawing.Color.Transparent;
            this.bet_2nd12.Location = new System.Drawing.Point(528, 218);
            this.bet_2nd12.Name = "bet_2nd12";
            this.bet_2nd12.Size = new System.Drawing.Size(128, 34);
            this.bet_2nd12.TabIndex = 44;
            this.bet_2nd12.UseVisualStyleBackColor = false;
            this.bet_2nd12.Click += new System.EventHandler(this.bet_2nd12_Click);
            this.bet_2nd12.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_2nd12.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_2nd12.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_2nd12.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_1st12
            // 
            this.bet_1st12.BackColor = System.Drawing.Color.Transparent;
            this.bet_1st12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_1st12.BackgroundImage")));
            this.bet_1st12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_1st12.FlatAppearance.BorderSize = 0;
            this.bet_1st12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_1st12.ForeColor = System.Drawing.Color.Transparent;
            this.bet_1st12.Location = new System.Drawing.Point(398, 218);
            this.bet_1st12.Name = "bet_1st12";
            this.bet_1st12.Size = new System.Drawing.Size(130, 34);
            this.bet_1st12.TabIndex = 45;
            this.bet_1st12.UseVisualStyleBackColor = false;
            this.bet_1st12.Click += new System.EventHandler(this.bet_1st12_Click);
            this.bet_1st12.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_1st12.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_1st12.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_1st12.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_3rd12
            // 
            this.bet_3rd12.BackColor = System.Drawing.Color.Transparent;
            this.bet_3rd12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_3rd12.BackgroundImage")));
            this.bet_3rd12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_3rd12.FlatAppearance.BorderSize = 0;
            this.bet_3rd12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_3rd12.ForeColor = System.Drawing.Color.Transparent;
            this.bet_3rd12.Location = new System.Drawing.Point(657, 218);
            this.bet_3rd12.Name = "bet_3rd12";
            this.bet_3rd12.Size = new System.Drawing.Size(129, 34);
            this.bet_3rd12.TabIndex = 46;
            this.bet_3rd12.UseVisualStyleBackColor = false;
            this.bet_3rd12.Click += new System.EventHandler(this.bet_3rd12_Click);
            this.bet_3rd12.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_3rd12.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_3rd12.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_3rd12.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // roulette_picture
            // 
            this.roulette_picture.BackColor = System.Drawing.Color.Transparent;
            this.roulette_picture.Location = new System.Drawing.Point(25, 28);
            this.roulette_picture.Name = "roulette_picture";
            this.roulette_picture.Size = new System.Drawing.Size(300, 300);
            this.roulette_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roulette_picture.TabIndex = 47;
            this.roulette_picture.TabStop = false;
            // 
            // bet_red
            // 
            this.bet_red.BackColor = System.Drawing.Color.Transparent;
            this.bet_red.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_red.BackgroundImage")));
            this.bet_red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_red.FlatAppearance.BorderSize = 0;
            this.bet_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_red.ForeColor = System.Drawing.Color.Transparent;
            this.bet_red.Location = new System.Drawing.Point(528, 252);
            this.bet_red.Name = "bet_red";
            this.bet_red.Size = new System.Drawing.Size(64, 34);
            this.bet_red.TabIndex = 49;
            this.bet_red.UseVisualStyleBackColor = false;
            this.bet_red.Click += new System.EventHandler(this.bet_red_Click);
            this.bet_red.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_red.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_red.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_red.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_black
            // 
            this.bet_black.BackColor = System.Drawing.Color.Transparent;
            this.bet_black.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_black.BackgroundImage")));
            this.bet_black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_black.FlatAppearance.BorderSize = 0;
            this.bet_black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_black.ForeColor = System.Drawing.Color.Transparent;
            this.bet_black.Location = new System.Drawing.Point(592, 252);
            this.bet_black.Name = "bet_black";
            this.bet_black.Size = new System.Drawing.Size(64, 34);
            this.bet_black.TabIndex = 50;
            this.bet_black.UseVisualStyleBackColor = false;
            this.bet_black.Click += new System.EventHandler(this.bet_black_Click);
            this.bet_black.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_black.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_black.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_black.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_odd
            // 
            this.bet_odd.BackColor = System.Drawing.Color.Transparent;
            this.bet_odd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_odd.BackgroundImage")));
            this.bet_odd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_odd.FlatAppearance.BorderSize = 0;
            this.bet_odd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_odd.ForeColor = System.Drawing.Color.Transparent;
            this.bet_odd.Location = new System.Drawing.Point(657, 252);
            this.bet_odd.Name = "bet_odd";
            this.bet_odd.Size = new System.Drawing.Size(64, 34);
            this.bet_odd.TabIndex = 51;
            this.bet_odd.UseVisualStyleBackColor = false;
            this.bet_odd.Click += new System.EventHandler(this.bet_odd_Click);
            this.bet_odd.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_odd.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_odd.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_odd.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_even
            // 
            this.bet_even.BackColor = System.Drawing.Color.Transparent;
            this.bet_even.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_even.BackgroundImage")));
            this.bet_even.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_even.FlatAppearance.BorderSize = 0;
            this.bet_even.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_even.ForeColor = System.Drawing.Color.Transparent;
            this.bet_even.Location = new System.Drawing.Point(463, 252);
            this.bet_even.Name = "bet_even";
            this.bet_even.Size = new System.Drawing.Size(64, 34);
            this.bet_even.TabIndex = 52;
            this.bet_even.UseVisualStyleBackColor = false;
            this.bet_even.Click += new System.EventHandler(this.bet_even_Click);
            this.bet_even.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_even.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_even.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_even.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_1to18
            // 
            this.bet_1to18.BackColor = System.Drawing.Color.Transparent;
            this.bet_1to18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_1to18.BackgroundImage")));
            this.bet_1to18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_1to18.FlatAppearance.BorderSize = 0;
            this.bet_1to18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_1to18.ForeColor = System.Drawing.Color.Transparent;
            this.bet_1to18.Location = new System.Drawing.Point(398, 252);
            this.bet_1to18.Name = "bet_1to18";
            this.bet_1to18.Size = new System.Drawing.Size(64, 34);
            this.bet_1to18.TabIndex = 53;
            this.bet_1to18.UseVisualStyleBackColor = false;
            this.bet_1to18.Click += new System.EventHandler(this.bet_1to18_Click);
            this.bet_1to18.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_1to18.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_1to18.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_1to18.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // bet_19to36
            // 
            this.bet_19to36.BackColor = System.Drawing.Color.Transparent;
            this.bet_19to36.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bet_19to36.BackgroundImage")));
            this.bet_19to36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bet_19to36.FlatAppearance.BorderSize = 0;
            this.bet_19to36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet_19to36.ForeColor = System.Drawing.Color.Transparent;
            this.bet_19to36.Location = new System.Drawing.Point(721, 252);
            this.bet_19to36.Name = "bet_19to36";
            this.bet_19to36.Size = new System.Drawing.Size(64, 34);
            this.bet_19to36.TabIndex = 54;
            this.bet_19to36.UseVisualStyleBackColor = false;
            this.bet_19to36.Click += new System.EventHandler(this.bet_19to36_Click);
            this.bet_19to36.Enter += new System.EventHandler(this.bet_button_Enter);
            this.bet_19to36.Leave += new System.EventHandler(this.bet_button_2_Leave);
            this.bet_19to36.MouseEnter += new System.EventHandler(this.bet_button_MouseEnter);
            this.bet_19to36.MouseLeave += new System.EventHandler(this.bet_button_2_MouseLeave);
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 377);
            this.Controls.Add(this.bet_19to36);
            this.Controls.Add(this.bet_1to18);
            this.Controls.Add(this.bet_even);
            this.Controls.Add(this.bet_odd);
            this.Controls.Add(this.bet_black);
            this.Controls.Add(this.bet_red);
            this.Controls.Add(this.roulette_picture);
            this.Controls.Add(this.bet_3rd12);
            this.Controls.Add(this.bet_1st12);
            this.Controls.Add(this.bet_2nd12);
            this.Controls.Add(this.bet_2to1_top);
            this.Controls.Add(this.bet_2to1_middle);
            this.Controls.Add(this.bet_2to1_bottom);
            this.Controls.Add(this.bet_36);
            this.Controls.Add(this.bet_35);
            this.Controls.Add(this.bet_34);
            this.Controls.Add(this.bet_33);
            this.Controls.Add(this.bet_32);
            this.Controls.Add(this.bet_31);
            this.Controls.Add(this.bet_30);
            this.Controls.Add(this.bet_29);
            this.Controls.Add(this.bet_28);
            this.Controls.Add(this.bet_27);
            this.Controls.Add(this.bet_26);
            this.Controls.Add(this.bet_25);
            this.Controls.Add(this.bet_24);
            this.Controls.Add(this.bet_23);
            this.Controls.Add(this.bet_22);
            this.Controls.Add(this.bet_21);
            this.Controls.Add(this.bet_20);
            this.Controls.Add(this.bet_19);
            this.Controls.Add(this.bet_18);
            this.Controls.Add(this.bet_17);
            this.Controls.Add(this.bet_16);
            this.Controls.Add(this.bet_15);
            this.Controls.Add(this.bet_14);
            this.Controls.Add(this.bet_13);
            this.Controls.Add(this.bet_12);
            this.Controls.Add(this.bet_11);
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
            // this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Roulette";
            this.Text = "Roulette";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Roulette_FormClosed);
            // ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betting_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roulette_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // private AxWMPLib.AxWindowsMediaPlayer Player;
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
        private System.Windows.Forms.Button bet_11;
        private System.Windows.Forms.Button bet_12;
        private System.Windows.Forms.Button bet_13;
        private System.Windows.Forms.Button bet_14;
        private System.Windows.Forms.Button bet_15;
        private System.Windows.Forms.Button bet_16;
        private System.Windows.Forms.Button bet_17;
        private System.Windows.Forms.Button bet_18;
        private System.Windows.Forms.Button bet_19;
        private System.Windows.Forms.Button bet_20;
        private System.Windows.Forms.Button bet_21;
        private System.Windows.Forms.Button bet_22;
        private System.Windows.Forms.Button bet_23;
        private System.Windows.Forms.Button bet_24;
        private System.Windows.Forms.Button bet_25;
        private System.Windows.Forms.Button bet_26;
        private System.Windows.Forms.Button bet_27;
        private System.Windows.Forms.Button bet_28;
        private System.Windows.Forms.Button bet_29;
        private System.Windows.Forms.Button bet_30;
        private System.Windows.Forms.Button bet_31;
        private System.Windows.Forms.Button bet_32;
        private System.Windows.Forms.Button bet_33;
        private System.Windows.Forms.Button bet_34;
        private System.Windows.Forms.Button bet_35;
        private System.Windows.Forms.Button bet_36;
        private System.Windows.Forms.Button bet_2to1_bottom;
        private System.Windows.Forms.Button bet_2to1_middle;
        private System.Windows.Forms.Button bet_2to1_top;
        private System.Windows.Forms.Button bet_2nd12;
        private System.Windows.Forms.Button bet_1st12;
        private System.Windows.Forms.Button bet_3rd12;
        private System.Windows.Forms.PictureBox roulette_picture;
        private System.Windows.Forms.Button bet_red;
        private System.Windows.Forms.Button bet_black;
        private System.Windows.Forms.Button bet_odd;
        private System.Windows.Forms.Button bet_even;
        private System.Windows.Forms.Button bet_1to18;
        private System.Windows.Forms.Button bet_19to36;
    }
}