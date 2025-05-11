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
            this.rocketButton1.Location = new System.Drawing.Point(460, 175);
            this.rocketButton1.Name = "rocketButton1";
            this.rocketButton1.Size = new System.Drawing.Size(192, 421);
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
            this.timeLabel.Location = new System.Drawing.Point(21, 9);
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
            this.clicksLabel.Location = new System.Drawing.Point(21, 51);
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
            this.restartButton.Location = new System.Drawing.Point(1010, 12);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(58, 61);
            this.restartButton.TabIndex = 3;
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // RocketClickerGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RocketClickerGame.Properties.Resources.centaurbridgeRender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1080, 608);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.clicksLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.rocketButton1);
            this.DoubleBuffered = true;
            this.Name = "RocketClickerGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocket Factory Tycoon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rocketButton1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label clicksLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button restartButton;
    }
}

