using System.Diagnostics;

namespace Challenges.Challenges.Arrays
{
    class SwapBlocksUnsafe
    {
        internal static string Swap( string input, int firstBlockSize )
            => new string( Swap( input.ToCharArray(), firstBlockSize ) );

        internal static char[] Swap( char[] input, int firstBlockSize )
            =>
                2 * firstBlockSize > input.Length
                    ? MoveBlockToLeft( input, input.Length - firstBlockSize, 0, input.Length )
                    : MoveBlockToRight( input, firstBlockSize, 0, input.Length );

        static char[] MoveBlockToRight( char[] input, int blockSize, int from, int to )
        {
            Debug.WriteLine( "==> to right ==> [>>>xxxx]" );

            var freeBlockSize = ( to - @from ) % blockSize;
            var affectedRange = new
            {
                from = from + blockSize,
                to = to - freeBlockSize
            };

            for ( var i = affectedRange.from; i < affectedRange.to; i = i + blockSize )
            {
                SwapWithPrevious( input, blockSize, i );
            }

            return freeBlockSize == 0
                ? input
                : MoveBlockToLeft( input, freeBlockSize, affectedRange.to - blockSize, to );
        }

        static char[] MoveBlockToLeft( char[] input, int blockSize, int from, int to )
        {
            Debug.WriteLine( "<== to left <== [xxxx<<<]" );

            var freeBlockSize = ( to - @from ) % blockSize;
            var affectedRange = new
            {
                from = from + freeBlockSize,
                to = to - blockSize
            };

            for ( var i = affectedRange.to; i > affectedRange.from; i = i - blockSize )
            {
                SwapWithPrevious( input, blockSize, i );
            }

            return freeBlockSize == 0
                ? input
                : MoveBlockToRight( input, freeBlockSize, from, affectedRange.from + blockSize );
        }

        static unsafe void SwapWithPrevious( char[] input, int blockSize, int startAt )
        {
            for ( var j = 0; j < blockSize; j++ )
            {
                fixed ( char* swap = &input[ startAt + j ]
                    , with = &input[ startAt + j - blockSize ] )
                {
                    var swapped = *swap;
                    *swap = *with;
                    *with = swapped;
                }

                Debug.WriteLine( new string( input ).PadLeft( 15 ) );
            }
        }
    }
}