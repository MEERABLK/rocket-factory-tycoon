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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RocketClickerGameForm));
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
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.rocketButton1, "rocketButton1");
            this.rocketButton1.BackColor = System.Drawing.Color.Transparent;
            this.rocketButton1.BackgroundImage = global::RocketClickerGame.Properties.Resources.conte_magnus_cc0_Rockets;
            this.rocketButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rocketButton1.FlatAppearance.BorderSize = 0;
            this.rocketButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rocketButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rocketButton1.Name = "rocketButton1";
            this.rocketButton1.UseVisualStyleBackColor = false;
            this.rocketButton1.Click += new System.EventHandler(this.rocketButton1_Click);
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Name = "timeLabel";
            // 
            // clicksLabel
            // 
            resources.ApplyResources(this.clicksLabel, "clicksLabel");
            this.clicksLabel.BackColor = System.Drawing.Color.Transparent;
            this.clicksLabel.ForeColor = System.Drawing.Color.White;
            this.clicksLabel.Name = "clicksLabel";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // restartButton
            // 
            resources.ApplyResources(this.restartButton, "restartButton");
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = global::RocketClickerGame.Properties.Resources.Restart;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restartButton.Name = "restartButton";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // settingsButton
            // 
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::RocketClickerGame.Properties.Resources.Options;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // playButton
            // 
            resources.ApplyResources(this.playButton, "playButton");
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::RocketClickerGame.Properties.Resources.Start;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playButton.Name = "playButton";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playButtonTimer
            // 
            this.playButtonTimer.Tick += new System.EventHandler(this.playButtonTimer_Tick);
            // 
            // firePictureBox
            // 
            resources.ApplyResources(this.firePictureBox, "firePictureBox");
            this.firePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.firePictureBox.BackgroundImage = global::RocketClickerGame.Properties.Resources.fire1__01;
            this.firePictureBox.Image = global::RocketClickerGame.Properties.Resources.fire1__01;
            this.firePictureBox.Name = "firePictureBox";
            this.firePictureBox.TabStop = false;
            // 
            // flameTimer
            // 
            this.flameTimer.Tick += new System.EventHandler(this.flameTimer_Tick);
            // 
            // pointsLabel
            // 
            resources.ApplyResources(this.pointsLabel, "pointsLabel");
            this.pointsLabel.BackColor = System.Drawing.Color.Black;
            this.pointsLabel.ForeColor = System.Drawing.Color.White;
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Click += new System.EventHandler(this.pointsLabel_Click);
            // 
            // upgradesLabel
            // 
            resources.ApplyResources(this.upgradesLabel, "upgradesLabel");
            this.upgradesLabel.BackColor = System.Drawing.Color.Transparent;
            this.upgradesLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.upgradesLabel.Name = "upgradesLabel";
            // 
            // rocketEnhanceLabel
            // 
            resources.ApplyResources(this.rocketEnhanceLabel, "rocketEnhanceLabel");
            this.rocketEnhanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.rocketEnhanceLabel.ForeColor = System.Drawing.Color.Gold;
            this.rocketEnhanceLabel.Name = "rocketEnhanceLabel";
            // 
            // factoryImprovementsLabel
            // 
            resources.ApplyResources(this.factoryImprovementsLabel, "factoryImprovementsLabel");
            this.factoryImprovementsLabel.BackColor = System.Drawing.Color.Transparent;
            this.factoryImprovementsLabel.ForeColor = System.Drawing.Color.Gold;
            this.factoryImprovementsLabel.Name = "factoryImprovementsLabel";
            // 
            // powerUpsLabel
            // 
            resources.ApplyResources(this.powerUpsLabel, "powerUpsLabel");
            this.powerUpsLabel.BackColor = System.Drawing.Color.Transparent;
            this.powerUpsLabel.ForeColor = System.Drawing.Color.Gold;
            this.powerUpsLabel.Name = "powerUpsLabel";
            // 
            // specialItemsLabel
            // 
            resources.ApplyResources(this.specialItemsLabel, "specialItemsLabel");
            this.specialItemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialItemsLabel.ForeColor = System.Drawing.Color.Gold;
            this.specialItemsLabel.Name = "specialItemsLabel";
            // 
            // helpersLabel
            // 
            resources.ApplyResources(this.helpersLabel, "helpersLabel");
            this.helpersLabel.BackColor = System.Drawing.Color.Transparent;
            this.helpersLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.helpersLabel.Name = "helpersLabel";
            // 
            // enhancePictureBox
            // 
            resources.ApplyResources(this.enhancePictureBox, "enhancePictureBox");
            this.enhancePictureBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.enhancePictureBox.Image = global::RocketClickerGame.Properties.Resources.smallfighter;
            this.enhancePictureBox.Name = "enhancePictureBox";
            this.enhancePictureBox.TabStop = false;
            // 
            // enhanceCostButton
            // 
            resources.ApplyResources(this.enhanceCostButton, "enhanceCostButton");
            this.enhanceCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enhanceCostButton.Name = "enhanceCostButton";
            this.enhanceCostButton.UseVisualStyleBackColor = false;
            this.enhanceCostButton.Click += new System.EventHandler(this.enhanceCostButton_Click);
            // 
            // rocketNameLabel
            // 
            resources.ApplyResources(this.rocketNameLabel, "rocketNameLabel");
            this.rocketNameLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.rocketNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rocketNameLabel.Name = "rocketNameLabel";
            // 
            // fuelLabel
            // 
            resources.ApplyResources(this.fuelLabel, "fuelLabel");
            this.fuelLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.fuelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fuelLabel.Name = "fuelLabel";
            // 
            // fuelCostButton
            // 
            resources.ApplyResources(this.fuelCostButton, "fuelCostButton");
            this.fuelCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fuelCostButton.Name = "fuelCostButton";
            this.fuelCostButton.UseVisualStyleBackColor = false;
            // 
            // speedLabel
            // 
            resources.ApplyResources(this.speedLabel, "speedLabel");
            this.speedLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.speedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.speedLabel.Name = "speedLabel";
            // 
            // speedCostButton
            // 
            resources.ApplyResources(this.speedCostButton, "speedCostButton");
            this.speedCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.speedCostButton.Name = "speedCostButton";
            this.speedCostButton.UseVisualStyleBackColor = false;
            // 
            // spacePictureBox
            // 
            resources.ApplyResources(this.spacePictureBox, "spacePictureBox");
            this.spacePictureBox.Image = global::RocketClickerGame.Properties.Resources.Space_Background_1;
            this.spacePictureBox.Name = "spacePictureBox";
            this.spacePictureBox.TabStop = false;
            // 
            // dayPictureBox
            // 
            resources.ApplyResources(this.dayPictureBox, "dayPictureBox");
            this.dayPictureBox.Image = global::RocketClickerGame.Properties.Resources.moonBackground;
            this.dayPictureBox.Name = "dayPictureBox";
            this.dayPictureBox.TabStop = false;
            // 
            // spaceLabel
            // 
            resources.ApplyResources(this.spaceLabel, "spaceLabel");
            this.spaceLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.spaceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spaceLabel.Name = "spaceLabel";
            // 
            // spaceCostButton
            // 
            resources.ApplyResources(this.spaceCostButton, "spaceCostButton");
            this.spaceCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.spaceCostButton.Name = "spaceCostButton";
            this.spaceCostButton.UseVisualStyleBackColor = false;
            this.spaceCostButton.Click += new System.EventHandler(this.spaceCostButton_Click);
            // 
            // nightCostButton
            // 
            resources.ApplyResources(this.nightCostButton, "nightCostButton");
            this.nightCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nightCostButton.Name = "nightCostButton";
            this.nightCostButton.UseVisualStyleBackColor = false;
            this.nightCostButton.Click += new System.EventHandler(this.nightCostButton_Click);
            // 
            // nightLabel
            // 
            resources.ApplyResources(this.nightLabel, "nightLabel");
            this.nightLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.nightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nightLabel.Name = "nightLabel";
            // 
            // effectCostbutton
            // 
            resources.ApplyResources(this.effectCostbutton, "effectCostbutton");
            this.effectCostbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.effectCostbutton.Name = "effectCostbutton";
            this.effectCostbutton.UseVisualStyleBackColor = false;
            this.effectCostbutton.Click += new System.EventHandler(this.effectCostbutton_Click);
            // 
            // meteorPictureBox1
            // 
            resources.ApplyResources(this.meteorPictureBox1, "meteorPictureBox1");
            this.meteorPictureBox1.Image = global::RocketClickerGame.Properties.Resources.Meteor1;
            this.meteorPictureBox1.Name = "meteorPictureBox1";
            this.meteorPictureBox1.TabStop = false;
            // 
            // meteorLabel
            // 
            resources.ApplyResources(this.meteorLabel, "meteorLabel");
            this.meteorLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.meteorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.meteorLabel.Name = "meteorLabel";
            // 
            // meteorTimer1
            // 
            this.meteorTimer1.Interval = 1000;
            this.meteorTimer1.Tick += new System.EventHandler(this.meteorTimer1_Tick);
            // 
            // riderPictureBox
            // 
            resources.ApplyResources(this.riderPictureBox, "riderPictureBox");
            this.riderPictureBox.Image = global::RocketClickerGame.Properties.Resources.gryphon_rider;
            this.riderPictureBox.Name = "riderPictureBox";
            this.riderPictureBox.TabStop = false;
            // 
            // engineerPictureBox
            // 
            resources.ApplyResources(this.engineerPictureBox, "engineerPictureBox");
            this.engineerPictureBox.Image = global::RocketClickerGame.Properties.Resources.return_goods;
            this.engineerPictureBox.Name = "engineerPictureBox";
            this.engineerPictureBox.TabStop = false;
            // 
            // minerPictureBox
            // 
            resources.ApplyResources(this.minerPictureBox, "minerPictureBox");
            this.minerPictureBox.Image = global::RocketClickerGame.Properties.Resources.dwarven_scout_gray_hair_braided_beard;
            this.minerPictureBox.Name = "minerPictureBox";
            this.minerPictureBox.TabStop = false;
            // 
            // minerLabel
            // 
            resources.ApplyResources(this.minerLabel, "minerLabel");
            this.minerLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.minerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minerLabel.Name = "minerLabel";
            // 
            // engineerLabel
            // 
            resources.ApplyResources(this.engineerLabel, "engineerLabel");
            this.engineerLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.engineerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.engineerLabel.Name = "engineerLabel";
            // 
            // riderLabel
            // 
            resources.ApplyResources(this.riderLabel, "riderLabel");
            this.riderLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.riderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.riderLabel.Name = "riderLabel";
            // 
            // riderCostButton
            // 
            resources.ApplyResources(this.riderCostButton, "riderCostButton");
            this.riderCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.riderCostButton.Name = "riderCostButton";
            this.riderCostButton.UseVisualStyleBackColor = false;
            this.riderCostButton.Click += new System.EventHandler(this.riderCostButton_Click);
            // 
            // minerCostButton
            // 
            resources.ApplyResources(this.minerCostButton, "minerCostButton");
            this.minerCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minerCostButton.Name = "minerCostButton";
            this.minerCostButton.UseVisualStyleBackColor = false;
            this.minerCostButton.Click += new System.EventHandler(this.minerCostButton_Click);
            // 
            // engineerCostButton
            // 
            resources.ApplyResources(this.engineerCostButton, "engineerCostButton");
            this.engineerCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.engineerCostButton.Name = "engineerCostButton";
            this.engineerCostButton.UseVisualStyleBackColor = false;
            this.engineerCostButton.Click += new System.EventHandler(this.engineerCostButton_Click);
            // 
            // passivePointTimer
            // 
            this.passivePointTimer.Interval = 1000;
            this.passivePointTimer.Tick += new System.EventHandler(this.passivePointTimer_Tick);
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.Transparent;
            this.languageLabel.ForeColor = System.Drawing.Color.White;
            this.languageLabel.Name = "languageLabel";
            // 
            // RocketClickerGameForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RocketClickerGame.Properties.Resources.centaurbridgeRender;
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
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
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
    }
}

