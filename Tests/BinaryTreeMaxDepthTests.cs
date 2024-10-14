using Challenge;
using Challenge.Tree;

namespace Tests;

public class BinaryTreeMaxDepthTests
{
    [Test]
    public void Should_Return_0_For_Single_Node()
    {
        var bt = new BinaryTreeMaxDepth();
        var root = new BinaryNode("A", null, null);

        Assert.True(bt.GetMaxDepth(root) == 0, "Should return 0 for a single node");
    }

    /// <summary>
    /// <code>
    ///           A
    ///        /     \
    ///      B         C
    ///     / \       / \
    ///    D   E     F   G
    ///       / \
    ///      H   I
    ///           \
    ///            J
    /// </code>
    /// </summary>
    [Test]
    public void Should_Return_4_For_Exemplary_Tree()
    {
        var bt = new BinaryTreeMaxDepth();

        var a = new BinaryNode("A");
        var b = new BinaryNode("B");
        var c = new BinaryNode("C");
        var d = new BinaryNode("D");
        var e = new BinaryNode("E");
        var f = new BinaryNode("F");
        var g = new BinaryNode("G");
        var h = new BinaryNode("H");
        var i = new BinaryNode("I");
        var j = new BinaryNode("J");

        a.SetChildren(b, c);
        b.SetChildren(d, e);
        c.SetChildren(f, g);
        e.SetChildren(h, i);
        i.SetChildren(null, j);

        Assert.True(bt.GetMaxDepth(a) == 4, "Should return 4 for the exemplary tree");
    }


    [Test]
    public void Should_Return_3_For_Chain()
    {
        var bt = new BinaryTreeMaxDepth();

        var a = new BinaryNode("A");
        var b = new BinaryNode("B");
        var c = new BinaryNode("C");
        var d = new BinaryNode("D");

        a.SetChildren(null, b);
        b.SetChildren(c, null);
        c.SetChildren(null, d);

        Assert.True(bt.GetMaxDepth(a) == 3, "Should return 3 for the 'A-B-C-D' chain");
    }
}
