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
    public partial class RocketClickerGameForm : Form
    {
        private int ticks;

        private int clicks;

        
        public RocketClickerGameForm()
        {
            InitializeComponent();
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
            //the timer stops reset  number of seconds and clicks back to 0
            timer.Stop();
            clicks = 0;
            ticks = 0;

            //timer label back to initial state
            timeLabel.Text = "Time: 0";
            clicksLabel.Text = "Clicks: 0";

        }
    }
}
