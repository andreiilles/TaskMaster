using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

namespace TaskMaster
{
    public partial class loggedInMainWindow : Form
    {
        private List<Task> tasks;
        /* De implementat
            private int TotalTaskCount = 0;
            private int CompletedTaskCount = 0;
            private int OverdueTaskCount = 0;
            private int CompletedOverdueTaskCount = 0;
            private int CompletedOnTimeTaskCount = 0;
            private int IncompleteOverdueTaskCount = 0;
            private int TasksDueTodayCount = 0;
            private int TasksDueTomorrowCount = 0;
            private int TasksDueThisWeekCount = 0;
            private int TasksDueThisMonthCount = 0;
        */

        private Dictionary<string, SortOrder> columnSortOrder = new Dictionary<string, SortOrder>();
        public loggedInMainWindow(User newlyLoggedInUser)
        {
            InitializeComponent();
            loggedInUser = newlyLoggedInUser;
            this.Text = loggedInUser.Username + "'s Task Master";
            this.MaximizeBox = false;
            tasks = GetTasks(loggedInUser.Username);
            taskDataGridView.DataSource = tasks;
            ConfigureDataGridViewColumns();
            AlertIfTaskDueTomorrow();

            taskDataGridView.ColumnHeaderMouseClick += TaskDataGridView_ColumnHeaderMouseClick;
        }
        private void TaskDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = taskDataGridView.Columns[e.ColumnIndex];
            SortTasks(clickedColumn.Name);
            taskDataGridView.DataSource = null;
            taskDataGridView.DataSource = tasks;
            taskDataGridView.Refresh();
            ConfigureDataGridViewColumns();
        }
        private void SortTasks(string columnName)
        {
            if (!columnSortOrder.ContainsKey(columnName))
            {
                columnSortOrder[columnName] = SortOrder.Ascending;
            }
            else
            {
                columnSortOrder[columnName] = (columnSortOrder[columnName] == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            switch (columnName)
            {
                case "Name":
                    if (columnSortOrder[columnName] == SortOrder.Ascending)
                    {
                        tasks = tasks.OrderBy(task => task.Name).ToList();
                    }
                    else
                    {
                        tasks = tasks.OrderByDescending(task => task.Name).ToList();
                    }
                    break;
                case "Description":
                    if (columnSortOrder[columnName] == SortOrder.Ascending)
                    {
                        tasks = tasks.OrderBy(task => task.Description).ToList();
                    }
                    else
                    {
                        tasks = tasks.OrderByDescending(task => task.Description).ToList();
                    }
                    break;
                case "Deadline":
                    if (columnSortOrder[columnName] == SortOrder.Ascending)
                    {
                        tasks = tasks.OrderBy(task => task.Deadline).ToList();
                    }
                    else
                    {
                        tasks = tasks.OrderByDescending(task => task.Deadline).ToList();
                    }
                    break;
                case "Priority":
                    if (columnSortOrder[columnName] == SortOrder.Ascending)
                    {
                        tasks = tasks.OrderBy(task => task.Priority).ToList();
                    }
                    else
                    {
                        tasks = tasks.OrderByDescending(task => task.Priority).ToList();
                    }
                    break;
                case "Created":
                    if (columnSortOrder[columnName] == SortOrder.Ascending)
                    {
                        tasks = tasks.OrderBy(task => task.Created).ToList();
                    }
                    else
                    {
                        tasks = tasks.OrderByDescending(task => task.Created).ToList();
                    }
                    break;
                case "Updated":
                    if (columnSortOrder[columnName] == SortOrder.Ascending)
                    {
                        tasks = tasks.OrderBy(task => task.Updated).ToList();
                    }
                    else
                    {
                        tasks = tasks.OrderByDescending(task => task.Updated).ToList();
                    }
                    break;
                case "Completed":
                    if (columnSortOrder[columnName] == SortOrder.Ascending)
                    {
                        tasks = tasks.OrderBy(task => task.Completed).ToList();
                    }
                    else
                    {
                        tasks = tasks.OrderByDescending(task => task.Completed).ToList();
                    }
                    break;
                case "Overdue":
                    if (columnSortOrder[columnName] == SortOrder.Ascending)
                    {
                        tasks = tasks.OrderBy(task => task.Overdue).ToList();
                    }
                    else
                    {
                        tasks = tasks.OrderByDescending(task => task.Overdue).ToList();
                    }
                    break;
                default:
                    break;
            }
        }
        private List<Task> GetTasks(string Name)
        {
            LoadTasks loadTasks = new LoadTasks();
            return loadTasks.GetTasksForCurrentUser(Name);
        }
        private void ConfigureDataGridViewColumns()
        {
            foreach (DataGridViewColumn column in taskDataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.ReadOnly = true;
            }
            foreach (DataGridViewRow row in taskDataGridView.Rows)
            {
                if (row.Cells["Overdue"].Value.ToString() == "True")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (row.Cells["Completed"].Value.ToString() == "True")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            OpenAddTaskWindow(loggedInUser);
        }
        private void OpenAddTaskWindow(User loggedInUser)
        {
            string currentUser = loggedInUser.Username;
            using (addTask addTask = new addTask(currentUser))
            {
                addTask.ShowDialog();
                if (addTask.DialogResult == DialogResult.OK)
                {
                    Task newTask = addTask.newTask;
                    tasks.Add(newTask);
                    taskDataGridView.DataSource = null;
                    taskDataGridView.DataSource = tasks;
                    taskDataGridView.Refresh();
                    ConfigureDataGridViewColumns();
                }
                else
                {
                    MessageBox.Show("Task not added.");
                }
            }
        }
        private void SaveTasksToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTasks saveTasks = new SaveTasks();
            saveTasks.SaveTaskList(tasks);
        }
        private void LoggedInMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save your tasks?", "Save Tasks", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SaveTasks saveTasks = new SaveTasks();
                saveTasks.SaveTaskList(tasks);
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        public void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {

                Program.Logout();

            }
            else if (confirm == DialogResult.Cancel)
            {
                return;
            }
        }
        private string GetSelectedTaskName()
        {
            if (taskDataGridView.CurrentCell != null && taskDataGridView.CurrentCell.RowIndex != -1)
            {
                return taskDataGridView.Rows[taskDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
            return null;
        }
        private void MarkTaskAsComplete(string Taskname)
        {
            foreach (Task task in tasks)
            {
                if (task.Name == Taskname)
                {
                    task.Completed = true;
                    taskDataGridView.DataSource = null;
                    taskDataGridView.DataSource = tasks;
                    taskDataGridView.Refresh();
                    ConfigureDataGridViewColumns();
                    return;
                }
            }
        }
        private void DeleteTask(string Taskname)
        {
            Task taskToRemove = tasks.FirstOrDefault(task => task.Name == Taskname);

            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                taskDataGridView.DataSource = null;
                taskDataGridView.DataSource = tasks;
                taskDataGridView.Refresh();
                ConfigureDataGridViewColumns();

                DeleteTaskFromDatabase(taskToRemove);
            }
        }
        private void DeleteTaskFromDatabase(Task task)
        {
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\OneDrive\\OneDrive - e-uvt.ro\\Proiect Individual\\TaskMaster\\bin\\Debug\\net6.0-windows\\taskMasterMain.accdb";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Tasks WHERE taskName = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", task.Name);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void MarkAsCompleteButton_Click(object sender, EventArgs e)
        {
            MarkTaskAsComplete(GetSelectedTaskName());
        }
        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            DeleteTask(GetSelectedTaskName());
            MessageBox.Show("Task deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadTasksFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tasks = GetTasks(loggedInUser.Username);
            taskDataGridView.DataSource = tasks;
            ConfigureDataGridViewColumns();
        }
        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            EditTask editTask = new EditTask(GetSelectedTaskName(), tasks);
            if (DialogResult.OK == editTask.ShowDialog())
            {
                taskDataGridView.DataSource = null;
                taskDataGridView.DataSource = tasks;
                taskDataGridView.Refresh();
                ConfigureDataGridViewColumns();
                MessageBox.Show("Task edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AlertIfTaskDueTomorrow()
        {
            foreach (Task task in tasks)
            {
                if (task.Deadline.Date == DateTime.Now.Date.AddDays(1))
                {
                    MessageBox.Show("You have a task due tomorrow: " + task.Name, "Upcoming Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private List<Task> GetTasksDueTomorrow(List<Task> tasks)
        {
            List<Task> tasksDueTomorrow = new List<Task>();
            foreach (Task task in tasks)
            {
                if (task.Deadline.Date == DateTime.Now.Date.AddDays(1))
                {
                    tasksDueTomorrow.Add(task);
                }
            }
            return tasksDueTomorrow;
        }
        private List<Task> GetTasksDueThisWeek(List<Task> tasks)
        {
            List<Task> tasksDueThisWeek = new List<Task>();
            foreach (Task task in tasks)
            {
                if (task.Deadline.Date >= DateTime.Now.Date && task.Deadline.Date <= DateTime.Now.Date.AddDays(7))
                {
                    tasksDueThisWeek.Add(task);
                }
            }
            return tasksDueThisWeek;
        }
        private List<Task> GetTasksDueThisMonth(List<Task> tasks)
        {
            List<Task> tasksDueThisMonth = new List<Task>();
            foreach (Task task in tasks)
            {
                if (task.Deadline.Date.Month == DateTime.Now.Date.Month)
                {
                    tasksDueThisMonth.Add(task);
                }
            }
            return tasksDueThisMonth;
        }
        private void ViewTasksDueTomorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Task> TasksDueTomorrow = GetTasksDueTomorrow(tasks);
            taskDataGridView.DataSource = null;
            taskDataGridView.DataSource = TasksDueTomorrow;
            taskDataGridView.Refresh();
            ConfigureDataGridViewColumns();
        }
        private void ViewTasksDueThisWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Task> TasksDueThisWeek = GetTasksDueThisWeek(tasks);
            taskDataGridView.DataSource = null;
            taskDataGridView.DataSource = TasksDueThisWeek;
            taskDataGridView.Refresh();
            ConfigureDataGridViewColumns();
        }
        private void ViewTasksDueThisMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Task> TasksDueThisMonth = GetTasksDueThisMonth(tasks);
            taskDataGridView.DataSource = null;
            taskDataGridView.DataSource = TasksDueThisMonth;
            taskDataGridView.Refresh();
            ConfigureDataGridViewColumns();
        }
        private void ViewAllTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskDataGridView.DataSource = null;
            taskDataGridView.DataSource = tasks;
            taskDataGridView.Refresh();
            ConfigureDataGridViewColumns();
        }
        private void GetTaskStatistics()
        {
            TotalTaskCount = tasks.Count;
            CompletedTaskCount = tasks.Count(task => task.Completed == true);
            OverdueTaskCount = tasks.Count(task => task.Overdue == true);
            CompletedOverdueTaskCount = tasks.Count(task => task.Completed == true && task.Overdue == true);
            CompletedOnTimeTaskCount = tasks.Count(task => task.Completed == true && task.Overdue == false);
            IncompleteOverdueTaskCount = tasks.Count(task => task.Completed == false && task.Overdue == true);
            TasksDueTodayCount = tasks.Count(task => task.Deadline.Date == DateTime.Now.Date);
            TasksDueTomorrowCount = tasks.Count(task => task.Deadline.Date == DateTime.Now.Date.AddDays(1));
            TasksDueThisWeekCount = tasks.Count(task => task.Deadline.Date >= DateTime.Now.Date && task.Deadline.Date <= DateTime.Now.Date.AddDays(7));
            TasksDueThisMonthCount = tasks.Count(task => task.Deadline.Date.Month == DateTime.Now.Date.Month);
        }
        private void ExportTasksToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToCSVFileDialog.Filter = "CSV files (*.csv)|*.csv";
            ExportToCSVFileDialog.Title = "Export Tasks to CSV";
            ExportToCSVFileDialog.ShowDialog();
            if (ExportToCSVFileDialog.FileName != "")
            {
                SaveTasks saveTasks = new SaveTasks();
                saveTasks.ExportTasksToCSV(tasks, ExportToCSVFileDialog.FileName);
            }
        }
    }
}
