using Graphs.DataStructures;

namespace Graphs.Models;

internal readonly struct Dependency
{
    public readonly char DependeeId { get; }

    public readonly Edge Edge { get; }

    public Dependency(char dependee, Edge edge)
    {
        DependeeId = dependee;
        Edge = edge;
    }

    public readonly void Deconstruct(out char dependeeId, out Edge edge)
    {
        dependeeId = DependeeId;
        edge = Edge;
    }
}
