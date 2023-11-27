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
            EditTaskDetailsBox.Location = new Point(12, 12);
            EditTaskDetailsBox.Name = "EditTaskDetailsBox";
            EditTaskDetailsBox.Size = new Size(558, 180);
            EditTaskDetailsBox.TabIndex = 1;
            EditTaskDetailsBox.TabStop = false;
            EditTaskDetailsBox.Text = "Edit task details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 112);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Deadline:";
            // 
            // EditTaskDeadlineDatePicker
            // 
            EditTaskDeadlineDatePicker.Location = new Point(104, 106);
            EditTaskDeadlineDatePicker.Name = "EditTaskDeadlineDatePicker";
            EditTaskDeadlineDatePicker.Size = new Size(200, 23);
            EditTaskDeadlineDatePicker.TabIndex = 4;
            EditTaskDeadlineDatePicker.Value = new DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // EditTaskPriorityPicker
            // 
            EditTaskPriorityPicker.Location = new Point(104, 77);
            EditTaskPriorityPicker.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            EditTaskPriorityPicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EditTaskPriorityPicker.Name = "EditTaskPriorityPicker";
            EditTaskPriorityPicker.Size = new Size(58, 23);
            EditTaskPriorityPicker.TabIndex = 3;
            EditTaskPriorityPicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Task priority:";
            // 
            // EditTaskDescriptionTextbox
            // 
            EditTaskDescriptionTextbox.Location = new Point(104, 22);
            EditTaskDescriptionTextbox.Multiline = true;
            EditTaskDescriptionTextbox.Name = "EditTaskDescriptionTextbox";
            EditTaskDescriptionTextbox.Size = new Size(448, 49);
            EditTaskDescriptionTextbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Task description:";
            // 
            // EditConfirmTaskButton
            // 
            EditConfirmTaskButton.DialogResult = DialogResult.OK;
            EditConfirmTaskButton.Location = new Point(116, 198);
            EditConfirmTaskButton.Name = "EditConfirmTaskButton";
            EditConfirmTaskButton.Size = new Size(132, 46);
            EditConfirmTaskButton.TabIndex = 6;
            EditConfirmTaskButton.Text = "Confirm";
            EditConfirmTaskButton.UseVisualStyleBackColor = true;
            EditConfirmTaskButton.Click += EditConfirmTaskButton_Click;
            // 
            // EditCancelTaskButton
            // 
            EditCancelTaskButton.DialogResult = DialogResult.Cancel;
            EditCancelTaskButton.Location = new Point(254, 198);
            EditCancelTaskButton.Name = "EditCancelTaskButton";
            EditCancelTaskButton.Size = new Size(132, 46);
            EditCancelTaskButton.TabIndex = 7;
            EditCancelTaskButton.Text = "Cancel";
            EditCancelTaskButton.UseVisualStyleBackColor = true;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 269);
            Controls.Add(EditCancelTaskButton);
            Controls.Add(EditConfirmTaskButton);
            Controls.Add(EditTaskDetailsBox);
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