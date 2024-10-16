namespace Challenge.Tree;

/// <summary>
/// Simple data structure for an edge connecting two given nodes.
/// <seealso cref="Node"/>
/// <seealso cref="Graph"/>
/// </summary>
public class Edge
{
    public Edge(string id, Node from, Node to)
    {
        Id = id;
        From = from;
        To = to;
    }

    public Edge(Node from, Node to)
    {
        Id = $"{from.Id}-{to.Id}";
        From = from;
        To = to;
    }

    public string Id { get; private set; }

    public Node From { get; private set; }

    public Node To { get; private set; }

    public Node GetOppositeNode(Node n)
    {
        return n == From ? To : From;
    }
}
