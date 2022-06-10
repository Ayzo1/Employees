namespace Employees
{
    public enum Gender
    {
        M, F,
    }

    public static class GenderExtension
    {
        public static string ToRusString(this Gender gender)
        {
            switch (gender)
            {
                case Gender.F:
                    return "Женщина";
                case Gender.M:
                    return "Мужчина";
            }
            return "";
        }

        public static Gender ToGender(this string str)
        {
            switch (str)
            {
                case "Женщина":
                    return Gender.F;
                case "Мужчина":
                    return Gender.M;
                case "M":
                    return Gender.M;
                case "F":
                    return Gender.F;
            }
            throw new System.Exception();
        }
    }
}
