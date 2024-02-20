using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster
{
    public class DBConn
    {
        private const string DatabaseFilename = "taskMasterMain.accdb";
        public static string GetDatabasePath()
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string databasePath = Path.Combine(executablePath, DatabaseFilename);

            return databasePath;
        }
    }
}
