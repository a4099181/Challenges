using Challenges.Challenges.Arrays;
using Machine.Specifications;

namespace Challenges.Tests.Arrays
{
    [Subject( typeof ( SwapBlocksParallel ) )]
    class SwapBlocksParallelSpec

    {
        Because _of = () =>
        {
            _joeCameron = SwapBlocksParallel.Swap( "JoeCameron", 3 );
            _jamesBlack = SwapBlocksParallel.Swap( "JamesBlack", 5 );
            _joeWilderman = SwapBlocksParallel.Swap( "JoeWilderman", 3 );
            _jonathanDoe = SwapBlocksParallel.Swap( "JonathanDoe", 8 );
            _jamesBond = SwapBlocksParallel.Swap( "JamesBond", 5 );
        };

        It _swappedJamesBlackShouldBeBlackJames =
            () => _jamesBlack.ShouldEqual( "BlackJames" );

        It _swappedJoeWildermanShouldBeWildermanJoe =
            () => _joeWilderman.ShouldEqual( "WildermanJoe" );

        It _swappedJamesBondShouldBeBondJames =
            () => _jamesBond.ShouldEqual( "BondJames" );

        It _swappedJoeCameronShouldBeCameronJoe =
            () => _joeCameron.ShouldEqual( "CameronJoe" );

        It _swappedJonathanDoeShouldBeDoeJonathan =
            () => _jonathanDoe.ShouldEqual( "DoeJonathan" );

        static string _jamesBlack;
        static string _jamesBond;
        static string _joeCameron;
        static string _joeWilderman;
        static string _jonathanDoe;
    }
}