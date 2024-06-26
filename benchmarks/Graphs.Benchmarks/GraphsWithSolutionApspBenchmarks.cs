﻿using BenchmarkDotNet.Attributes;
using Graphs.Benchmarks.Generators;
using Graphs.DataStructures;
using System.Diagnostics;

namespace Graphs.Benchmarks;

[MemoryDiagnoser(false)]
public class GraphsWithSolutionApspBenchmarks
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
    }

    [Benchmark]
    public void BellmanFord()
    {
        _graph.BellmanFord();
    }

    [Benchmark]
    public void DependencyLists()
    {
        _graph.DependencyListSP();
    }

    [Benchmark]
    public void Queues()
    {
        _graph.QueuedSP();
    }
}
