namespace TestsWithCode
{
    public static class StringExtension
    {
        public static string Prefix(this string input, char prefix) => string.Concat(prefix, input);
    }
}