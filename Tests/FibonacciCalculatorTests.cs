using Challenge;

namespace Tests;

public class FibonacciCalculatorTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseDataSource))]
    public void GetFibonacci_PositiveValue_ShouldReturnCorrectValue(int expected, int input)
    {
        var calculator = new FibonacciCalculator();

        Assert.That(calculator.GetFibonacci(input), Is.EqualTo(expected));
    }
    
    [Test]
    public void GetFibonacci_NegativeValue_ShouldThrowArgumentException()
    {
        var calculator = new FibonacciCalculator();

        Assert.Throws<ArgumentException>(() => calculator.GetFibonacci(-1));
    }

    private static IEnumerable<TestCaseData> TestCaseDataSource()
    {
        return new List<TestCaseData>()
        {
            new TestCaseData(0, 0),
            new TestCaseData(1, 1),
            new TestCaseData(1, 2),
            new TestCaseData(2, 3),
            new TestCaseData(5, 5),
            new TestCaseData(13, 7)
        };
    }

}
