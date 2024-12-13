namespace Final_Project
{
    partial class Form2
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 429);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(516, 251);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "Food";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 251);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Electronics";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(83, 251);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Comfort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 120);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "What are you looking for?";
            textBox1.Size = new Size(227, 31);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 74);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Sundalandz!";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(26, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 421);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 44);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 0;
            label2.Text = "Comfort";
            label2.Click += label2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 476);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Label label2;
    }
}