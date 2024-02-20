namespace TaskMaster
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            registerGroup = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            registerButton = new Button();
            registerGroup.SuspendLayout();
            SuspendLayout();
            // 
            // registerGroup
            // 
            registerGroup.Controls.Add(label2);
            registerGroup.Controls.Add(label1);
            registerGroup.Controls.Add(passwordBox);
            registerGroup.Controls.Add(usernameBox);
            registerGroup.Controls.Add(registerButton);
            registerGroup.Location = new Point(163, 132);
            registerGroup.Margin = new Padding(5, 6, 5, 6);
            registerGroup.Name = "registerGroup";
            registerGroup.Padding = new Padding(5, 6, 5, 6);
            registerGroup.Size = new Size(660, 452);
            registerGroup.TabIndex = 1;
            registerGroup.TabStop = false;
            registerGroup.Text = "Welcome";
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
            // registerButton
            // 
            registerButton.Location = new Point(247, 300);
            registerButton.Margin = new Padding(5, 6, 5, 6);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(171, 46);
            registerButton.TabIndex = 0;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 676);
            Controls.Add(registerGroup);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Register";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Register || TaskMaster";
            registerGroup.ResumeLayout(false);
            registerGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox registerGroup;
        private Label label2;
        private Label label1;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button registerButton;
    }
}