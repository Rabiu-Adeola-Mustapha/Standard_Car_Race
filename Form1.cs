using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Car_Race
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int Score;
        int carImage;
        int playerSpeed = 0;

        bool goRight, goLeft;

        Random rand = new Random();
        Random carPosition = new Random();

        public Form1()
        {
            InitializeComponent();
            gameReset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            txtScore.Text = "Score:" + Score;
            Score++;


            if (goLeft == true && player.Left > 11)
            {
                player.Left -= playerSpeed;
            }
            
            if (goRight == true && player.Left < 368)
            {
                player.Left += playerSpeed;
            }

            MoveLine(playerSpeed);

            Ai1.Top += trafficSpeed;
            Ai2.Top += trafficSpeed;

            if (Ai1.Top > 400)
            {
                changeAiCars(Ai1);
            }

            if (Ai2.Top > 400)
            {
                changeAiCars(Ai2);
            }

            if(player.Bounds.IntersectsWith(Ai1.Bounds) || player.Bounds.IntersectsWith(Ai2.Bounds))
            {
                gameOver();
            }

            if (Score > 10 &&  Score < 750)
            {
                award.Image = Properties.Resources.bronze;
                trafficSpeed = 7;
                playerSpeed = 9;
            }

            if (Score > 1000 && Score < 2500)
            {
                award.Image = Properties.Resources.silver;
                trafficSpeed = 10;
                playerSpeed = 12;
            }

            if (Score > 2500)
            {
                award.Image = Properties.Resources.bronze;
                trafficSpeed = 12;
                playerSpeed = 13;
            }

        }

        void MoveLine(int Speed)
        {
            if (pictureBox1.Top >= 383)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top +=Speed;

            }
            if (pictureBox2.Top >= 383)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += Speed;

            }
            if (pictureBox3.Top >= 383)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top +=Speed ;

            }
            if (pictureBox4.Top >= 383)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += Speed;

            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Move(object sender, EventArgs e)
        {

        }

        private void player_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.KeyCode == Keys.Left)
            //{
            //    player.Left += -8;
            //}
            //if(e.KeyCode == Keys.Right)
            //{
            //    player.Left += 8;
            //}
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (player.Left > 0)
                    player.Left += -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (player.Left < 448)
                    player.Left += 1 ;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }


            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            

            if( e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
           
            if (e.KeyCode == Keys.Up)
            {
                if (playerSpeed < 21)
                {
                    playerSpeed++;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if(playerSpeed > 0)
                {
                    playerSpeed--;
                }
            }
        }

        private void gameReset()
        {
            btnStart.Enabled = false;
            Explosion.Visible = false;
            Score = 0;
            award.Visible = false;
            goLeft = false;
            goRight = false;
            playerSpeed = 5;

            trafficSpeed = 4;

            Ai1.Top = carPosition.Next(200, 400) * -1;
            Ai1.Left = carPosition.Next(11, 157);

            Ai2.Top = carPosition.Next(200, 400) * -1;
            Ai2.Left = carPosition.Next(225, 363);

            timer1.Start();
        }

        private void changeAiCars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 9);

            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;

                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;

                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                default:
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            if((string)tempCar.Tag == "CarLeft")
            {
                tempCar.Left = carPosition.Next(11, 157);
            }
            
            if((string)tempCar.Tag == "CarRight")
            {
                tempCar.Left = carPosition.Next(225,363);
            }
        }

       

        private void Ai1_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void restartGame(object sender, EventArgs e)
        {
            gameReset();
        }

        private void gameOver()
        {
            playsound();
            timer1.Stop();
            Explosion.Visible = true;
            player.Controls.Add(Explosion);
            Explosion.Location = new Point(-5, 5);
            Explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;
        }

        private void playsound()
        {
            System.Media.SoundPlayer Playercrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            Playercrash.Play();

        }
    }
}
