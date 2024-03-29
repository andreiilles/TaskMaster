﻿namespace TaskMaster
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            loginGroup = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            loginButton = new Button();
            loginGroup.SuspendLayout();
            SuspendLayout();
            // 
            // loginGroup
            // 
            loginGroup.Controls.Add(label2);
            loginGroup.Controls.Add(label1);
            loginGroup.Controls.Add(passwordBox);
            loginGroup.Controls.Add(usernameBox);
            loginGroup.Controls.Add(loginButton);
            loginGroup.Location = new Point(182, 160);
            loginGroup.Margin = new Padding(5, 6, 5, 6);
            loginGroup.Name = "loginGroup";
            loginGroup.Padding = new Padding(5, 6, 5, 6);
            loginGroup.Size = new Size(615, 374);
            loginGroup.TabIndex = 0;
            loginGroup.TabStop = false;
            loginGroup.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 188);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 124);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(185, 182);
            passwordBox.Margin = new Padding(5, 6, 5, 6);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(301, 35);
            passwordBox.TabIndex = 2;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(185, 124);
            usernameBox.Margin = new Padding(5, 6, 5, 6);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(301, 35);
            usernameBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(249, 240);
            loginButton.Margin = new Padding(5, 6, 5, 6);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(171, 46);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1023, 738);
            Controls.Add(loginGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login || TaskMaster";
            loginGroup.ResumeLayout(false);
            loginGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox loginGroup;
        private Label label1;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button loginButton;
        private Label label2;
    }
}