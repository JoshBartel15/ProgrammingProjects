namespace Game
{
    partial class StartMenu
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
            Start = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Start.ForeColor = Color.Red;
            Start.Location = new Point(561, 337);
            Start.Name = "Start";
            Start.Size = new Size(582, 193);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 55.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(154, 151);
            label1.Name = "label1";
            label1.Size = new Size(1366, 183);
            label1.TabIndex = 2;
            label1.Text = "The Catch Game!";
            label1.Click += label1_Click;
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1686, 939);
            Controls.Add(label1);
            Controls.Add(Start);
            Name = "StartMenu";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Start;
        private Label label1;
    }
}