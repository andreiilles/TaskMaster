using System.Data.OleDb;

namespace TaskMaster
{
    internal class LoadTasks
    {
        private string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\OneDrive\\OneDrive - e-uvt.ro\\Proiect Individual\\TaskMaster\\bin\\Debug\\net6.0-windows\\taskMasterMain.accdb";
        public List<Task> GetTasksForCurrentUser(string currentUser)
        {
            List<Task> tasks = new List<Task>();
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Tasks WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", currentUser);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string Username = reader.GetString(0);
                    string Name = reader.GetString(1);
                    string Description = reader.GetString(2);
                    int Priority = reader.GetInt32(3);
                    DateTime Created = reader.GetDateTime(4);
                    DateTime Updated = reader.GetDateTime(5);
                    DateTime Deadline = reader.GetDateTime(6);
                    bool Completed = reader.GetBoolean(7);
                    tasks.Add(new Task(Username, Name, Description, Priority, Created, Updated, Deadline, Completed));
                }
            }
            return tasks;
        }
    }
}
