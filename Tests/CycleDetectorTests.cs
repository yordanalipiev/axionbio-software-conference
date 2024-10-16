using Challenge;
using Challenge.Tree;

namespace Tests;

public class CycleDetectorTests
{
    [Test]
    public void Should_Return_False_For_Single_Node()
    {
        var graph = new Graph();
        var n = new Node("A");
        graph.AddNode(n);

        var cd = new CycleDetector();
        Assert.False(cd.HasCycles(graph), "Should return False for a single node");
    }

    /// <summary>
    /// <code>
    ///     A --- B --- C
    ///            \
    ///             D --- E --- F
    ///                   \
    ///                    G
    /// </code>
    /// </summary>
    [Test]
    public void Should_Return_False_For_A_Tree()
    {
        var graph = Graph.FromEdgeNotation(new string[]
        {
            "A-B", "B-C",
            "B-D", "D-E", "E-F",
            "E-G",
        });

        var cd = new CycleDetector();
        Assert.False(cd.HasCycles(graph), "Should return False for a tree");
    }

    /// <summary>
    /// <code>
    ///     A --- B --- C --- H
    ///            \        /
    ///             D --- E --- F
    ///                   \
    ///                    G
    /// </code>
    /// </summary>
    [Test]
    public void Should_Return_True_For_If_Has_Cycle()
    {
        var graph = Graph.FromEdgeNotation(new string[]
        {
            "A-B", "B-C", "C-H", "H-E",
            "B-D", "D-E", "E-F",
            "E-G",
        });

        var cd = new CycleDetector();
        Assert.False(cd.HasCycles(graph), "Should return True if a cycle exists");
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
