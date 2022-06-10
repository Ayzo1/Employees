namespace Employees
{
    public class Controller: Employee
    {
        public int ConveyorNumber { get; set; }

        public Controller(int id, string name, Gender gender, string birthDate, Subunit subunit, JobTitle jobTitle, int conveyorNumber) : base(id, name, gender, birthDate, subunit, jobTitle)
        {
            ConveyorNumber = conveyorNumber;
        }
    }
}
