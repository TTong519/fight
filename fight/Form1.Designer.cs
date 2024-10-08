﻿namespace fight
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
            Heal = new Button();
            Kick = new Button();
            Bite = new Button();
            pictureBox2 = new PictureBox();
            CatMoves = new Panel();
            WaterBody = new Button();
            Bite2 = new Button();
            Scratch = new Button();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            CatHealth = new ProgressBar();
            DogHealth = new ProgressBar();
            CatRabiesIndicator = new PictureBox();
            DogRabiesIndicator = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DogMoves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            CatMoves.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CatRabiesIndicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DogRabiesIndicator).BeginInit();
            panel1.SuspendLayout();
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
            DogMoves.Controls.Add(Heal);
            DogMoves.Controls.Add(Kick);
            DogMoves.Controls.Add(Bite);
            DogMoves.Location = new Point(645, 350);
            DogMoves.Name = "DogMoves";
            DogMoves.Size = new Size(155, 100);
            DogMoves.TabIndex = 1;
            // 
            // Heal
            // 
            Heal.Location = new Point(41, 70);
            Heal.Name = "Heal";
            Heal.Size = new Size(75, 23);
            Heal.TabIndex = 4;
            Heal.Text = "Heal";
            Heal.UseVisualStyleBackColor = true;
            Heal.Click += Heal_Click;
            // 
            // Kick
            // 
            Kick.Location = new Point(41, 41);
            Kick.Name = "Kick";
            Kick.Size = new Size(75, 23);
            Kick.TabIndex = 3;
            Kick.Text = "Kick";
            Kick.UseVisualStyleBackColor = true;
            Kick.Click += Kick_Click;
            // 
            // Bite
            // 
            Bite.Location = new Point(41, 12);
            Bite.Name = "Bite";
            Bite.Size = new Size(75, 23);
            Bite.TabIndex = 2;
            Bite.Text = "Bite";
            Bite.UseVisualStyleBackColor = true;
            Bite.Click += Bite_Click;
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
            CatMoves.Controls.Add(WaterBody);
            CatMoves.Controls.Add(Bite2);
            CatMoves.Controls.Add(Scratch);
            CatMoves.Location = new Point(0, 1);
            CatMoves.Name = "CatMoves";
            CatMoves.Size = new Size(155, 100);
            CatMoves.TabIndex = 5;
            // 
            // WaterBody
            // 
            WaterBody.Location = new Point(41, 70);
            WaterBody.Name = "WaterBody";
            WaterBody.Size = new Size(77, 25);
            WaterBody.TabIndex = 4;
            WaterBody.Text = "Water Body";
            WaterBody.UseVisualStyleBackColor = true;
            WaterBody.Click += WaterBody_Click;
            // 
            // Bite2
            // 
            Bite2.Location = new Point(41, 41);
            Bite2.Name = "Bite2";
            Bite2.Size = new Size(75, 23);
            Bite2.TabIndex = 3;
            Bite2.Text = "Bite";
            Bite2.UseVisualStyleBackColor = true;
            Bite2.Click += Bite2_Click;
            // 
            // Scratch
            // 
            Scratch.Location = new Point(41, 12);
            Scratch.Name = "Scratch";
            Scratch.Size = new Size(75, 23);
            Scratch.TabIndex = 2;
            Scratch.Text = "Scratch";
            Scratch.UseVisualStyleBackColor = true;
            Scratch.Click += Scratch_Click;
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
            panel3.Controls.Add(CatRabiesIndicator);
            panel3.Controls.Add(DogRabiesIndicator);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
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
            // CatRabiesIndicator
            // 
            CatRabiesIndicator.Image = (Image)resources.GetObject("CatRabiesIndicator.Image");
            CatRabiesIndicator.Location = new Point(700, 111);
            CatRabiesIndicator.Name = "CatRabiesIndicator";
            CatRabiesIndicator.Size = new Size(100, 50);
            CatRabiesIndicator.SizeMode = PictureBoxSizeMode.StretchImage;
            CatRabiesIndicator.TabIndex = 10;
            CatRabiesIndicator.TabStop = false;
            // 
            // DogRabiesIndicator
            // 
            DogRabiesIndicator.Image = (Image)resources.GetObject("DogRabiesIndicator.Image");
            DogRabiesIndicator.Location = new Point(166, 397);
            DogRabiesIndicator.Name = "DogRabiesIndicator";
            DogRabiesIndicator.Size = new Size(100, 50);
            DogRabiesIndicator.SizeMode = PictureBoxSizeMode.StretchImage;
            DogRabiesIndicator.TabIndex = 11;
            DogRabiesIndicator.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 17;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(346, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "replay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 144);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 0;
            label3.Text = "placeholde4r";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DogMoves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            CatMoves.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CatRabiesIndicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)DogRabiesIndicator).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel DogMoves;
        private Button Heal;
        private Button Bite;
        private PictureBox pictureBox2;
        private Panel CatMoves;
        private Button WaterBody;
        private Button Bite2;
        private Button Scratch;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar DogHealth;
        private ProgressBar CatHealth;
        private Button Kick;
        private PictureBox DogRabiesIndicator;
        private PictureBox CatRabiesIndicator;
        private Panel panel1;
        private Label label3;
        private Button button1;
    }
}
