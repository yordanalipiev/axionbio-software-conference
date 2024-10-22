using Challenge;

namespace Tests;

public class MatrixRotatorTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseDataSource))]
    public void RotateMatrix_ShouldReturnCorrectlyRotatedMatrix(int[,] expected, int[,] input)
    {
        var rotator = new MatrixRotator();

        Assert.That(rotator.RotateMatrix(input), Is.EqualTo(expected));
    }

    [Test]
    public void RotateMatrix_ShouldThrowArgumentException_WhenMatrixIsNotSquare()
    {
        var rotator = new MatrixRotator();
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        Assert.Throws<ArgumentException>(() => rotator.RotateMatrix(matrix));
    }

    private static IEnumerable<TestCaseData> TestCaseDataSource()
    {
        return new List<TestCaseData>()
        {
            new TestCaseData(
                new int [,] {
                    { 7, 4, 1 },
                    { 8, 5, 2 },
                    { 9, 6, 3 }
                },
                new int[,]{
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                }),
            new TestCaseData(
                new int[,]{
                    { 3, 1 },
                    { 4, 2 }
                },
                new int [,] {
                    { 1, 2 },
                    { 3, 4 }
                }),
            new TestCaseData(
                new int[,]{
                    { 13, 9, 5, 1 },
                    { 14, 10, 6, 2 },
                    { 15, 11, 7, 3 },
                    { 16, 12, 8, 4 }
                },
                new int [,] {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 },
                    { 13, 14, 15, 16 }
                }),
            new TestCaseData(
                new int[,]{
                    { 21, 16, 11, 6, 1 },
                    { 22, 17, 12, 7, 2 },
                    { 23, 18, 13, 8, 3 },
                    { 24, 19, 14, 9, 4 },
                    { 25, 20, 15, 10, 5 }
                },
                new int [,] {
                    { 1, 2, 3, 4, 5 },
                    { 6, 7, 8, 9, 10 },
                    { 11, 12, 13, 14, 15 },
                    { 16, 17, 18, 19, 20 },
                    { 21, 22, 23, 24, 25 }
                }) ,
            new TestCaseData(
                new int[,]{
                    { 31, 25, 19, 13, 7, 1 },
                    { 32, 26, 20, 14, 8, 2 },
                    { 33, 27, 21, 15, 9, 3 },
                    { 34, 28, 22, 16, 10, 4 },
                    { 35, 29, 23, 17, 11, 5 },
                    { 36, 30, 24, 18, 12, 6 }
                },
                new int [,] {
                    { 1, 2, 3, 4, 5, 6 },
                    { 7, 8, 9, 10, 11, 12 },
                    { 13, 14, 15, 16, 17, 18 },
                    { 19, 20, 21, 22, 23, 24 },
                    { 25, 26, 27, 28, 29, 30 },
                    { 31, 32, 33, 34, 35, 36 }
                })
        };
    }

}
