using Graphs.DataStructures;
using Graphs.Models;
using System.Runtime.InteropServices;

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

    public static bool CheckForImprovement(Vertex vertex, Edge edge)
    {
        ref Pathing pathingToTarget = ref CollectionsMarshal.GetValueRefOrAddDefault(vertex.Paths, edge.TerminalVertex.Id, out _);
        ref Pathing pathingToSource = ref CollectionsMarshal.GetValueRefOrAddDefault(vertex.Paths, edge.SourceVertex.Id, out _);
        float currentDistance = pathingToTarget.TotalWeight;
        float newDistance = pathingToSource.TotalWeight + edge.Weight;

        if (currentDistance > newDistance)
        {
            pathingToTarget.TotalWeight = newDistance;
            pathingToTarget.VertexIds.Clear();
            pathingToTarget.VertexIds.AddRange(pathingToSource.VertexIds);
            pathingToTarget.VertexIds.Add(edge.TerminalVertex.Id);
            return true;
        }

        return false;
    }
}
