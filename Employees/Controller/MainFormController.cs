using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Database;

namespace Employees
{
    class MainFormController: IMainFormController
    {
        private DatabaseManager databaseManager = new DatabaseManager();
        private List<Employee> employees;

        public MainFormController()
        {
            loadEmployees();
        }

        private void loadEmployees()
        {
            var loaded = databaseManager.GetEmployees();
            employees = loaded;
        }

        public void Refresh()
        {
            loadEmployees();
        }

        public (int, string, string, string)[] GetEmployees(int firstSelect, int secondSelect)
        {
            if (employees == null) return null;
            switch (firstSelect)
            {
                case 0:
                    return employees
                        .Select(e => (e.Id, e.Name, e.Gender.ToString(), e.BirthDate))
                        .ToArray();
                case 1:
                    return employees
                        .Where(e => (int)e.JobTitle == secondSelect + 1)
                        .Select(e => (e.Id, e.Name, e.Gender.ToString(), e.BirthDate))
                        .ToArray();
                case 2:
                    return employees
                        .Where(e => (int)e.Subunit == secondSelect + 1)
                        .Select(e => (e.Id, e.Name, e.Gender.ToString(), e.BirthDate))
                        .ToArray();
            }
            return null;
        }

        public string[] GetJobtitles()
        {
            string[] result = { "Рабочий", "Контролер", "Управляющий", "Директор" };
            return result;
        }

        public string[] GetSubunits()
        {
            string[] result = { "Первое подразделение", "Второе подразделение"};
            return result;
        }

        public string[] GetGenders()
        {
            string[] result = { "Мужчина", "Женщина" };
            return result;
        }

        public Employee GetEmployee(int id)
        {
            return employees.Where(e => e.Id == id).First();
        }

        public (string, string) GetUniqEmployeeAttribute(int id)
        {
            var employee = employees.Where(e => e.Id == id).First();

            switch (employee.JobTitle)
            {
                case JobTitle.Worker:
                    return ("Имя руководителя", ((Worker)employee).ManagerName);
                case JobTitle.Controller:
                    return ("Номер конвеера", ((Controller)employee).ConveyorNumber.ToString());
                case JobTitle.Manager:
                    return ("Название подразделения", ((Manager)employee).SubunitName);
                case JobTitle.Director:
                    return ("Номер кабинета", ((Director)employee).CabinetNumber.ToString());
            }
            return ("","");
        }

        public string GetAttributeName(int index)
        {
            var attributes = new string[] { "Имя руководителя", "Номер конвеера", "Название подразделения", "Номер кабинета" };
            return attributes[index];
        }

        public void ChangeEmployee(
            string id, 
            string name, 
            string date, 
            string gender, 
            string jobTitle,
            string subunit,
            string attribute)
        {
            var job = jobTitle.ToJobTitle();
           
            switch (job)
            {
                case JobTitle.Worker:
                    var worker = new Worker(Convert.ToInt32(id), name, gender.ToGender(), date, subunit.ToSubunit(), job, attribute);
                    ChangeEmployee(worker);
                    break;
                case JobTitle.Controller:
                    var controller = new Controller(Convert.ToInt32(id), name, gender.ToGender(), date, subunit.ToSubunit(), job, Convert.ToInt32(attribute));
                    ChangeEmployee(controller);
                    break;
                case JobTitle.Manager:
                    var manager = new Manager(Convert.ToInt32(id), name, gender.ToGender(), date, subunit.ToSubunit(), job, attribute);
                    ChangeEmployee(manager);
                    break;
                case JobTitle.Director:
                    var director = new Director(Convert.ToInt32(id), name, gender.ToGender(), date, subunit.ToSubunit(), job, Convert.ToInt32(attribute));
                    ChangeEmployee(director);
                    break;
            }
        }

        public void AddEmployee(
            string name,
            string date,
            string gender,
            string jobTitle,
            string subunit,
            string attribute)
        {
            var job = jobTitle.ToJobTitle();

            switch (job)
            {
                case JobTitle.Worker:
                    var worker = new Worker(0, name, gender.ToGender(), date, subunit.ToSubunit(), job, attribute);
                    CreateEmployee(worker);
                    break;
                case JobTitle.Controller:
                    var controller = new Controller(0, name, gender.ToGender(), date, subunit.ToSubunit(), job, Convert.ToInt32(attribute));
                    CreateEmployee(controller);
                    break;
                case JobTitle.Manager:
                    var manager = new Manager(0, name, gender.ToGender(), date, subunit.ToSubunit(), job, attribute);
                    CreateEmployee(manager);
                    break;
                case JobTitle.Director:
                    var director = new Director(0, name, gender.ToGender(), date, subunit.ToSubunit(), job, Convert.ToInt32(attribute));
                    CreateEmployee(director);
                    break;
            }
        }

        async void CreateEmployee(Employee employee)
        {
            await Task.Run(() =>
            {
                lock (databaseManager)
                {
                    databaseManager.CreateEmployee(employee);
                }
            });
        }

        async void DeleteEmployee(int id)
        {
            await Task.Run(() =>
            {
                lock (databaseManager)
                {
                    databaseManager.DeleteEmployee(id);
                }
            });
        }

        async void ChangeEmployee(Employee employee)
        {
            await Task.Run(() =>
            {
                lock (databaseManager)
                {
                    databaseManager.ChangeEmployee(employee);
                }
            });
        }

        public void Delete(int id)
        {
            DeleteEmployee(id);
        }
    }
}
