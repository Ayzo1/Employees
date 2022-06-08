using System.Data.SQLite;

namespace Employees.Database
{
    interface IDatabase
    {
        SQLiteConnection Connection { get; }
        void OpenConnection();
        void CloseConnection();
    }
}
