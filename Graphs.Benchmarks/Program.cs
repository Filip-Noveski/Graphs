using BenchmarkDotNet.Running;
using Graphs.Benchmarks;

bool valid = false;
int value = -1;

while (!valid)
{
    Console.Clear();
    Console.Write("""
        Which benchmarks to run?
        1. Exception Benchmarks;
        2. Graphs With Solution Single-Pairs Benchmarks
        3. Graphs With Solution All-Pairs Benchmarks
        4. Graphs With Negative-Weight cycle Single-Pairs Benchmarks
        5. Graphs With Negative-Weight cycle All-Pairs Benchmarks
        > 
        """);
    valid = int.TryParse(Console.ReadLine(), out value);
}

switch (value)
{
    case 1: BenchmarkRunner.Run<ExceptionBenchmarks>(); break;
    case 2: BenchmarkRunner.Run<GraphsWithSolutionSpspBenchmarks>(); break;
    case 3: BenchmarkRunner.Run<GraphsWithSolutionApspBenchmarks>(); break;
    case 4: BenchmarkRunner.Run<GraphsWithNwcSpspBenchmarks>(); break;
    case 5: BenchmarkRunner.Run<GraphsWithNwcApspBenchmarks>(); break;
    default: return;
}

