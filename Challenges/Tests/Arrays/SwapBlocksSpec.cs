using Challenges.Challenges.Arrays;
using Machine.Specifications;

namespace Challenges.Tests.Arrays
{
    [Subject( typeof ( SwapBlocks ) )]
    class SwapBlocksSpec
    {
        Because _of = () =>
        {
            _joeCameron = SwapBlocks.Swap( "JoeCameron", 3 );
            _jamesBlack = SwapBlocks.Swap( "JamesBlack", 5 );
            _joeWilderman = SwapBlocks.Swap( "JoeWilderman", 3 );
            _jonathanDoe = SwapBlocks.Swap( "JonathanDoe", 8 );
            _jamesBond = SwapBlocks.Swap( "JamesBond", 5 );
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