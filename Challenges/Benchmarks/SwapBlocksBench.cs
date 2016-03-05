using System.Linq;
using BenchmarkDotNet.Attributes;
using arrays = Challenges.Challenges.Arrays;
using linq = Challenges.Challenges.Linq;

namespace Challenges.Benchmarks
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
        public char[] SwapBlocksInOneMillionCharsArray()
            => arrays.SwapBlocks.Swap( _oneMillionChars, 4000 );

        [Benchmark]
        public char[] SwapBlocksInOneThousandCharsArray()
            => arrays.SwapBlocks.Swap( _oneThousandChars, 40 );

        [Benchmark]
        public char[] SwapBlocksInOneMillionCharsArray_Linq()
            => linq.SwapBlocks.Swap( _oneMillionChars, 4000 );

        [Benchmark]
        public char[] SwapBlocksInOneThousandCharsArray_Linq()
            => linq.SwapBlocks.Swap( _oneThousandChars, 40 );
    }
}