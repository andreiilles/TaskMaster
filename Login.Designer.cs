namespace TaskMaster
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
            loginGroup.Location = new Point(106, 80);
            loginGroup.Name = "loginGroup";
            loginGroup.Size = new Size(359, 187);
            loginGroup.TabIndex = 0;
            loginGroup.TabStop = false;
            loginGroup.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 94);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 62);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(108, 91);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(177, 23);
            passwordBox.TabIndex = 2;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(108, 62);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(177, 23);
            usernameBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(145, 120);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 23);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(597, 369);
            Controls.Add(loginGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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