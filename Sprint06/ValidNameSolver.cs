using System.Text.RegularExpressions;

namespace Sprint06
{
    public class ValidNameSolver
    {
        private static string[] patterns =
        {
            @"^[A-Z]. [A-Z][a-z]+$",
            @"^[A-Z]. [A-Z]. [A-Z][a-z]+$",
            @"^[A-Z][a-z]+ [A-Z]. [A-Z][a-z]+$",
            @"^[A-Z][a-z]+ [A-Z][a-z]+ [A-Z][a-z]+$",
        };

        public static bool IsValidName(string str)
        {
            for (int i = 0; i < patterns.Length; i++)
            {
                if (Regex.IsMatch(str, patterns[i]))
                    return true;
            }
            return false;
        }
    }
}