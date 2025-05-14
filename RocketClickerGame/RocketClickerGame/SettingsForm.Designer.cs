namespace RocketClickerGame
{
    partial class SettingsForm
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
            this.settingsLabel = new System.Windows.Forms.Label();
            this.NumberSettingComboBox = new System.Windows.Forms.ComboBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.MusicOn = new System.Windows.Forms.RadioButton();
            this.MusicOffButton = new System.Windows.Forms.RadioButton();
            this.MusicLabel = new System.Windows.Forms.Label();
            this.AchievementLabel = new System.Windows.Forms.Label();
            this.MinerAchievementLabel = new System.Windows.Forms.Label();
            this.EngineerAchievementLabel = new System.Windows.Forms.Label();
            this.RiderAchievementLabel = new System.Windows.Forms.Label();
            this.ClickAchievementLabel1 = new System.Windows.Forms.Label();
            this.ClickAchievementLabel2 = new System.Windows.Forms.Label();
            this.SpaceAchievementLabel = new System.Windows.Forms.Label();
            this.NightSkyAchievementLabel = new System.Windows.Forms.Label();
            this.MeteorAchievementLabel = new System.Windows.Forms.Label();
            this.PlayTimeAchievementLabel = new System.Windows.Forms.Label();
            this.NewRocketAchievementLabel = new System.Windows.Forms.Label();
            this.ClickAchievementLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.Black;
            this.settingsLabel.Location = new System.Drawing.Point(296, 38);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(208, 40);
            this.settingsLabel.TabIndex = 8;
            this.settingsLabel.Text = "SETTINGS";
            // 
            // NumberSettingComboBox
            // 
            this.NumberSettingComboBox.FormattingEnabled = true;
            this.NumberSettingComboBox.Items.AddRange(new object[] {
            "Spoken Notation",
            "Scientific Notation",
            "Engineering Notation"});
            this.NumberSettingComboBox.Location = new System.Drawing.Point(124, 130);
            this.NumberSettingComboBox.Name = "NumberSettingComboBox";
            this.NumberSettingComboBox.Size = new System.Drawing.Size(141, 21);
            this.NumberSettingComboBox.TabIndex = 9;
            this.NumberSettingComboBox.SelectedIndexChanged += new System.EventHandler(this.NumberSettingComboBox_SelectedIndexChanged);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.Location = new System.Drawing.Point(120, 107);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(120, 20);
            this.NumberLabel.TabIndex = 11;
            this.NumberLabel.Text = "Number Format";
            this.NumberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MusicOn
            // 
            this.MusicOn.AutoSize = true;
            this.MusicOn.BackColor = System.Drawing.Color.Transparent;
            this.MusicOn.Location = new System.Drawing.Point(124, 186);
            this.MusicOn.Name = "MusicOn";
            this.MusicOn.Size = new System.Drawing.Size(39, 17);
            this.MusicOn.TabIndex = 12;
            this.MusicOn.TabStop = true;
            this.MusicOn.Text = "On";
            this.MusicOn.UseVisualStyleBackColor = false;
            // 
            // MusicOffButton
            // 
            this.MusicOffButton.AutoSize = true;
            this.MusicOffButton.BackColor = System.Drawing.Color.Transparent;
            this.MusicOffButton.Location = new System.Drawing.Point(124, 204);
            this.MusicOffButton.Name = "MusicOffButton";
            this.MusicOffButton.Size = new System.Drawing.Size(39, 17);
            this.MusicOffButton.TabIndex = 13;
            this.MusicOffButton.TabStop = true;
            this.MusicOffButton.Text = "Off";
            this.MusicOffButton.UseVisualStyleBackColor = false;
            // 
            // MusicLabel
            // 
            this.MusicLabel.AutoSize = true;
            this.MusicLabel.BackColor = System.Drawing.Color.Transparent;
            this.MusicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicLabel.Location = new System.Drawing.Point(120, 163);
            this.MusicLabel.Name = "MusicLabel";
            this.MusicLabel.Size = new System.Drawing.Size(50, 20);
            this.MusicLabel.TabIndex = 15;
            this.MusicLabel.Text = "Music";
            // 
            // AchievementLabel
            // 
            this.AchievementLabel.AutoSize = true;
            this.AchievementLabel.BackColor = System.Drawing.Color.Transparent;
            this.AchievementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchievementLabel.Location = new System.Drawing.Point(503, 99);
            this.AchievementLabel.Name = "AchievementLabel";
            this.AchievementLabel.Size = new System.Drawing.Size(175, 29);
            this.AchievementLabel.TabIndex = 16;
            this.AchievementLabel.Text = "Achievements";
            this.AchievementLabel.Click += new System.EventHandler(this.AchievementLabel_Click);
            // 
            // MinerAchievementLabel
            // 
            this.MinerAchievementLabel.AutoSize = true;
            this.MinerAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MinerAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinerAchievementLabel.Location = new System.Drawing.Point(503, 136);
            this.MinerAchievementLabel.Name = "MinerAchievementLabel";
            this.MinerAchievementLabel.Padding = new System.Windows.Forms.Padding(54, 6, 54, 6);
            this.MinerAchievementLabel.Size = new System.Drawing.Size(172, 27);
            this.MinerAchievementLabel.TabIndex = 17;
            this.MinerAchievementLabel.Text = "Buy a miner";
            this.MinerAchievementLabel.Click += new System.EventHandler(this.Achievement1Label_Click);
            // 
            // EngineerAchievementLabel
            // 
            this.EngineerAchievementLabel.AutoSize = true;
            this.EngineerAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EngineerAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EngineerAchievementLabel.Location = new System.Drawing.Point(503, 164);
            this.EngineerAchievementLabel.Name = "EngineerAchievementLabel";
            this.EngineerAchievementLabel.Padding = new System.Windows.Forms.Padding(54, 6, 32, 6);
            this.EngineerAchievementLabel.Size = new System.Drawing.Size(172, 27);
            this.EngineerAchievementLabel.TabIndex = 18;
            this.EngineerAchievementLabel.Text = "Buy an engineer";
            // 
            // RiderAchievementLabel
            // 
            this.RiderAchievementLabel.AutoSize = true;
            this.RiderAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.RiderAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RiderAchievementLabel.Location = new System.Drawing.Point(503, 192);
            this.RiderAchievementLabel.Name = "RiderAchievementLabel";
            this.RiderAchievementLabel.Padding = new System.Windows.Forms.Padding(54, 6, 59, 6);
            this.RiderAchievementLabel.Size = new System.Drawing.Size(172, 27);
            this.RiderAchievementLabel.TabIndex = 19;
            this.RiderAchievementLabel.Text = "Buy a rider";
            // 
            // ClickAchievementLabel1
            // 
            this.ClickAchievementLabel1.AutoSize = true;
            this.ClickAchievementLabel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClickAchievementLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickAchievementLabel1.Location = new System.Drawing.Point(503, 220);
            this.ClickAchievementLabel1.Name = "ClickAchievementLabel1";
            this.ClickAchievementLabel1.Padding = new System.Windows.Forms.Padding(54, 6, 38, 6);
            this.ClickAchievementLabel1.Size = new System.Drawing.Size(172, 27);
            this.ClickAchievementLabel1.TabIndex = 20;
            this.ClickAchievementLabel1.Text = "Click 100 times";
            // 
            // ClickAchievementLabel2
            // 
            this.ClickAchievementLabel2.AutoSize = true;
            this.ClickAchievementLabel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClickAchievementLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickAchievementLabel2.Location = new System.Drawing.Point(503, 248);
            this.ClickAchievementLabel2.Name = "ClickAchievementLabel2";
            this.ClickAchievementLabel2.Padding = new System.Windows.Forms.Padding(54, 6, 38, 6);
            this.ClickAchievementLabel2.Size = new System.Drawing.Size(172, 27);
            this.ClickAchievementLabel2.TabIndex = 21;
            this.ClickAchievementLabel2.Text = "Click 250 times";
            // 
            // SpaceAchievementLabel
            // 
            this.SpaceAchievementLabel.AutoSize = true;
            this.SpaceAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SpaceAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpaceAchievementLabel.Location = new System.Drawing.Point(503, 416);
            this.SpaceAchievementLabel.Name = "SpaceAchievementLabel";
            this.SpaceAchievementLabel.Padding = new System.Windows.Forms.Padding(54, 6, 38, 6);
            this.SpaceAchievementLabel.Size = new System.Drawing.Size(172, 27);
            this.SpaceAchievementLabel.TabIndex = 22;
            this.SpaceAchievementLabel.Text = "Move to space";
            // 
            // NightSkyAchievementLabel
            // 
            this.NightSkyAchievementLabel.AutoSize = true;
            this.NightSkyAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NightSkyAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NightSkyAchievementLabel.Location = new System.Drawing.Point(503, 388);
            this.NightSkyAchievementLabel.Name = "NightSkyAchievementLabel";
            this.NightSkyAchievementLabel.Padding = new System.Windows.Forms.Padding(54, 6, 7, 6);
            this.NightSkyAchievementLabel.Size = new System.Drawing.Size(172, 27);
            this.NightSkyAchievementLabel.TabIndex = 23;
            this.NightSkyAchievementLabel.Text = "Move to the night sky";
            // 
            // MeteorAchievementLabel
            // 
            this.MeteorAchievementLabel.AutoSize = true;
            this.MeteorAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MeteorAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeteorAchievementLabel.Location = new System.Drawing.Point(503, 332);
            this.MeteorAchievementLabel.Name = "MeteorAchievementLabel";
            this.MeteorAchievementLabel.Padding = new System.Windows.Forms.Padding(54, 6, 6, 6);
            this.MeteorAchievementLabel.Size = new System.Drawing.Size(172, 27);
            this.MeteorAchievementLabel.TabIndex = 24;
            this.MeteorAchievementLabel.Text = "Start a meteor shower";
            // 
            // PlayTimeAchievementLabel
            // 
            this.PlayTimeAchievementLabel.AutoSize = true;
            this.PlayTimeAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PlayTimeAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayTimeAchievementLabel.Location = new System.Drawing.Point(503, 360);
            this.PlayTimeAchievementLabel.Name = "PlayTimeAchievementLabel";
            this.PlayTimeAchievementLabel.Padding = new System.Windows.Forms.Padding(54, 6, 20, 6);
            this.PlayTimeAchievementLabel.Size = new System.Drawing.Size(172, 27);
            this.PlayTimeAchievementLabel.TabIndex = 25;
            this.PlayTimeAchievementLabel.Text = "Play for 10 minutes";
            // 
            // NewRocketAchievementLabel
            // 
            this.NewRocketAchievementLabel.AutoSize = true;
            this.NewRocketAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewRocketAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewRocketAchievementLabel.Location = new System.Drawing.Point(503, 304);
            this.NewRocketAchievementLabel.Name = "NewRocketAchievementLabel";
            this.NewRocketAchievementLabel.Padding = new System.Windows.Forms.Padding(54, 6, 26, 6);
            this.NewRocketAchievementLabel.Size = new System.Drawing.Size(172, 27);
            this.NewRocketAchievementLabel.TabIndex = 26;
            this.NewRocketAchievementLabel.Text = "Buy a new rocket";
            // 
            // ClickAchievementLabel3
            // 
            this.ClickAchievementLabel3.AutoSize = true;
            this.ClickAchievementLabel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClickAchievementLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickAchievementLabel3.Location = new System.Drawing.Point(503, 276);
            this.ClickAchievementLabel3.Name = "ClickAchievementLabel3";
            this.ClickAchievementLabel3.Padding = new System.Windows.Forms.Padding(54, 6, 32, 6);
            this.ClickAchievementLabel3.Size = new System.Drawing.Size(172, 27);
            this.ClickAchievementLabel3.TabIndex = 27;
            this.ClickAchievementLabel3.Text = "Click 1000 times";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RocketClickerGame.Properties.Resources.paper_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClickAchievementLabel3);
            this.Controls.Add(this.NewRocketAchievementLabel);
            this.Controls.Add(this.PlayTimeAchievementLabel);
            this.Controls.Add(this.MeteorAchievementLabel);
            this.Controls.Add(this.NightSkyAchievementLabel);
            this.Controls.Add(this.SpaceAchievementLabel);
            this.Controls.Add(this.ClickAchievementLabel2);
            this.Controls.Add(this.ClickAchievementLabel1);
            this.Controls.Add(this.RiderAchievementLabel);
            this.Controls.Add(this.EngineerAchievementLabel);
            this.Controls.Add(this.MinerAchievementLabel);
            this.Controls.Add(this.AchievementLabel);
            this.Controls.Add(this.MusicLabel);
            this.Controls.Add(this.MusicOffButton);
            this.Controls.Add(this.MusicOn);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NumberSettingComboBox);
            this.Controls.Add(this.settingsLabel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.ComboBox NumberSettingComboBox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.RadioButton MusicOn;
        private System.Windows.Forms.RadioButton MusicOffButton;
        private System.Windows.Forms.Label MusicLabel;
        private System.Windows.Forms.Label AchievementLabel;
        private System.Windows.Forms.Label MinerAchievementLabel;
        private System.Windows.Forms.Label EngineerAchievementLabel;
        private System.Windows.Forms.Label RiderAchievementLabel;
        private System.Windows.Forms.Label ClickAchievementLabel1;
        private System.Windows.Forms.Label ClickAchievementLabel2;
        private System.Windows.Forms.Label SpaceAchievementLabel;
        private System.Windows.Forms.Label NightSkyAchievementLabel;
        private System.Windows.Forms.Label MeteorAchievementLabel;
        private System.Windows.Forms.Label PlayTimeAchievementLabel;
        private System.Windows.Forms.Label NewRocketAchievementLabel;
        private System.Windows.Forms.Label ClickAchievementLabel3;
    }
}