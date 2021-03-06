using System.Collections.Generic;
using Challenges.Challenges.Linq;
using Machine.Specifications;
using NSubstitute;

namespace Challenges.Tests.Linq
{
    [Subject( typeof ( BeforeLastWithAggregate ) )]
    class BeforeLastWithAggregateSpec
    {
        Establish _context = () =>
        {
            _mockedList = Substitute.For<IList<char>>();
            _mockedList.GetEnumerator()
                .Returns( _ => "length7".GetEnumerator() );
        };

        Because _of = () =>
        {
            _emptyArray = BeforeLastWithAggregate.GetIndex( new char[0] );
            _singleItemArray =
                BeforeLastWithAggregate.GetIndex( new[] {'a'} );
            _beforeLastIndexOfMockedList =
                BeforeLastWithAggregate.GetIndex( _mockedList );
            _bar = BeforeLastWithAggregate.Get( "QWEZXCaS".ToCharArray() );
        };

        It _beforeLastCharOfBarShouldBeSmallLetterA =
            () => _bar.ShouldEqual( 'a' );

        It _beforeLastCharOfEmptyArrayShouldBeMinus2 =
            () => _emptyArray.ShouldEqual( -2 );

        It _beforeLastCharOfSingleItemArrayShouldBeMinus2 =
            () => _singleItemArray.ShouldEqual( -1 );

        It _beforeLastIndexOfMockedListShouldBe5 =
            () => _beforeLastIndexOfMockedList.ShouldEqual( 5 );

        It _propertyCountShouldNotbeInvoked = () =>
        {
            var list_Count = _mockedList.DidNotReceive().Count;
            var collection_Count =
                ( ( ICollection<char> ) _mockedList ).DidNotReceive().Count;
        };

        static char _bar;
        static int _beforeLastIndexOfMockedList;
        static int _emptyArray;
        static IList<char> _mockedList;
        static int _singleItemArray;
    }
}