using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Timer
{
    public partial class Form1 : Form
    {
        TimeSpan timeLeft = new TimeSpan(1,0,0);
        TimeSpan timeToSet = new TimeSpan(1,0,0);
        TimeSpan singleSecond = new TimeSpan(0, 0, 1);
        SoundPlayer player = new SoundPlayer(@"C:\Users\sanjay\Music\SoundEffects_Misc\beep.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void secondsTimer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(singleSecond);
            lblTime.Text = timeLeft.ToString();
            if (timeLeft.Seconds == 0 && timeLeft.Minutes == 0 && timeLeft.Hours == 0)
            {
                pause();
                player.Play();
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            timeToSet = new TimeSpan(Int32.Parse(txtHour.Text), Int32.Parse(txtMinute.Text), Int32.Parse(txtSecond.Text));
            reset();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void reset()
        {
            this.timeLeft = new TimeSpan(timeToSet.Hours, timeToSet.Minutes, timeToSet.Seconds);
            lblTime.Text = timeLeft.ToString();
        }
        private void pause()
        {
            secondsTimer.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnReset.Enabled = true;
            gbSet.Visible = true;
        }
        private void start()
        {
            secondsTimer.Enabled = true;
            btnPause.Enabled = true;
            btnStart.Enabled = false;
            btnReset.Enabled = false;
            gbSet.Visible = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = timeLeft.ToString();
        }
    }
}
