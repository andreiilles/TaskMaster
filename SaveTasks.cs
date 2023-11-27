using CsvHelper;
using System.Data.OleDb;
using System.Globalization;

namespace TaskMaster
{
    public class SaveTasks
    {
        private string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\OneDrive\\OneDrive - e-uvt.ro\\Proiect Individual\\TaskMaster\\bin\\Debug\\net6.0-windows\\taskMasterMain.accdb";
        public void SaveTaskList(List<Task> tasks)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                foreach (Task task in tasks)
                {
                    if (TaskExists(connection, task))
                    {
                        UpdateTask(connection, task);
                    }
                    else
                    {
                        InsertTask(connection, task);
                    }
                }
            }
            MessageBox.Show("Tasks saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ExportTasksToCSV(List<Task> tasks, string FilePath)
        {
            try
            {
                using (var writer = new StreamWriter(FilePath)) 
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(tasks);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool TaskExists(OleDbConnection connection, Task task)
        {
            string query = "SELECT COUNT(*) FROM Tasks WHERE Username = ? AND taskName = ?";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("?", task.Username);
                command.Parameters.AddWithValue("?", task.Name);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void InsertTask(OleDbConnection connection, Task task)
        {
            string query = "INSERT INTO Tasks (Username, taskName, Description, Priority, Created, Updated, Deadline, Complete) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {

                command.Parameters.Add("?", OleDbType.VarChar).Value = task.Username;
                command.Parameters.Add("?", OleDbType.VarChar).Value = task.Name;
                command.Parameters.Add("?", OleDbType.VarChar).Value = task.Description;
                command.Parameters.Add("?", OleDbType.Integer).Value = task.Priority;
                command.Parameters.Add("?", OleDbType.Date).Value = task.Created;
                command.Parameters.Add("?", OleDbType.Date).Value = task.Updated;
                command.Parameters.Add("?", OleDbType.Date).Value = task.Deadline;
                command.Parameters.Add("?", OleDbType.Boolean).Value = task.Completed;
                try { command.ExecuteNonQuery(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }

        private void UpdateTask(OleDbConnection connection, Task task)
        {
            bool completed = task.Completed;
            string query = "UPDATE Tasks SET Description = ?, Priority = ?, Updated = ?, Deadline = ?, Complete = ? WHERE Username = ? AND taskName = ?";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.Add("?", OleDbType.VarChar).Value = task.Description;
                command.Parameters.Add("?", OleDbType.Integer).Value = task.Priority;
                command.Parameters.Add("?", OleDbType.Date).Value = task.Updated;
                command.Parameters.Add("?", OleDbType.Date).Value = task.Deadline;
                command.Parameters.Add("?", OleDbType.Boolean).Value = completed;
                command.Parameters.Add("?", OleDbType.VarChar).Value = task.Username;
                command.Parameters.Add("?", OleDbType.VarChar).Value = task.Name;


                try { command.ExecuteNonQuery(); }
                catch (Exception ex) { };
            }
        }
    }
}