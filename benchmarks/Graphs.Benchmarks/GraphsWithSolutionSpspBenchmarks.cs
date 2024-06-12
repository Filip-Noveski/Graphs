using BenchmarkDotNet.Attributes;
using Graphs.Benchmarks.Generators;
using Graphs.DataStructures;
using System.Diagnostics;

namespace Graphs.Benchmarks;

[MemoryDiagnoser(false)]
public class GraphsWithSolutionSpspBenchmarks
{
    private Graph _graph = null!;

    [Params([0, 1, 2])]
    public int Id { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _graph = Id switch
        {
            0 => GraphsWithSolutionBenchmarkingHelper.GraphWith8VerticesAnd11Edges,
            1 => GraphsWithSolutionBenchmarkingHelper.GraphWith23VerticesAnd35Edges,
            2 => GraphsWithSolutionBenchmarkingHelper.GraphWith49VerticesAnd69Edges,
            _ => throw new UnreachableException()
        };

        _graph.OrderEdgesByDfs('A');
    }

    [Benchmark]
    public void BellmanFord()
    {
        _graph.BellmanFord('A');
    }

    [Benchmark]
    public void DependencyLists()
    {
        _graph.DependencyListSP('A');
    }

    [Benchmark]
    public void Queues()
    {
        _graph.QueuedSP('A');
    }
}
