using System.Collections.Generic;
using System.Linq;

namespace Challenges.Challenges.Linq
{
    class BeforeLastWithSum
    {
        internal static char Get( IList<char> input )
            => input[ GetIndex( input ) ];

        internal static int GetIndex( IList<char> input )
            => input.Select( _ => 1 ).Sum() - 2;
    }
}