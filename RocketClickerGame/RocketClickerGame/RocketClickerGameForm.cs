using RocketClickerGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace RocketClickerGame
{
    public partial class RocketClickerGameForm : Form
    {
        //the number for time
        private int ticks;

        //the number of clicks
        private int clicks;

        //to change based on upgrades
        int pointsPerClick = 1;

        // The player's points
        private int points = 0;

        //for play button
        private int originalX;

        private int movingDirection = 1;

        // how far it moves left/right
        private int movingRange = 8;

        // how fast it moves
        private int movingSpeed = 3;

        //for music using SoundPlayer Class
        SoundPlayer musicPlayer;

        //for animated launch using frames list images
        private List<Image> flameFrames = new List<Image>();

        //access list index
        private int flameFrameIndex = 0;

        //enhancements
        //using class for list storing objects
        private List<RocketEnhancement> rocketEnhancements = new List<RocketEnhancement>();

        //access list index
        private int currentEnhancementIndex = 0;

        //special items
        // list to store meteor PictureBoxes
        private List<SpecialEffects> specialEffects = new List<SpecialEffects>();

        private int currentEffectIndex = 0;

        //to add a counter for the timer as an addition ex: tickCount=15  would count 15 from timer
        //if timer= 122 it counts +15 
        private int tickCount = 0;

        //helpers
        List<Helpers> helpers = new List<Helpers>();
       
        private int currentHelperIndex = 0;

        private int passivePointsPerSecond = 0;

        //factory improvements
        List<FactoryImprovements> factoryImprovements = new List<FactoryImprovements>();

        private int currentFactoryIndex = 0;

        // allows for editing the settings form from this form
        private SettingsForm settingsForm;

        //power ups
        //using class for list storing objects
        private List<PowerUps> powerUps= new List<PowerUps>();

        //access list index
        private int currentPowerIndex = 0;

        // for number display
        public String numberDisplay { get; set; }

        private PointConversion convert = new PointConversion();

        private string currentLanguage;


        public RocketClickerGameForm()
        {

            InitializeComponent();

            settingsForm = new SettingsForm(this);
            numberDisplay = "SpokenNotation";


            // Disable rocket button until Play is clicked
            rocketButton1.Enabled = false;

            //position for the frame picture box
            firePictureBox.Location = new Point(rocketButton1.Location.X - 150, rocketButton1.Location.Y + rocketButton1.Height);

            flameTimer.Start();
            addToEnhanceList();
            addSpecialEffects();
            addHelpersToList();
            addFactoryUpgradeToList();
            addPowerToList();

            riderCostButton.Enabled = false;
            engineerCostButton.Enabled = false;
            minerCostButton.Enabled = false;
            spaceCostButton.Enabled = false;
            nightCostButton.Enabled = false;
            rocketButton1.Enabled = false;
            enhanceCostButton.Enabled = false;
            fuelCostButton.Enabled = false;
            speedCostButton.Enabled = false;
            effectCostbutton.Enabled = false;

        }

        private void RocketClickerGameForm_Load(object sender, EventArgs e)
        {

            currentLanguage = ConfigurationManager.AppSettings["language"];

            addFrames();
            musicPlayer = new SoundPlayer(Properties.Resources.backgroundMusic);
            // Loops the music infinetely
            musicPlayer.PlayLooping();

            //set the origin position to the location of button on form horizental
            originalX = playButton.Location.X;

            //start timer
            playButtonTimer.Start();


        }


        //add frames
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

      


            //the number of clicks increment at each click
            clicks++;
            // displays as int number of clicks
            switch (currentLanguage)
            {
                case "en":
                    clicksLabel.Text = "Clicks: " + clicks;
                    break;
                case "fr-CA":
                    clicksLabel.Text = "Clics : " + clicks;
                    break;
                case "es":
                    clicksLabel.Text = "Clics: " + clicks;
                    break;
                default:
                    clicksLabel.Text = "Clicks: " + clicks;
                    break;
            }

            if (clicks == 100)
            {
                settingsForm.CompleteClickAchievement1();
            }
            if (clicks == 250)
            {
                settingsForm.CompleteClickAchievement2();
            }
            if (clicks == 1000)
            {
                settingsForm.CompleteClickAchievement3();
            }

            points += pointsPerClick;
            switch (numberDisplay)
            {
                case "SpokenNotation":
                    switch (currentLanguage)
                    {
                        case "en":
                            pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                            break;
                        case "fr-CA":
                            pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                            break;
                        case "es":
                            pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                            break;
                    }
                    break;
                case "ScientificNotation":
                    switch (currentLanguage)
                    {
                        case "en":
                            pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                            break;
                        case "fr-CA":
                            pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                            break;
                        case "es":
                            pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                            break;
                    }
                    break;

                case "EngineeringNotation":
                    switch (currentLanguage)
                    {
                        case "en":
                            pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                            break;
                        case "fr-CA":
                            pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                            break;
                        case "es":
                            pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                            break;
                    }
                    break;
            }


        }

        //the time
        private void timer_Tick(object sender, EventArgs e)
        {
            //timer
            //increase by one second(1000 milisecond interval property equal to 1 second)
            ticks++;

            //displays the number of seconds
            switch (currentLanguage)
            {
                case "en":
                    timeLabel.Text = "Time: " + ticks;
                    break;
                case "fr-CA":
                    timeLabel.Text = "Temps : " + ticks;
                    break;
                case "es":
                    timeLabel.Text = "Tiempo: " + ticks;
                    break;
                default:
                    timeLabel.Text = "Time: " + ticks;
                    break;
            }
            if (ticks == 600)
            {
                settingsForm.CompletePlaytimeAchievement();
            }

        }

        //to restart the game
        private void restartButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = DialogResult.No; // Default value

            switch (currentLanguage)
            {
                case "en":
                     choice = MessageBox.Show("Are you sure you want to restart the game?",
                                         "Confirm Restart",
                                         MessageBoxButtons.YesNo); 
                    break;
                case "fr-CA":
                    choice = MessageBox.Show("Êtes-vous sûr de vouloir redémarrer le jeu ?",
                                             "Confirmer le redémarrage",
                                             MessageBoxButtons.YesNo); 
                    break;
                case "es":
                    choice = MessageBox.Show("¿Estás seguro de que quieres reiniciar el juego?",
                          "Confirmar reinicio",
                          MessageBoxButtons.YesNo);
                    break;

            }
            if (choice == DialogResult.Yes)
            {
                playButtonTimer.Start();

                timer.Stop();
                clicks = 0;
                ticks = 0;
                points = 0;


                //timer label back to initial state
                timeLabel.Text = "Time: 0";
                clicksLabel.Text = "Clicks: 0";
                pointsLabel.Text = "Points: 0";
                playButton.Enabled = true;
                riderCostButton.Enabled = false;
                engineerCostButton.Enabled = false;
                minerCostButton.Enabled = false;
                spaceCostButton.Enabled = false;
                nightCostButton.Enabled = false;
                rocketButton1.Enabled = false;
                enhanceCostButton.Enabled = false;
                fuelCostButton.Enabled = false;
                speedCostButton.Enabled = false;
                effectCostbutton.Enabled = false;

                passivePointTimer.Stop();


                Application.Restart();
            }
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            //Stop Animation After Clicking Play
            playButtonTimer.Stop();

            playButton.Location = new Point(originalX, playButton.Location.Y);

            // Enable rocket button when Play is clicked
            rocketButton1.Enabled = true;
            riderCostButton.Enabled = true;
            engineerCostButton.Enabled = true;
            minerCostButton.Enabled = true;
            spaceCostButton.Enabled = true;
            nightCostButton.Enabled = true;
            enhanceCostButton.Enabled = true;
            fuelCostButton.Enabled = true;
            speedCostButton.Enabled = true;
            effectCostbutton.Enabled = true;
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


        //rocket enhancements
        //add rocket image to list
        public void addToEnhanceList()
        {
            currentLanguage = ConfigurationManager.AppSettings["language"];

            string jetFighterName = "";
            string spaceShuttleName = "";

            switch (currentLanguage)
            {
                case "fr-CA":
                    jetFighterName = "Chasseur à réaction";
                    spaceShuttleName = "Navette spatiale";
                    break;
                case "es":
                    jetFighterName = "Caza a reacción";
                    spaceShuttleName = "Transbordador espacial";
                    break;
                default: // English
                    jetFighterName = "Jet Fighter";
                    spaceShuttleName = "Space Shuttle";
                    break;
            }

            rocketEnhancements.Add(new RocketEnhancement
            {
                Image = Properties.Resources.smallfighter,
                Price = 300,
                Name = jetFighterName
            });

            rocketEnhancements.Add(new RocketEnhancement
            {
                Image = Properties.Resources.spaceShuttle1,
                Price = 550,
                Name = spaceShuttleName
            });
        }




        //to show go through the rockets
        public void ShowCurrentEnhancement()
        {
            var current = rocketEnhancements[currentEnhancementIndex];
            //set picture box image
            //stretch it
            enhancePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            enhancePictureBox.Image = current.Image;
            rocketNameLabel.Text = $"{current.Name}";

            switch (currentLanguage)
            {
                case "en":
                    enhanceCostButton.Text = $" {current.Price}" + " points"; 
                    break;
                case "fr-CA":
                    enhanceCostButton.Text = $" {current.Price}" + " points";
                    break;
                case "es":
                    enhanceCostButton.Text = $" {current.Price}" + " puntos";
                    break;
                default:
                    enhanceCostButton.Text = $" {current.Price}" + " points";
                    break;
            }
        }

        //change rocket image and deduct points
        private void enhanceCostButton_Click(object sender, EventArgs e)
        {
            //get the element from the list
            var selected = rocketEnhancements[currentEnhancementIndex];

            if (points >= selected.Price)
            {
                // Deduct points first
                points -= selected.Price;

                // Complete the rocket achievement
                settingsForm.CompleteRocketAchievement();

                // Update UI immediately
                switch (numberDisplay)
                {
                    case "SpokenNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                break;
                        }
                        break;
                    case "ScientificNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                break;
                        }
                                break;
                      
                    case "EngineeringNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                break;
                        }
                        break;
                }
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show($"Purchased: {selected.Name}!");
                        break;
                    case "fr-CA":
                        MessageBox.Show($"Acheté: {selected.Name}!");
                        break;
                    case "es":
                        MessageBox.Show($"Comprado: {selected.Name}!");

                        break;
                        
                }

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

                rocketButton1.BackgroundImage = selected.Image;
                rocketButton1.BackgroundImageLayout = ImageLayout.Stretch;

                // go to next enhancement if any
                if (currentEnhancementIndex < rocketEnhancements.Count - 1)
                {
                    currentEnhancementIndex++;
                    ShowCurrentEnhancement();
                }
                else
                {
                    // Last enhancement reached, disable buy button
                    enhanceCostButton.Enabled = false;
                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show("You have bought all rockets!");
                            break;
                        case "fr-CA":
                            MessageBox.Show("Vous avez acheté tous les fusées!");
                            break;
                        case "es":
                            MessageBox.Show("¡Has comprado todos los cohetes!");

                            break;

                    }
                }
            }

            else
            {
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show("Not enough points!");
                        break;
                    case "fr-CA":
                        MessageBox.Show("Points insuffisant!");
                        break;
                    case "es":
                        MessageBox.Show("¡No tienes suficientes puntos!");

                        break;

                }
            }
        }


        //special effects
        //add special effet image name price to list
        private void addSpecialEffects()
        {
            currentLanguage = ConfigurationManager.AppSettings["language"];

            string specialEffectsName = "";

            switch (currentLanguage)
            {
                case "fr-CA":
                    specialEffectsName = "Pluie de feu de 15s";
                    break;
                case "es":
                    specialEffectsName = "Lluvia de fuego de 15s";
                    break;
                default: // English
                    specialEffectsName = "15s Fire Shower";
                    break;
            }

        specialEffects.Add(new SpecialEffects
            {
                MeteorImage = Properties.Resources.Meteor1,
                Price = 600,
                Name = specialEffectsName

        });


        }


        //add meteor shower image and deduct points
        private void effectCostbutton_Click(object sender, EventArgs e)
        {
            var selectedEffect = specialEffects[currentEffectIndex];

            if (points >= selectedEffect.Price)
            {
                points -= selectedEffect.Price;

                settingsForm.CompleteMeteorAchievement();

                switch (numberDisplay)
                {
                    case "SpokenNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                break;
                        }
                        break;
                    case "ScientificNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                break;
                        }
                        break;

                    case "EngineeringNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                break;
                        }
                        break;
                }
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show("Meteor Shower Unlocked!");
                        break;
                    case "fr-CA":
                        MessageBox.Show("Pluie de météores débloquée !");
                        break;
                    case "es":
                        MessageBox.Show("¡Lluvia de meteoritos desbloqueada!");

                        break;

                }

                // Increase pointsPerClick depending on which upgrade
                if (currentEffectIndex == 0)
                {
                    // First upgrade
                    pointsPerClick += 60;
                }

                //meteor start timer
                StartMeteorShower();
            }
            else
            {
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show("Not enough points!");
                        break;
                    case "fr-CA":
                        MessageBox.Show("Points insuffisant!");
                        break;
                    case "es":
                        MessageBox.Show("¡No tienes suficientes puntos!");

                        break;

                }
            }
        }


        private void StartMeteorShower()
        {
            tickCount = 0; // reset counter

            if (meteorTimer1 != null)
            {
                meteorTimer1.Stop();
            }

            meteorTimer1 = new Timer();

            // 1 second to stop it  we define it here 1 second for one meteor
            meteorTimer1.Interval = 1000;

            // .Tick event happens every time the timer interval passes 1000
            //runs the meteorTimer1_Tick method
            meteorTimer1.Tick += meteorTimer1_Tick;

            meteorTimer1.Start();


        }


        private void meteorTimer1_Tick(object sender, EventArgs e)
        {
            // stop after 15 seconds
            //increase to get the actual count from timer
            tickCount++;
            if (tickCount >= 15)
            {
                meteorTimer1.Stop();
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show("Meteor Shower Ended!");
                        break;
                    case "fr-CA":
                        MessageBox.Show("La pluie de météores est terminée !");
                        break;
                    case "es":
                        MessageBox.Show("¡La lluvia de meteoritos ha terminado!");

                        break;

                }
               
                return;
            }

            //random class to have random position of meteor
            Random rand = new Random();

            //(min) 0 is left edge of form (max)this.ClientSize.Width is the width of the form's usable area (excluding borders)
            //keeps from going out of right edge the size of picture box is 50
            int xPosition = rand.Next(0, this.ClientSize.Width - 50);

            // start at the top of the form
            int yPosition = 0;

            // create a new meteor PictureBox
            PictureBox meteor = new PictureBox();

            //for first meteor type
            meteor.Image = specialEffects[0].MeteorImage;
            meteor.BackColor = Color.Transparent;

            meteor.SizeMode = PictureBoxSizeMode.StretchImage;
            meteor.Size = new Size(50, 50);


            meteor.Location = new Point(xPosition, yPosition);

            //add the meteor to the form
            this.Controls.Add(meteor);

            // create a SpecialEffects object for managing the meteor
            SpecialEffects meteorEffect = new SpecialEffects
            {
                //from class SpecialEffects class
                MeteorBox = meteor,
                // random falling speed for each meteor
                //min 5 max 15
                FallingSpeed = rand.Next(5, 15),

                FallTimer = new Timer()
            };

            // set the timer to control the meteor's falling
            // Control the speed of falling 10 milliseconds
            meteorEffect.FallTimer.Interval = 10;


            // Create a separate method handler for the falling animation
            meteorEffect.FallTimer.Tick += MeteorFallHandler;

            //add special effects to lsit
            specialEffects.Add(meteorEffect);

            //Start timer
            meteorEffect.FallTimer.Start();
        }

        //makes each meteor fall down and removes it when it goes off the screen
        //runs every 10 milliseconds (as set earlier) for each falling meteor
        //The sender tells us which Timer triggered this event
        private void MeteorFallHandler(object sender, EventArgs e)
        {
            //loop through the special effects
            for (int i = 0; i < specialEffects.Count; i++)
            {
                SpecialEffects effect = specialEffects[i];

                //check: Is this the meteor whose timer ticked
                //compare sender(the Timer that ticked) to the meteor’s FallTimer
                if (effect.FallTimer == sender)
                {
                    PictureBox meteor = effect.MeteorBox;

                    //move the meteor down by a few pixels(based on its speed)
                    //This creates the falling effect.
                    meteor.Top += effect.FallingSpeed;

                    //If the meteor reaches the bottom of the screen remove it
                    //Form.ClientSize Property gets or sets the size of the
                    //client area of the form
                    if (meteor.Top > this.ClientSize.Height)
                    {
                        //stop its falling timer
                        effect.FallTimer.Stop();

                        //make picture box dissapear from screen
                        this.Controls.Remove(meteor);

                        //remove it from the list
                        specialEffects.RemoveAt(i);
                    }
                    //stop loop
                    break;
                }
            }
        }

        //Helpers
        //add ojects to list
        private void addHelpersToList()
        {
            currentLanguage = ConfigurationManager.AppSettings["language"];

            string riderName = "";
            string engineerName = "";
            string minerName = "";

            switch (currentLanguage)
            {
                case "fr-CA":
                    riderName = "Cavalier";
                    engineerName = "Ingénieur";
                    minerName = "Mineur";
                    break;
                case "es":
                    riderName = "Jinete";
                    engineerName = "Ingeniero";
                    minerName = "Minero";
                    break;
                default: // English
                    riderName = "Rider";
                    engineerName = "Engineer";
                    minerName = "Miner";
                    break;
            }

            helpers.Add(new Helpers
            {
                Name = riderName,
                Price = 220,
                PointsPerSecond = 10,
                Image = Properties.Resources.gryphon_rider
            });

            helpers.Add(new Helpers
            {
                Name = engineerName,
                Price = 500,
                PointsPerSecond = 5,
                Image = Properties.Resources.return_goods
            });

            helpers.Add(new Helpers
            {
                Name = minerName,
                Price = 50,
                PointsPerSecond = 2,
                Image = Properties.Resources.dwarven_scout_gray_hair_braided_beard
            });
        }

        private void riderCostButton_Click(object sender, EventArgs e)
        {
            // Use current index or manually assign Rider index (0)
            var selected = helpers[currentHelperIndex];

            if (selected.Name == "Rider"|| selected.Name == "Cavalier"|| selected.Name == "Jinete")
            {
                if (points >= selected.Price)
                {
                    points -= selected.Price;
                    passivePointsPerSecond += selected.PointsPerSecond;

                    switch (numberDisplay)
                    {
                        case "SpokenNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                    break;
                            }
                            break;
                        case "ScientificNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                    break;
                            }
                            break;

                        case "EngineeringNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                    break;
                            }
                            break;
                    }
                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show($"{selected.Name} hired!");
                            break;
                        case "fr-CA":
                            MessageBox.Show($"{selected.Name} embauché(e) !");
                            break;
                        case "es":
                            MessageBox.Show($"{selected.Name} contratado!");

                            break;

                    }

                    settingsForm.CompleteRiderAchievement();
                    StartPassivePointGeneration();

                    // Increase price and update button
                    selected.Price = (int)(selected.Price * 1.25);
                    switch (currentLanguage)
                    {
                        case "en":
                            riderCostButton.Text = $"{selected.Price} points";
                            break;
                        case "fr-CA":
                            riderCostButton.Text = $"{selected.Price} points";
                            break;
                        case "es":
                            riderCostButton.Text = $"{selected.Price} puntos";

                            break;

                    }
                }
                else
                {

                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show("Not enough points!");
                            break;
                        case "fr-CA":
                            MessageBox.Show("Points insuffisant!");
                            break;
                        case "es":
                            MessageBox.Show("¡No tienes suficientes puntos!");

                            break;

                    }
                }
            }
        
        }


        


        private void StartPassivePointGeneration()
        {
            passivePointTimer.Stop();
            //to add the passive ponts once remove previous tick
            passivePointTimer.Tick -= passivePointTimer_Tick; 
            passivePointTimer.Tick += passivePointTimer_Tick;
            passivePointTimer.Start();
        }

        private void passivePointTimer_Tick(object sender, EventArgs e)
        {
            points += passivePointsPerSecond;
            switch (numberDisplay)
            {
                case "SpokenNotation":
                    switch (currentLanguage)
                    {
                        case "en":
                            pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                            break;
                        case "fr-CA":
                            pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                            break;
                        case "es":
                            pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                            break;
                    }
                    break;
                case "ScientificNotation":
                    switch (currentLanguage)
                    {
                        case "en":
                            pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                            break;
                        case "fr-CA":
                            pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                            break;
                        case "es":
                            pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                            break;
                    }
                    break;

                case "EngineeringNotation":
                    switch (currentLanguage)
                    {
                        case "en":
                            pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                            break;
                        case "fr-CA":
                            pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                            break;
                        case "es":
                            pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                            break;
                    }
                    break;
            }
            }

        private void engineerCostButton_Click(object sender, EventArgs e)
        {
            var selected = helpers[1]; // Engineer is at index 1

            if (selected.Name == "Engineer"|| selected.Name == "Ingénieur" || selected.Name == "Ingeniero")
            {
                if (points >= selected.Price)
                {
                    points -= selected.Price;
                    passivePointsPerSecond += selected.PointsPerSecond;
                    switch (numberDisplay)
                    {
                        case "SpokenNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                    break;
                            }
                            break;
                        case "ScientificNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                    break;
                            }
                            break;

                        case "EngineeringNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                    break;
                            }
                            break;
                    }

                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show($"{selected.Name} hired!");
                            break;
                        case "fr-CA":
                            MessageBox.Show($"{selected.Name} embauché(e) !");
                            break;
                        case "es":
                            MessageBox.Show($"{selected.Name} contratado!");

                            break;

                    }
                    settingsForm.CompleteEngineerAchievement();

                    StartPassivePointGeneration();

                    selected.Price = (int)(selected.Price * 1.25);
                    switch (currentLanguage)
                    {
                        case "en":
                            engineerCostButton.Text = $"{selected.Price} points";
                            break;
                        case "fr-CA":
                            engineerCostButton.Text = $"{selected.Price} points";
                            break;
                        case "es":
                            engineerCostButton.Text = $"{selected.Price} puntos";

                            break;
                    }
                }
                else
                {
                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show("Not enough points!");
                            break;
                        case "fr-CA":
                            MessageBox.Show("Points insuffisant!");
                            break;
                        case "es":
                            MessageBox.Show("¡No tienes suficientes puntos!");

                            break;
                    }
                }
            }
        }

        private void minerCostButton_Click(object sender, EventArgs e)
        {
            // Miner is at index 2
            var selected = helpers[2];
             
                if (selected.Name == "Miner" || selected.Name == "Mineur" || selected.Name == "Minero")
            {
                if (points >= selected.Price)
                {
                    points -= selected.Price;
                    passivePointsPerSecond += selected.PointsPerSecond;
                    switch (numberDisplay)
                    {
                        case "SpokenNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                    break;
                            }
                            break;
                        case "ScientificNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                    break;
                            }
                            break;

                        case "EngineeringNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                    break;
                            }
                            break;
                    }
                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show($"{selected.Name} hired!");
                            break;
                        case "fr-CA":
                            MessageBox.Show($"{selected.Name} embauché(e) !");
                            break;
                        case "es":
                            MessageBox.Show($"¡{selected.Name} contratado!");

                            break;
                    }
                    settingsForm.CompleteMinerAchievement();

                    StartPassivePointGeneration();
                    //increase price
                    selected.Price = (int)(selected.Price * 1.25);
                    switch (currentLanguage)
                    {
                        case "en":
                            minerCostButton.Text = $"{selected.Price} points";
                            break;
                        case "fr-CA":
                            minerCostButton.Text = $"{selected.Price} points";
                            break;
                        case "es":
                            minerCostButton.Text = $"{selected.Price} puntos";

                            break;
                    }
                }

                else
                {
                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show("Not enough points!");
                            break;
                        case "fr-CA":
                            MessageBox.Show("Points insuffisant!");
                            break;
                        case "es":
                            MessageBox.Show("¡No tienes suficientes puntos!");

                            break;
                    }
                }
            }
        }


        //Factory improvements
        //add ojects to list
        private void addFactoryUpgradeToList()
        {
            currentLanguage = ConfigurationManager.AppSettings["language"];

            string spaceName = "";
            string moonNightName = "";

            switch (currentLanguage)
            {
                case "fr-CA":
                    spaceName = "Espace";
                    moonNightName = "Nuit de Lune";
                    break;
                case "es":
                    spaceName = "Espacio";
                    moonNightName = "Noche Lunar";
                    break;
                default: // English
                    spaceName = "Space";
                    moonNightName = "Moon Night";
                    break;
            }

            factoryImprovements.Add(new FactoryImprovements
            {
                Name = spaceName,
                Price = 2000,
                Image = Properties.Resources.Space_Background_1
            });

            factoryImprovements.Add(new FactoryImprovements
            {
                Name = moonNightName,
                Price = 1000,
                Image = Properties.Resources.moonBackground
            });
        }

        private void spaceCostButton_Click(object sender, EventArgs e)
        {
            var selected = factoryImprovements[currentFactoryIndex];

            if (points >= selected.Price)
            {
                points -= selected.Price;

                switch (numberDisplay)
                {
                    case "SpokenNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                break;
                        }
                        break;
                    case "ScientificNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                break;
                        }
                        break;

                    case "EngineeringNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                break;
                        }
                        break;
                }
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show("Welcome to Space!");
                        break;
                    case "fr-CA":
                        MessageBox.Show("Bienvenue dans l’espace !");
                        break;
                    case "es":
                        MessageBox.Show("¡Bienvenido al espacio!");

                        break;
                }
                settingsForm.CompleteSpaceAchievement();

                this.BackgroundImage = selected.Image;
                this.BackgroundImageLayout = ImageLayout.Stretch;

                // Disable the button after purchase
                spaceCostButton.Enabled = false;

            }
            else
            {
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show("Not enough points!");
                        break;
                    case "fr-CA":
                        MessageBox.Show("Points insuffisant!");
                        break;
                    case "es":
                        MessageBox.Show("¡No tienes suficientes puntos!");

                        break;
                }
            }
        
    }

        private void nightCostButton_Click(object sender, EventArgs e)
        {
            {
                var selected = factoryImprovements[1];

                if (points >= selected.Price)
                {
                    points -= selected.Price;

                    switch (numberDisplay)
                    {
                        case "SpokenNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                    break;
                            }
                            break;
                        case "ScientificNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                    break;
                            }
                            break;

                        case "EngineeringNotation":
                            switch (currentLanguage)
                            {
                                case "en":
                                    pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                    break;
                                case "fr-CA":
                                    pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                    break;
                                case "es":
                                    pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                    break;
                            }
                            break;
                    }
                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show("Moon Night!");
                            break;
                        case "fr-CA":
                            MessageBox.Show("Nuit de Lune !");
                            break;
                        case "es":
                            MessageBox.Show("¡Noche de Luna!");

                            break;
                    }
                    settingsForm.CompleteNightSkyAchievement();

                    this.BackgroundImage = selected.Image;
                    this.BackgroundImageLayout = ImageLayout.Stretch;

                    // Disable the button after purchase
                    nightCostButton.Enabled = false;

                }
                else
                {
                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show("Not enough points!");
                            break;
                        case "fr-CA":
                            MessageBox.Show("Points insuffisant!");
                            break;
                        case "es":
                            MessageBox.Show("¡No tienes suficientes puntos!");

                            break;
                    }
                }

            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            // Opens it as a window blocks the main form
            settingsForm.ShowDialog(); 
        }

   

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;
                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 2:
                    changeLanguage.UpdateConfig("language", "es");
                    Application.Restart();
                    break;
              
               
            }
        }

        //Factory improvements
        //add ojects to list
        private void addPowerToList()
        {
            currentLanguage = ConfigurationManager.AppSettings["language"];

            string fuelName = "";
            string speedName = "";

            switch (currentLanguage)
            {
                case "fr-CA":
                    fuelName = "Carburant";
                    speedName = "Vitesse";
                    break;
                case "es":
                    fuelName = "Combustible";
                    speedName = "Velocidad";
                    break;
                default: // English
                    fuelName = "Fuel";
                    speedName = "Speed";
                    break;
            }

            powerUps.Add(new PowerUps
            {
                Name = fuelName,
                Price = 50,
            });

            powerUps.Add(new PowerUps
            {
                Name = speedName,
                Price = 100,
            });
        
        }

        //Power Ups
        private void fuelCostButton_Click(object sender, EventArgs e)
        {
            //get the element from the list
            var selected = powerUps[currentPowerIndex];

            if (points >= selected.Price)
            {
                // Deduct points first
                points -= selected.Price;

                // Update UI immediately
                switch (numberDisplay)
                {
                    case "SpokenNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                break;
                        }
                        break;
                    case "ScientificNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                break;
                        }
                        break;

                    case "EngineeringNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                break;
                        }
                        break;
                }
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show($"Purchased: {selected.Name}!");
                        break;
                    case "fr-CA":
                        MessageBox.Show($"Acheté : {selected.Name} !");
                        break;
                    case "es":
                        MessageBox.Show($"Comprado: {selected.Name}!");

                        break;
                }

                // Increase pointsPerClick depending on which upgrade
                if (currentEnhancementIndex == 0)
                {
                    pointsPerClick += 100; // First upgrade
                } 
                }
            

            else
            {
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show("Not enough points!");
                        break;
                    case "fr-CA":
                        MessageBox.Show("Points insuffisant!");
                        break;
                    case "es":
                        MessageBox.Show("¡No tienes suficientes puntos!");

                        break;
                }
            }
        }

        private void speedCostButton_Click(object sender, EventArgs e)
        {
            //get the element from the list
            var selected = powerUps[1];

            if (points >= selected.Price)
            {
                // Deduct points first
                points -= selected.Price;

                // Update UI immediately
                switch (numberDisplay)
                {
                    case "SpokenNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToSpokenNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToSpokenNotation(points);
                                break;
                        }
                        break;
                    case "ScientificNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToScientificNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToScientificNotation(points);
                                break;
                        }
                        break;

                    case "EngineeringNotation":
                        switch (currentLanguage)
                        {
                            case "en":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "fr-CA":
                                pointsLabel.Text = "Points: " + convert.ToEngineeringNotation(points);
                                break;
                            case "es":
                                pointsLabel.Text = "Puntos: " + convert.ToEngineeringNotation(points);

                                break;
                        }
                        break;
                }
                switch (currentLanguage)
                {
                    case "en":
                        MessageBox.Show($"Purchased: {selected.Name}!");
                        break;
                    case "fr-CA":
                        MessageBox.Show($"Acheté : {selected.Name} !");
                        break;
                    case "es":
                        MessageBox.Show($"Comprado: {selected.Name}!");
                        break;
                }
                // Increase pointsPerClick depending on which upgrade
                if (currentEnhancementIndex == 0)
                        {
                            pointsPerClick += 200; // First upgrade
                        }
                }


            else
                {
                    switch (currentLanguage)
                    {
                        case "en":
                            MessageBox.Show("Not enough points!");
                            break;
                        case "fr-CA":
                            MessageBox.Show("Points insuffisant!");
                            break;
                        case "es":
                            MessageBox.Show("¡No tienes suficientes puntos!");

                            break;
                    }
                }
            }
        

        public void musicOn()
        {
            musicPlayer.PlayLooping();
        }
        public void musicOff()
        {
            musicPlayer.Stop();
        }
    }
    }


