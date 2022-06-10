namespace Employees
{
    public enum JobTitle
    {
        Worker = 1,
        Controller = 2,
        Manager = 3,
        Director = 4,
    }

    public static class JobTitleExtension
    {
        public static string ToRusString(this JobTitle jobTitle)
        {
            switch (jobTitle)
            {
                case JobTitle.Worker:
                    return "Рабочий";
                case JobTitle.Controller:
                    return "Контролер";
                case JobTitle.Manager:
                    return "Управляющий";
                case JobTitle.Director:
                    return "Директор";
            }
            return "";
        }

        public static JobTitle ToJobTitle(this string str)
        {
            switch (str)
            {
                case "Рабочий":
                    return JobTitle.Worker;
                case "Контролер":
                    return JobTitle.Controller;
                case "Управляющий":
                    return JobTitle.Manager;
                case "Директор":
                    return JobTitle.Director;
            }
            throw new System.Exception();
        }
    }
}
