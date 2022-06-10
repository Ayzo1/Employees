namespace Employees
{
    public class Worker: Employee
    {
        public string ManagerName { get; set; }

        public Worker(int id, string name, Gender gender, string birthDate, Subunit subunit, JobTitle jobTitle, string managerName) : base(id, name, gender, birthDate, subunit, jobTitle)
        {
            ManagerName = managerName;
        }
    }
}
