namespace Employees
{
    public abstract class Employee
    {
        public int Id { get; }
        public string Name { get; set; }
        public Gender Gender { get; }
        public string BirthDate { get; }
        public Subunit Subunit { get; set; }
        public JobTitle JobTitle { get; set; }

        public Employee(
            int id, 
            string name, 
            Gender gender, 
            string birthDate, 
            Subunit subunit, 
            JobTitle jobTitle)
        {
            Id = id;
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Subunit = subunit;
            JobTitle = jobTitle;
        }
    }
}
