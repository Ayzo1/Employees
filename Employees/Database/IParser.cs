using System.Data.SQLite;

namespace Employees.Database
{
    interface IParser<T>
    {
        T Parse(SQLiteDataReader reader);
    }
}
