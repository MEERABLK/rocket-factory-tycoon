namespace RocketClickerGame
{
    partial class StartForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.subWelcomeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.welcomeLabel.Location = new System.Drawing.Point(76, 31);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(497, 42);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = " Welcome to Rocket Factory Tycoon!";
            // 
            // subWelcomeLabel
            // 
            this.subWelcomeLabel.AutoSize = true;
            this.subWelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.subWelcomeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subWelcomeLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.subWelcomeLabel.Location = new System.Drawing.Point(179, 85);
            this.subWelcomeLabel.Name = "subWelcomeLabel";
            this.subWelcomeLabel.Size = new System.Drawing.Size(263, 29);
            this.subWelcomeLabel.TabIndex = 8;
            this.subWelcomeLabel.Text = "Build, Collect, and Upgrade";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.startButton.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(224, 146);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 49);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "S T A R T";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(637, 226);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.subWelcomeLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To Rocket Factory ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label subWelcomeLabel;
        private System.Windows.Forms.Button startButton;
    }
}