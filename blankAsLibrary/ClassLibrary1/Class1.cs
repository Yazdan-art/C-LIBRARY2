using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    // New non-generic static class
    public static class StringExtensions
    {
        public static bool StartWithUpper(this string? str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;
            char ch = str[0];

            return char.IsUpper(ch);
        }
    }
}