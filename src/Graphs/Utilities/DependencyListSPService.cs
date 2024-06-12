using Graphs.DataStructures;
using Graphs.Exceptions;
using Graphs.Models;
using System.Runtime.InteropServices;

namespace Graphs.Utilities;

internal ref struct DependencyListSPService
{
    private readonly ReadOnlySpan<Vertex> _vertices;
    private readonly ReadOnlySpan<Edge> _edges;
    private DependencyList _dependencies;

    public DependencyListSPService(ref List<Vertex> vertices, ref List<Edge> edges)
    {
        _vertices = CollectionsMarshal.AsSpan(vertices);
        _edges = CollectionsMarshal.AsSpan(edges);
        _dependencies = new(vertices.Count, edges.Count);
    }

    private readonly void UpdateDependencies(Vertex source, Vertex loopInitiator, Edge edge)
    {
        ReadOnlySpan<Dependency> edges = _dependencies.GetDependencies(edge.TerminalVertex.Id);

        foreach ((char _, Edge e) in edges)
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
        _dependencies.AddDependency(edge);
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
