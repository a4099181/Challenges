using System;
using BenchmarkDotNet.Running;
using Challenges.Benchmarks;

namespace Challenges
{
    static class Benchmark
    {
        [MTAThread]
        static void Main()
        {
            BenchmarkRunner.Run<SwapBlocksBench>();
        }
    }
}