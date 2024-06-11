using Graphs.DataStructures;
using Graphs.Exceptions;
using System.Runtime.InteropServices;

namespace Graphs.Utilities;

internal readonly ref struct DependencyListSPService
{
    private readonly ReadOnlySpan<Vertex> _vertices;
    private readonly ReadOnlySpan<Edge> _edges;
    private readonly Dictionary<char, List<Edge>> _dependencies;

    public DependencyListSPService(ref List<Vertex> vertices, ref List<Edge> edges)
    {
        _vertices = CollectionsMarshal.AsSpan(vertices);
        _edges = CollectionsMarshal.AsSpan(edges);
        _dependencies = new();
    }

    private readonly void UpdateDependencies(Vertex source, Vertex loopInitiator, Edge edge)
    {
        if (!_dependencies.TryGetValue(edge.TerminalVertex.Id, out List<Edge>? edges))
        {
            return;
        }

        foreach (Edge e in edges)
        {
            bool improved = VertexPathingUtilities.CheckForImprovement(source, e);

            if (!improved)
            {
                continue;
            }

            if (e.TerminalVertex == loopInitiator)
            {
                throw new NegativeWeightCycleException();
            }

            UpdateDependencies(source, loopInitiator, e);
        }
    }

    private readonly void MarkDependency(Edge edge)
    {
        ref List<Edge>? value = ref CollectionsMarshal.GetValueRefOrAddDefault(_dependencies, edge.SourceVertex.Id, out bool existed);

        if (existed)
        {
            value!.Add(edge);
            return;
        }

        value = new()
        {
            edge
        };
    }

    public readonly void Execute(Vertex vertex)
    {
        VertexPathingUtilities.ResetPaths(vertex, _vertices);

        int edgeCount = _edges.Length;
        for (int i = 0; i < edgeCount; i++)
        {
            Edge edge = _edges[i];
            MarkDependency(edge);
            bool improved = VertexPathingUtilities.CheckForImprovement(vertex, edge);
            if (improved)
            {
                UpdateDependencies(vertex, edge.SourceVertex, edge);
            }
        }
    }
}
