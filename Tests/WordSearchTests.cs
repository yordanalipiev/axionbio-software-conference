using Challenge;

namespace Tests;

public class WordSearchTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseValidDataSource))]
    public void Exist_WhenWordExistsInGrid_ShouldReturnTrue(char[,] matrix, string word)
    {
        var wordSearch = new WordSearch();

        Assert.That(wordSearch.Exist(matrix, word), Is.True);
    }

    [Test]
    [TestCaseSource(nameof(TestCaseInvalidDataSource))]
    public void Exist_WhenWordDoesNotExistInGrid_ShouldReturnFalse(char[,] matrix, string word)
    {
        var wordSearch = new WordSearch();

        Assert.That(wordSearch.Exist(matrix, word), Is.False);
    }

    private static IEnumerable<TestCaseData> TestCaseValidDataSource()
    {
        char[,] board1 = {
            { 'A', 'B', 'C', 'E' },
            { 'S', 'F', 'C', 'S' },
            { 'A', 'D', 'E', 'E' }
        };

        yield return new TestCaseData(board1, "ABCCED");
        yield return new TestCaseData(board1, "SEE");
        yield return new TestCaseData(board1, "A");
        yield return new TestCaseData(board1, "DEE");
        yield return new TestCaseData(board1, "ESE");
        yield return new TestCaseData(board1, "ESEE");
    }

    private static IEnumerable<TestCaseData> TestCaseInvalidDataSource()
    {
        char[,] board1 = {
            { 'A', 'B', 'C', 'E' },
            { 'S', 'F', 'C', 'S' },
            { 'A', 'D', 'E', 'E' }
        };

        yield return new TestCaseData(board1, "ABCB");
        yield return new TestCaseData(board1, "XYZ");
    }
}
