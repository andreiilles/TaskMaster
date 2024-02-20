namespace TaskMaster
{
    partial class EditTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTask));
            EditTaskDetailsBox = new GroupBox();
            label3 = new Label();
            EditTaskDeadlineDatePicker = new DateTimePicker();
            EditTaskPriorityPicker = new NumericUpDown();
            label2 = new Label();
            EditTaskDescriptionTextbox = new TextBox();
            label1 = new Label();
            EditConfirmTaskButton = new Button();
            EditCancelTaskButton = new Button();
            EditTaskDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditTaskPriorityPicker).BeginInit();
            SuspendLayout();
            // 
            // EditTaskDetailsBox
            // 
            EditTaskDetailsBox.Controls.Add(label3);
            EditTaskDetailsBox.Controls.Add(EditTaskDeadlineDatePicker);
            EditTaskDetailsBox.Controls.Add(EditTaskPriorityPicker);
            EditTaskDetailsBox.Controls.Add(label2);
            EditTaskDetailsBox.Controls.Add(EditTaskDescriptionTextbox);
            EditTaskDetailsBox.Controls.Add(label1);
            EditTaskDetailsBox.Location = new Point(21, 24);
            EditTaskDetailsBox.Margin = new Padding(5, 6, 5, 6);
            EditTaskDetailsBox.Name = "EditTaskDetailsBox";
            EditTaskDetailsBox.Padding = new Padding(5, 6, 5, 6);
            EditTaskDetailsBox.Size = new Size(957, 360);
            EditTaskDetailsBox.TabIndex = 1;
            EditTaskDetailsBox.TabStop = false;
            EditTaskDetailsBox.Text = "Edit task details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 224);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 0;
            label3.Text = "Deadline:";
            // 
            // EditTaskDeadlineDatePicker
            // 
            EditTaskDeadlineDatePicker.Location = new Point(178, 212);
            EditTaskDeadlineDatePicker.Margin = new Padding(5, 6, 5, 6);
            EditTaskDeadlineDatePicker.Name = "EditTaskDeadlineDatePicker";
            EditTaskDeadlineDatePicker.Size = new Size(340, 35);
            EditTaskDeadlineDatePicker.TabIndex = 4;
            EditTaskDeadlineDatePicker.Value = new DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // EditTaskPriorityPicker
            // 
            EditTaskPriorityPicker.Location = new Point(178, 154);
            EditTaskPriorityPicker.Margin = new Padding(5, 6, 5, 6);
            EditTaskPriorityPicker.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            EditTaskPriorityPicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EditTaskPriorityPicker.Name = "EditTaskPriorityPicker";
            EditTaskPriorityPicker.Size = new Size(99, 35);
            EditTaskPriorityPicker.TabIndex = 3;
            EditTaskPriorityPicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 158);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 30);
            label2.TabIndex = 0;
            label2.Text = "Task priority:";
            // 
            // EditTaskDescriptionTextbox
            // 
            EditTaskDescriptionTextbox.Location = new Point(178, 44);
            EditTaskDescriptionTextbox.Margin = new Padding(5, 6, 5, 6);
            EditTaskDescriptionTextbox.Multiline = true;
            EditTaskDescriptionTextbox.Name = "EditTaskDescriptionTextbox";
            EditTaskDescriptionTextbox.Size = new Size(765, 94);
            EditTaskDescriptionTextbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 50);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 0;
            label1.Text = "Task description:";
            // 
            // EditConfirmTaskButton
            // 
            EditConfirmTaskButton.DialogResult = DialogResult.OK;
            EditConfirmTaskButton.Location = new Point(199, 396);
            EditConfirmTaskButton.Margin = new Padding(5, 6, 5, 6);
            EditConfirmTaskButton.Name = "EditConfirmTaskButton";
            EditConfirmTaskButton.Size = new Size(226, 92);
            EditConfirmTaskButton.TabIndex = 6;
            EditConfirmTaskButton.Text = "Confirm";
            EditConfirmTaskButton.UseVisualStyleBackColor = true;
            EditConfirmTaskButton.Click += EditConfirmTaskButton_Click;
            // 
            // EditCancelTaskButton
            // 
            EditCancelTaskButton.DialogResult = DialogResult.Cancel;
            EditCancelTaskButton.Location = new Point(435, 396);
            EditCancelTaskButton.Margin = new Padding(5, 6, 5, 6);
            EditCancelTaskButton.Name = "EditCancelTaskButton";
            EditCancelTaskButton.Size = new Size(226, 92);
            EditCancelTaskButton.TabIndex = 7;
            EditCancelTaskButton.Text = "Cancel";
            EditCancelTaskButton.UseVisualStyleBackColor = true;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 538);
            Controls.Add(EditCancelTaskButton);
            Controls.Add(EditConfirmTaskButton);
            Controls.Add(EditTaskDetailsBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "EditTask";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit task";
            EditTaskDetailsBox.ResumeLayout(false);
            EditTaskDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditTaskPriorityPicker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EditTaskDetailsBox;
        private Label label3;
        private DateTimePicker EditTaskDeadlineDatePicker;
        private NumericUpDown EditTaskPriorityPicker;
        private Label label2;
        private TextBox EditTaskDescriptionTextbox;
        private Label label1;
        private Button EditConfirmTaskButton;
        private Button EditCancelTaskButton;
    }
}