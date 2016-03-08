using System.Diagnostics;

namespace Challenges.Challenges.Arrays
{
    class SwapBlocks
    {
        internal static string Swap( string input, int firstBlockSize )
            => new string( Swap( input.ToCharArray(), firstBlockSize ) );

        internal static char[] Swap( char[] input, int firstBlockSize )
            =>
                2 * firstBlockSize > input.Length
                    ? MoveBlockToLeft( input, firstBlockSize )
                    : MoveBlockToRight( input, firstBlockSize );

        static char[] MoveBlockToRight( char[] input, int firstBlockSize )
            => MoveBlockToRight( input, firstBlockSize, 0, input.Length );

        static char[] MoveBlockToLeft( char[] input, int firstBlockSize )
            =>
                MoveBlockToLeft(
                    input,
                    input.Length - firstBlockSize,
                    0,
                    input.Length );

        static char[] MoveBlockToRight(
            char[] input,
            int blockSize,
            int from,
            int to )
        {
            Debug.WriteLine( "==> to right ==> [>>>xxxx]" );

            var freeBlockSize = ( to - @from ) % blockSize;
            var affectedRange = new
            {
                from = from + blockSize,
                to = to - freeBlockSize
            };

            for ( var i = affectedRange.from;
                i < affectedRange.to;
                i = i + blockSize )
            {
                ReplaceWithPrevious( input, blockSize, i );
            }

            return freeBlockSize == 0
                ? input
                : MoveBlockToLeft(
                    input,
                    freeBlockSize,
                    affectedRange.to - blockSize,
                    to );
        }

        static char[] MoveBlockToLeft(
            char[] input,
            int blockSize,
            int from,
            int to )
        {
            Debug.WriteLine( "<== to left <== [xxxx<<<]" );

            var freeBlockSize = ( to - @from ) % blockSize;
            var affectedRange = new
            {
                from = from + freeBlockSize,
                to = to - blockSize
            };

            for ( var i = affectedRange.to;
                i > affectedRange.from;
                i = i - blockSize )
            {
                ReplaceWithPrevious( input, blockSize, i );
            }

            return freeBlockSize == 0
                ? input
                : MoveBlockToRight(
                    input,
                    freeBlockSize,
                    from,
                    affectedRange.from + blockSize );
        }

        static void ReplaceWithPrevious(
            char[] input,
            int blockSize,
            int startAt )
        {
            for ( var j = 0; j < blockSize; j++ )
            {
                var replacement = input[ startAt + j - blockSize ];
                input[ startAt + j - blockSize ] = input[ startAt + j ];
                input[ startAt + j ] = replacement;

                Debug.WriteLine( new string( input ).PadLeft( 15 ) );
            }
        }
    }
}