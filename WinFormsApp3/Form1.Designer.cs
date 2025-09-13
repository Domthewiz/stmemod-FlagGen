namespace WinFormsApp3
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            helpProvider1 = new HelpProvider();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(955, 12);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 2;
            button1.Text = "Open Noexes Expressions";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_09_09_173936;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(786, 401);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLight;
            pictureBox2.Location = new Point(804, 128);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 401);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(955, 41);
            button2.Name = "button2";
            button2.Size = new Size(149, 23);
            button2.TabIndex = 5;
            button2.Text = "Open Config";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(818, 137);
            label1.Name = "label1";
            label1.Size = new Size(273, 15);
            label1.TabIndex = 6;
            label1.Text = "Add some kind of way to find memory values here";
            // 
            // button3
            // 
            button3.Location = new Point(955, 70);
            button3.Name = "button3";
            button3.Size = new Size(149, 23);
            button3.TabIndex = 7;
            button3.Text = "Open GDB Terminal";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(955, 99);
            button4.Name = "button4";
            button4.Size = new Size(149, 23);
            button4.TabIndex = 8;
            button4.Text = "Display SMM2 Info";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(800, 99);
            button5.Name = "button5";
            button5.Size = new Size(149, 23);
            button5.TabIndex = 9;
            button5.Text = "Open Flag Gen";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(800, 70);
            button6.Name = "button6";
            button6.Size = new Size(149, 23);
            button6.TabIndex = 10;
            button6.Text = "lil button";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(800, 41);
            button7.Name = "button7";
            button7.Size = new Size(149, 23);
            button7.TabIndex = 11;
            button7.Text = "lil button";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(800, 12);
            button8.Name = "button8";
            button8.Size = new Size(149, 23);
            button8.TabIndex = 12;
            button8.Text = "lil button";
            button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 648);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 13;
            label2.Text = "Add some more features here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 724);
            Controls.Add(label2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "WIP";
            Load += Form1_Load;
            Enter += Form1_Enter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private HelpProvider helpProvider1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label2;
    }
}
