namespace Challenge.Tree;

/// <summary>
/// A recursive data structure for representing an undirected simple graph.
/// Think
/// <code>
///     graph = Node()
///         {
///             Child_1 = Node,
///             Child_2 = Node,
///             ...
///             Child_N = Node,
///         }
/// </code>
///
/// Considerations:
/// <list type="number">
///     <item>A Node can have zero or more children.</item>
///     <item>The Node-to-Child pair corresponds to an Edge in terms of graph theory.</item>
///     <item>TBD!!!</item>
/// </list>
/// </summary>
public class Node
{
    public Node(string id)
    {
        Id = id;
    }

    public string Id { get; private set; }
}

public class Edge
{
    public Edge(Node from, Node to)
    {
        Id = $"{from.Id}-{to.Id}";
        From = from;
        To = to;
    }

    public string Id { get; private set; }

    public Node From { get; private set; }

    public Node To { get; private set; }

    public Node OppositeNode(Node n)
    {
        return n == From ? To : From;
    }
}

public class Tree
{
    public static Tree FromEdgeNotation(IEnumerable<string> edges)
    {
        var tree = new Tree();

        foreach (var edgeNotation in edges)
        {
            var nodeNames = edgeNotation.Split("-");
            var n1 = new Node(nodeNames[0]);
            var n2 = new Node(nodeNames[1]);
            var edge = new Edge(n1, n2);
            tree.AddEdge(edge);
        }

        return tree;
    }

    private readonly Dictionary<Node, HashSet<Edge>> _nodeEdges = new Dictionary<Node, HashSet<Edge>>();

    public readonly HashSet<Node> Nodes = new HashSet<Node>();
    public readonly HashSet<Edge> Edges = new HashSet<Edge>();

    public void AddEdge(Edge edge)
    {
        Edges.Add(edge);

        _nodeEdges.TryAdd(edge.From, new HashSet<Edge>());
        _nodeEdges.GetValueOrDefault(edge.From)!.Add(edge);

        _nodeEdges.TryAdd(edge.To, new HashSet<Edge>());
        _nodeEdges.GetValueOrDefault(edge.To)!.Add(edge);
    }

    public HashSet<Edge> GetNodeEdges(Node n)
    {
        return _nodeEdges.TryGetValue(n, out var edges)
            ? edges
            : new HashSet<Edge>();
    }
}
