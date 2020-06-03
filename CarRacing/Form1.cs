using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class kok : Form
    {
        public kok()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int GameSpeed;

        private void timer1_Tick(object sender, EventArgs e)
        {

            MoveLine(GameSpeed);
            Enemy(GameSpeed);
            GameOver();
            coin(GameSpeed);
            CoinCollection();
        }

        Random r =  new Random();

        int x;

        void Enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 180);

                enemy1.Location = new Point(x, 0);

            }

           else  
            { 
                enemy1.Top += speed; 
            
            }


            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 380);

                enemy2.Location = new Point(x, 0);

            }

            else
            {
                enemy2.Top += speed;

            }



            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 300);

                enemy3.Location = new Point(x, 0);

            }

            else
            {
                enemy3.Top += speed;

            }



        }


        void coin(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 280);

                coin1.Location = new Point(x, 0);

            }

            else
            {
                coin1.Top += speed;

            }


            if (coin2.Top >= 500)
            {
                x = r.Next(0, 320);

                coin2.Location = new Point(x, 0);

            }

            else
            {
                coin2.Top += speed;

            }



            if (coin3.Top >= 500)
            {
                x = r.Next(0, 390);

                coin3.Location = new Point(x, 0);

            }

            else
            {
                coin3.Top += speed;

            }



        }

        void GameOver()
        {
            if(car.Bounds.IntersectsWith(enemy1.Bounds))
            {

                timer1.Enabled = false;
                over.Visible = true;





            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {

                timer1.Enabled = false;
                over.Visible = true;

            }


            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {

                timer1.Enabled = false;
                over.Visible = true;

            }


        }

        int CollectedCoins = 0;

        void CoinCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {

                CollectedCoins++;
                score.Text = "Score :" + CollectedCoins.ToString();

                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);



            }


            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {

                CollectedCoins++;
                score.Text = "Score :" + CollectedCoins.ToString();

                x = r.Next(100, 300);

                coin2.Location = new Point(x, 0);


            }



            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {

                CollectedCoins++;
                score.Text = "Score :" + CollectedCoins.ToString();

                x = r.Next(40, 390);

                coin3.Location = new Point(x, 0);

            }


        }






        void MoveLine(int speed)
        {

            if(pictureBox1.Top >= 500)
            { pictureBox1.Top = 0;  }
            else
            { pictureBox1.Top += speed; }


            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }


            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }


            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else
            { pictureBox4.Top += speed; }

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void car_Click(object sender, EventArgs e)
        {

        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)


        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                {

                    car.Left += -20;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                {
                    car.Left += 20;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (GameSpeed < 21)
                {
                    GameSpeed ++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (GameSpeed > 0)
                {
                    GameSpeed--;
                }
            }
        }
    }
}
