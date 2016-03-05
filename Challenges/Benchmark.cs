using BenchmarkDotNet.Running;
using Challenges.Benchmarks.Arrays;

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