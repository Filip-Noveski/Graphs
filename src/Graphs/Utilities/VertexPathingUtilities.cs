using Graphs.DataStructures;
using Graphs.Models;

namespace Graphs.Utilities;

internal static class VertexPathingUtilities
{
    public static void ResetPaths(Vertex vertex, ReadOnlySpan<Vertex> vertices)
    {
        vertex.Paths.Clear();

        for (int i = 0; i <= vertices.Length - 1; i++)
        {
            Pathing pathing = new()
            {
                TargetVertexId = vertices[i].Id,
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
