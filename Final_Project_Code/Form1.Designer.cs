namespace Final_Project
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
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            passwordInput = new TextBox();
            label6 = new Label();
            usernameInput = new TextBox();
            label5 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(429, 103);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(150, 31);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(429, 183);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(150, 31);
            passwordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 103);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 190);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 40);
            label3.Name = "label3";
            label3.Size = new Size(230, 25);
            label3.TabIndex = 4;
            label3.Text = "Welcome to the login Page!";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(349, 288);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 5;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(usernameBox);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 447);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(passwordInput);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(usernameInput);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(13, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(751, 403);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(326, 297);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(296, 258);
            button2.Name = "button2";
            button2.Size = new Size(179, 33);
            button2.TabIndex = 5;
            button2.Text = "Create account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(381, 175);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(150, 31);
            passwordInput.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 172);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 3;
            label6.Text = "Password:";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(380, 123);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(150, 31);
            usernameInput.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 127);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 1;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 50);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 0;
            label4.Text = "Sign up for Sundalnadz";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(309, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(182, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here to Sign Up!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 458);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Button button2;
        private TextBox passwordInput;
        private Label label6;
        private TextBox usernameInput;
        private Label label5;
        private Label label4;
        private Button button3;
    }
}
