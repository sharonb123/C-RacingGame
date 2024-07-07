namespace Car_Racing_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ImgCar = new PictureBox();
            enemy3 = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            lblGameover = new Label();
            coin1 = new PictureBox();
            coin3 = new PictureBox();
            coin4 = new PictureBox();
            coin2 = new PictureBox();
            lblCoinCounter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(177, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 122);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(177, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 75);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(177, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 107);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(177, 388);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 79);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Location = new Point(-1, -6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(11, 469);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Location = new Point(374, -2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(11, 469);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // ImgCar
            // 
            ImgCar.Image = (Image)resources.GetObject("ImgCar.Image");
            ImgCar.Location = new Point(47, 351);
            ImgCar.Name = "ImgCar";
            ImgCar.Size = new Size(38, 56);
            ImgCar.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgCar.TabIndex = 6;
            ImgCar.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(47, 75);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(38, 56);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 7;
            enemy3.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(270, 106);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(38, 56);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 8;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(223, 250);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(38, 56);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 9;
            enemy2.TabStop = false;
            // 
            // lblGameover
            // 
            lblGameover.AutoSize = true;
            lblGameover.BackColor = Color.FromArgb(255, 255, 128);
            lblGameover.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameover.ForeColor = Color.Red;
            lblGameover.Location = new Point(104, 165);
            lblGameover.Name = "lblGameover";
            lblGameover.Size = new Size(171, 40);
            lblGameover.TabIndex = 10;
            lblGameover.Text = "Game Over";
            // 
            // coin1
            // 
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(47, 229);
            coin1.Name = "coin1";
            coin1.Size = new Size(25, 25);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 11;
            coin1.TabStop = false;
            // 
            // coin3
            // 
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(206, 137);
            coin3.Name = "coin3";
            coin3.Size = new Size(25, 25);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 12;
            coin3.TabStop = false;
            // 
            // coin4
            // 
            coin4.Image = (Image)resources.GetObject("coin4.Image");
            coin4.Location = new Point(299, 218);
            coin4.Name = "coin4";
            coin4.Size = new Size(25, 25);
            coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            coin4.TabIndex = 13;
            coin4.TabStop = false;
            // 
            // coin2
            // 
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(104, 75);
            coin2.Name = "coin2";
            coin2.Size = new Size(25, 25);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 14;
            coin2.TabStop = false;
            // 
            // lblCoinCounter
            // 
            lblCoinCounter.AutoSize = true;
            lblCoinCounter.BackColor = Color.Transparent;
            lblCoinCounter.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoinCounter.ForeColor = Color.Yellow;
            lblCoinCounter.Location = new Point(12, 9);
            lblCoinCounter.Name = "lblCoinCounter";
            lblCoinCounter.Size = new Size(106, 30);
            lblCoinCounter.TabIndex = 15;
            lblCoinCounter.Text = "Coins = 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(384, 461);
            Controls.Add(lblCoinCounter);
            Controls.Add(coin2);
            Controls.Add(coin4);
            Controls.Add(coin3);
            Controls.Add(coin1);
            Controls.Add(lblGameover);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(enemy3);
            Controls.Add(ImgCar);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Car Game";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private PictureBox ImgCar;
        private PictureBox enemy3;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private Label lblGameover;
        private PictureBox coin1;
        private PictureBox coin3;
        private PictureBox coin4;
        private PictureBox coin2;
        private Label lblCoinCounter;
    }
}
