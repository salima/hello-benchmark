using Benchmark;
using BenchmarkDotNet.Running;

Console.WriteLine("### Hello, BenchmarkDotNet  ###\n");
Console.WriteLine("Pressione algo para iniciar\n");
Console.ReadLine();

var summary = BenchmarkRunner.Run<MemoryBenchmark>();