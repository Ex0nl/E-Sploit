using System.Text;

namespace E_XPloit
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

        public List<string> Lines;

        public string GetList()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (string s in Lines)
            {
                sb.AppendFormat("{0}: {1}", i, s).AppendLine();
                i++;
            }
            return sb.ToString();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            scripteditor = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            buttonpanel = new Panel();
            button5 = new Button();
            button16 = new Button();
            button15 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            label8 = new Label();
            label7 = new Label();
            button11 = new Button();
            button10 = new Button();
            label6 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            button17 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            buttonpanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 14, 30);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(91, 69);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 47);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 57);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 9F);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(92, 433);
            label1.Name = "label1";
            label1.Size = new Size(120, 12);
            label1.TabIndex = 2;
            label1.Text = "E-SPLOIT V2.1 BY EXONL";
            // 
            // scripteditor
            // 
            scripteditor.BackColor = Color.FromArgb(14, 14, 30);
            scripteditor.BorderStyle = BorderStyle.None;
            scripteditor.EnableAutoDragDrop = true;
            scripteditor.ForeColor = SystemColors.MenuBar;
            scripteditor.Location = new Point(89, 12);
            scripteditor.Name = "scripteditor";
            scripteditor.Size = new Size(699, 367);
            scripteditor.TabIndex = 3;
            scripteditor.Text = "print(\"Hello World!\")";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe Fluent Icons", 10F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(668, 385);
            button1.Name = "button1";
            button1.Size = new Size(120, 45);
            button1.TabIndex = 4;
            button1.Text = "EXECUTE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe Fluent Icons", 10F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(92, 385);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(120, 45);
            button2.TabIndex = 5;
            button2.Text = "INJECT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 62);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // buttonpanel
            // 
            buttonpanel.BackColor = Color.FromArgb(14, 14, 30);
            buttonpanel.Controls.Add(button17);
            buttonpanel.Controls.Add(button5);
            buttonpanel.Controls.Add(button16);
            buttonpanel.Controls.Add(button15);
            buttonpanel.Controls.Add(textBox3);
            buttonpanel.Controls.Add(textBox2);
            buttonpanel.Controls.Add(textBox1);
            buttonpanel.Controls.Add(label12);
            buttonpanel.Controls.Add(label11);
            buttonpanel.Controls.Add(label10);
            buttonpanel.Controls.Add(button14);
            buttonpanel.Controls.Add(button13);
            buttonpanel.Controls.Add(button12);
            buttonpanel.Controls.Add(label8);
            buttonpanel.Controls.Add(label7);
            buttonpanel.Controls.Add(button11);
            buttonpanel.Controls.Add(button10);
            buttonpanel.Controls.Add(label6);
            buttonpanel.Controls.Add(button9);
            buttonpanel.Controls.Add(button8);
            buttonpanel.Controls.Add(button7);
            buttonpanel.Controls.Add(button6);
            buttonpanel.Controls.Add(button4);
            buttonpanel.Controls.Add(button3);
            buttonpanel.Controls.Add(label5);
            buttonpanel.Controls.Add(label4);
            buttonpanel.Controls.Add(label3);
            buttonpanel.Controls.Add(label2);
            buttonpanel.Location = new Point(89, 12);
            buttonpanel.Name = "buttonpanel";
            buttonpanel.Size = new Size(699, 367);
            buttonpanel.TabIndex = 7;
            buttonpanel.Visible = false;
            buttonpanel.Paint += buttonpanel_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe Fluent Icons", 10F);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(8, 121);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(86, 25);
            button5.TabIndex = 34;
            button5.Text = "JERK OFF R6";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(64, 64, 64);
            button16.FlatStyle = FlatStyle.Popup;
            button16.Font = new Font("Segoe Fluent Icons", 10F);
            button16.ForeColor = SystemColors.ButtonHighlight;
            button16.Location = new Point(194, 335);
            button16.Name = "button16";
            button16.RightToLeft = RightToLeft.No;
            button16.Size = new Size(125, 25);
            button16.TabIndex = 33;
            button16.Text = "TELEPORT";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(64, 64, 64);
            button15.FlatStyle = FlatStyle.Popup;
            button15.Font = new Font("Segoe Fluent Icons", 10F);
            button15.ForeColor = Color.White;
            button15.Location = new Point(7, 335);
            button15.Name = "button15";
            button15.RightToLeft = RightToLeft.No;
            button15.Size = new Size(181, 25);
            button15.TabIndex = 32;
            button15.Text = "APPLY";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 309);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Exact username here";
            textBox3.Size = new Size(125, 23);
            textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 309);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Default = 50";
            textBox2.Size = new Size(87, 23);
            textBox2.TabIndex = 30;
            textBox2.Text = "50";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 309);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Default = 16";
            textBox1.Size = new Size(87, 23);
            textBox1.TabIndex = 29;
            textBox1.Text = "16";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Fluent Icons", 14F);
            label12.ForeColor = Color.Snow;
            label12.Location = new Point(194, 287);
            label12.Name = "label12";
            label12.Size = new Size(125, 19);
            label12.TabIndex = 28;
            label12.Text = "Teleport to player";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Fluent Icons", 14F);
            label11.ForeColor = Color.Snow;
            label11.Location = new Point(100, 287);
            label11.Name = "label11";
            label11.Size = new Size(88, 19);
            label11.TabIndex = 27;
            label11.Text = "Jump Power";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Fluent Icons", 14F);
            label10.ForeColor = Color.Snow;
            label10.Location = new Point(7, 287);
            label10.Name = "label10";
            label10.Size = new Size(87, 19);
            label10.TabIndex = 26;
            label10.Text = "Walk Speed";
            // 
            // button14
            // 
            button14.BackColor = Color.Azure;
            button14.FlatStyle = FlatStyle.Popup;
            button14.Font = new Font("Segoe Fluent Icons", 10F);
            button14.ForeColor = SystemColors.ActiveCaptionText;
            button14.Location = new Point(460, 59);
            button14.Name = "button14";
            button14.RightToLeft = RightToLeft.No;
            button14.Size = new Size(103, 25);
            button14.TabIndex = 25;
            button14.Text = "SCRIPT HUB V3";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.DodgerBlue;
            button13.FlatStyle = FlatStyle.Popup;
            button13.Font = new Font("Segoe Fluent Icons", 10F);
            button13.ForeColor = Color.White;
            button13.Location = new Point(572, 59);
            button13.Name = "button13";
            button13.RightToLeft = RightToLeft.No;
            button13.Size = new Size(106, 25);
            button13.TabIndex = 24;
            button13.Text = "FORCE RESET";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DodgerBlue;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Font = new Font("Segoe Fluent Icons", 10F);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(572, 90);
            button12.Name = "button12";
            button12.RightToLeft = RightToLeft.No;
            button12.Size = new Size(106, 25);
            button12.TabIndex = 23;
            button12.Text = "DEX EXPLORER";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Fluent Icons", 14F);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(572, 37);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 22;
            label8.Text = "Other";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Fluent Icons", 14F);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(460, 37);
            label7.Name = "label7";
            label7.Size = new Size(103, 19);
            label7.TabIndex = 21;
            label7.Text = "Scripting Hubs";
            // 
            // button11
            // 
            button11.BackColor = Color.Lime;
            button11.FlatStyle = FlatStyle.Popup;
            button11.Font = new Font("Segoe Fluent Icons", 10F);
            button11.ForeColor = SystemColors.ActiveCaptionText;
            button11.Location = new Point(316, 90);
            button11.Name = "button11";
            button11.RightToLeft = RightToLeft.No;
            button11.Size = new Size(132, 25);
            button11.TabIndex = 20;
            button11.Text = "NAKIFY GUI";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Lime;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Segoe Fluent Icons", 10F);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(316, 59);
            button10.Name = "button10";
            button10.RightToLeft = RightToLeft.Yes;
            button10.Size = new Size(132, 25);
            button10.TabIndex = 19;
            button10.Text = "WEAREDEVS ESP";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Fluent Icons", 14F);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(316, 37);
            label6.Name = "label6";
            label6.Size = new Size(133, 19);
            label6.TabIndex = 18;
            label6.Text = "Client appearances";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 0);
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe Fluent Icons", 10F);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(216, 59);
            button9.Name = "button9";
            button9.RightToLeft = RightToLeft.No;
            button9.Size = new Size(86, 25);
            button9.TabIndex = 17;
            button9.Text = "AIRHUB GUI";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Fuchsia;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe Fluent Icons", 10F);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(114, 90);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(86, 36);
            button8.TabIndex = 16;
            button8.Text = "CTRL+CLICK TELEPORT";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Fuchsia;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe Fluent Icons", 10F);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(114, 59);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(86, 25);
            button7.TabIndex = 15;
            button7.Text = "INF JUMP";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe Fluent Icons", 10F);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(8, 152);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(86, 36);
            button6.TabIndex = 14;
            button6.Text = "JERK OFF R15";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe Fluent Icons", 10F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(7, 90);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(86, 25);
            button4.TabIndex = 12;
            button4.Text = "FUCK PLR R6";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe Fluent Icons", 10F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(7, 59);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(86, 25);
            button3.TabIndex = 8;
            button3.Text = "ENERGIZE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Fluent Icons", 14F);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(114, 37);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 11;
            label5.Text = "Movement";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 14F);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(7, 37);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 10;
            label4.Text = "Troll Scripts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 14F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(216, 37);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 9;
            label3.Text = "Combat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(7, 0);
            label2.Name = "label2";
            label2.Size = new Size(266, 19);
            label2.TabIndex = 8;
            label2.Text = "QUICK ACCESS SCRIPT BUTTONS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Fluent Icons", 9F);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(682, 433);
            label9.Name = "label9";
            label9.Size = new Size(91, 12);
            label9.TabIndex = 8;
            label9.Text = "USING SALAD API";
            // 
            // button17
            // 
            button17.BackColor = Color.DodgerBlue;
            button17.FlatStyle = FlatStyle.Popup;
            button17.Font = new Font("Segoe Fluent Icons", 10F);
            button17.ForeColor = SystemColors.ButtonHighlight;
            button17.Location = new Point(572, 121);
            button17.Name = "button17";
            button17.RightToLeft = RightToLeft.No;
            button17.Size = new Size(106, 25);
            button17.TabIndex = 35;
            button17.Text = "INF YIELD";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(buttonpanel);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(scripteditor);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "E-Sploit";
            TopMost = true;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            buttonpanel.ResumeLayout(false);
            buttonpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private RichTextBox scripteditor;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Panel buttonpanel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button button3;
        private Label label8;
        private Label label7;
        private Button button11;
        private Button button10;
        private Label label6;
        private Button button9;
        private Button button13;
        private Button button12;
        private Label label9;
        private Label label10;
        private Button button16;
        private Button button15;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label12;
        private Label label11;
        private Button button14;
        private Button button5;
        private Button button17;
    }
}
