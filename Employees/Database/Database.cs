using System.Data.SQLite;

namespace Employees.Database
{
    class Database: IDatabase
    {
        private readonly string fileName = "./database.sqlite3";
        public SQLiteConnection Connection { get; }

        public Database() 
        {
            Connection = new SQLiteConnection("Data Source=database.sqlite3");
        }

        public void OpenConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
