namespace FlapGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DownPipe = new PictureBox();
            Ground = new PictureBox();
            Score = new Label();
            UpPipe = new PictureBox();
            Bird = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)DownPipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpPipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bird).BeginInit();
            SuspendLayout();
            // 
            // DownPipe
            // 
            DownPipe.Image = (Image)resources.GetObject("DownPipe.Image");
            DownPipe.Location = new Point(609, 628);
            DownPipe.Name = "DownPipe";
            DownPipe.Size = new Size(164, 413);
            DownPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            DownPipe.TabIndex = 0;
            DownPipe.TabStop = false;
            DownPipe.Click += DownPipe_Click;
            // 
            // Ground
            // 
            Ground.Image = (Image)resources.GetObject("Ground.Image");
            Ground.Location = new Point(-6, 1047);
            Ground.Name = "Ground";
            Ground.Size = new Size(1105, 264);
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
            Ground.TabIndex = 2;
            Ground.TabStop = false;
            Ground.Click += Ground_Click;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Score.ForeColor = SystemColors.ButtonHighlight;
            Score.Location = new Point(12, 17);
            Score.Name = "Score";
            Score.Size = new Size(333, 79);
            Score.TabIndex = 4;
            Score.Text = "Score = 0";
            Score.Click += Score_Click;
            // 
            // UpPipe
            // 
            UpPipe.Image = (Image)resources.GetObject("UpPipe.Image");
            UpPipe.Location = new Point(818, 3);
            UpPipe.Name = "UpPipe";
            UpPipe.Size = new Size(163, 390);
            UpPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            UpPipe.TabIndex = 3;
            UpPipe.TabStop = false;
            UpPipe.Click += UpPipe_Click;
            // 
            // Bird
            // 
            Bird.Image = (Image)resources.GetObject("Bird.Image");
            Bird.Location = new Point(65, 471);
            Bird.Name = "Bird";
            Bird.Size = new Size(132, 119);
            Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            Bird.TabIndex = 1;
            Bird.TabStop = false;
            Bird.Click += Bird_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(1094, 1148);
            Controls.Add(Bird);
            Controls.Add(Score);
            Controls.Add(UpPipe);
            Controls.Add(Ground);
            Controls.Add(DownPipe);
            Name = "Form1";
            Text = "Form1";
            KeyDown += gameKeyIsDown;
            KeyUp += gameKeyIsUp;
            ((System.ComponentModel.ISupportInitialize)DownPipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpPipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DownPipe;
        private PictureBox Ground;
        private Label Score;
        private PictureBox UpPipe;
        private PictureBox Bird;
        private System.Windows.Forms.Timer gameTimer;
    }
}