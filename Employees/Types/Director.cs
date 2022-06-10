namespace Employees
{ 
    public class Director: Employee
    {
        public int CabinetNumber { get; set; }

        public Director(int id, string name, Gender gender, string birthDate, Subunit subunit, JobTitle jobTitle, int cabinetNumber) : base(id, name, gender, birthDate, subunit, jobTitle)
        {
            CabinetNumber = cabinetNumber;
        }
    }
}
