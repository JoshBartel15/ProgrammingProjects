namespace Game
{
    partial class CYOGame
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
            Drop2 = new PictureBox();
            Drop1 = new PictureBox();
            Drop3 = new PictureBox();
            Evil = new PictureBox();
            AddPoints = new Label();
            MinusPoints = new Label();
            Title = new Label();
            Catchie = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Drop2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Drop1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Drop3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Evil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Catchie).BeginInit();
            SuspendLayout();
            // 
            // Drop2
            // 
            Drop2.Location = new Point(98, 91);
            Drop2.Name = "Drop2";
            Drop2.Size = new Size(166, 132);
            Drop2.SizeMode = PictureBoxSizeMode.StretchImage;
            Drop2.TabIndex = 9;
            Drop2.TabStop = false;
            Drop2.Click += Drop2_Click;
            // 
            // Drop1
            // 
            Drop1.Location = new Point(376, 184);
            Drop1.Name = "Drop1";
            Drop1.Size = new Size(166, 132);
            Drop1.SizeMode = PictureBoxSizeMode.StretchImage;
            Drop1.TabIndex = 10;
            Drop1.TabStop = false;
            Drop1.Click += Drop1_Click;
            // 
            // Drop3
            // 
            Drop3.Location = new Point(674, 74);
            Drop3.Name = "Drop3";
            Drop3.Size = new Size(166, 132);
            Drop3.SizeMode = PictureBoxSizeMode.StretchImage;
            Drop3.TabIndex = 11;
            Drop3.TabStop = false;
            Drop3.Click += Drop3_Click;
            // 
            // Evil
            // 
            Evil.Location = new Point(944, 194);
            Evil.Name = "Evil";
            Evil.Size = new Size(166, 132);
            Evil.SizeMode = PictureBoxSizeMode.StretchImage;
            Evil.TabIndex = 12;
            Evil.TabStop = false;
            Evil.Click += Evil_Click;
            // 
            // AddPoints
            // 
            AddPoints.AutoSize = true;
            AddPoints.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            AddPoints.ForeColor = Color.Lime;
            AddPoints.Location = new Point(1258, 93);
            AddPoints.Name = "AddPoints";
            AddPoints.Size = new Size(364, 79);
            AddPoints.TabIndex = 14;
            AddPoints.Text = "Points = 0";
            AddPoints.Click += AddPoints_Click;
            // 
            // MinusPoints
            // 
            MinusPoints.AutoSize = true;
            MinusPoints.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            MinusPoints.ForeColor = Color.Red;
            MinusPoints.Location = new Point(1379, 172);
            MinusPoints.Name = "MinusPoints";
            MinusPoints.Size = new Size(277, 66);
            MinusPoints.TabIndex = 15;
            MinusPoints.Text = "Lives = 10";
            MinusPoints.Click += MinusPoints_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.FromArgb(0, 0, 192);
            Title.Location = new Point(1193, 9);
            Title.Name = "Title";
            Title.Size = new Size(463, 84);
            Title.TabIndex = 17;
            Title.Text = "Catch Game";
            Title.Click += Title_Click;
            // 
            // Catchie
            // 
            Catchie.Location = new Point(636, 737);
            Catchie.Name = "Catchie";
            Catchie.Size = new Size(244, 212);
            Catchie.SizeMode = PictureBoxSizeMode.StretchImage;
            Catchie.TabIndex = 18;
            Catchie.TabStop = false;
            Catchie.Click += Catchie_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick;
            // 
            // CYOGame
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 961);
            Controls.Add(Catchie);
            Controls.Add(Title);
            Controls.Add(MinusPoints);
            Controls.Add(AddPoints);
            Controls.Add(Evil);
            Controls.Add(Drop3);
            Controls.Add(Drop1);
            Controls.Add(Drop2);
            Name = "CYOGame";
            Text = "CYOGame";
            KeyDown += CYOGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Drop2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Drop1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Drop3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Evil).EndInit();
            ((System.ComponentModel.ISupportInitialize)Catchie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Drop2;
        private PictureBox Drop1;
        private PictureBox Drop3;
        private PictureBox Evil;
        private Label AddPoints;
        private Label MinusPoints;
        private Label Title;
        private PictureBox Catchie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}