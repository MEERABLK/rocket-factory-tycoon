namespace RocketClickerGame
{
    partial class RocketClickerGameForm
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
            this.components = new System.ComponentModel.Container();
            this.rocketButton1 = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.clicksLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.restartButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.playButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.firePictureBox = new System.Windows.Forms.PictureBox();
            this.flameTimer = new System.Windows.Forms.Timer(this.components);
            this.pointsLabel = new System.Windows.Forms.Label();
            this.upgradesLabel = new System.Windows.Forms.Label();
            this.rocketEnhanceLabel = new System.Windows.Forms.Label();
            this.factoryImprovementsLabel = new System.Windows.Forms.Label();
            this.powerUpsLabel = new System.Windows.Forms.Label();
            this.specialItemsLabel = new System.Windows.Forms.Label();
            this.helpersLabel = new System.Windows.Forms.Label();
            this.enhancePictureBox = new System.Windows.Forms.PictureBox();
            this.enhanceCostButton = new System.Windows.Forms.Button();
            this.rocketNameLabel = new System.Windows.Forms.Label();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.fuelCostButton = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedCostButton = new System.Windows.Forms.Button();
            this.spacePictureBox = new System.Windows.Forms.PictureBox();
            this.dayPictureBox = new System.Windows.Forms.PictureBox();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.spaceCostButton = new System.Windows.Forms.Button();
            this.nightCostButton = new System.Windows.Forms.Button();
            this.nightLabel = new System.Windows.Forms.Label();
            this.effectCostbutton = new System.Windows.Forms.Button();
            this.meteorPictureBox1 = new System.Windows.Forms.PictureBox();
            this.meteorLabel = new System.Windows.Forms.Label();
            this.meteorTimer1 = new System.Windows.Forms.Timer(this.components);
            this.riderPictureBox = new System.Windows.Forms.PictureBox();
            this.engineerPictureBox = new System.Windows.Forms.PictureBox();
            this.minerPictureBox = new System.Windows.Forms.PictureBox();
            this.minerLabel = new System.Windows.Forms.Label();
            this.engineerLabel = new System.Windows.Forms.Label();
            this.riderLabel = new System.Windows.Forms.Label();
            this.riderCostButton = new System.Windows.Forms.Button();
            this.minerCostButton = new System.Windows.Forms.Button();
            this.engineerCostButton = new System.Windows.Forms.Button();
            this.passivePointTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.firePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enhancePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rocketButton1
            // 
            this.rocketButton1.BackColor = System.Drawing.Color.Transparent;
            this.rocketButton1.BackgroundImage = global::RocketClickerGame.Properties.Resources.conte_magnus_cc0_Rockets;
            this.rocketButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rocketButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rocketButton1.FlatAppearance.BorderSize = 0;
            this.rocketButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rocketButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rocketButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rocketButton1.Location = new System.Drawing.Point(456, 163);
            this.rocketButton1.Name = "rocketButton1";
            this.rocketButton1.Size = new System.Drawing.Size(245, 468);
            this.rocketButton1.TabIndex = 0;
            this.rocketButton1.UseVisualStyleBackColor = false;
            this.rocketButton1.Click += new System.EventHandler(this.rocketButton1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(91, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(113, 42);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Time: 0";
            // 
            // clicksLabel
            // 
            this.clicksLabel.AutoSize = true;
            this.clicksLabel.BackColor = System.Drawing.Color.Transparent;
            this.clicksLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clicksLabel.ForeColor = System.Drawing.Color.White;
            this.clicksLabel.Location = new System.Drawing.Point(91, 51);
            this.clicksLabel.Name = "clicksLabel";
            this.clicksLabel.Size = new System.Drawing.Size(131, 42);
            this.clicksLabel.TabIndex = 2;
            this.clicksLabel.Text = "Clicks: 0";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = global::RocketClickerGame.Properties.Resources.Restart;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Location = new System.Drawing.Point(863, 9);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(58, 61);
            this.restartButton.TabIndex = 3;
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::RocketClickerGame.Properties.Resources.Options;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(799, 9);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(58, 61);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::RocketClickerGame.Properties.Resources.Start;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(720, 9);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(58, 61);
            this.playButton.TabIndex = 5;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playButtonTimer
            // 
            this.playButtonTimer.Tick += new System.EventHandler(this.playButtonTimer_Tick);
            // 
            // firePictureBox
            // 
            this.firePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.firePictureBox.BackgroundImage = global::RocketClickerGame.Properties.Resources.fire1__01;
            this.firePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.firePictureBox.Image = global::RocketClickerGame.Properties.Resources.fire1__01;
            this.firePictureBox.Location = new System.Drawing.Point(315, 575);
            this.firePictureBox.Name = "firePictureBox";
            this.firePictureBox.Size = new System.Drawing.Size(516, 203);
            this.firePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firePictureBox.TabIndex = 6;
            this.firePictureBox.TabStop = false;
            // 
            // flameTimer
            // 
            this.flameTimer.Tick += new System.EventHandler(this.flameTimer_Tick);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Black;
            this.pointsLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.White;
            this.pointsLabel.Location = new System.Drawing.Point(477, 9);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(133, 42);
            this.pointsLabel.TabIndex = 7;
            this.pointsLabel.Text = "Points: 0";
            // 
            // upgradesLabel
            // 
            this.upgradesLabel.BackColor = System.Drawing.Color.Transparent;
            this.upgradesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgradesLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.upgradesLabel.Location = new System.Drawing.Point(1005, 291);
            this.upgradesLabel.Name = "upgradesLabel";
            this.upgradesLabel.Size = new System.Drawing.Size(137, 41);
            this.upgradesLabel.TabIndex = 8;
            this.upgradesLabel.Text = "UPGRADES";
            // 
            // rocketEnhanceLabel
            // 
            this.rocketEnhanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.rocketEnhanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketEnhanceLabel.ForeColor = System.Drawing.Color.Gold;
            this.rocketEnhanceLabel.Location = new System.Drawing.Point(1022, 335);
            this.rocketEnhanceLabel.Name = "rocketEnhanceLabel";
            this.rocketEnhanceLabel.Size = new System.Drawing.Size(165, 48);
            this.rocketEnhanceLabel.TabIndex = 9;
            this.rocketEnhanceLabel.Text = "Rocket  Enhancement";
            // 
            // factoryImprovementsLabel
            // 
            this.factoryImprovementsLabel.BackColor = System.Drawing.Color.Transparent;
            this.factoryImprovementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factoryImprovementsLabel.ForeColor = System.Drawing.Color.Gold;
            this.factoryImprovementsLabel.Location = new System.Drawing.Point(1022, 456);
            this.factoryImprovementsLabel.Name = "factoryImprovementsLabel";
            this.factoryImprovementsLabel.Size = new System.Drawing.Size(165, 19);
            this.factoryImprovementsLabel.TabIndex = 10;
            this.factoryImprovementsLabel.Text = "Factory Improvements";
            // 
            // powerUpsLabel
            // 
            this.powerUpsLabel.BackColor = System.Drawing.Color.Transparent;
            this.powerUpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerUpsLabel.ForeColor = System.Drawing.Color.Gold;
            this.powerUpsLabel.Location = new System.Drawing.Point(1022, 614);
            this.powerUpsLabel.Name = "powerUpsLabel";
            this.powerUpsLabel.Size = new System.Drawing.Size(165, 17);
            this.powerUpsLabel.TabIndex = 11;
            this.powerUpsLabel.Text = "Power Ups";
            // 
            // specialItemsLabel
            // 
            this.specialItemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialItemsLabel.ForeColor = System.Drawing.Color.Gold;
            this.specialItemsLabel.Location = new System.Drawing.Point(1022, 713);
            this.specialItemsLabel.Name = "specialItemsLabel";
            this.specialItemsLabel.Size = new System.Drawing.Size(165, 16);
            this.specialItemsLabel.TabIndex = 12;
            this.specialItemsLabel.Text = "Special Items";
            // 
            // helpersLabel
            // 
            this.helpersLabel.BackColor = System.Drawing.Color.Transparent;
            this.helpersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpersLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.helpersLabel.Location = new System.Drawing.Point(12, 269);
            this.helpersLabel.Name = "helpersLabel";
            this.helpersLabel.Size = new System.Drawing.Size(137, 24);
            this.helpersLabel.TabIndex = 15;
            this.helpersLabel.Text = "HELPERS";
            // 
            // enhancePictureBox
            // 
            this.enhancePictureBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.enhancePictureBox.Image = global::RocketClickerGame.Properties.Resources.smallfighter;
            this.enhancePictureBox.Location = new System.Drawing.Point(982, 365);
            this.enhancePictureBox.Name = "enhancePictureBox";
            this.enhancePictureBox.Size = new System.Drawing.Size(71, 76);
            this.enhancePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enhancePictureBox.TabIndex = 16;
            this.enhancePictureBox.TabStop = false;
            // 
            // enhanceCostButton
            // 
            this.enhanceCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enhanceCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enhanceCostButton.Location = new System.Drawing.Point(1066, 406);
            this.enhanceCostButton.Name = "enhanceCostButton";
            this.enhanceCostButton.Size = new System.Drawing.Size(121, 35);
            this.enhanceCostButton.TabIndex = 17;
            this.enhanceCostButton.Text = "300 points";
            this.enhanceCostButton.UseVisualStyleBackColor = false;
            this.enhanceCostButton.Click += new System.EventHandler(this.enhanceCostButton_Click);
            // 
            // rocketNameLabel
            // 
            this.rocketNameLabel.AutoSize = true;
            this.rocketNameLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.rocketNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rocketNameLabel.Location = new System.Drawing.Point(875, 406);
            this.rocketNameLabel.Name = "rocketNameLabel";
            this.rocketNameLabel.Size = new System.Drawing.Size(85, 20);
            this.rocketNameLabel.TabIndex = 18;
            this.rocketNameLabel.Text = "Jet Fighter";
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.fuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fuelLabel.Location = new System.Drawing.Point(987, 642);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(40, 20);
            this.fuelLabel.TabIndex = 19;
            this.fuelLabel.Text = "Fuel";
            // 
            // fuelCostButton
            // 
            this.fuelCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fuelCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelCostButton.Location = new System.Drawing.Point(1066, 634);
            this.fuelCostButton.Name = "fuelCostButton";
            this.fuelCostButton.Size = new System.Drawing.Size(121, 35);
            this.fuelCostButton.TabIndex = 20;
            this.fuelCostButton.Text = "50 points";
            this.fuelCostButton.UseVisualStyleBackColor = false;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.speedLabel.Location = new System.Drawing.Point(987, 683);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(56, 20);
            this.speedLabel.TabIndex = 21;
            this.speedLabel.Text = "Speed";
            // 
            // speedCostButton
            // 
            this.speedCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.speedCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedCostButton.Location = new System.Drawing.Point(1066, 675);
            this.speedCostButton.Name = "speedCostButton";
            this.speedCostButton.Size = new System.Drawing.Size(121, 35);
            this.speedCostButton.TabIndex = 22;
            this.speedCostButton.Text = "100 points";
            this.speedCostButton.UseVisualStyleBackColor = false;
            // 
            // spacePictureBox
            // 
            this.spacePictureBox.Image = global::RocketClickerGame.Properties.Resources.Space_Background_1;
            this.spacePictureBox.Location = new System.Drawing.Point(980, 495);
            this.spacePictureBox.Name = "spacePictureBox";
            this.spacePictureBox.Size = new System.Drawing.Size(73, 50);
            this.spacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spacePictureBox.TabIndex = 23;
            this.spacePictureBox.TabStop = false;
            // 
            // dayPictureBox
            // 
            this.dayPictureBox.Image = global::RocketClickerGame.Properties.Resources.moonBackground;
            this.dayPictureBox.Location = new System.Drawing.Point(980, 551);
            this.dayPictureBox.Name = "dayPictureBox";
            this.dayPictureBox.Size = new System.Drawing.Size(73, 50);
            this.dayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dayPictureBox.TabIndex = 24;
            this.dayPictureBox.TabStop = false;
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.spaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spaceLabel.Location = new System.Drawing.Point(919, 510);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(55, 20);
            this.spaceLabel.TabIndex = 25;
            this.spaceLabel.Text = "Space";
            // 
            // spaceCostButton
            // 
            this.spaceCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.spaceCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceCostButton.Location = new System.Drawing.Point(1066, 510);
            this.spaceCostButton.Name = "spaceCostButton";
            this.spaceCostButton.Size = new System.Drawing.Size(121, 35);
            this.spaceCostButton.TabIndex = 26;
            this.spaceCostButton.Text = "2000 points";
            this.spaceCostButton.UseVisualStyleBackColor = false;
            this.spaceCostButton.Click += new System.EventHandler(this.spaceCostButton_Click);
            // 
            // nightCostButton
            // 
            this.nightCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nightCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightCostButton.Location = new System.Drawing.Point(1066, 566);
            this.nightCostButton.Name = "nightCostButton";
            this.nightCostButton.Size = new System.Drawing.Size(121, 35);
            this.nightCostButton.TabIndex = 27;
            this.nightCostButton.Text = "1000 points";
            this.nightCostButton.UseVisualStyleBackColor = false;
            this.nightCostButton.Click += new System.EventHandler(this.nightCostButton_Click);
            // 
            // nightLabel
            // 
            this.nightLabel.AutoSize = true;
            this.nightLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.nightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nightLabel.Location = new System.Drawing.Point(874, 566);
            this.nightLabel.Name = "nightLabel";
            this.nightLabel.Size = new System.Drawing.Size(86, 20);
            this.nightLabel.TabIndex = 28;
            this.nightLabel.Text = "MoonNight";
            // 
            // effectCostbutton
            // 
            this.effectCostbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.effectCostbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectCostbutton.Location = new System.Drawing.Point(1050, 734);
            this.effectCostbutton.Name = "effectCostbutton";
            this.effectCostbutton.Size = new System.Drawing.Size(121, 35);
            this.effectCostbutton.TabIndex = 29;
            this.effectCostbutton.Text = "600 points";
            this.effectCostbutton.UseVisualStyleBackColor = false;
            this.effectCostbutton.Click += new System.EventHandler(this.effectCostbutton_Click);
            // 
            // meteorPictureBox1
            // 
            this.meteorPictureBox1.Image = global::RocketClickerGame.Properties.Resources.Meteor1;
            this.meteorPictureBox1.Location = new System.Drawing.Point(1009, 734);
            this.meteorPictureBox1.Name = "meteorPictureBox1";
            this.meteorPictureBox1.Size = new System.Drawing.Size(35, 35);
            this.meteorPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.meteorPictureBox1.TabIndex = 30;
            this.meteorPictureBox1.TabStop = false;
            // 
            // meteorLabel
            // 
            this.meteorLabel.AutoSize = true;
            this.meteorLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.meteorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meteorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.meteorLabel.Location = new System.Drawing.Point(860, 742);
            this.meteorLabel.Name = "meteorLabel";
            this.meteorLabel.Size = new System.Drawing.Size(124, 20);
            this.meteorLabel.TabIndex = 31;
            this.meteorLabel.Text = "15s Fire Shower";
            // 
            // meteorTimer1
            // 
            this.meteorTimer1.Interval = 1000;
            this.meteorTimer1.Tick += new System.EventHandler(this.meteorTimer1_Tick);
            // 
            // riderPictureBox
            // 
            this.riderPictureBox.Image = global::RocketClickerGame.Properties.Resources.gryphon_rider;
            this.riderPictureBox.Location = new System.Drawing.Point(22, 335);
            this.riderPictureBox.Name = "riderPictureBox";
            this.riderPictureBox.Size = new System.Drawing.Size(100, 74);
            this.riderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.riderPictureBox.TabIndex = 32;
            this.riderPictureBox.TabStop = false;
            // 
            // engineerPictureBox
            // 
            this.engineerPictureBox.Image = global::RocketClickerGame.Properties.Resources.return_goods;
            this.engineerPictureBox.Location = new System.Drawing.Point(16, 456);
            this.engineerPictureBox.Name = "engineerPictureBox";
            this.engineerPictureBox.Size = new System.Drawing.Size(106, 73);
            this.engineerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engineerPictureBox.TabIndex = 33;
            this.engineerPictureBox.TabStop = false;
            // 
            // minerPictureBox
            // 
            this.minerPictureBox.Image = global::RocketClickerGame.Properties.Resources.dwarven_scout_gray_hair_braided_beard;
            this.minerPictureBox.Location = new System.Drawing.Point(16, 575);
            this.minerPictureBox.Name = "minerPictureBox";
            this.minerPictureBox.Size = new System.Drawing.Size(106, 75);
            this.minerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minerPictureBox.TabIndex = 34;
            this.minerPictureBox.TabStop = false;
            // 
            // minerLabel
            // 
            this.minerLabel.AutoSize = true;
            this.minerLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.minerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minerLabel.Location = new System.Drawing.Point(41, 553);
            this.minerLabel.Name = "minerLabel";
            this.minerLabel.Size = new System.Drawing.Size(48, 20);
            this.minerLabel.TabIndex = 35;
            this.minerLabel.Text = "Miner";
            // 
            // engineerLabel
            // 
            this.engineerLabel.AutoSize = true;
            this.engineerLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.engineerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.engineerLabel.Location = new System.Drawing.Point(30, 434);
            this.engineerLabel.Name = "engineerLabel";
            this.engineerLabel.Size = new System.Drawing.Size(73, 20);
            this.engineerLabel.TabIndex = 36;
            this.engineerLabel.Text = "Engineer";
            // 
            // riderLabel
            // 
            this.riderLabel.AutoSize = true;
            this.riderLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.riderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.riderLabel.Location = new System.Drawing.Point(41, 313);
            this.riderLabel.Name = "riderLabel";
            this.riderLabel.Size = new System.Drawing.Size(47, 20);
            this.riderLabel.TabIndex = 37;
            this.riderLabel.Text = "Rider";
            // 
            // riderCostButton
            // 
            this.riderCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.riderCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riderCostButton.Location = new System.Drawing.Point(128, 365);
            this.riderCostButton.Name = "riderCostButton";
            this.riderCostButton.Size = new System.Drawing.Size(108, 35);
            this.riderCostButton.TabIndex = 38;
            this.riderCostButton.Text = "220 points";
            this.riderCostButton.UseVisualStyleBackColor = false;
            this.riderCostButton.Click += new System.EventHandler(this.riderCostButton_Click);
            // 
            // minerCostButton
            // 
            this.minerCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minerCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minerCostButton.Location = new System.Drawing.Point(128, 596);
            this.minerCostButton.Name = "minerCostButton";
            this.minerCostButton.Size = new System.Drawing.Size(108, 35);
            this.minerCostButton.TabIndex = 39;
            this.minerCostButton.Text = "50 points";
            this.minerCostButton.UseVisualStyleBackColor = false;
            this.minerCostButton.Click += new System.EventHandler(this.minerCostButton_Click);
            // 
            // engineerCostButton
            // 
            this.engineerCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.engineerCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineerCostButton.Location = new System.Drawing.Point(128, 470);
            this.engineerCostButton.Name = "engineerCostButton";
            this.engineerCostButton.Size = new System.Drawing.Size(108, 35);
            this.engineerCostButton.TabIndex = 40;
            this.engineerCostButton.Text = "500 points";
            this.engineerCostButton.UseVisualStyleBackColor = false;
            this.engineerCostButton.Click += new System.EventHandler(this.engineerCostButton_Click);
            // 
            // passivePointTimer
            // 
            this.passivePointTimer.Interval = 1000;
            this.passivePointTimer.Tick += new System.EventHandler(this.passivePointTimer_Tick);
            // 
            // RocketClickerGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RocketClickerGame.Properties.Resources.centaurbridgeRender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 790);
            this.Controls.Add(this.engineerCostButton);
            this.Controls.Add(this.minerCostButton);
            this.Controls.Add(this.riderCostButton);
            this.Controls.Add(this.riderLabel);
            this.Controls.Add(this.engineerLabel);
            this.Controls.Add(this.minerLabel);
            this.Controls.Add(this.minerPictureBox);
            this.Controls.Add(this.engineerPictureBox);
            this.Controls.Add(this.riderPictureBox);
            this.Controls.Add(this.meteorLabel);
            this.Controls.Add(this.meteorPictureBox1);
            this.Controls.Add(this.effectCostbutton);
            this.Controls.Add(this.nightLabel);
            this.Controls.Add(this.nightCostButton);
            this.Controls.Add(this.spaceCostButton);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.dayPictureBox);
            this.Controls.Add(this.spacePictureBox);
            this.Controls.Add(this.speedCostButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.fuelCostButton);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.rocketNameLabel);
            this.Controls.Add(this.enhanceCostButton);
            this.Controls.Add(this.enhancePictureBox);
            this.Controls.Add(this.helpersLabel);
            this.Controls.Add(this.specialItemsLabel);
            this.Controls.Add(this.powerUpsLabel);
            this.Controls.Add(this.factoryImprovementsLabel);
            this.Controls.Add(this.rocketEnhanceLabel);
            this.Controls.Add(this.upgradesLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.firePictureBox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.clicksLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.rocketButton1);
            this.DoubleBuffered = true;
            this.Name = "RocketClickerGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocket Factory Tycoon";
            this.Load += new System.EventHandler(this.RocketClickerGameForm_Load);
            this.Shown += new System.EventHandler(this.RocketClickerGameForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.firePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enhancePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rocketButton1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label clicksLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer playButtonTimer;
        private System.Windows.Forms.PictureBox firePictureBox;
        private System.Windows.Forms.Timer flameTimer;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label upgradesLabel;
        private System.Windows.Forms.Label rocketEnhanceLabel;
        private System.Windows.Forms.Label factoryImprovementsLabel;
        private System.Windows.Forms.Label powerUpsLabel;
        private System.Windows.Forms.Label specialItemsLabel;
        private System.Windows.Forms.Label helpersLabel;
        private System.Windows.Forms.PictureBox enhancePictureBox;
        private System.Windows.Forms.Button enhanceCostButton;
        private System.Windows.Forms.Label rocketNameLabel;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.Button fuelCostButton;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button speedCostButton;
        private System.Windows.Forms.PictureBox spacePictureBox;
        private System.Windows.Forms.PictureBox dayPictureBox;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Button spaceCostButton;
        private System.Windows.Forms.Button nightCostButton;
        private System.Windows.Forms.Label nightLabel;
        private System.Windows.Forms.Button effectCostbutton;
        private System.Windows.Forms.PictureBox meteorPictureBox1;
        private System.Windows.Forms.Label meteorLabel;
        private System.Windows.Forms.Timer meteorTimer;
        private System.Windows.Forms.Timer meteorTimer1;
        private System.Windows.Forms.PictureBox riderPictureBox;
        private System.Windows.Forms.PictureBox engineerPictureBox;
        private System.Windows.Forms.PictureBox minerPictureBox;
        private System.Windows.Forms.Label minerLabel;
        private System.Windows.Forms.Label engineerLabel;
        private System.Windows.Forms.Label riderLabel;
        private System.Windows.Forms.Button riderCostButton;
        private System.Windows.Forms.Button minerCostButton;
        private System.Windows.Forms.Button engineerCostButton;
        private System.Windows.Forms.Timer passivePointTimer;
    }
}

