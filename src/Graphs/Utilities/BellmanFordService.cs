using Graphs.DataStructures;
using Graphs.Exceptions;
using Graphs.Models;
using System.Runtime.InteropServices;

namespace Graphs.Utilities;

internal readonly ref struct BellmanFordService
{
    private readonly ReadOnlySpan<Vertex> _vertices;
    private readonly ReadOnlySpan<Edge> _edges;

    public BellmanFordService(ref List<Vertex> vertices, ref List<Edge> edges)
    {
        _vertices = CollectionsMarshal.AsSpan(vertices);
        _edges = CollectionsMarshal.AsSpan(edges);
    }

    private readonly bool Iteration(Vertex vertex)
    {
        bool improved = false;
        for (int i = 0; i < _edges.Length; i++)
        {
            Edge e = _edges[i];
            ref Pathing pathingToTarget = ref CollectionsMarshal.GetValueRefOrAddDefault(vertex.Paths, e.TerminalVertex.Id, out _);
            ref Pathing pathingToSource = ref CollectionsMarshal.GetValueRefOrAddDefault(vertex.Paths, e.SourceVertex.Id, out _);
            float currentDistance = pathingToTarget.TotalWeight;
            float newDistance = pathingToSource.TotalWeight + e.Weight;

            if (currentDistance > newDistance)
            {
                improved = true;
                pathingToTarget.TotalWeight = newDistance;
                pathingToTarget.VertexIds.Clear();
                pathingToTarget.VertexIds.AddRange(pathingToSource.VertexIds);
                pathingToTarget.VertexIds.Add(e.TerminalVertex.Id);
            }
        }

        return improved;
    }

    public readonly void Execute(Vertex vertex)
    {
        VertexPathingUtilities.ResetPaths(vertex, _vertices);

        int vertexCount = _vertices.Length;
        for (int i = 0; i < vertexCount; i++)
        {
            bool improved = Iteration(vertex);
            if (!improved)
            {
                return;
            }
        }

        throw new NegativeWeightCycleException();
    }
}
