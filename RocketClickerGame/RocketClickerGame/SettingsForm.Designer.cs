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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
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
            resources.ApplyResources(this.settingsLabel, "settingsLabel");
            this.settingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel.ForeColor = System.Drawing.Color.Black;
            this.settingsLabel.Name = "settingsLabel";
            // 
            // NumberSettingComboBox
            // 
            resources.ApplyResources(this.NumberSettingComboBox, "NumberSettingComboBox");
            this.NumberSettingComboBox.FormattingEnabled = true;
            this.NumberSettingComboBox.Items.AddRange(new object[] {
            resources.GetString("NumberSettingComboBox.Items"),
            resources.GetString("NumberSettingComboBox.Items1"),
            resources.GetString("NumberSettingComboBox.Items2")});
            this.NumberSettingComboBox.Name = "NumberSettingComboBox";
            this.NumberSettingComboBox.SelectedIndexChanged += new System.EventHandler(this.NumberSettingComboBox_SelectedIndexChanged);
            // 
            // NumberLabel
            // 
            resources.ApplyResources(this.NumberLabel, "NumberLabel");
            this.NumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberLabel.Name = "NumberLabel";
          //  this.NumberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MusicOn
            // 
            resources.ApplyResources(this.MusicOn, "MusicOn");
            this.MusicOn.BackColor = System.Drawing.Color.Transparent;
            this.MusicOn.Name = "MusicOn";
            this.MusicOn.TabStop = true;
            this.MusicOn.UseVisualStyleBackColor = false;
            this.MusicOn.CheckedChanged += new System.EventHandler(this.MusicOn_CheckedChanged);
            // 
            // MusicOffButton
            // 
            resources.ApplyResources(this.MusicOffButton, "MusicOffButton");
            this.MusicOffButton.BackColor = System.Drawing.Color.Transparent;
            this.MusicOffButton.Name = "MusicOffButton";
            this.MusicOffButton.TabStop = true;
            this.MusicOffButton.UseVisualStyleBackColor = false;
            this.MusicOffButton.CheckedChanged += new System.EventHandler(this.MusicOffButton_CheckedChanged);
            // 
            // MusicLabel
            // 
            resources.ApplyResources(this.MusicLabel, "MusicLabel");
            this.MusicLabel.BackColor = System.Drawing.Color.Transparent;
            this.MusicLabel.Name = "MusicLabel";
            // 
            // AchievementLabel
            // 
            resources.ApplyResources(this.AchievementLabel, "AchievementLabel");
            this.AchievementLabel.BackColor = System.Drawing.Color.Transparent;
            this.AchievementLabel.Name = "AchievementLabel";
//            this.AchievementLabel.Click += new System.EventHandler(this.AchievementLabel_Click);
            // 
            // MinerAchievementLabel
            // 
            resources.ApplyResources(this.MinerAchievementLabel, "MinerAchievementLabel");
            this.MinerAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MinerAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinerAchievementLabel.Name = "MinerAchievementLabel";
//            this.MinerAchievementLabel.Click += new System.EventHandler(this.Achievement1Label_Click);
            // 
            // EngineerAchievementLabel
            // 
            resources.ApplyResources(this.EngineerAchievementLabel, "EngineerAchievementLabel");
            this.EngineerAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EngineerAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EngineerAchievementLabel.Name = "EngineerAchievementLabel";
            // 
            // RiderAchievementLabel
            // 
            resources.ApplyResources(this.RiderAchievementLabel, "RiderAchievementLabel");
            this.RiderAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.RiderAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RiderAchievementLabel.Name = "RiderAchievementLabel";
            // 
            // ClickAchievementLabel1
            // 
            resources.ApplyResources(this.ClickAchievementLabel1, "ClickAchievementLabel1");
            this.ClickAchievementLabel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClickAchievementLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickAchievementLabel1.Name = "ClickAchievementLabel1";
            // 
            // ClickAchievementLabel2
            // 
            resources.ApplyResources(this.ClickAchievementLabel2, "ClickAchievementLabel2");
            this.ClickAchievementLabel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClickAchievementLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickAchievementLabel2.Name = "ClickAchievementLabel2";
            // 
            // SpaceAchievementLabel
            // 
            resources.ApplyResources(this.SpaceAchievementLabel, "SpaceAchievementLabel");
            this.SpaceAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SpaceAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpaceAchievementLabel.Name = "SpaceAchievementLabel";
            // 
            // NightSkyAchievementLabel
            // 
            resources.ApplyResources(this.NightSkyAchievementLabel, "NightSkyAchievementLabel");
            this.NightSkyAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NightSkyAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NightSkyAchievementLabel.Name = "NightSkyAchievementLabel";
            // 
            // MeteorAchievementLabel
            // 
            resources.ApplyResources(this.MeteorAchievementLabel, "MeteorAchievementLabel");
            this.MeteorAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MeteorAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeteorAchievementLabel.Name = "MeteorAchievementLabel";
            // 
            // PlayTimeAchievementLabel
            // 
            resources.ApplyResources(this.PlayTimeAchievementLabel, "PlayTimeAchievementLabel");
            this.PlayTimeAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PlayTimeAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayTimeAchievementLabel.Name = "PlayTimeAchievementLabel";
            // 
            // NewRocketAchievementLabel
            // 
            resources.ApplyResources(this.NewRocketAchievementLabel, "NewRocketAchievementLabel");
            this.NewRocketAchievementLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewRocketAchievementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewRocketAchievementLabel.Name = "NewRocketAchievementLabel";
            // 
            // ClickAchievementLabel3
            // 
            resources.ApplyResources(this.ClickAchievementLabel3, "ClickAchievementLabel3");
            this.ClickAchievementLabel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClickAchievementLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickAchievementLabel3.Name = "ClickAchievementLabel3";
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RocketClickerGame.Properties.Resources.paper_background;
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
//            this.Load += new System.EventHandler(this.SettingsForm_Load);
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