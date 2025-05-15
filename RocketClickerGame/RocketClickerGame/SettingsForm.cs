using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketClickerGame
{
    public partial class SettingsForm : Form
    {
        private RocketClickerGameForm gameForm;
        public SettingsForm(RocketClickerGameForm gameForm)
        {
            InitializeComponent();
            this.gameForm = gameForm;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void NumberSettingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (NumberSettingComboBox.SelectedIndex)
            {
                case 0:
                    gameForm.numberDisplay = "SpokenNotation";
                    break;
                case 1:
                    gameForm.numberDisplay = "ScientificNotation";
                    break;
                case 2:
                    gameForm.numberDisplay = "EngineeringNotation";
                    break;
            }
        }

        public void CompleteMinerAchievement()
        {
            MinerAchievementLabel.BackColor = Color.Green;
        }
        public void CompleteEngineerAchievement()
        {
            EngineerAchievementLabel.BackColor = Color.Green;
        }
        public void CompleteRiderAchievement()
        {
            RiderAchievementLabel.BackColor = Color.Green;
        }
        public void CompleteClickAchievement1()
        {
            ClickAchievementLabel1.BackColor = Color.Green;
        }
        public void CompleteClickAchievement2()
        {
            ClickAchievementLabel2.BackColor = Color.Green;
        }
        public void CompleteClickAchievement3()
        {
            ClickAchievementLabel3.BackColor = Color.Green;
        }
        public void CompleteRocketAchievement()
        {
            NewRocketAchievementLabel.BackColor = Color.Green;
        }
        public void CompleteMeteorAchievement()
        {
            MeteorAchievementLabel.BackColor = Color.Green;
        }
        public void CompletePlaytimeAchievement()
        {
            PlayTimeAchievementLabel.BackColor = Color.Green;
        }
        public void CompleteNightSkyAchievement()
        {
            NightSkyAchievementLabel.BackColor = Color.Green;
        }
        public void CompleteSpaceAchievement()
        {
            SpaceAchievementLabel.BackColor = Color.Green;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AchievementLabel_Click(object sender, EventArgs e)
        {

        }

        private void Achievement1Label_Click(object sender, EventArgs e)
        {

        }

        private void MusicOn_CheckedChanged(object sender, EventArgs e)
        {
            if (MusicOn.Checked) {
                gameForm.musicOn();
            }
        }

        private void MusicOffButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MusicOffButton.Checked)
            {
                gameForm.musicOff();
            }
        }
    }
}
