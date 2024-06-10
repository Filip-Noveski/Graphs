using Graphs.Interfaces;
using Graphs.Models;
using System.Diagnostics.CodeAnalysis;

namespace Graphs.DataStructures;

/// <summary>
/// A vertex / node in a <see cref="IGraph"/>.
/// </summary>
internal class Vertex
{
    /// <summary>
    /// The id of the Vertex.
    /// </summary>
    public required char Id { get; init; }

    /// <summary>
    /// A list of edges whose source vertex is this instance.
    /// </summary>
    public List<Edge> OutgoingEdges { get; }

    /// <summary>
    /// A dictionary mapping vertex ids to paths to all vertices in the graph.
    /// </summary>
    public Dictionary<char, Pathing> Paths { get; }

    /// <summary>
    /// Creates a new instace of the <see cref="Vertex"/> struct.
    /// </summary>
    public Vertex()
    {
        OutgoingEdges = new();
        Paths = new();
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
        Paths = new();
    }
}
