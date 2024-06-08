using System.Diagnostics.CodeAnalysis;

namespace Graphs.DataStructures;

/// <summary>
/// An edge between two instances of <see cref="Vertex"/>.
/// </summary>
internal class Edge
{
    /// <summary>
    /// The id of the Edge.
    /// </summary>
    public required char Id { get; init; }

    /// <summary>
    /// The source vertex of the Edge.
    /// </summary>
    public required Vertex SourceVertex { get; init; }

    /// <summary>
    /// The terminal vertex of the Edge.
    /// </summary>
    public required Vertex TerminalVertex { get; init; }

    /// <summary>
    /// The weight of the Edge.
    /// </summary>
    public required int Weight { get; init; }

    /// <summary>
    /// Creates an instance of the <see cref="Edge"/> class.
    /// </summary>
    public Edge()
    {
    }

    /// <summary>
    /// Creates an instance of the <see cref="Edge"/> class.
    /// </summary>
    /// <param name="id">The id of the Edge.</param>
    /// <param name="source">The source vertex of the Edge.</param>
    /// <param name="terminal">The terminal vertex of the Edge.</param>
    /// <param name="weight">The weight of the Edge.</param>
    [SetsRequiredMembers]
    public Edge(char id, Vertex source, Vertex terminal, int weight)
    {
        Id = id;
        SourceVertex = source;
        TerminalVertex = terminal;
        Weight = weight;
    }
}
