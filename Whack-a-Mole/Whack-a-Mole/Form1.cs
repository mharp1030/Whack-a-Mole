using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Whack_a_Mole
{
    public partial class Form1 : Form
    {
        private List<PictureBox> moles = new List<PictureBox>();
        private int wacked, total, missed, currentMole;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            moles.Add(m1);
            moles.Add(m2);
            moles.Add(m3);
            moles.Add(m4);
            moles.Add(m5);
            moles.Add(m6);
            moles.Add(m7);
            moles.Add(m8);
            moles.Add(m9);
            moles.Add(m10);
        }
        
        private void Form1_Load(object sender, EventArgs e) // start a new game when the form loads
        {
            newGame();
        }

        private void reset() // hides all moles, no matter where they are.
        {
            foreach (PictureBox mole in moles)
                mole.Hide();
        }

        private void newGame() // resets the game to defaults
        {
            wacked = 0;
            missed = 0;
            total = -1;
            lblHit.Text = wacked.ToString();
            lblTotal.Text = total.ToString();
            lblMissed.Text = missed.ToString();
            reset();
            newMole();
        }

        private void newMole() // generates a new mole, hides the previous one
        {
            moles[currentMole].Hide();
            Random r = new Random(Guid.NewGuid().GetHashCode());
            currentMole = r.Next(0, 10);
            moles[currentMole].Show();
            SetTimer();
        }

        private void moleClick(object sender, EventArgs e) // when user taps on a mole
        {
            hit();
            newMole();
        }

        private void hit() // when a mole is hit
        {
            wacked++;
            lblHit.Text = wacked.ToString();
        }

        private void totalMoles() // total moles that appeared
        {
            total++;
            lblTotal.Text = total.ToString();
        }

        private void label2_Click(object sender, EventArgs e) // new game button
        {
            newGame();
        }

        private void lblExit_Click(object sender, EventArgs e) // exit button
        {
            Application.Exit();
        }

        private void SetTimer() // handles how soon a mole should appear or disappear
        {
            if (timer != null) // distroys the previous timer, if one exists
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
            timer = new Timer();
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int time = r.Next(0, 3);
            timer.Interval = (time != 0) ? time * 1000 : 750; // if the random number is 0, make the time .75 seconds
            timer.Tick += timer1_Tick;
            timer.Start();
            totalMoles();
        }

        private void timer1_Tick(object sender, EventArgs e) // when the time is up
        {
            newMole();
            misses();
        }

        private void misses() // amount of moles that are missed
        {
            missed = total - wacked;
            lblMissed.Text = missed.ToString();
        }
    }
}
