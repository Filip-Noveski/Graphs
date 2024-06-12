using Graphs.DataStructures;
using System.Runtime.InteropServices;

namespace Graphs.Utilities;

internal readonly ref struct DfsGraphTraverser
{
    private readonly List<Edge> _newEdges;
    private readonly Queue<Vertex> _queue;
    private readonly List<char> _visitedVertices;

    public DfsGraphTraverser()
    {
        _newEdges = new();
        _visitedVertices = new();
        _queue = new();
    }

    private readonly void ExploreEdges()
    {
        Vertex vertex = _queue.Dequeue();

        if (_visitedVertices.Contains(vertex.Id))
        {
            return;
        }

        _visitedVertices.Add(vertex.Id);
        ReadOnlySpan<Edge> edges = CollectionsMarshal.AsSpan(vertex.OutgoingEdges);

        for (int i = 0; i < edges.Length; i++)
        {
            _newEdges.Add(edges[i]);
            _queue.Enqueue(edges[i].TerminalVertex);
        }
    }

    public readonly List<Edge> Traverse(Vertex vertex)
    {
        _queue.Enqueue(vertex);
        while (_queue.Count > 0)
        {
            ExploreEdges();
        }
        return _newEdges;
    }
}
