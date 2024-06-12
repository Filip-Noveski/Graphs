using BenchmarkDotNet.Attributes;
using Graphs.Benchmarks.Generators;
using Graphs.DataStructures;
using System.Diagnostics;

namespace Graphs.Benchmarks;

[MemoryDiagnoser(false)]
public class GraphsWithNwcSpspBenchmarks
{
    private Graph _graph = null!;

    [Params([0, 1, 2])]
    public int Id { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _graph = Id switch
        {
            0 => GraphsWithNWCycleBenchmarkingHelper.GraphWith8VerticesAnd11Edges,
            1 => GraphsWithNWCycleBenchmarkingHelper.GraphWith23VerticesAnd35Edges,
            2 => GraphsWithNWCycleBenchmarkingHelper.GraphWith49VerticesAnd69Edges,
            _ => throw new UnreachableException()
        };

        _graph.OrderEdgesByDfs('A');
    }

    [Benchmark]
    public void BellmanFord()
    {
        try
        {
            _graph.BellmanFord('A');
        }
        catch
        {
            // do nothing
        }
    }

    [Benchmark]
    public void DependencyLists()
    {
        try
        {
            _graph.DependencyListSP('A');
        }
        catch
        {
            // do nothing
        }
    }

    [Benchmark]
    public void Queues()
    {
        try
        {
            _graph.QueuedSP('A');
        }
        catch
        {
            // do nothing
        }
    }
}
