namespace TaskMaster
{
    public partial class addTask : Form
    {
        private string currentUser;
        public Task newTask { get; set; }
        public addTask(string Username)
        {
            InitializeComponent();
            currentUser = Username;
            this.FormClosing += AddTask_FormClosing;
            this.taskDeadlineDatePicker.MinDate = DateTime.Now.AddDays(1);
            newTask = null;
        }

        private bool allowFormClose = true;
        public void AcceptNewTask_Click(object sender, EventArgs e)
        {
            if (taskNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter a task name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allowFormClose = false;
            }
            else if (taskDescriptionTextbox.Text == "")
            {
                MessageBox.Show("Please enter a task description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allowFormClose = false;
            }
            else if (taskDeadlineDatePicker.Value < DateTime.Now)
            {
                MessageBox.Show("Please enter a valid deadline.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allowFormClose = false;
            }
            else
            {
                string newTaskName = taskNameTextbox.Text;
                string newTaskDescription = taskDescriptionTextbox.Text;
                int newTaskPriority = Convert.ToInt32(taskPriorityPicker.Value);
                DateTime newTaskDeadline = taskDeadlineDatePicker.Value;

                newTask = new Task(currentUser, newTaskName, newTaskDescription, newTaskPriority, newTaskDeadline);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void AddTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowFormClose)
            {
                e.Cancel = true;
                allowFormClose = true;
            }
        }
    }
}
