using Graphs.DataStructures;
using Graphs.Exceptions;
using Graphs.Extensions;
using System.Runtime.InteropServices;

namespace Graphs.Utilities;

internal readonly ref struct QueueBasedSPService
{
    private readonly ReadOnlySpan<Vertex> _vertices;
    private readonly ReadOnlySpan<Edge> _edges;
    private readonly HashSet<Vertex> _queue;
    private readonly Dictionary<Vertex, int> _enqueueCounts;

    public QueueBasedSPService(ref List<Vertex> vertices, ref List<Edge> edges)
    {
        _vertices = CollectionsMarshal.AsSpan(vertices);
        _edges = CollectionsMarshal.AsSpan(edges);
        _queue = new();
        _enqueueCounts = new();
    }

    private readonly void Iteration(Vertex source, Vertex vertex)
    {
        foreach (Edge e in vertex.OutgoingEdges)
        {
            bool improved = VertexPathingUtilities.CheckForImprovement(source, e);
            if (!improved)
            {
                continue;
            }

            if (!_queue.Contains(e.TerminalVertex))
            {
                _queue.Add(e.TerminalVertex);
            }

            ref int enqueueCount = ref CollectionsMarshal.GetValueRefOrAddDefault(_enqueueCounts, e.TerminalVertex, out _);
            enqueueCount++;
            if (enqueueCount >= _vertices.Length)
            {
                throw new NegativeWeightCycleException();
            }
        }
    }

    public readonly void Execute(Vertex vertex)
    {
        VertexPathingUtilities.ResetPaths(vertex, _vertices);
        _queue.Add(vertex);
        _enqueueCounts.Add(vertex, 1);

        while (_queue.Count != 0)
        {
            Vertex v = _queue.Dequeue();
            Iteration(vertex, v);
        }
    }
}
