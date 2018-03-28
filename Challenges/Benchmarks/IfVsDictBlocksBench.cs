using System.Linq;
using BenchmarkDotNet.Attributes;
using Challenges.Challenges;

namespace Challenges.Benchmarks
{
  public class IfVsDictBlocksBench
  {
    readonly char[] _one;
    readonly char[] _oneMillionChars;
    readonly char[] _oneThousandChars;

    public IfVsDictBlocksBench()
    {
      _oneMillionChars = Enumerable.Repeat( "0123456789abcdef", 1000000 / 16 )
        .SelectMany( x => x ).Select( x => x ).ToArray();
      _oneThousandChars = Enumerable.Repeat( "0123456789abcdef", 1000 / 16 )
        .SelectMany( x => x ).Select( x => x ).ToArray();
      _one = _oneThousandChars.Take( 1 ).ToArray();
    }

    [Benchmark]
    public int[] UseCond_Million()
      => IfVsDict.UseCond( _oneMillionChars );

    [Benchmark]
    public int[] UseCond_One()
      => IfVsDict.UseCond( _one );

    [Benchmark]
    public int[] UseCond_Thousand()
      => IfVsDict.UseCond( _oneThousandChars );

    [Benchmark]
    public int[] UseDict_Million()
      => IfVsDict.UseDict( _oneMillionChars );

    [Benchmark]
    public int[] UseDict_One()
      => IfVsDict.UseDict( _one );

    [Benchmark]
    public int[] UseDict_Thousand()
      => IfVsDict.UseDict( _oneThousandChars );

    [Benchmark]
    public int[] UseIf_Million()
      => IfVsDict.UseIf( _oneMillionChars );

    [Benchmark]
    public int[] UseIf_One()
      => IfVsDict.UseIf( _one );

    [Benchmark]
    public int[] UseIf_Thousand()
      => IfVsDict.UseIf( _oneThousandChars );

    [Benchmark]
    public int[] UseSwitch_Million()
      => IfVsDict.UseSwitch( _oneMillionChars );

    [Benchmark]
    public int[] UseSwitch_One()
      => IfVsDict.UseSwitch( _one );

    [Benchmark]
    public int[] UseSwitch_Thousand()
      => IfVsDict.UseSwitch( _oneThousandChars );
  }
}
