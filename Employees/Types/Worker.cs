namespace Employees
{
    class Worker: Employee
    {
        public string ManagerName { get; set; }

        public Worker(int id, string name, Gender gender, string birthDate, int subunit, JobTitle jobTitle, string managerName) : base(id, name, gender, birthDate, subunit, jobTitle)
        {
            ManagerName = managerName;
        }
    }
}
