using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private string currentLanguage;

        private RocketClickerGameForm gameForm;
        public SettingsForm(RocketClickerGameForm gameForm)
        {
            InitializeComponent();
            this.gameForm = gameForm;
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

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //clear items of combobox
            NumberSettingComboBox.Items.Clear();

            //foreach notation type class in enum method get the values as notation type class
            foreach (NotationType notation in Enum.GetValues(typeof(NotationType)))
            {
                //then add the values from the  GetNotationDisplayName method the notation object as text and value
                NumberSettingComboBox.Items.Add(new { Text = GetNotationDisplayName(notation), Value = notation });
            }
            //use properties of combobox to display as text and use value to display properly for other methods 
            NumberSettingComboBox.DisplayMember = "Text";
            NumberSettingComboBox.ValueMember = "Value";
        }

        //default values
        //enum is user-defined type in C#
        public enum NotationType
        {
            Spoken,
            Scientific,
            Engineering
        }

        //translation
        public string GetNotationDisplayName(NotationType notation)
        {
            currentLanguage = ConfigurationManager.AppSettings["language"];

            switch (notation)
            {
                case NotationType.Spoken:
                    switch (currentLanguage)
                    {
                        case "fr-CA":
                            return "Notation parlée";
                        case "es":
                            return "Notación hablada";
                        default:
                            return "Spoken Notation";
                    }

                case NotationType.Scientific:
                    switch (currentLanguage)
                    {
                        case "fr-CA":
                            return "Notation scientifique";
                        case "es":
                            return "Notación científica";
                        default:
                            return "Scientific Notation";
                    }

                case NotationType.Engineering:
                    switch (currentLanguage)
                    {
                        case "fr-CA":
                            return "Notation ingénierie";
                        case "es":
                            return "Notación de ingeniería";
                        default:
                            return "Engineering Notation";
                    }

                default:
                    return notation.ToString();
            }
        }
    }
}
