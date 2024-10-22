using Challenge;

namespace Tests;

public class DigitSumCalculatorTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseDataSource))]
    public void SumOfDigits_PositiveValue_ShouldReturnCorrectValue(int expected, int input)
    {
        var calculator = new DigitSumCalculator();

        Assert.That(calculator.SumOfDigits(input), Is.EqualTo(expected));
    }
    
    [Test]
    public void SumOfDigits_NegativeValue_ShouldThrowArgumentException()
    {
        var calculator = new DigitSumCalculator();

        Assert.Throws<ArgumentException>(() => calculator.SumOfDigits(-1));
    }

    private static IEnumerable<TestCaseData> TestCaseDataSource()
    {
        return new List<TestCaseData>()
        {
            new TestCaseData(6, 123),
            new TestCaseData(0, 0),
            new TestCaseData(15, 555),
            new TestCaseData(1, 10),
            new TestCaseData(1, 1000000),
            new TestCaseData(2, 101)
        };
    }

}
