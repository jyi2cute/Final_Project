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
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            button4 = new Button();
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            button6 = new Button();
            label4 = new Label();
            label3 = new Label();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            button5 = new Button();
            flowLayoutPanelProducts = new FlowLayoutPanel(); // FlowLayoutPanel here

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();

            //
            // flowLayoutPanel
            //
            flowLayoutPanelProducts.Location = new Point(20, 150); 
            flowLayoutPanelProducts.Size = new Size(750, 300);
            flowLayoutPanelProducts.WrapContents = true;
            flowLayoutPanelProducts.FlowDirection = FlowDirection.LeftToRight; 
            flowLayoutPanelProducts.AutoScroll = true;
            // Adding to the form's controls
            this.Controls.Add(flowLayoutPanelProducts);

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
            panel1.Visible = false;
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
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button8);
            panel2.Location = new Point(26, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 429);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button7);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(714, 397);
            panel3.TabIndex = 6;
            panel3.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(714, 397);
            panel4.TabIndex = 7;
            panel4.Visible = false;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(splitContainer1);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(14, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(694, 380);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(22, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(642, 339);
            panel6.TabIndex = 3;
            panel6.Paint += panel6_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 69);
            label8.Name = "label8";
            label8.Size = new Size(405, 50);
            label8.TabIndex = 0;
            label8.Text = "         Congrats your purchase went through! \r\nEnjoy and thank you for shopping at Sundalandz!";
            // 
            // button4
            // 
            button4.Location = new Point(285, 292);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 2;
            button4.Text = "Checkout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(229, 103);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(225, 150);
            splitContainer1.SplitterDistance = 155;
            splitContainer1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 6);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 0;
            label6.Text = "Items";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 6);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 0;
            label7.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 39);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 0;
            label5.Text = "Shopping Cart";
            // 
            // button6
            // 
            button6.Location = new Point(524, 294);
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
            label4.Location = new Point(327, 47);
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
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 0;
            label3.Text = "Electronics";
            label3.Click += label3_Click;
            // 
            // button7
            // 
            button7.Location = new Point(527, 297);
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
            label2.Location = new Point(313, 44);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 0;
            label2.Text = "Comfort";
            label2.Click += label2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(548, 280);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 7;
            button8.Text = "Checkout";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.Location = new Point(219, 204);
            button5.Name = "button5";
            button5.Size = new Size(187, 34);
            button5.TabIndex = 1;
            button5.Text = "Want to shop more?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 454);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private Panel panel6;
        private Button button4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanelProducts;


    }
}