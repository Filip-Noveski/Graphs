using Graphs.DataStructures;
using System.Runtime.InteropServices;

namespace Graphs.Utilities;

internal readonly ref struct BfsGraphTraverser
{
    private readonly List<Edge> _newEdges;
    private readonly List<char> _visitedVertices;

    public BfsGraphTraverser()
    {
        _newEdges = new();
        _visitedVertices = new();
    }

    private readonly void ExploreEdges(Vertex vertex)
    {
        if (_visitedVertices.Contains(vertex.Id))
        {
            return;
        }

        _visitedVertices.Add(vertex.Id);
        ReadOnlySpan<Edge> edges = CollectionsMarshal.AsSpan(vertex.OutgoingEdges);

        for (int i = 0; i < edges.Length; i++)
        {
            _newEdges.Add(edges[i]);
            ExploreEdges(edges[i].TerminalVertex);
        }
    }

    public readonly List<Edge> Traverse(Vertex vertex)
    {
        ExploreEdges(vertex);
        return _newEdges;
    }
}
