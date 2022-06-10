using System.Data.SQLite;
using System.IO;
using System;

namespace Employees.Database
{
    class Database: IDatabase
    {
        public SQLiteConnection Connection { get; }

        public Database() 
        {
            var a = $"{AppDomain.CurrentDomain.BaseDirectory}";
            Connection = new SQLiteConnection($"Data Source={AppDomain.CurrentDomain.BaseDirectory}database.sqlite3");
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
