namespace MyPaint
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(32, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2053, 1229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(59, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "pencil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(195, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "line";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(897, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 100);
            this.button3.TabIndex = 4;
            this.button3.Text = "rectangle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.rectangle_click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(749, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 100);
            this.button4.TabIndex = 3;
            this.button4.Text = "triangle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.triangle_click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(1305, 31);
            this.button5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 100);
            this.button5.TabIndex = 6;
            this.button5.Text = "color";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(1169, 31);
            this.button6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 100);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(450, 163);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(320, 38);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1441, 29);
            this.button7.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 100);
            this.button7.TabIndex = 8;
            this.button7.Text = "eraser";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.eraser_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(467, 31);
            this.button8.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 100);
            this.button8.TabIndex = 9;
            this.button8.Text = "pipetka";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(603, 31);
            this.button9.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 100);
            this.button9.TabIndex = 10;
            this.button9.Text = "fill";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1033, 31);
            this.button10.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 100);
            this.button10.TabIndex = 11;
            this.button10.Text = "ellipse";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(68, 163);
            this.button11.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 80);
            this.button11.TabIndex = 12;
            this.button11.Text = "new picture";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.newpicture_click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(291, 163);
            this.button12.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 80);
            this.button12.TabIndex = 13;
            this.button12.Text = "save";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.save_click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(175, 163);
            this.button13.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 80);
            this.button13.TabIndex = 14;
            this.button13.Text = "open";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.open_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(331, 31);
            this.button14.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 100);
            this.button14.TabIndex = 15;
            this.button14.Text = "spray";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.spray_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2416, 1560);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

