using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_Game
{
    public partial class Form1 : Form
    {
        readonly LogicClass1 Logic = new LogicClass1();

        public object ShootAHead { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }
        //Load Button coding
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSound.Enabled = true;
            SpinSound.Enabled = false;
            ShootAHeadSound.Enabled = false;
            ShootAwaySound.Enabled = false;
        }

        //ShootAHeadButton Coding Started

        private void ShootAHeadSound_Click(object sender, EventArgs e)
        {
            Logic.ShootAHead();
            RestartTheGame.Enabled = true;
            textBox2.Text = Logic.Score + "";
            SoundPlayer player = new SoundPlayer(Resource1.ShootAHeadSound);
            player.Play();
            if(Logic.ShootAHeadGoals ==1)
            {
                ShootAHeadSound.Enabled = false;
            }
        }
        //ShootAway Coding
        private void ShootAwaySound_Click(object sender, EventArgs e)
        {
            if (Logic.ShootAwayGoals == 3)
            {
                ShootAwaySound.Enabled = false;
                RestartTheGame.Enabled = true;
            }
            Logic.ShootAway();
            SoundPlayer player = new SoundPlayer(Resource1.ShootAwaySound);
            player.Play();
        }
        //Coding PlayAgain Button
        private void RestartTheGame_Click(object sender, EventArgs e)
        {
            Logic.Load();
            LoadSound.Enabled = true;
            SpinSound.Enabled = false;
            ShootAHeadSound.Enabled = false;
            ShootAwaySound.Enabled = false;
        }
        //Coding for Spin Button
        private void SpinSound_Click(object sender, EventArgs e)
        {
            Logic.Spin();
            LoadSound.Enabled = false;
            SpinSound.Enabled = false;
            ShootAHeadSound.Enabled = true;
            ShootAwaySound.Enabled = true;
            RestartTheGame.Enabled = false;
            SoundPlayer player = new SoundPlayer(Resource1.SpinSound);
            player.Play();

        }
        //Coding For Load
        private void LoadSound_Click(object sender, EventArgs e)
        {
            Logic.Load();
            LoadSound.Enabled = false;
            SpinSound.Enabled = true;
            ShootAHeadSound.Enabled = false;
            ShootAwaySound.Enabled = false;
            RestartTheGame.Enabled = false;
            SoundPlayer player = new SoundPlayer(Resource1.LoadSound);
            player.Play();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
