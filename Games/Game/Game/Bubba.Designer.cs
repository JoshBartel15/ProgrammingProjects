namespace Game
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
            Egg1 = new PictureBox();
            chicken = new PictureBox();
            Egg2 = new PictureBox();
            Egg3 = new PictureBox();
            Title = new Label();
            AddPoints = new Label();
            MinusPoints = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Izzle = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Egg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Egg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Egg3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Izzle).BeginInit();
            SuspendLayout();
            // 
            // Egg1
            // 
            Egg1.Image = (Image)resources.GetObject("Egg1.Image");
            Egg1.Location = new Point(124, 62);
            Egg1.Name = "Egg1";
            Egg1.Size = new Size(137, 168);
            Egg1.SizeMode = PictureBoxSizeMode.StretchImage;
            Egg1.TabIndex = 0;
            Egg1.TabStop = false;
            Egg1.Click += Egg1_Click;
            // 
            // chicken
            // 
            chicken.ErrorImage = null;
            chicken.Image = (Image)resources.GetObject("chicken.Image");
            chicken.Location = new Point(585, 695);
            chicken.Name = "chicken";
            chicken.Size = new Size(352, 274);
            chicken.SizeMode = PictureBoxSizeMode.StretchImage;
            chicken.TabIndex = 1;
            chicken.TabStop = false;
            chicken.Click += chicken_Click;
            // 
            // Egg2
            // 
            Egg2.Image = (Image)resources.GetObject("Egg2.Image");
            Egg2.Location = new Point(456, 235);
            Egg2.Name = "Egg2";
            Egg2.Size = new Size(148, 184);
            Egg2.SizeMode = PictureBoxSizeMode.StretchImage;
            Egg2.TabIndex = 2;
            Egg2.TabStop = false;
            Egg2.Click += Egg2_Click;
            // 
            // Egg3
            // 
            Egg3.Image = (Image)resources.GetObject("Egg3.Image");
            Egg3.Location = new Point(773, 62);
            Egg3.Name = "Egg3";
            Egg3.Size = new Size(150, 181);
            Egg3.SizeMode = PictureBoxSizeMode.StretchImage;
            Egg3.TabIndex = 3;
            Egg3.TabStop = false;
            Egg3.Click += Egg3_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Title.Location = new Point(1002, 9);
            Title.Name = "Title";
            Title.Size = new Size(621, 79);
            Title.TabIndex = 4;
            Title.Text = "Kitty Can Catch!";
            Title.Click += label1_Click;
            // 
            // AddPoints
            // 
            AddPoints.AutoSize = true;
            AddPoints.Font = new Font("Stencil", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AddPoints.ForeColor = Color.FromArgb(0, 192, 0);
            AddPoints.Location = new Point(1118, 88);
            AddPoints.Name = "AddPoints";
            AddPoints.Size = new Size(475, 63);
            AddPoints.TabIndex = 5;
            AddPoints.Text = "Cans Caught = 0";
            AddPoints.Click += label2_Click;
            // 
            // MinusPoints
            // 
            MinusPoints.AutoSize = true;
            MinusPoints.Font = new Font("Stencil", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MinusPoints.ForeColor = Color.Red;
            MinusPoints.Location = new Point(1296, 151);
            MinusPoints.Name = "MinusPoints";
            MinusPoints.Size = new Size(295, 63);
            MinusPoints.TabIndex = 6;
            MinusPoints.Text = "Lives = 10";
            MinusPoints.Click += MinusPoints_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Izzle
            // 
            Izzle.Image = (Image)resources.GetObject("Izzle.Image");
            Izzle.Location = new Point(998, 213);
            Izzle.Name = "Izzle";
            Izzle.Size = new Size(205, 206);
            Izzle.SizeMode = PictureBoxSizeMode.StretchImage;
            Izzle.TabIndex = 8;
            Izzle.TabStop = false;
            Izzle.Click += Izzle_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(1264, 213);
            label1.Name = "label1";
            label1.Size = new Size(359, 59);
            label1.TabIndex = 9;
            label1.Text = "Izzles = -3 Lives";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1635, 972);
            Controls.Add(label1);
            Controls.Add(Izzle);
            Controls.Add(MinusPoints);
            Controls.Add(AddPoints);
            Controls.Add(Title);
            Controls.Add(Egg3);
            Controls.Add(Egg2);
            Controls.Add(chicken);
            Controls.Add(Egg1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Egg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)Egg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Egg3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Izzle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Egg1;
        private PictureBox chicken;
        private PictureBox Egg2;
        private PictureBox Egg3;
        private Label Title;
        private Label AddPoints;
        private Label MinusPoints;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Izzle;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
    }
}