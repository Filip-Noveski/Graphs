using Graphs.DataStructures;

namespace Graphs.Benchmarks.Extensions;

public static class GraphExtensions
{
    public static void CreateBidirectionalEdge(this Graph graph,
        char forwardId,
        char backwardId,
        char firstVertex,
        char secondVertex,
        float weight)
    {
        graph.CreateEdge(forwardId, firstVertex, secondVertex, weight);
        graph.CreateEdge(backwardId, secondVertex, firstVertex, weight);
    }
}
