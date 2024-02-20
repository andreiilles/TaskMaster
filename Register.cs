using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMaster
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        /*private User registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

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
                        MessageBox.Show("User already exists!");
                        return;
                    }
                    else
                    {
                        Messa
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
        }*/
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
