using System.Security.Cryptography;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MinusPoints_Click(object sender, EventArgs e)
        {

        }

        private void Egg1_Click(object sender, EventArgs e)
        {

        }

        private void Egg2_Click(object sender, EventArgs e)
        {

        }

        private void Egg3_Click(object sender, EventArgs e)
        {

        }

        private void chicken_Click(object sender, EventArgs e)
        {

        }
        private void Izzle_Click(object sender, EventArgs e)
        {

        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer("pacman_dies_y.wav");

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left & mis > 0)
            {
                chicken.Left += -30;
            }
            if (e.KeyCode == Keys.Right & mis > 0)
            {
                chicken.Left += 30;
            }
        }

        Random r = new Random();
        int pts = 0;
        int mis = 10;
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
            if (egg.Bounds.IntersectsWith(chicken.Bounds))
            {
                egg.Location = new Point((r.Next(100, 1000)), 0);
                pts++;
                AddPoints.Text = "Cans Caught = " + pts.ToString();
            }
        }

        void ifalldown(PictureBox izzle, int speed)
        {
            if (izzle.Top <= this.Height)
            {
                izzle.Top += speed;
            }
            else if (izzle.Top > this.Height)
            {
                Izzle.Location = new Point((r.Next(100, 1000)), 0);
            }

            if (izzle.Bounds.IntersectsWith(chicken.Bounds))
            {
                izzle.Location = new Point((r.Next(100, 1000)), 0);
                mis -= 3;
                MinusPoints.Text = "Lives = " + mis.ToString();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mis > 0)//
            {
                falldown(Egg1, r.Next(1, 10));
                falldown(Egg2, r.Next(1, 10));
                falldown(Egg3, r.Next(1, 10));
            }
            else if (mis <= 0)
            {
                timer1.Stop();
                Egg1.Visible = false;
                Egg2.Visible = false;
                Egg3.Visible = false;
                label1.Visible = false;
                chicken.Location = new Point(500, 350);
                chicken.Size = new Size(500, 500);
                AddPoints.Location = new Point(500, 250);
                MinusPoints.Location = new Point(565, 150);
                MinusPoints.Text = "GAME OVER!";
                player.Play();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (mis > 0)
            {
                ifalldown(Izzle, r.Next(1, 10));
            }
            else if (mis <= 0)
            {
                timer2.Stop();
                Izzle.Visible = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}