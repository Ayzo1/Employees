namespace Employees
{
    class Manager: Employee
    {
        public string SubunitName { get; set; }

        public Manager(int id, string name, Gender gender, string birthDate, int subunit, JobTitle jobTitle, string subunitName) : base(id, name, gender, birthDate, subunit, jobTitle)
        {
            SubunitName = subunitName;
        }
    }
}
