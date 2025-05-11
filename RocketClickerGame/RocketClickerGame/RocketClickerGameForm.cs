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

        public RocketClickerGameForm()
        {
            InitializeComponent();
            // Disable rocket button until Play is clicked
            rocketButton1.Enabled = false;
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
    }
}
