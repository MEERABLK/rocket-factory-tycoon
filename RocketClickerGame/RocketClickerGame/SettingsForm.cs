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
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void NumberSettingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (NumberSettingComboBox.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    
                    break;
                case 2:
                    
                    break;


            }
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
    }
}
