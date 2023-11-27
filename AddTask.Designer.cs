namespace TaskMaster
{
    partial class addTask
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
            taskDetailsBox = new GroupBox();
            label3 = new Label();
            taskDeadlineDatePicker = new DateTimePicker();
            taskPriorityPicker = new NumericUpDown();
            label2 = new Label();
            taskDescriptionTextbox = new TextBox();
            label1 = new Label();
            taskNameTextbox = new TextBox();
            labelTaskName = new Label();
            acceptNewTask = new Button();
            cancelNewTask = new Button();
            taskDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskPriorityPicker).BeginInit();
            SuspendLayout();
            // 
            // taskDetailsBox
            // 
            taskDetailsBox.Controls.Add(label3);
            taskDetailsBox.Controls.Add(taskDeadlineDatePicker);
            taskDetailsBox.Controls.Add(taskPriorityPicker);
            taskDetailsBox.Controls.Add(label2);
            taskDetailsBox.Controls.Add(taskDescriptionTextbox);
            taskDetailsBox.Controls.Add(label1);
            taskDetailsBox.Controls.Add(taskNameTextbox);
            taskDetailsBox.Controls.Add(labelTaskName);
            taskDetailsBox.Location = new Point(12, 12);
            taskDetailsBox.Name = "taskDetailsBox";
            taskDetailsBox.Size = new Size(558, 180);
            taskDetailsBox.TabIndex = 0;
            taskDetailsBox.TabStop = false;
            taskDetailsBox.Text = "New task details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 129);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Deadline:";
            // 
            // taskDeadlineDatePicker
            // 
            taskDeadlineDatePicker.Location = new Point(104, 123);
            taskDeadlineDatePicker.Name = "taskDeadlineDatePicker";
            taskDeadlineDatePicker.Size = new Size(200, 23);
            taskDeadlineDatePicker.TabIndex = 4;
            // 
            // taskPriorityPicker
            // 
            taskPriorityPicker.Location = new Point(104, 94);
            taskPriorityPicker.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            taskPriorityPicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            taskPriorityPicker.Name = "taskPriorityPicker";
            taskPriorityPicker.Size = new Size(58, 23);
            taskPriorityPicker.TabIndex = 3;
            taskPriorityPicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 96);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Task priority:";
            // 
            // taskDescriptionTextbox
            // 
            taskDescriptionTextbox.Location = new Point(104, 39);
            taskDescriptionTextbox.Multiline = true;
            taskDescriptionTextbox.Name = "taskDescriptionTextbox";
            taskDescriptionTextbox.Size = new Size(448, 49);
            taskDescriptionTextbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Task description:";
            // 
            // taskNameTextbox
            // 
            taskNameTextbox.Location = new Point(104, 14);
            taskNameTextbox.Name = "taskNameTextbox";
            taskNameTextbox.Size = new Size(448, 23);
            taskNameTextbox.TabIndex = 1;
            // 
            // labelTaskName
            // 
            labelTaskName.AutoSize = true;
            labelTaskName.Location = new Point(33, 17);
            labelTaskName.Name = "labelTaskName";
            labelTaskName.Size = new Size(65, 15);
            labelTaskName.TabIndex = 0;
            labelTaskName.Text = "Task name:";
            // 
            // acceptNewTask
            // 
            acceptNewTask.DialogResult = DialogResult.OK;
            acceptNewTask.Location = new Point(164, 202);
            acceptNewTask.Name = "acceptNewTask";
            acceptNewTask.Size = new Size(120, 47);
            acceptNewTask.TabIndex = 5;
            acceptNewTask.Text = "Accept";
            acceptNewTask.UseVisualStyleBackColor = true;
            acceptNewTask.Click += AcceptNewTask_Click;
            // 
            // cancelNewTask
            // 
            cancelNewTask.DialogResult = DialogResult.Cancel;
            cancelNewTask.Location = new Point(290, 202);
            cancelNewTask.Name = "cancelNewTask";
            cancelNewTask.Size = new Size(120, 47);
            cancelNewTask.TabIndex = 6;
            cancelNewTask.Text = "Cancel";
            cancelNewTask.UseVisualStyleBackColor = true;
            // 
            // addTask
            // 
            AcceptButton = acceptNewTask;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelNewTask;
            ClientSize = new Size(581, 261);
            Controls.Add(cancelNewTask);
            Controls.Add(acceptNewTask);
            Controls.Add(taskDetailsBox);
            Name = "addTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new task";
            taskDetailsBox.ResumeLayout(false);
            taskDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskPriorityPicker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox taskDetailsBox;
        private Label label3;
        private DateTimePicker taskDeadlineDatePicker;
        private NumericUpDown taskPriorityPicker;
        private Label label2;
        private TextBox taskDescriptionTextbox;
        private Label label1;
        private TextBox taskNameTextbox;
        private Label labelTaskName;
        private Button acceptNewTask;
        private Button cancelNewTask;
    }
}