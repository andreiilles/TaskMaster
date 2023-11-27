namespace TaskMaster
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            LoginScreen();
        }
        public static void LoginScreen()
        {
            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                User loggedInUser = loginForm.LoggedInUser;
                loggedInMainWindow mainWindow = new loggedInMainWindow(loggedInUser);
                Application.Run(mainWindow);
            }
        }
        public static void Logout()
        {
            Application.Restart();
        }
    }
}