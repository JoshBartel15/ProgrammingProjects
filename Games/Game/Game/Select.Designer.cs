namespace Game
{
    partial class Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select));
            Bubba = new Button();
            Clay = new Button();
            label1 = new Label();
            CYOG = new Button();
            SuspendLayout();
            // 
            // Bubba
            // 
            Bubba.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            Bubba.ForeColor = SystemColors.ButtonFace;
            Bubba.Image = (Image)resources.GetObject("Bubba.Image");
            Bubba.Location = new Point(1006, 202);
            Bubba.Name = "Bubba";
            Bubba.Size = new Size(804, 592);
            Bubba.TabIndex = 1;
            Bubba.Text = "Bubba";
            Bubba.UseVisualStyleBackColor = true;
            Bubba.Click += Bubba_Click;
            // 
            // Clay
            // 
            Clay.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            Clay.ForeColor = Color.Red;
            Clay.Image = (Image)resources.GetObject("Clay.Image");
            Clay.ImageAlign = ContentAlignment.BottomCenter;
            Clay.Location = new Point(207, 202);
            Clay.Name = "Clay";
            Clay.Size = new Size(804, 592);
            Clay.TabIndex = 2;
            Clay.Text = "Clay";
            Clay.UseVisualStyleBackColor = true;
            Clay.Click += Clay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(269, 25);
            label1.Name = "label1";
            label1.Size = new Size(1495, 159);
            label1.TabIndex = 3;
            label1.Text = "Select Your Catcher";
            label1.Click += label1_Click;
            // 
            // CYOG
            // 
            CYOG.BackColor = SystemColors.ActiveCaption;
            CYOG.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            CYOG.Location = new Point(207, 781);
            CYOG.Name = "CYOG";
            CYOG.Size = new Size(1603, 331);
            CYOG.TabIndex = 4;
            CYOG.Text = "Create Your Own";
            CYOG.UseVisualStyleBackColor = false;
            CYOG.Click += CYOG_Click;
            // 
            // Select
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1876, 1124);
            Controls.Add(CYOG);
            Controls.Add(label1);
            Controls.Add(Clay);
            Controls.Add(Bubba);
            Name = "Select";
            Text = "Select";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Bubba;
        private Button Clay;
        private Label label1;
        private Button CYOG;
    }
}