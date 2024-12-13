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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(428, 104);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(150, 31);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(428, 184);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(150, 31);
            passwordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 104);
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
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 459);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
