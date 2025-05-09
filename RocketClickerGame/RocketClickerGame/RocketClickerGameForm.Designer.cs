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
            this.rocketButton1 = new System.Windows.Forms.Button();
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
            // 
            // RocketClickerGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RocketClickerGame.Properties.Resources.centaurbridgeRender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1080, 608);
            this.Controls.Add(this.rocketButton1);
            this.DoubleBuffered = true;
            this.Name = "RocketClickerGameForm";
            this.Text = "Rocket Factory Tycoon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rocketButton1;
    }
}

