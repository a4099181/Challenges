using System;
using System.Collections.Generic;

namespace Challenges.Challenges
{
  static class IfVsDict
  {
    static readonly Dictionary<char, int> Dict = new Dictionary<char, int>
    {
      {'0', 0},
      {'1', 1},
      {'2', 2},
      {'3', 3},
      {'4', 4},
      {'5', 5},
      {'6', 6},
      {'7', 7},
      {'8', 8},
      {'9', 9},
      {'a', 10},
      {'b', 11},
      {'c', 12},
      {'d', 13},
      {'e', 14},
      {'f', 15},
    };

    internal static int[] UseDict( char[] chars )
    {
      return Array.ConvertAll( chars, ToInt );

      int ToInt( char input ) => Dict[ input ];
    }

    internal static int[] UseIf( char[] chars )
    {
      return Array.ConvertAll( chars, ToInt );

      int ToInt( char input )
      {
        if (input == '0')
        {
          return 0;
        }

        if (input == '1')
        {
          return 1;
        }

        if (input == '2')
        {
          return 2;
        }

        if (input == '3')
        {
          return 3;
        }

        if (input == '4')
        {
          return 4;
        }

        if (input == '5')
        {
          return 5;
        }

        if (input == '6')
        {
          return 6;
        }

        if (input == '7')
        {
          return 7;
        }

        if (input == '8')
        {
          return 8;
        }

        if (input == '9')
        {
          return 9;
        }

        if (input == 'a')
        {
          return 10;
        }

        if (input == 'b')
        {
          return 11;
        }

        if (input == 'c')
        {
          return 12;
        }

        if (input == 'd')
        {
          return 13;
        }

        if (input == 'e')
        {
          return 14;
        }

        if (input == 'f')
        {
          return 15;
        }

        throw new ArgumentOutOfRangeException( nameof(input) );
      }
    }

    internal static int[] UseSwitch( char[] chars )
    {
      return Array.ConvertAll( chars, ToInt );

      int ToInt( char input )
      {
        switch (input)
        {
          case '0':
            return 0;
          case '1':
            return 1;
          case '2':
            return 2;
          case '3':
            return 3;
          case '4':
            return 4;
          case '5':
            return 5;
          case '6':
            return 6;
          case '7':
            return 7;
          case '8':
            return 8;
          case '9':
            return 9;
          case 'a':
            return 10;
          case 'b':
            return 11;
          case 'c':
            return 12;
          case 'd':
            return 13;
          case 'e':
            return 14;
          case 'f':
            return 15;
        }

        throw  new ArgumentOutOfRangeException(nameof(input));
      }
    }

    internal static int[] UseCond( char[] chars )
    {
      return Array.ConvertAll( chars, ToInt );

      int ToInt( char input )
        => input == '0' ? 0
          : input == '1' ? 1
          : input == '2' ? 2
          : input == '3' ? 3
          : input == '4' ? 4
          : input == '5' ? 5
          : input == '6' ? 6
          : input == '7' ? 7
          : input == '8' ? 8
          : input == '9' ? 9
          : input == 'a' ? 10
          : input == 'b' ? 11
          : input == 'c' ? 12
          : input == 'd' ? 13
          : input == 'e' ? 14
          : input == 'f' ? 15
          : throw new ArgumentOutOfRangeException( nameof(input) );
    }
  }
}
