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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            button5 = new Button();
            label8 = new Label();
            button4 = new Button();
            label5 = new Label();
            button6 = new Button();
            label4 = new Label();
            label3 = new Label();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 21);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 539);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(516, 251);
            button3.Margin = new Padding(2);
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
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Electronics";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(82, 251);
            button1.Margin = new Padding(2);
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
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "What are you looking for?";
            textBox1.Size = new Size(226, 31);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Sundalandz!";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(11, 139);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(486, 268);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button8);
            panel2.Location = new Point(41, 21);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 518);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button7);
            panel3.Location = new Point(12, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(737, 497);
            panel3.TabIndex = 6;
            panel3.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(709, 455);
            panel4.TabIndex = 7;
            panel4.Visible = false;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(19, 2);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(661, 411);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(button5);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(26, 32);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(621, 350);
            panel6.TabIndex = 3;
            panel6.Paint += panel6_Paint;
            // 
            // panel7
            // 
            panel7.Location = new Point(303, 22);
            panel7.Name = "panel7";
            panel7.Size = new Size(300, 150);
            panel7.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(219, 204);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(188, 34);
            button5.TabIndex = 1;
            button5.Text = "Want to shop more?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 69);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(405, 50);
            label8.TabIndex = 0;
            label8.Text = "         Congrats your purchase went through! \r\nEnjoy and thank you for shopping at Sundalandz!";
            // 
            // button4
            // 
            button4.Location = new Point(285, 292);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 2;
            button4.Text = "Checkout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 39);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 0;
            label5.Text = "Shopping Cart";
            // 
            // button6
            // 
            button6.Location = new Point(507, 18);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 1;
            button6.Text = "Checkout";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 48);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 0;
            label4.Text = "Food";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 41);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 0;
            label3.Text = "Electronics";
            label3.Click += label3_Click;
            // 
            // button7
            // 
            button7.Location = new Point(523, 15);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 8;
            button7.Text = "Checkout";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 0;
            label2.Text = "Comfort";
            label2.Click += label2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(525, 17);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 7;
            button8.Text = "Checkout";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 582);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Button button4;
        private Label label8;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel7;
    }
}