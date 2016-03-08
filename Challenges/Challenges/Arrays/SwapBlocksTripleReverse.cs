using System;

namespace Challenges.Challenges.Arrays
{
    class SwapBlocksTripleReverse
    {
        internal static string Swap( string input, int firstBlockSize )
            => new string( Swap( input.ToCharArray(), firstBlockSize ) );

        internal static char[] Swap( char[] input, int firstBlockSize )
        {
            Array.Reverse( input, 0, firstBlockSize );
            Array.Reverse( input, firstBlockSize, input.Length - firstBlockSize );
            Array.Reverse( input );
            return input;
        }
    }
}