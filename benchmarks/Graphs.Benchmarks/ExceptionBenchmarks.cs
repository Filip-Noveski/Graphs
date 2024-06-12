using BenchmarkDotNet.Attributes;

namespace Graphs.Benchmarks;

/*
 * Checking how much throwing and catching exceptions impacts performance.
 */
[MemoryDiagnoser(false)]
public class ExceptionBenchmarks
{
    [Benchmark]
    public void ThrowCatch()
    {
        try
        {
            Console.WriteLine(Math.Sin(1));
            throw new Exception();
        }
        catch
        {
            // do nothing
        }
    }
    
    [Benchmark]
    public void ThrowFinally()
    {
        try
        {
            Console.WriteLine(Math.Sin(1));
            throw new Exception();
        }
        finally
        {
            // do nothing
        }
    }

    [Benchmark]
    public void DontThrowCatch()
    {
        try
        {
            Console.WriteLine(Math.Sin(1));
        }
        catch
        {
            // do nothing
        }
    }

    [Benchmark]
    public void DontThrowFinally()
    {
        try
        {
            Console.WriteLine(Math.Sin(1));
        }
        finally
        {
            // do nothing
        }
    }

    [Benchmark]
    public void NoTry()
    {
        Console.WriteLine(Math.Sin(1));
    }
}
