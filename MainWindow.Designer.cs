namespace TaskMaster
{
    partial class loggedInMainWindow
    {
        private System.ComponentModel.IContainer components = null;

        public User loggedInUser;
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
            taskDataGridView = new DataGridView();
            addTaskButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadTasksFromDatabaseToolStripMenuItem = new ToolStripMenuItem();
            saveTasksToDatabaseToolStripMenuItem = new ToolStripMenuItem();
            ExportTasksToCSVToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            logOutButton = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            ViewTasksDueTomorrowToolStripMenuItem = new ToolStripMenuItem();
            ViewTasksDueInToolStripMenuItem = new ToolStripMenuItem();
            ViewTasksDueThisMonthToolStripMenuItem = new ToolStripMenuItem();
            ViewAllTasksToolStripMenuItem = new ToolStripMenuItem();
            MarkAsCompleteButton = new Button();
            DeleteTaskButton = new Button();
            EditTaskButton = new Button();
            ExportToCSVFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // taskDataGridView
            // 
            taskDataGridView.AllowUserToOrderColumns = true;
            taskDataGridView.BackgroundColor = SystemColors.GradientInactiveCaption;
            taskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskDataGridView.Location = new Point(12, 27);
            taskDataGridView.Name = "taskDataGridView";
            taskDataGridView.RowTemplate.Height = 25;
            taskDataGridView.Size = new Size(938, 439);
            taskDataGridView.TabIndex = 0;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(195, 472);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(132, 46);
            addTaskButton.TabIndex = 1;
            addTaskButton.Text = "Add new task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += AddTaskButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, userToolStripMenuItem, tasksToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(966, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadTasksFromDatabaseToolStripMenuItem, saveTasksToDatabaseToolStripMenuItem, ExportTasksToCSVToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadTasksFromDatabaseToolStripMenuItem
            // 
            loadTasksFromDatabaseToolStripMenuItem.Name = "loadTasksFromDatabaseToolStripMenuItem";
            loadTasksFromDatabaseToolStripMenuItem.Size = new Size(208, 22);
            loadTasksFromDatabaseToolStripMenuItem.Text = "Load tasks from database";
            loadTasksFromDatabaseToolStripMenuItem.Click += LoadTasksFromDatabaseToolStripMenuItem_Click;
            // 
            // saveTasksToDatabaseToolStripMenuItem
            // 
            saveTasksToDatabaseToolStripMenuItem.Name = "saveTasksToDatabaseToolStripMenuItem";
            saveTasksToDatabaseToolStripMenuItem.Size = new Size(208, 22);
            saveTasksToDatabaseToolStripMenuItem.Text = "Save tasks to database";
            saveTasksToDatabaseToolStripMenuItem.Click += SaveTasksToDatabaseToolStripMenuItem_Click;
            // 
            // ExportTasksToCSVToolStripMenuItem
            // 
            ExportTasksToCSVToolStripMenuItem.Name = "ExportTasksToCSVToolStripMenuItem";
            ExportTasksToCSVToolStripMenuItem.Size = new Size(208, 22);
            ExportTasksToCSVToolStripMenuItem.Text = "Export tasks to CSV";
            ExportTasksToCSVToolStripMenuItem.Click += ExportTasksToCSVToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutButton });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(42, 20);
            userToolStripMenuItem.Text = "User";
            // 
            // logOutButton
            // 
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(115, 22);
            logOutButton.Text = "Log out";
            logOutButton.Click += LogOutButton_Click;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewTasksDueTomorrowToolStripMenuItem, ViewTasksDueInToolStripMenuItem, ViewTasksDueThisMonthToolStripMenuItem, ViewAllTasksToolStripMenuItem });
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(46, 20);
            tasksToolStripMenuItem.Text = "Tasks";
            // 
            // ViewTasksDueTomorrowToolStripMenuItem
            // 
            ViewTasksDueTomorrowToolStripMenuItem.Name = "ViewTasksDueTomorrowToolStripMenuItem";
            ViewTasksDueTomorrowToolStripMenuItem.Size = new Size(212, 22);
            ViewTasksDueTomorrowToolStripMenuItem.Text = "View tasks due tomorrow";
            ViewTasksDueTomorrowToolStripMenuItem.Click += ViewTasksDueTomorrowToolStripMenuItem_Click;
            // 
            // ViewTasksDueInToolStripMenuItem
            // 
            ViewTasksDueInToolStripMenuItem.Name = "ViewTasksDueInToolStripMenuItem";
            ViewTasksDueInToolStripMenuItem.Size = new Size(212, 22);
            ViewTasksDueInToolStripMenuItem.Text = "View tasks due this week";
            // 
            // ViewTasksDueThisMonthToolStripMenuItem
            // 
            ViewTasksDueThisMonthToolStripMenuItem.Name = "ViewTasksDueThisMonthToolStripMenuItem";
            ViewTasksDueThisMonthToolStripMenuItem.Size = new Size(212, 22);
            ViewTasksDueThisMonthToolStripMenuItem.Text = "View tasks due this month";
            ViewTasksDueThisMonthToolStripMenuItem.Click += ViewTasksDueThisMonthToolStripMenuItem_Click;
            // 
            // ViewAllTasksToolStripMenuItem
            // 
            ViewAllTasksToolStripMenuItem.Name = "ViewAllTasksToolStripMenuItem";
            ViewAllTasksToolStripMenuItem.Size = new Size(212, 22);
            ViewAllTasksToolStripMenuItem.Text = "View all tasks";
            ViewAllTasksToolStripMenuItem.Click += ViewAllTasksToolStripMenuItem_Click;
            // 
            // MarkAsCompleteButton
            // 
            MarkAsCompleteButton.Location = new Point(333, 472);
            MarkAsCompleteButton.Name = "MarkAsCompleteButton";
            MarkAsCompleteButton.Size = new Size(132, 46);
            MarkAsCompleteButton.TabIndex = 3;
            MarkAsCompleteButton.Text = "Mark as complete";
            MarkAsCompleteButton.UseVisualStyleBackColor = true;
            MarkAsCompleteButton.Click += MarkAsCompleteButton_Click;
            // 
            // DeleteTaskButton
            // 
            DeleteTaskButton.Location = new Point(471, 472);
            DeleteTaskButton.Name = "DeleteTaskButton";
            DeleteTaskButton.Size = new Size(132, 46);
            DeleteTaskButton.TabIndex = 4;
            DeleteTaskButton.Text = "Delete task";
            DeleteTaskButton.UseVisualStyleBackColor = true;
            DeleteTaskButton.Click += DeleteTaskButton_Click;
            // 
            // EditTaskButton
            // 
            EditTaskButton.Location = new Point(609, 472);
            EditTaskButton.Name = "EditTaskButton";
            EditTaskButton.Size = new Size(132, 46);
            EditTaskButton.TabIndex = 5;
            EditTaskButton.Text = "Edit task";
            EditTaskButton.UseVisualStyleBackColor = true;
            EditTaskButton.Click += EditTaskButton_Click;
            // 
            // ExportToCSVFileDialog
            // 
            ExportToCSVFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
            ExportToCSVFileDialog.FileOk += ExportToCSVFileDialog_FileOk;
            // 
            // loggedInMainWindow
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(966, 609);
            Controls.Add(EditTaskButton);
            Controls.Add(DeleteTaskButton);
            Controls.Add(MarkAsCompleteButton);
            Controls.Add(addTaskButton);
            Controls.Add(taskDataGridView);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "loggedInMainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "|| TaskMaster ";
            FormClosing += LoggedInMainWindow_FormClosing;
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView taskDataGridView;
        private Button addTaskButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadTasksFromDatabaseToolStripMenuItem;
        private ToolStripMenuItem saveTasksToDatabaseToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem logOutButton;
        private Button MarkAsCompleteButton;
        private Button DeleteTaskButton;
        private Button EditTaskButton;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem ViewTasksDueTomorrowToolStripMenuItem;
        private ToolStripMenuItem ViewTasksDueInToolStripMenuItem;
        private ToolStripMenuItem ViewTasksDueThisMonthToolStripMenuItem;
        private ToolStripMenuItem ViewAllTasksToolStripMenuItem;
        private ToolStripMenuItem ExportTasksToCSVToolStripMenuItem;
        private SaveFileDialog ExportToCSVFileDialog;
    }
}