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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.subWelcomeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.welcomeLabel.Name = "welcomeLabel";
            // 
            // subWelcomeLabel
            // 
            resources.ApplyResources(this.subWelcomeLabel, "subWelcomeLabel");
            this.subWelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.subWelcomeLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.subWelcomeLabel.Name = "subWelcomeLabel";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.subWelcomeLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label subWelcomeLabel;
        private System.Windows.Forms.Button startButton;
    }
}