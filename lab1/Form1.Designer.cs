﻿namespace lab1
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button8 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(723, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(33, 295);
            button1.Name = "button1";
            button1.Size = new Size(194, 53);
            button1.TabIndex = 1;
            button1.Text = "Замена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(233, 295);
            button2.Name = "button2";
            button2.Size = new Size(187, 53);
            button2.TabIndex = 2;
            button2.Text = "Удаление";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(426, 295);
            button3.Name = "button3";
            button3.Size = new Size(183, 53);
            button3.TabIndex = 3;
            button3.Text = "Получение символа";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(615, 295);
            button4.Name = "button4";
            button4.Size = new Size(173, 53);
            button4.TabIndex = 4;
            button4.Text = "Длина";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(44, 358);
            button5.Name = "button5";
            button5.Size = new Size(242, 62);
            button5.TabIndex = 5;
            button5.Text = "Количество гласных/согласных";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(292, 358);
            button6.Name = "button6";
            button6.Size = new Size(239, 62);
            button6.TabIndex = 6;
            button6.Text = "Количество предложений";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(537, 358);
            button7.Name = "button7";
            button7.Size = new Size(219, 62);
            button7.TabIndex = 7;
            button7.Text = "Количество слов";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 241);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.GradientActiveCaption;
            button8.Location = new Point(659, 232);
            button8.Name = "button8";
            button8.Size = new Size(109, 38);
            button8.TabIndex = 12;
            button8.Text = "подтвердить";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button8;
    }
}