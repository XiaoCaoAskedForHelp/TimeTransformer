namespace WinFormsApp1
{
    partial class TimeTransformer
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(30, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Time && Ticks";
            // 
            // button3
            // 
            button3.Location = new Point(338, 253);
            button3.Name = "button3";
            button3.Size = new Size(99, 41);
            button3.TabIndex = 14;
            button3.Text = "重置";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 199);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 12;
            label6.Text = "Ticks(18位)：";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = " yyyy-MM-dd HH:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(168, 319);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 319);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 10;
            label5.Text = "本地时间：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = " yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(168, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 149);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 4;
            label3.Text = "13位时间戳(毫秒)：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 100);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 3;
            label2.Text = "10位时间戳(秒)：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 48);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "UTC时间：";
            // 
            // button2
            // 
            button2.Location = new Point(182, 253);
            button2.Name = "button2";
            button2.Size = new Size(132, 41);
            button2.TabIndex = 1;
            button2.Text = "Ticks To Time";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 253);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 0;
            button1.Text = "Time To Ticks";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TimeTransformer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 418);
            Controls.Add(groupBox1);
            Name = "TimeTransformer";
            Text = "Time Transformer";
            Load += TimeTransformer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button button3;
    }
}