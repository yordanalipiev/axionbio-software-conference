using Challenge;

namespace Tests;

public class AnagramCheckerTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseValidDataSource))]
    public void AreAnagrams_ForAnagramStrings_ShouldReturnTrue(string first, string second)
    {
        var calculator = new AnagramChecker();

        Assert.That(calculator.AreAnagrams(first, second), Is.True);
    }

    [Test]
    [TestCaseSource(nameof(TestCaseInvalidDataSource))]
    public void AreAnagrams_ForRandomStrings_ShouldReturnFalse(string first, string second)
    {
        var calculator = new AnagramChecker();

        Assert.That(calculator.AreAnagrams(first, second), Is.False);
    }

    private static IEnumerable<TestCaseData> TestCaseValidDataSource()
    {
        return new List<TestCaseData>()
        {
            new TestCaseData("Listen", "Silent"),
            new TestCaseData("Dormitory", "Dirty room"),
            new TestCaseData("The eyes", "They see"),
        };
    }
    
    private static IEnumerable<TestCaseData> TestCaseInvalidDataSource()
    {
        return new List<TestCaseData>()
        {
            new TestCaseData("Hello", "World"),
            new TestCaseData("Test", "Taste"),
            new TestCaseData("abc", "def"),
        };
    }
}
