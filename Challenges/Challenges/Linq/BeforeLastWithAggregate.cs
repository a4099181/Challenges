using System.Collections.Generic;
using System.Linq;

namespace Challenges.Challenges.Linq
{
    class BeforeLastWithAggregate
    {
        internal static char Get( IList<char> input )
            => input[ GetIndex( input ) ];

        internal static int GetIndex( IList<char> input )
            =>
                input.Select( ( c, x ) => x )
                    .Aggregate( -1, ( _, x ) => x ) - 1;
    }
}