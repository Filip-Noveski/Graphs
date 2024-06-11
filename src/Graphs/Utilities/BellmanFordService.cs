using Graphs.DataStructures;
using Graphs.Exceptions;
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
            improved |= VertexPathingUtilities.CheckForImprovement(vertex, _edges[i]);
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
