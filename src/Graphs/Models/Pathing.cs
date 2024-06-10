using System.Runtime.InteropServices;

namespace Graphs.Models;

/// <summary>
/// Pathing data for shortest paths from the storing vertex to the specified target.
/// </summary>
public struct Pathing
{
    /// <summary>
    /// The id of the vertex at the end of the path.
    /// </summary>
    public char TargetVertexId { get; init; }

    /// <summary>
    /// The total weight of the path.
    /// </summary>
    public float TotalWeight { get; set; }

    /// <summary>
    /// A list of vertex ids that represent the route to be traversed.
    /// </summary>
    public List<char> VertexIds { get; set; }

    /// <summary>
    /// Returns a span to the list of vertices to traverse.
    /// </summary>
    /// <returns>A span to the list of vertices to traverse.</returns>
    public readonly ReadOnlySpan<char> GetRoute()
    {
        return CollectionsMarshal.AsSpan(VertexIds);
    }
}
