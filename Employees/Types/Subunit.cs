namespace Employees
{
    public enum Subunit
    {
        FirstSubunit = 1,
        SecondSubunit = 2,
    }

    public static class SubunitExtension
    {
        public static string ToRusString(this Subunit subunit)
        {
            switch (subunit)
            {
                case Subunit.FirstSubunit:
                    return "Первое подразделение";
                case Subunit.SecondSubunit:
                    return "Второе подразделение";
            }
            return "";
        }

        public static Subunit ToSubunit(this string str)
        {
            switch (str)
            {
                case "Первое подразделение":
                    return Subunit.FirstSubunit;
                case "Второе подразделение":
                    return Subunit.SecondSubunit;
            }
            throw new System.Exception();
        }
    }
}
