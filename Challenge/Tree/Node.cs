namespace Challenge.Tree;

/// <summary>
/// A simple data structure for a graph node.
/// <seealso cref="Edge"/>
/// <seealso cref="Graph"/>
/// </summary>
public class Node
{
    public Node(string id)
    {
        Id = id;
    }

    public string Id { get; private set; }
}
