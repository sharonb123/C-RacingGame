namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblGameover.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            collectioncoins();

        }

        int collectedcoins = 0;

        Random r = new Random();
        int x, y;

        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);
                enemy1.Location= new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 350);
                //y = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }

        }

        void collectioncoins()
        {
            if (ImgCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                lblCoinCounter.Text = "Coins =" + collectedcoins.ToString();

                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }

            if (ImgCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                lblCoinCounter.Text = "Coins =" + collectedcoins.ToString();
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin2.Location = new Point(x, 0);

            }

            if (ImgCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                lblCoinCounter.Text = "Coins =" + collectedcoins.ToString();
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }

            if (ImgCar.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                lblCoinCounter.Text = "Coins =" + collectedcoins.ToString();
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
        }


        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);
                //y = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }



        }

        void gameover()
        {
            if (ImgCar.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                lblGameover.Visible = true;
            }

            if (ImgCar.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                lblGameover.Visible = true;
            }

            if (ImgCar.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                lblGameover.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }


            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                if(ImgCar.Left>0)
                ImgCar.Left += -gamespeed;
            }

            if (e.KeyCode == Keys.Right)
            {
                if(ImgCar.Right<380)
                ImgCar.Left += gamespeed;
            }

            if(e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }
                

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
                

        }
    }
}
