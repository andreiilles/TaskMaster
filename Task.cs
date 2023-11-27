namespace TaskMaster
{
    public class Task
    {
        public String Username { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deadline { get; set; }
        public bool Completed { get; set; }
        public bool Overdue
        {
            get
            {
                return Deadline < DateTime.Now;
            }
        }
        public Task(string username, string name, string description, int priority, DateTime deadline)
        {
            Username = username;
            Name = name;
            Description = description;
            Priority = priority;
            Created = DateTime.Now;
            Updated = DateTime.Now;
            Deadline = deadline;
            Completed = false;
        }
        public Task(string username, string name, string description, int priority, DateTime created, DateTime updated, DateTime deadline, bool completed)
        {
            Username = username;
            Name = name;
            Description = description;
            Priority = priority;
            Created = created;
            Updated = updated;
            Deadline = deadline;
            Completed = completed;
        }
    }
}
