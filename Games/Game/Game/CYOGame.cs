using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class CYOGame : Form
    {
        public CYOGame()
        {
            InitializeComponent();
        }

        private void Catchie_Click(object sender, EventArgs e)
        {

        }

        private void Drop2_Click(object sender, EventArgs e)
        {

        }

        private void Drop1_Click(object sender, EventArgs e)
        {

        }

        private void Drop3_Click(object sender, EventArgs e)
        {

        }

        private void Evil_Click(object sender, EventArgs e)
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

        System.Media.SoundPlayer player = new System.Media.SoundPlayer("pacman_dies_y.wav");
        private void CYOGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left & mis > 0)
            {
                Catchie.Left += -30;
            }
            if (e.KeyCode == Keys.Right & mis > 0)
            {
                Catchie.Left += 30;
            }
        }
        int mis = 10;
        int pts = 0;
        Random r = new Random();
        void falldown(PictureBox cat, int speed)
        {

            if (cat.Top <= this.Height)
            {
                cat.Top += speed;
            }
            else if (cat.Top > this.Height)
            {
                cat.Location = new Point((r.Next(100, 1000)), 0);
                mis--;
                MinusPoints.Text = "Lives = " + mis.ToString();
            }
            //code for egg catching
            if (cat.Bounds.IntersectsWith(Catchie.Bounds))
            {
                cat.Location = new Point((r.Next(100, 1000)), 0);
                pts++;
                AddPoints.Text = "Points = " + pts.ToString();
            }
        }

        void ifalldown(PictureBox Evils, int speed)
        {
            if (Evils.Top <= this.Height)
            {
                Evils.Top += speed;
            }
            else if (Evils.Top > this.Height)
            {
                Evil.Location = new Point((r.Next(100, 1000)), 0);
            }

            if (Evils.Bounds.IntersectsWith(Catchie.Bounds))
            {
                Evils.Location = new Point((r.Next(100, 1000)), 0);
                mis -= 3;
                MinusPoints.Text = "Lives = " + mis.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mis > 0)
            {
                falldown(Drop1, r.Next(1, 10));
                falldown(Drop2, r.Next(1, 10));
                falldown(Drop3, r.Next(1, 10));
            }
            else if (mis <= 0)
            {
                timer1.Stop();
                Drop1.Visible = false;
                Drop2.Visible = false;
                Drop3.Visible = false;
                Catchie.Location = new Point(500, 350);
                Catchie.Size = new Size(500, 500);
                AddPoints.Location = new Point(565, 250);
                MinusPoints.Location = new Point(565, 150);
                MinusPoints.Text = "GAME OVER!";
                player.Play();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (mis > 0)
            {
                ifalldown(Evil, r.Next(1, 10));
            }
            else if (mis <= 0)
            {
                timer2.Stop();
                Evil.Visible = false;
            }
        }
    }
}
