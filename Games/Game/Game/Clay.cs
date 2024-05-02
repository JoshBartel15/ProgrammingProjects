using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Clay : Form
    {
        public Clay()
        {
            InitializeComponent();
        }

        private void Clayster_Click(object sender, EventArgs e)
        {

        }

        private void Wii_Click(object sender, EventArgs e)
        {

        }

        private void Xbox_Click(object sender, EventArgs e)
        {

        }
        private void Switch_Click(object sender, EventArgs e)
        {

        }
        private void Lyss_Click(object sender, EventArgs e)
        {

        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer("pacman_dies_y.wav");



        private void Clay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left & mis > 0)
            {
                Clayster.Left += -30;
            }
            if (e.KeyCode == Keys.Right & mis > 0)
            {
                Clayster.Left += 30;
            }
        }

        int mis = 10;
        int pts = 0;
        Random r = new Random();
        void falldown(PictureBox egg, int speed)
        {

            if (egg.Top <= this.Height)
            {
                egg.Top += speed;
            }
            else if (egg.Top > this.Height)
            {
                egg.Location = new Point((r.Next(100, 1000)), 0);
                mis--;
                MinusPoints.Text = "Lives = " + mis.ToString();
            }
            //code for egg catching
            if (egg.Bounds.IntersectsWith(Clayster.Bounds))
            {
                egg.Location = new Point((r.Next(100, 1000)), 0);
                pts++;
                AddPoints.Text = "Points = " + pts.ToString();
            }
        }

        void ifalldown(PictureBox Alyssa, int speed)
        {
            if (Alyssa.Top <= this.Height)
            {
                Alyssa.Top += speed;
            }
            else if (Alyssa.Top > this.Height)
            {
                Lyss.Location = new Point((r.Next(100, 1000)), 0);
            }

            if (Alyssa.Bounds.IntersectsWith(Clayster.Bounds))
            {
                Alyssa.Location = new Point((r.Next(100, 1000)), 0);
                mis -= 3;
                MinusPoints.Text = "Lives = " + mis.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (mis > 0)
            {
                ifalldown(Lyss, r.Next(1, 10));
            }
            else if (mis <= 0)
            {
                timer2.Stop();
                Lyss.Visible = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (mis > 0)
            {
                falldown(Xbox, r.Next(1, 10));
                falldown(Wii, r.Next(1, 10));
                falldown(Switch, r.Next(1, 10));
            }
            else if (mis <= 0)
            {
                timer1.Stop();
                Xbox.Visible = false;
                Wii.Visible = false;
                Switch.Visible = false;
                label1.Visible = false;
                Clayster.Location = new Point(500, 350);
                Clayster.Size = new Size(500, 500);
                AddPoints.Location = new Point(565, 250);
                MinusPoints.Location = new Point(565, 150);
                MinusPoints.Text = "GAME OVER!";
                player.Play();
            }
        }

        private void VG_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void AddPoints_Click(object sender, EventArgs e)
        {

        }

        private void MinusPoints_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
