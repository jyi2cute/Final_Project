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
            usernameBox.Location = new Point(300, 62);
            usernameBox.Margin = new Padding(2, 2, 2, 2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(106, 23);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(300, 110);
            passwordBox.Margin = new Padding(2, 2, 2, 2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(106, 23);
            passwordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 4;
            label3.Text = "Welcome to the login Page!";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(244, 173);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
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
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 268);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(passwordInput);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(usernameInput);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(9, 9);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 242);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(207, 155);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(125, 20);
            button2.TabIndex = 5;
            button2.Text = "Create account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(267, 105);
            passwordInput.Margin = new Padding(2, 2, 2, 2);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(106, 23);
            passwordInput.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 103);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 3;
            label6.Text = "Password:";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(266, 74);
            usernameInput.Margin = new Padding(2, 2, 2, 2);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(106, 23);
            usernameInput.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 76);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 1;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 30);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 0;
            label4.Text = "Sign up for Sundalnadz";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(216, 209);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here to Sign Up!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 275);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
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
    }
}
