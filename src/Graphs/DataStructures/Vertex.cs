using Graphs.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Graphs.DataStructures;

/// <summary>
/// A vertex / node in a <see cref="IGraph"/>.
/// </summary>
internal readonly struct Vertex
{
    /// <summary>
    /// The id of the Vertex.
    /// </summary>
    public required char Id { get; init; }

    /// <summary>
    /// A list of edges whose source vertex is this instance.
    /// </summary>
    public List<Edge> OutgoingEdges { get; } = new();

    /// <summary>
    /// Creates a new instace of the <see cref="Vertex"/> struct.
    /// </summary>
    public Vertex()
    {
        OutgoingEdges = new();
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Vertex"/> struct.
    /// </summary>
    /// <param name="id">The id of the vertex.</param>
    [SetsRequiredMembers]
    public Vertex(char id)
    {
        Id = id;
        OutgoingEdges = new();
    }
}
