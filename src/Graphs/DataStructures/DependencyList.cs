using Graphs.Models;

namespace Graphs.DataStructures;

internal ref struct DependencyList
{
    private readonly Span<Dependency> _dependencies;
    private readonly Span<int> _indices;
    private readonly Span<int> _counts;
    private readonly Span<int> _registeredDependencies;
    private Wrapper<int> _nextDependencyIndex;

    public DependencyList(int vertexCount, int edgeCount)
    {
        _dependencies = new Dependency[edgeCount];
        _indices = new int[vertexCount];
        _counts = new int[vertexCount];
        _registeredDependencies = new int[vertexCount];
        _nextDependencyIndex = 0;
    }

    public void AddDependency(Edge edge)
    {
        /*
         * Simplified implementation, relies on user providing vertices with
         * a +1 increment between ids so as not to overlap. 
         */ 
        int index = edge.SourceVertex.Id % _indices.Length;

        if (_counts[index] != 0)
        {
            MarkDependency(edge, index);
            return;
        }

        _counts[index] = edge.SourceVertex.OutgoingEdges.Count;
        _indices[index] = _nextDependencyIndex;
        _nextDependencyIndex += _counts[index];
        MarkDependency(edge, index);
    }

    private readonly void MarkDependency(Edge edge, int index)
    {
        int writeToIndex = _indices[index] + _registeredDependencies[index];
        _dependencies[writeToIndex] = new Dependency(edge.SourceVertex.Id, edge);
        _registeredDependencies[index]++;
    }

    public readonly ReadOnlySpan<Dependency> GetDependencies(char vertexId)
    {
        int index = vertexId % _indices.Length;
        int readIndex = _indices[index];
        int readCount = _registeredDependencies[index];

        return _dependencies[readIndex..(readIndex + readCount)];
    }
}
