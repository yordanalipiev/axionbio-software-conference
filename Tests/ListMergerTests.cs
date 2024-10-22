using Challenge;

namespace Tests;

public class ListMergerTests
{
    [Test]
    public void Should_Merge_Two_Lists()
    {
        var lm = new ListMerger();
        var testData = new TestData[]
        {
            new TestData()
            {
                Left = new int[] {},
                Right = new int[] {},
                Expected = new int[] {},
            },
            new TestData()
            {
                Left = new int[] { 1, },
                Right = new int[] { 2, 3, },
                Expected = new int[] { 1, 2, 3, },
            },
            new TestData()
            {
                Left = new int[] { 2, 3, 9, },
                Right = new int[] { 1, 2, 4, },
                Expected = new int[] { 1, 2, 2, 3, 4, 9, },
            },
            new TestData()
            {
                Left = new int[] { },
                Right = new int[] { 1, 2, },
                Expected = new int[] { 1, 2, },
            },
            new TestData()
            {
                Left = new int[] { 7, 8, 9, },
                Right = new int[] { 1, 2, 3, },
                Expected = new int[] { 1, 2, 3, 7, 8, 9, },
            },
        };

        foreach (var td in testData)
        {
            var merged = lm.Merge(td.Left, td.Right);
            CollectionAssert.AreEqual(
                td.Expected,
                merged,
                $"[ {string.Join(", ", td.Left)} ] + [ {string.Join(", ", td.Right)} ]:\n"
                + $"Expected [ {string.Join(", ", td.Expected)} ]\n"
                + $"Received [ {string.Join(", ", merged)} ]"
            );
        }
    }
}

internal struct TestData
{
    public int[] Left { set; get; }
    public int[] Right { set; get; }
    public int[] Expected { set; get; }
}
