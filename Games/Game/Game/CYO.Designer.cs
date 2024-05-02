namespace Game
{
    partial class CYO
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
            Catcher = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Catchie = new PictureBox();
            Drop1 = new PictureBox();
            Drop2 = new PictureBox();
            Drop3 = new PictureBox();
            Meanie = new PictureBox();
            updrop1 = new Button();
            updrop2 = new Button();
            updrop3 = new Button();
            upmean = new Button();
            upcatch = new Button();
            Start = new Button();
            ((System.ComponentModel.ISupportInitialize)Catchie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Drop1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Drop2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Drop3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Meanie).BeginInit();
            SuspendLayout();
            // 
            // Catcher
            // 
            Catcher.AutoSize = true;
            Catcher.Font = new Font("Showcard Gothic", 28.125F, FontStyle.Bold, GraphicsUnit.Point);
            Catcher.ForeColor = Color.FromArgb(0, 192, 0);
            Catcher.Location = new Point(29, 64);
            Catcher.Name = "Catcher";
            Catcher.Size = new Size(381, 93);
            Catcher.TabIndex = 0;
            Catcher.Text = "Catcher";
            Catcher.Click += Catcher_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(458, 128);
            label1.Name = "label1";
            label1.Size = new Size(264, 93);
            label1.TabIndex = 1;
            label1.Text = "Item 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 28.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 192, 0);
            label2.Location = new Point(454, 404);
            label2.Name = "label2";
            label2.Size = new Size(268, 93);
            label2.TabIndex = 2;
            label2.Text = "Item 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 28.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 192, 0);
            label3.Location = new Point(452, 691);
            label3.Name = "label3";
            label3.Size = new Size(270, 93);
            label3.TabIndex = 3;
            label3.Text = "Item 3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 28.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1159, 64);
            label4.Name = "label4";
            label4.Size = new Size(392, 93);
            label4.TabIndex = 4;
            label4.Text = "Evil Item";
            label4.Click += label4_Click;
            // 
            // Catchie
            // 
            Catchie.Location = new Point(94, 203);
            Catchie.Name = "Catchie";
            Catchie.Size = new Size(244, 212);
            Catchie.SizeMode = PictureBoxSizeMode.StretchImage;
            Catchie.TabIndex = 6;
            Catchie.TabStop = false;
            Catchie.Click += Catchie_Click;
            // 
            // Drop1
            // 
            Drop1.Location = new Point(867, 387);
            Drop1.Name = "Drop1";
            Drop1.Size = new Size(166, 132);
            Drop1.SizeMode = PictureBoxSizeMode.StretchImage;
            Drop1.TabIndex = 7;
            Drop1.TabStop = false;
            Drop1.Click += Drop1_Click;
            // 
            // Drop2
            // 
            Drop2.Location = new Point(867, 128);
            Drop2.Name = "Drop2";
            Drop2.Size = new Size(166, 132);
            Drop2.SizeMode = PictureBoxSizeMode.StretchImage;
            Drop2.TabIndex = 8;
            Drop2.TabStop = false;
            Drop2.Click += Drop2_Click;
            // 
            // Drop3
            // 
            Drop3.Location = new Point(867, 673);
            Drop3.Name = "Drop3";
            Drop3.Size = new Size(166, 132);
            Drop3.SizeMode = PictureBoxSizeMode.StretchImage;
            Drop3.TabIndex = 9;
            Drop3.TabStop = false;
            Drop3.Click += Drop3_Click;
            // 
            // Meanie
            // 
            Meanie.Location = new Point(1270, 177);
            Meanie.Name = "Meanie";
            Meanie.Size = new Size(166, 132);
            Meanie.SizeMode = PictureBoxSizeMode.StretchImage;
            Meanie.TabIndex = 10;
            Meanie.TabStop = false;
            // 
            // updrop1
            // 
            updrop1.Location = new Point(851, 288);
            updrop1.Name = "updrop1";
            updrop1.Size = new Size(199, 46);
            updrop1.TabIndex = 11;
            updrop1.Text = "Upload image";
            updrop1.UseVisualStyleBackColor = true;
            updrop1.Click += updrop1_Click;
            // 
            // updrop2
            // 
            updrop2.Location = new Point(851, 572);
            updrop2.Name = "updrop2";
            updrop2.Size = new Size(199, 46);
            updrop2.TabIndex = 16;
            updrop2.Text = "Upload image";
            updrop2.UseVisualStyleBackColor = true;
            updrop2.Click += updrop2_Click;
            // 
            // updrop3
            // 
            updrop3.Location = new Point(851, 866);
            updrop3.Name = "updrop3";
            updrop3.Size = new Size(199, 46);
            updrop3.TabIndex = 17;
            updrop3.Text = "Upload image";
            updrop3.UseVisualStyleBackColor = true;
            updrop3.Click += updrop3_Click;
            // 
            // upmean
            // 
            upmean.Location = new Point(1254, 335);
            upmean.Name = "upmean";
            upmean.Size = new Size(199, 46);
            upmean.TabIndex = 18;
            upmean.Text = "Upload image";
            upmean.UseVisualStyleBackColor = true;
            upmean.Click += upmean_Click;
            // 
            // upcatch
            // 
            upcatch.ForeColor = SystemColors.ControlText;
            upcatch.Location = new Point(112, 473);
            upcatch.Name = "upcatch";
            upcatch.Size = new Size(199, 46);
            upcatch.TabIndex = 19;
            upcatch.Text = "Upload image";
            upcatch.UseVisualStyleBackColor = true;
            upcatch.Click += upcatch_Click;
            // 
            // Start
            // 
            Start.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            Start.ForeColor = Color.Blue;
            Start.Location = new Point(1204, 755);
            Start.Name = "Start";
            Start.Size = new Size(347, 140);
            Start.TabIndex = 20;
            Start.Text = "Start Game";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // CYO
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1606, 948);
            Controls.Add(Start);
            Controls.Add(upcatch);
            Controls.Add(upmean);
            Controls.Add(updrop3);
            Controls.Add(updrop2);
            Controls.Add(updrop1);
            Controls.Add(Meanie);
            Controls.Add(Drop3);
            Controls.Add(Drop2);
            Controls.Add(Drop1);
            Controls.Add(Catchie);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Catcher);
            Name = "CYO";
            Text = "CYO";
            Load += CYO_Load;
            ((System.ComponentModel.ISupportInitialize)Catchie).EndInit();
            ((System.ComponentModel.ISupportInitialize)Drop1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Drop2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Drop3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Meanie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Catcher;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox Catchie;
        private PictureBox Drop1;
        private PictureBox Drop2;
        private PictureBox Drop3;
        private PictureBox Meanie;
        private Button updrop1;
        private Button updrop2;
        private Button updrop3;
        private Button upmean;
        private Button upcatch;
        private Button Start;
    }
}