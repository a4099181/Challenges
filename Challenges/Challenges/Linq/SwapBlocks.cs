using System.Linq;

namespace Challenges.Challenges.Linq
{
    class SwapBlocks
    {
        internal static string Swap( string input, int n )
            => new string( Swap( input.ToCharArray(), n ) );

        internal static char[] Swap( char[] array, int n )
            => array.Skip( n ).Concat( array.Take( n ) ).ToArray();
    }
}