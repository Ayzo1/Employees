using System.Collections.Generic;

namespace Employees
{
    interface IMainFormController
    {
        void Refresh();
        void Delete(int id);
        string[] GetJobtitles();
        string[] GetSubunits();
        string[] GetGenders();
        (int, string, string, string)[] GetEmployees(int firstSelect, int secondSelect);
        Employee GetEmployee(int id);
        (string, string) GetUniqEmployeeAttribute(int id);
        string GetAttributeName(int index);
        void ChangeEmployee(
            string id,
            string name,
            string date,
            string gender,
            string jobTitle,
            string subunit,
            string attribute);
        void AddEmployee(
            string name,
            string date,
            string gender,
            string jobTitle,
            string subunit,
            string attribute);

    }
}
