namespace Challenge.Tree;

/// <summary>
/// A simple structure for an unordered graph.
/// <seealso cref="Node"/>
/// <seealso cref="Edge"/>
/// </summary>
public class Graph
{
    /// <summary>
    /// Create the graph out of list of strings.<br/>
    /// Consider the <c>"A-B"</c> creates two nodes, <c>"A"</c> and <c>"B"</c>,
    /// and connects them with appropriate edge.<br/>
    ///
    /// <code>
    /// FromEdgeNotation(new string[] {
    ///     "A-B",
    ///     "B-C", "B-D",
    ///     "D-E"
    /// })
    /// </code>
    /// produces the tree of
    /// <code>
    ///     A
    ///      \
    ///       B
    ///      / \
    ///     C   D
    ///          \
    ///           E
    /// </code>
    /// </summary>
    public static Graph FromEdgeNotation(IEnumerable<string> edges)
    {
        var graph = new Graph();

        foreach (var edgeNotation in edges)
        {
            var nodeNames = edgeNotation.Split("-");
            var n1 = new Node(nodeNames[0]);
            var n2 = new Node(nodeNames[1]);
            var edge = new Edge(n1, n2);
            graph.AddEdge(edge);
        }

        return graph;
    }

    private readonly Dictionary<Node, Dictionary<string, Edge>> _nodeEdges = new Dictionary<Node, Dictionary<string, Edge>>();

    public readonly Dictionary<string, Node> Nodes = new Dictionary<string, Node>();
    public readonly Dictionary<string, Edge> Edges = new Dictionary<string, Edge>();

    public void AddNode(Node node)
    {
        Nodes.TryAdd(node.Id, node);
    }

    public void AddEdge(Edge edge)
    {
        Edges.TryAdd(edge.Id, edge);

        _nodeEdges.TryAdd(edge.From, new Dictionary<string, Edge>());
        _nodeEdges.GetValueOrDefault(edge.From)!.Add(edge.Id, edge);

        _nodeEdges.TryAdd(edge.To, new Dictionary<string, Edge>());
        _nodeEdges.GetValueOrDefault(edge.To)!.Add(edge.Id, edge);
    }

    public IEnumerable<Edge> GetNodeEdges(Node n)
    {
        return _nodeEdges.TryGetValue(n, out var edges)
            ? edges.Values.ToList()
            : new List<Edge>();
    }
}
