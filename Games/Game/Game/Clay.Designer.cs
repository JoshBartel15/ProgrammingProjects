namespace Game
{
    partial class Clay
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clay));
            Xbox = new PictureBox();
            Switch = new PictureBox();
            Clayster = new PictureBox();
            Wii = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Lyss = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            Title = new Label();
            AddPoints = new Label();
            MinusPoints = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Xbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Switch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Clayster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Wii).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Lyss).BeginInit();
            SuspendLayout();
            // 
            // Xbox
            // 
            Xbox.BackColor = Color.Red;
            Xbox.Image = (Image)resources.GetObject("Xbox.Image");
            Xbox.Location = new Point(815, 144);
            Xbox.Name = "Xbox";
            Xbox.Size = new Size(178, 142);
            Xbox.SizeMode = PictureBoxSizeMode.StretchImage;
            Xbox.TabIndex = 0;
            Xbox.TabStop = false;
            Xbox.Click += Xbox_Click;
            // 
            // Switch
            // 
            Switch.Image = (Image)resources.GetObject("Switch.Image");
            Switch.Location = new Point(93, 125);
            Switch.Name = "Switch";
            Switch.Size = new Size(231, 119);
            Switch.SizeMode = PictureBoxSizeMode.StretchImage;
            Switch.TabIndex = 2;
            Switch.TabStop = false;
            Switch.Click += Switch_Click;
            // 
            // Clayster
            // 
            Clayster.Image = (Image)resources.GetObject("Clayster.Image");
            Clayster.Location = new Point(617, 753);
            Clayster.Name = "Clayster";
            Clayster.Size = new Size(297, 244);
            Clayster.SizeMode = PictureBoxSizeMode.StretchImage;
            Clayster.TabIndex = 3;
            Clayster.TabStop = false;
            Clayster.Click += Clayster_Click;
            // 
            // Wii
            // 
            Wii.Image = (Image)resources.GetObject("Wii.Image");
            Wii.Location = new Point(486, 167);
            Wii.Name = "Wii";
            Wii.Size = new Size(167, 193);
            Wii.SizeMode = PictureBoxSizeMode.StretchImage;
            Wii.TabIndex = 5;
            Wii.TabStop = false;
            Wii.Click += Wii_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick_1;
            // 
            // Lyss
            // 
            Lyss.Image = (Image)resources.GetObject("Lyss.Image");
            Lyss.Location = new Point(1091, 221);
            Lyss.Name = "Lyss";
            Lyss.Size = new Size(200, 212);
            Lyss.SizeMode = PictureBoxSizeMode.StretchImage;
            Lyss.TabIndex = 8;
            Lyss.TabStop = false;
            Lyss.Click += Lyss_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Title.ForeColor = Color.Red;
            Title.Location = new Point(1172, 9);
            Title.Name = "Title";
            Title.Size = new Size(643, 79);
            Title.TabIndex = 9;
            Title.Text = "Video Game Catch";
            Title.Click += Title_Click;
            // 
            // AddPoints
            // 
            AddPoints.AutoSize = true;
            AddPoints.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AddPoints.ForeColor = Color.Firebrick;
            AddPoints.Location = new Point(1452, 101);
            AddPoints.Name = "AddPoints";
            AddPoints.Size = new Size(300, 66);
            AddPoints.TabIndex = 10;
            AddPoints.Text = "Points = 0";
            AddPoints.Click += AddPoints_Click;
            // 
            // MinusPoints
            // 
            MinusPoints.AutoSize = true;
            MinusPoints.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MinusPoints.ForeColor = Color.ForestGreen;
            MinusPoints.Location = new Point(1538, 167);
            MinusPoints.Name = "MinusPoints";
            MinusPoints.Size = new Size(277, 66);
            MinusPoints.TabIndex = 11;
            MinusPoints.Text = "Lives = 10";
            MinusPoints.Click += MinusPoints_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(1452, 233);
            label1.Name = "label1";
            label1.Size = new Size(358, 50);
            label1.TabIndex = 12;
            label1.Text = "Mommy = -3 Lives";
            label1.Click += label1_Click;
            // 
            // Clay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1824, 999);
            Controls.Add(label1);
            Controls.Add(MinusPoints);
            Controls.Add(AddPoints);
            Controls.Add(Title);
            Controls.Add(Lyss);
            Controls.Add(Wii);
            Controls.Add(Clayster);
            Controls.Add(Switch);
            Controls.Add(Xbox);
            Name = "Clay";
            Text = "=-";
            KeyDown += Clay_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Xbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Switch).EndInit();
            ((System.ComponentModel.ISupportInitialize)Clayster).EndInit();
            ((System.ComponentModel.ISupportInitialize)Wii).EndInit();
            ((System.ComponentModel.ISupportInitialize)Lyss).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Xbox;
        private PictureBox Switch;
        private PictureBox Clayster;
        private PictureBox Wii;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Lyss;
        private System.Windows.Forms.Timer timer2;
        private Label Title;
        private Label AddPoints;
        private Label MinusPoints;
        private Label label1;
    }
}