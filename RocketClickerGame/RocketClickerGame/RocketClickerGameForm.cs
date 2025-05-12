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
       
        //to change based on upgrades
        int pointsPerClick = 1;
       
        // how fast it moves
        private int movingSpeed = 3;


        SoundPlayer musicPlayer;

        private List<Image> flameFrames = new List<Image>();
        private int flameFrameIndex = 0;


        private int points = 0;

        //enhancements
        private List<RocketEnhancement> rocketEnhancements = new List<RocketEnhancement>();
        private int currentEnhancementIndex = 0;


        public RocketClickerGameForm()
        {
            InitializeComponent();


           
       
            // Disable rocket button until Play is clicked
            rocketButton1.Enabled = false;


            firePictureBox.Location = new Point(rocketButton1.Location.X-150, rocketButton1.Location.Y + rocketButton1.Height);

            flameTimer.Start();
            addToList();

        }

        private void RocketClickerGameForm_Load(object sender, EventArgs e)
        {
            addFrames();
            musicPlayer = new SoundPlayer(Properties.Resources.backgroundMusic);
            // Loops the music infinetely
            musicPlayer.PlayLooping(); 

            //set the origin position to the location of button on form horizental
            originalX = playButton.Location.X;

            //start timer
            playButtonTimer.Start();

           
        }
        private void addFrames()
        {
            flameFrames.Add(Properties.Resources.fire1__01);
            flameFrames.Add(Properties.Resources.fire1__02);
            flameFrames.Add(Properties.Resources.fire1__03);
            flameFrames.Add(Properties.Resources.fire1__04);
            flameFrames.Add(Properties.Resources.fire1__05);
            flameFrames.Add(Properties.Resources.fire1__07);
            flameFrames.Add(Properties.Resources.fire1__06);
            flameFrames.Add(Properties.Resources.fire1__07);
            flameFrames.Add(Properties.Resources.fire1__08);
            flameFrames.Add(Properties.Resources.fire1__09);
            flameFrames.Add(Properties.Resources.fire1__10);
            flameFrames.Add(Properties.Resources.fire1__11);
            flameFrames.Add(Properties.Resources.fire1__12);
            flameFrames.Add(Properties.Resources.fire1__13);
        }
        private void rocketButton1_Click(object sender, EventArgs e)
        {
            //rocket timer starts at click
            timer.Start();

            // displays as int number of clicks
            clicksLabel.Text = "Clicks: " + clicks;


            //the number of clicks increment at each click
            clicks++;

            

            points += pointsPerClick;

            pointsLabel.Text = "Points: " + points;


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

            //cycles through the frames of the fire animation in a loop
            //wraps around to 0 when it reaches the end of the list (because % is the remainder operator)
            //after 13 frames it goes back to 0 
            flameFrameIndex = (flameFrameIndex + 1) % flameFrames.Count;
            // It shows the current fire frame in the PictureBox
            //makes a fresh copy of the image just for this display, leaving the original untouched.
            firePictureBox.Image = (Image)flameFrames[flameFrameIndex].Clone();
            //flif 90degrees
            firePictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);


        }

      

        //add rocket image to list
        public void addToList()
        {
            rocketEnhancements.Add(new RocketEnhancement
            {
                image = Properties.Resources.smallfighter,
                Price = 300,
                Name = "Jet Fighter"
            });

            rocketEnhancements.Add(new RocketEnhancement
            {
                image = Properties.Resources.spaceShuttle1,
                Price = 550,
                Name = "Space Shuttle"
            });
        }

        //to show go through the rockets
        public void ShowCurrentEnhancement()
        {
            var current = rocketEnhancements[currentEnhancementIndex];
            //set picture box image
            //stretch it
            enhancePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            enhancePictureBox.Image = current.image;
            rocketNameLabel.Text = $"{current.Name}";
            enhanceCostButton.Text = $" {current.Price}" + " points";
        }

        //change rocket image and deduct points
        private void enhanceCostButton_Click(object sender, EventArgs e)
        {
            var selected = rocketEnhancements[currentEnhancementIndex];

            if (points >= selected.Price)
            {
                // Deduct points first
                points -= selected.Price;

                // Update UI immediately
                pointsLabel.Text = "Points: " + points;

                MessageBox.Show($"Purchased: {selected.Name}!");

                // Increase pointsPerClick depending on which upgrade
                if (currentEnhancementIndex == 0)
                {
                    pointsPerClick += 50; // First upgrade
                }
                else if (currentEnhancementIndex == 1)
                {
                    //Second upgrade (total increase = 100)
                      pointsPerClick += 50;
                }

                rocketButton1.BackgroundImage = selected.image;
                rocketButton1.BackgroundImageLayout = ImageLayout.Stretch;

                // go to next enhancement if any
                if (currentEnhancementIndex < rocketEnhancements.Count - 1)
                {
                    currentEnhancementIndex++;
                    ShowCurrentEnhancement();
                }
            }

            else
            {
                MessageBox.Show("Not enough points!");
            }
        }
    }
}

