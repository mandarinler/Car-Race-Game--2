﻿namespace Car_Race_Game
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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Car = new PictureBox();
            Pedestrian = new PictureBox();
            Coin1 = new PictureBox();
            Coin2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pedestrian).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(212, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Location = new Point(202, 270);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 88);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Location = new Point(212, 639);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 130);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Location = new Point(212, 441);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 130);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonHighlight;
            pictureBox5.Location = new Point(212, 835);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 130);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonHighlight;
            pictureBox6.Location = new Point(144, 270);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(27, 88);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ButtonHighlight;
            pictureBox7.Location = new Point(259, 270);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(27, 88);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = SystemColors.ButtonHighlight;
            pictureBox8.Location = new Point(317, 270);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(27, 88);
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = SystemColors.ButtonHighlight;
            pictureBox9.Location = new Point(21, 270);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(27, 88);
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = SystemColors.ButtonHighlight;
            pictureBox10.Location = new Point(88, 270);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(27, 88);
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = SystemColors.ButtonHighlight;
            pictureBox11.Location = new Point(381, 270);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(27, 88);
            pictureBox11.TabIndex = 10;
            pictureBox11.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Car
            // 
            Car.BackColor = Color.Transparent;
            Car.Image = (Image)resources.GetObject("Car.Image");
            Car.Location = new Point(259, 806);
            Car.Name = "Car";
            Car.Size = new Size(87, 159);
            Car.TabIndex = 11;
            Car.TabStop = false;
            // 
            // Pedestrian
            // 
            Pedestrian.BackColor = Color.Transparent;
            Pedestrian.Image = (Image)resources.GetObject("Pedestrian.Image");
            Pedestrian.Location = new Point(44, 184);
            Pedestrian.Name = "Pedestrian";
            Pedestrian.Size = new Size(84, 150);
            Pedestrian.TabIndex = 12;
            Pedestrian.TabStop = false;
            // 
            // Coin1
            // 
            Coin1.BackColor = Color.Yellow;
            Coin1.Image = (Image)resources.GetObject("Coin1.Image");
            Coin1.Location = new Point(299, 100);
            Coin1.Name = "Coin1";
            Coin1.Size = new Size(75, 75);
            Coin1.TabIndex = 13;
            Coin1.TabStop = false;
            // 
            // Coin2
            // 
            Coin2.BackColor = Color.Yellow;
            Coin2.Image = (Image)resources.GetObject("Coin2.Image");
            Coin2.Location = new Point(65, 639);
            Coin2.Name = "Coin2";
            Coin2.Size = new Size(75, 75);
            Coin2.TabIndex = 14;
            Coin2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(265, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 46);
            label1.TabIndex = 15;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(19, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 16;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(422, 994);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Coin2);
            Controls.Add(Coin1);
            Controls.Add(Pedestrian);
            Controls.Add(Car);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pedestrian).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Car;
        private PictureBox Pedestrian;
        private PictureBox Coin1;
        private PictureBox Coin2;
        private Label label1;
        private Label label2;
    }
}