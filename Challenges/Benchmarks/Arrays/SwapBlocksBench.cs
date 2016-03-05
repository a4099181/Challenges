using System.Linq;
using BenchmarkDotNet.Attributes;
using Challenges.Challenges.Arrays;

namespace Challenges.Benchmarks.Arrays
{
    public class SwapBlocksBench
    {
        readonly char[] _oneMillionChars;
        readonly char[] _oneThousandChars;

        public SwapBlocksBench()
        {
            _oneMillionChars = Enumerable.Repeat( 'a', 1000000 ).ToArray();
            _oneThousandChars = Enumerable.Repeat( 'a', 1000 ).ToArray();
        }

        [Benchmark]
        public char[] SwapBlocksInOneMillionCharsArray() => SwapBlocks.Swap( _oneMillionChars, 4000 );

        [Benchmark]
        public char[] SwapBlocksInOneThousandCharsArray() => SwapBlocks.Swap( _oneThousandChars, 40 );
    }
}
