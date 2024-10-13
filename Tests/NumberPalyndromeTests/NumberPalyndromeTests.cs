namespace NumberPalyndromeTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Should_Pass_On_Palyndrome()
    {
        var np = new NumberPalyndrome.NumberPalyndrome();
        var validNumbers = new UInt64[]
        {
            0, 9, 11, 121, 1221, 12345654321,
        };

        foreach (var n in validNumbers)
        {
            Assert.True(np.IsPalyndrome(n), $"Should return True for {n}");
        }
    }

    [Test]
    public void Should_Fail_On_NonPalyndrome()
    {
        var np = new NumberPalyndrome.NumberPalyndrome();
        var invalidNumbers = new UInt64[]
        {
            12, 123123, 1234021, 12340321,
        };

        foreach (var n in invalidNumbers)
        {
            Assert.False(np.IsPalyndrome(n), $"Should return False for {n}");
        }
    }
}
