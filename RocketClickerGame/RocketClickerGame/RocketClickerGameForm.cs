using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketClickerGame
{
    public partial class RocketClickerGameForm : Form
    {
        private int ticks;

        private int clicks;

        private int originalX;

        private int movingDirection = 1;
        // how far it moves left/right
        private int movingRange = 8;

        // how fast it moves
        private int movingSpeed = 3;


        SoundPlayer musicPlayer;

        private int flameFrame = 0;


        public RocketClickerGameForm()
        {
            InitializeComponent();


           
       
            // Disable rocket button until Play is clicked
            rocketButton1.Enabled = false;


            firePictureBox.Location = new Point(rocketButton1.Location.X-150, rocketButton1.Location.Y + rocketButton1.Height);

            flameTimer.Start();


        }

        private void RocketClickerGameForm_Load(object sender, EventArgs e)
        {

            musicPlayer = new SoundPlayer(Properties.Resources.backgroundMusic);
            // Loops the music infinetely
            musicPlayer.PlayLooping(); 

            //set the origin position to the location of button on form horizental
            originalX = playButton.Location.X;

            //start timer
            playButtonTimer.Start();

           
        }

        private void rocketButton1_Click(object sender, EventArgs e)
        {
            //rocket timer starts at click
            timer.Start();

            // displays as int number of clicks
            clicksLabel.Text = "Clicks: " + clicks;

            //the number of clicks increment at each click
            clicks++;
        }

        //the time
        private void timer_Tick(object sender, EventArgs e)
        {
            //timer
            //increase by one second(1000 milisecond interval property equal to 1 second)
            ticks++;

            //displays the number of seconds
            timeLabel.Text = "Time: " + ticks;


            
        }

        //to restart the game
        private void restartButton_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to restart the game?",
                                         "Confirm Restart",
                                         MessageBoxButtons.YesNo);


            if (choice == DialogResult.Yes)
            {
                playButtonTimer.Start();

                timer.Stop();
                clicks = 0;
                ticks = 0;

                //timer label back to initial state
                timeLabel.Text = "Time: 0";
                clicksLabel.Text = "Clicks: 0";
                playButton.Enabled = true;

                rocketButton1.Enabled = false;
            }
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            //Stop Animation After Clicking Play
            playButtonTimer.Stop();

            playButton.Location = new Point(originalX, playButton.Location.Y);

            // Enable rocket button when Play is clicked
            rocketButton1.Enabled = true;

            //disable Play button so it can’t be clicked again
            playButton.Enabled = false;
        }

        private void playButtonTimer_Tick(object sender, EventArgs e)
        {
            //set a variable location horizentally x axis by addind the direction with speed to the original position
            int newX = playButton.Location.X + (movingDirection * movingSpeed);

            // move back if it goes out of range
            //decrease from original position and if superior to moving range
            if (Math.Abs(newX - originalX) >= movingRange)
                //the moving direction is multiplied by -1 to move backwards right to left 
                movingDirection *= -1;

            //instantiate the point to make the button moving
            playButton.Location = new Point(newX, playButton.Location.Y);
        }

        private void RocketClickerGameForm_Shown(object sender, EventArgs e)
        {
            // When the main form is already visible, show the popup in front
            StartForm startForm = new StartForm();
            var result = startForm.ShowDialog(this); // this = show in front of main form

            if (result == DialogResult.OK)
            {
                rocketButton1.Enabled = false;
            }
            else
            {
                this.Close(); // User closed popup without starting
            }
        }

        private void flameTimer_Tick(object sender, EventArgs e)
        {
           
            //modulo 14 because of 0-13 cases and frames

            flameFrame = (flameFrame + 1) % 14;
            RotateFlipType rotateAngle = RotateFlipType.Rotate180FlipNone;

            switch (flameFrame)
            {
                case 0:
                    firePictureBox.Image = Properties.Resources.fire1__01;
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                case 1:
                    firePictureBox.Image = Properties.Resources.fire1__02;
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                case 2:
                   firePictureBox.Image = Properties.Resources.fire1__03;
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 3: 
                    firePictureBox.Image= Properties.Resources.fire1__04;
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 4:
                    firePictureBox.Image=(Properties.Resources.fire1__05);
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 5:
                    firePictureBox.Image=Properties.Resources.fire1__07;
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 6:
                    firePictureBox.Image = ((Properties.Resources.fire1__06));
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 7:
                    firePictureBox.Image=((Properties.Resources.fire1__07));
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;  
                    case 8: 
                    firePictureBox.Image= ((Properties.Resources.fire1__08));
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 9:
                    firePictureBox.Image= ((Properties.Resources.fire1__09));
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 10:
                    firePictureBox.Image= ((Properties.Resources.fire1__10));
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 11:
                    firePictureBox.Image=((Properties.Resources.fire1__11));
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 12:
                    firePictureBox.Image=((Properties.Resources.fire1__12));
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;
                    case 13:
                    firePictureBox.Image=(Properties.Resources.fire1__13);
                    firePictureBox.Image.RotateFlip(rotateAngle);
                    break;  
                                

            }
        }
    }
}
