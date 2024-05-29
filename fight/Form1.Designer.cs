namespace fight
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
            pictureBox1 = new PictureBox();
            DogMoves = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            CatMoves = new Panel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            CatHealth = new ProgressBar();
            DogHealth = new ProgressBar();
            Announcement = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DogMoves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            CatMoves.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 250);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DogMoves
            // 
            DogMoves.Controls.Add(button3);
            DogMoves.Controls.Add(button2);
            DogMoves.Controls.Add(button1);
            DogMoves.Location = new Point(645, 350);
            DogMoves.Name = "DogMoves";
            DogMoves.Size = new Size(155, 100);
            DogMoves.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(41, 70);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(41, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(41, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(522, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // CatMoves
            // 
            CatMoves.Controls.Add(button4);
            CatMoves.Controls.Add(button5);
            CatMoves.Controls.Add(button6);
            CatMoves.Location = new Point(0, 1);
            CatMoves.Name = "CatMoves";
            CatMoves.Size = new Size(155, 100);
            CatMoves.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(41, 70);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(41, 41);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(41, 12);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 2;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(114, 207);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 6;
            label1.Text = "DOG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(645, 184);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 7;
            label2.Text = "CAT";
            // 
            // panel3
            // 
            panel3.Controls.Add(CatHealth);
            panel3.Controls.Add(DogHealth);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(CatMoves);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(DogMoves);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 8;
            // 
            // CatHealth
            // 
            CatHealth.Location = new Point(522, 158);
            CatHealth.Name = "CatHealth";
            CatHealth.Size = new Size(278, 23);
            CatHealth.TabIndex = 9;
            CatHealth.Value = 100;
            // 
            // DogHealth
            // 
            DogHealth.Location = new Point(0, 230);
            DogHealth.Name = "DogHealth";
            DogHealth.Size = new Size(266, 23);
            DogHealth.TabIndex = 8;
            DogHealth.Value = 100;
            // 
            // Announcement
            // 
            Announcement.AutoSize = true;
            Announcement.Font = new Font("Segoe UI", 30F);
            Announcement.Location = new Point(262, 190);
            Announcement.Name = "Announcement";
            Announcement.Size = new Size(295, 54);
            Announcement.TabIndex = 9;
            Announcement.Text = "Announcement";
            // 
            // timer1
            // 
            timer1.Interval = 9;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Announcement);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DogMoves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            CatMoves.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel DogMoves;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel CatMoves;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label Announcement;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar DogHealth;
        private ProgressBar CatHealth;
    }
}
