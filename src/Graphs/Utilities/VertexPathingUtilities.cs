using Graphs.DataStructures;
using Graphs.Models;
using System.Runtime.InteropServices;

namespace Graphs.Utilities;

internal static class VertexPathingUtilities
{
    public static void ResetPaths(Vertex vertex, List<Vertex> vertices)
    {
        vertex.Paths.Clear();
        ReadOnlySpan<Vertex> vertexSpan = CollectionsMarshal.AsSpan(vertices);

        for (int i = 0; i <= vertices.Count - 1; i++)
        {
            Pathing pathing = new()
            {
                TargetVertexId = vertexSpan[i].Id,
                TotalWeight = float.PositiveInfinity,
                VertexIds = new()
            };

            if (pathing.TargetVertexId == vertex.Id)
            {
                pathing.TotalWeight = 0;
            }

            vertex.Paths.Add(pathing.TargetVertexId, pathing);
        }
    }
}
