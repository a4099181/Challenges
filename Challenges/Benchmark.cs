using BenchmarkDotNet.Running;
using Challenges.Benchmarks;

namespace Challenges
{
    static class Benchmark
    {
        static void Main()
        {
            BenchmarkRunner.Run<SwapBlocksBench>();
        }
    }
}