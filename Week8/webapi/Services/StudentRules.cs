public static class StudentRules
{
    public static bool IsSpecial(Student student) => student.EmailAddress.StartsWith(specialKey);

    public static string specialKey = "j";
}