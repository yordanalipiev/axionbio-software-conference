namespace Challenge.Tree;

/// <summary>
/// A recursive data structure for representing a binary tree.
/// Think
/// <code>
///     tree = BinaryNode()
///         {
///             Left = BinaryNode | null,
///             Right = BinaryNode | null
///         }
/// </code>
/// The node has an <c>Id</c> and (optional) <c>Left</c> and <c>Right</c> children.<br/>
/// The children can be set via dedicated method or right away in the constructor.
/// </summary>
public class BinaryNode
{
    public BinaryNode(string id)
    {
        Id = id;
    }

    public BinaryNode(string id, BinaryNode? left, BinaryNode? right)
    {
        Id = id;
        SetChildren(left, right);
    }

    public string Id { get; private set; }

    public BinaryNode? Left { get; private set; } = null;

    public BinaryNode? Right { get; private set; } = null;

    public void SetChildren(BinaryNode? left, BinaryNode? right)
    {
        Left = left;
        Right = right;
    }
}
