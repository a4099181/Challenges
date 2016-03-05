using Challenges.Challenges.Linq;
using Machine.Specifications;

namespace Challenges.Tests.Linq
{
    [Subject( typeof ( SwapBlocks ) )]
    class SwapBlocksSpec
    {
        Because _of = () =>
        {
            _foobar = SwapBlocks.Swap( "foobar", 3 );
            _jamesBond = SwapBlocks.Swap( "JamesBond", 5 );
        };

        It _swappedFoobarShouldBeBarfoo =
            () => _foobar.ShouldEqual( "barfoo" );

        It _swappedJamesBondShouldBeBondJames =
            () => _jamesBond.ShouldEqual( "BondJames" );

        static string _foobar;
        static string _jamesBond;
    }
}