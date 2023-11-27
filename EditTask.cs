using System.Data.OleDb;

namespace TaskMaster
{
    public partial class EditTask : Form
    {
        string taskname;
        List<Task> tasks;
        public EditTask(string Taskname, List<Task> Tasks)
        {
            InitializeComponent();
            Task TaskToEdit = Tasks.FirstOrDefault(task => task.Name == Taskname);
            taskname = Taskname;
            tasks = Tasks;
            this.EditTaskDeadlineDatePicker.Value = TaskToEdit.Deadline;
            this.EditTaskDescriptionTextbox.Text = TaskToEdit.Description;
            this.EditTaskPriorityPicker.Value = TaskToEdit.Priority;
        }
        public void EditSelectedTask(string Taskname, List<Task> Tasks)
        {
            Task TaskToEdit = Tasks.FirstOrDefault(task => task.Name == Taskname);

            if (TaskToEdit != null)
            {
                TaskToEdit.Description = EditTaskDescriptionTextbox.Text;
                TaskToEdit.Deadline = EditTaskDeadlineDatePicker.Value;
                TaskToEdit.Priority = (int)EditTaskPriorityPicker.Value;
                UpdateTaskInDatabase(TaskToEdit);
            }
            DialogResult = DialogResult.OK;
        }
        private void UpdateTaskInDatabase(Task task)
        {
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\OneDrive\\OneDrive - e-uvt.ro\\Proiect Individual\\TaskMaster\\bin\\Debug\\net6.0-windows\\taskMasterMain.accdb";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                string query = @"UPDATE Tasks 
                                 SET Description = ?, Priority = ?, Updated = ?, Deadline = ?
                                 WHERE taskName = ?";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Add("?", OleDbType.VarChar).Value = task.Description;
                    command.Parameters.Add("?", OleDbType.Integer).Value = task.Priority;
                    command.Parameters.Add("?", OleDbType.Date).Value = task.Updated;
                    command.Parameters.Add("?", OleDbType.Date).Value = task.Deadline;
                    command.Parameters.Add("?", OleDbType.VarChar).Value = task.Name;

                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); };
                }
            }
        }
        private void EditConfirmTaskButton_Click(object sender, EventArgs e)
        {
            EditSelectedTask(taskname, tasks);
        }
    }
}
