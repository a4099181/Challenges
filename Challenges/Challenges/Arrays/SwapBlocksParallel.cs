using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Challenges.Challenges.Arrays
{
    class SwapBlocksParallel
    {
        internal static string Swap( string input, int firstBlockSize )
            => new string( Swap( input.ToCharArray(), firstBlockSize ) );

        internal static char[] Swap( char[] input, int firstBlockSize )
        {
            if (2 * firstBlockSize > input.Length)
            {
                MoveToLeft( input, 0, input.Length, input.Length - firstBlockSize );
            }
            else
            {
                MoveToRight( input, 0, input.Length, firstBlockSize );
            }

            return input;
        }

        static void MoveToRight( char[] input, int from, int to, int size )
        {
            var freeBlockSize = ( to - from ) % size;
            var range = new
            {
                from = from + size,
                to = to - freeBlockSize
            };

            Parallel.For( 0, size, j => MoveToRight( input, range.@from, range.to, j, size ) );

            if (freeBlockSize > 0)
            {
                MoveToLeft( input, range.to - size, to, freeBlockSize );
            }
        }

        static void MoveToRight( char[] input, int from, int to, int offset, int size )
        {
            Debug.WriteLine( $"{Thread.CurrentThread.ManagedThreadId}==> to right ==> [>>>xxxx]" );

            for ( var i = from; i < to; i = i + size )
            {
                SwapWithPrevious( input, i + offset, size );
            }
        }

        static void MoveToLeft( char[] input, int from, int to, int size )
        {
            var freeBlockSize = ( to - from ) % size;
            var range = new
            {
                from = from + freeBlockSize,
                to = to - size
            };

            Parallel.For( 0, size, j => MoveToLeft( input, range.@from, range.to, j, size ) );

            if (freeBlockSize > 0)
            {
                MoveToRight( input, from, range.from + size, freeBlockSize );
            }
        }

        static void MoveToLeft( char[] input, int @from, int to, int offset, int size )
        {
            Debug.WriteLine( $"{Thread.CurrentThread.ManagedThreadId}<== to left <== [xxxx<<<]" );

            for ( var i = to; i > from; i = i - size )
            {
                SwapWithPrevious( input, i + offset, size );
            }
        }

        static unsafe void SwapWithPrevious( char[] input, int start, int size )
        {
            fixed ( char* swap = &input[ start ]
                , with = &input[ start - size ] )
            {
                var swapped = *swap;
                *swap = *with;
                *with = swapped;
            }

            Debug.WriteLine( $"{Thread.CurrentThread.ManagedThreadId}){new string( input ),15}" );
        }
    }
}