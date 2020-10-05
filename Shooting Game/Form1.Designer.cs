namespace Shooting_Game
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShootAHeadSound = new System.Windows.Forms.Button();
            this.ShootAwaySound = new System.Windows.Forms.Button();
            this.LoadSound = new System.Windows.Forms.Button();
            this.SpinSound = new System.Windows.Forms.Button();
            this.RestartTheGame = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Shooting_Game.Resource1.image2;
            this.pictureBox1.Location = new System.Drawing.Point(594, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShootAHeadSound
            // 
            this.ShootAHeadSound.Location = new System.Drawing.Point(66, 31);
            this.ShootAHeadSound.Name = "ShootAHeadSound";
            this.ShootAHeadSound.Size = new System.Drawing.Size(154, 74);
            this.ShootAHeadSound.TabIndex = 1;
            this.ShootAHeadSound.Text = "ShootAHead";
            this.ShootAHeadSound.UseVisualStyleBackColor = true;
            this.ShootAHeadSound.Click += new System.EventHandler(this.ShootAHeadSound_Click);
            // 
            // ShootAwaySound
            // 
            this.ShootAwaySound.Location = new System.Drawing.Point(66, 125);
            this.ShootAwaySound.Name = "ShootAwaySound";
            this.ShootAwaySound.Size = new System.Drawing.Size(154, 74);
            this.ShootAwaySound.TabIndex = 2;
            this.ShootAwaySound.Text = "ShootAway";
            this.ShootAwaySound.UseVisualStyleBackColor = true;
            this.ShootAwaySound.Click += new System.EventHandler(this.ShootAwaySound_Click);
            // 
            // LoadSound
            // 
            this.LoadSound.Location = new System.Drawing.Point(472, 337);
            this.LoadSound.Name = "LoadSound";
            this.LoadSound.Size = new System.Drawing.Size(154, 74);
            this.LoadSound.TabIndex = 3;
            this.LoadSound.Text = "Load";
            this.LoadSound.UseVisualStyleBackColor = true;
            this.LoadSound.Click += new System.EventHandler(this.LoadSound_Click);
            // 
            // SpinSound
            // 
            this.SpinSound.Location = new System.Drawing.Point(226, 337);
            this.SpinSound.Name = "SpinSound";
            this.SpinSound.Size = new System.Drawing.Size(154, 74);
            this.SpinSound.TabIndex = 4;
            this.SpinSound.Text = "Spin";
            this.SpinSound.UseVisualStyleBackColor = true;
            this.SpinSound.Click += new System.EventHandler(this.SpinSound_Click);
            // 
            // RestartTheGame
            // 
            this.RestartTheGame.Location = new System.Drawing.Point(35, 346);
            this.RestartTheGame.Name = "RestartTheGame";
            this.RestartTheGame.Size = new System.Drawing.Size(154, 56);
            this.RestartTheGame.TabIndex = 5;
            this.RestartTheGame.Text = "RestartTheGame";
            this.RestartTheGame.UseVisualStyleBackColor = true;
            this.RestartTheGame.Click += new System.EventHandler(this.RestartTheGame_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Score";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(413, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shooting_Game.Resource1.BGimage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RestartTheGame);
            this.Controls.Add(this.SpinSound);
            this.Controls.Add(this.LoadSound);
            this.Controls.Add(this.ShootAwaySound);
            this.Controls.Add(this.ShootAHeadSound);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ShootAHeadSound;
        private System.Windows.Forms.Button ShootAwaySound;
        private System.Windows.Forms.Button LoadSound;
        private System.Windows.Forms.Button SpinSound;
        private System.Windows.Forms.Button RestartTheGame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

