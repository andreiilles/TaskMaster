using System.Data.OleDb;

namespace TaskMaster
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public User LoggedInUser { get; private set; }
        public void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameBox.Text;
            String password = passwordBox.Text;

            if (!IsValidEmail(username))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            User loggedInUser = validateUser(username, password);

            if (loggedInUser != null)
            {
                LoggedInUser = loggedInUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }
        private User validateUser(String username, String password)
        {
            String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=taskMasterMain.accdb;";
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                connection.Open();
                String query = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "'";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        User loggedInUser = new User
                        {
                            Username = username,
                            Password = password
                        };
                        return loggedInUser;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}