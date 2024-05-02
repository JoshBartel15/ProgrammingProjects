namespace FlapGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int pipespeed = 8;
        int gravity = 15;
        int pts = 0;
        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            UpPipe.Left -= pipespeed;
            DownPipe.Left -= pipespeed;

            if (UpPipe.Left < 0)
            {
                UpPipe.Left = 900;
                pts++;
            }
            if (DownPipe.Left < -20)
            {
                DownPipe.Left = 950;
                pts++;
            }
            Score.Text = "Score = " + pts.ToString();

            if (Bird.Bounds.IntersectsWith(DownPipe.Bounds) || Bird.Bounds.IntersectsWith(UpPipe.Bounds) || Bird.Bounds.IntersectsWith(Ground.Bounds))
            {
                endGame();
            }

            if (pts % 10 == 0)
            {
                pipespeed++;
            }
            if (Bird.Top < -25)
            {
                endGame();
            }

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            Score.Text += " Game Over!";

        }

        private void Bird_Click(object sender, EventArgs e)
        {

        }

        private void UpPipe_Click(object sender, EventArgs e)
        {

        }

        private void DownPipe_Click(object sender, EventArgs e)
        {

        }

        private void Ground_Click(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }
    }
}