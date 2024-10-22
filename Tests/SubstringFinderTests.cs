using Challenge;

namespace Tests;

public class SubstringFinderTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseDataSource))]
    public void LengthOfLongestSubstring_ShouldReturnCorrectValue(int expected, string input)
    {
        var calculator = new SubstringFinder();

        Assert.That(calculator.LengthOfLongestSubstring(input), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> TestCaseDataSource()
    {
        return new List<TestCaseData>()
        {
            new TestCaseData(3, "abcabcbb"),
            new TestCaseData(1,"bbbbb"),
            new TestCaseData(3, "pwwkew"),
            new TestCaseData(0, "")
        };
    }
}
