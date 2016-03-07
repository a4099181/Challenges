using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Challenges.Arrays
{
    class SwapBlocksMta
    {
        internal static string Swap( string input, int firstBlockSize )
            => new string( Swap( input.ToCharArray(), firstBlockSize ) );

        internal static char[] Swap( char[] input, int firstBlockSize )
        {
            if (2 * firstBlockSize > input.Length)
            {
                MoveToLeftAsync( input, 0, input.Length, input.Length - firstBlockSize ).Wait();
            }
            else
            {
                MoveToRightAsync( input, 0, input.Length, firstBlockSize ).Wait();
            }

            return input;
        }

        static async Task MoveToRightAsync( char[] input, int from, int to, int size )
        {
            var freeBlockSize = ( to - from ) % size;
            var block = new
            {
                from = from + size,
                to = to - freeBlockSize
            };

            var threads = Math.Min( size, Environment.ProcessorCount );
            var tasks = from t in Enumerable.Range( 0, threads )
                select Task.Run( () => MoveToRightTask( input, block.@from, block.to, size, threads, t ) );

            await Task.WhenAll( tasks );

            if (freeBlockSize > 0)
            {
                await MoveToLeftAsync( input, block.to - size, to, freeBlockSize );
            }
        }

        static void MoveToRightTask( char[] input, int from, int to, int size, int threads, int thread )
        {
            Debug.WriteLine( $"{thread})==> to right ==> [>>>xxxx]" );

            for ( var i = from; i < to; i = i + size )
            {
                SwapWithPrevious( input, i + thread, size, threads, thread );
            }
        }

        static async Task MoveToLeftAsync( char[] input, int from, int to, int size )
        {
            var freeBlockSize = ( to - from ) % size;
            var block = new
            {
                from = from + freeBlockSize,
                to = to - size
            };

            var threads = Math.Min( size, Environment.ProcessorCount );
            var tasks = from t in Enumerable.Range( 0, threads )
                select Task.Run( () => MoveToLeftTask( input, block.@from, block.to, size, threads, t ) );

            await Task.WhenAll( tasks );

            if (freeBlockSize > 0)
            {
                await MoveToRightAsync( input, from, block.from + size, freeBlockSize );
            }
        }

        static void MoveToLeftTask( char[] input, int from, int to, int size, int threads, int thread )
        {
            Debug.WriteLine( $"{thread})<== to left <== [xxxx<<<]" );

            for ( var i = to; i > from; i = i - size )
            {
                SwapWithPrevious( input, i + thread, size, threads, thread );
            }
        }

        static unsafe void SwapWithPrevious( char[] input, int start, int size, int threads, int thread )
        {
            for ( var j = 0; j < size - thread; j = j + threads )
            {
                fixed ( char* swap = &input[ start + j ]
                    , with = &input[ start + j - size ] )
                {
                    var swapped = *swap;
                    *swap = *with;
                    *with = swapped;
                }

                Debug.WriteLine( $"{thread}){new string( input ),15}" );
            }
        }
    }
}