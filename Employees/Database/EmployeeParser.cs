using System;
using System.Data.SQLite;

namespace Employees.Database
{
    class EmployeeParser : IParser<Employee>
    {
        public Employee Parse(SQLiteDataReader reader)
        {
            var id = Convert.ToInt32(reader["id"]);
            var name = reader["name"].ToString();
            Gender gender = (Gender)Enum.Parse(typeof(Gender), reader["gender"].ToString());
            var birthDate = reader["birthDate"].ToString();
            var subunitInt = Convert.ToInt32(reader["subunit"]);
            var subunit = Subunit.FirstSubunit;
            if (subunitInt == 2) subunit = Subunit.SecondSubunit;
            var jobTitle = Convert.ToInt32(reader["job"]);
         
            switch (jobTitle)
            {
                case 1:
                    var managerName = reader["managerName"].ToString();
                    var worker = new Worker(id, name, gender, birthDate, subunit, JobTitle.Worker, managerName);
                    return worker;
                case 2:
                    var conveyorNumber = Convert.ToInt32(reader["conveyorNumber"]);
                    var controller = new Controller(id, name, gender, birthDate, subunit, JobTitle.Controller, conveyorNumber);
                    return controller;
                case 3:
                    var subunitName = reader["subunitName"].ToString();
                    var manager = new Manager(id, name, gender, birthDate, subunit, JobTitle.Manager, subunitName);
                    return manager;
                case 4:
                    var cabinetNumber = Convert.ToInt32(reader["cabinetNumber"]);
                    var director = new Director(id, name, gender, birthDate, subunit, JobTitle.Director, cabinetNumber);
                    return director;
                default:
                    break;
            }
            return null;
        }
    }
}
