using System.Data.SQLite;
using System.Collections.Generic;

namespace Employees.Database
{
    class DatabaseManager
    {
        private readonly IDatabase databaseObject;

        public DatabaseManager()
        {
            databaseObject = new Database();
        }

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            var query = "SELECT * FROM employee";
            var selectAllCommand = new SQLiteCommand(query, databaseObject.Connection);
            databaseObject.OpenConnection();
            var result = selectAllCommand.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    var parser = new EmployeeParser();
                    var employee = parser.Parse(result);
                    employees.Add(employee);
                }
            }
            databaseObject.CloseConnection();
            return employees;
        }

        public void ChangeEmployee(Employee employee)
        {
            var query = "UPDATE employee SET " +
                $"name = @name, subunit = @subunit, job = @job WHERE id = { employee.Id }";
            databaseObject.OpenConnection();
            var createCommand = new SQLiteCommand(query, databaseObject.Connection);
            createCommand.Parameters.AddWithValue("@name", employee.Name);
            createCommand.Parameters.AddWithValue("@subunit", "1");
            createCommand.Parameters.AddWithValue("@job", ((int)employee.JobTitle));
            
            switch (employee.JobTitle)
            {
                case JobTitle.Worker:
                    var worker = (Worker)employee;
                    createCommand.Parameters.AddWithValue("@managerName", worker.ManagerName);
                    createCommand.Parameters.AddWithValue("@subunitName", null);
                    createCommand.Parameters.AddWithValue("@conveyorNumber", null);
                    break;
                case JobTitle.Controller:
                    var controller = (Controller)employee;
                    createCommand.Parameters.AddWithValue("@conveyorNumber", controller.ConveyorNumber);
                    createCommand.Parameters.AddWithValue("@managerName", null);
                    createCommand.Parameters.AddWithValue("@subunitName", null);
                    break;
                case JobTitle.Manager:
                    var manager = (Manager)employee;
                    createCommand.Parameters.AddWithValue("@subunitName", manager.SubunitName);
                    createCommand.Parameters.AddWithValue("@managerName", null);
                    createCommand.Parameters.AddWithValue("@conveyorNumber", null);
                    break;
                case JobTitle.Director:
                    break;
            }
            
            var result = createCommand.ExecuteNonQuery();
            databaseObject.CloseConnection();
        }

        public void DeleteEmployee(int id)
        {
            var query = $@"DELETE FROM employee WHERE id = {id}";
            var deleteCommand = new SQLiteCommand(query, databaseObject.Connection);
            databaseObject.OpenConnection();
            var result = deleteCommand.ExecuteNonQuery();
            databaseObject.CloseConnection();
        }

        public void CreateEmployee(Employee employee)
        {
            var query = "INSERT INTO employee " +
                "(name, gender, birthDate, subunit, job, managerName, subunitName, conveyorNumber)" +
                "VALUES (@name, @gender, @birthDate, @subunit, @job, @managerName, @subunitName, @conveyorNumber)";
            databaseObject.OpenConnection();
            var createCommand = new SQLiteCommand(query, databaseObject.Connection);
            createCommand.Parameters.AddWithValue("@name", employee.Name);
            createCommand.Parameters.AddWithValue("@gender", employee.Gender.ToString());
            createCommand.Parameters.AddWithValue("@birthDate", employee.BirthDate);
            createCommand.Parameters.AddWithValue("@subunit", "1");
            createCommand.Parameters.AddWithValue("@job", ((int)employee.JobTitle));
            switch (employee.JobTitle)
            {
                case JobTitle.Worker:
                    var worker = (Worker)employee;
                    createCommand.Parameters.AddWithValue("@managerName", worker.ManagerName);
                    createCommand.Parameters.AddWithValue("@subunitName", null);
                    createCommand.Parameters.AddWithValue("@conveyorNumber", null);
                    break;
                case JobTitle.Controller:
                    var controller = (Controller)employee;
                    createCommand.Parameters.AddWithValue("@conveyorNumber", controller.ConveyorNumber);
                    createCommand.Parameters.AddWithValue("@managerName", null);
                    createCommand.Parameters.AddWithValue("@subunitName", null);
                    break;
                case JobTitle.Manager:
                    var manager = (Manager)employee;
                    createCommand.Parameters.AddWithValue("@subunitName", manager.SubunitName);
                    createCommand.Parameters.AddWithValue("@managerName", null);
                    createCommand.Parameters.AddWithValue("@conveyorNumber", null);
                    break;
                case JobTitle.Director:
                    break;
            }
            var result = createCommand.ExecuteNonQuery();
            databaseObject.CloseConnection();
        }
    }
}
