using Xunit;

namespace TestsWithCode
{
    public class StringExtensionTests
    {
        [Theory]
        [InlineData("Hello", '$', "$Hello")]
        public void Test_StringExtension_Replace(string input, char prefix, string expected)
        {
            var actual = input.Prefix(prefix);
            Assert.Equal(expected, actual);
        }
    }
}
