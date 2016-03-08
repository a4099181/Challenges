```ini
BenchmarkDotNet=v0.9.2.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500 CPU @ 3.30GHz, ProcessorCount=3
Frequency=10000000 ticks, Resolution=100.0000 ns
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE

Type=SwapBlocksBench  Mode=Throughput  

```
                                          Method |             Median |            StdDev |
------------------------------------------------ |------------------- |------------------ |
           SwapBlocksInOneMillionCharsArray_Linq | 23,351,962.5000 ns | 1,033,045.8826 ns |
            SwapBlocksInOneMillionCharsArray_Mta |  1,836,542.1875 ns |   113,939.3598 ns |
                SwapBlocksInOneMillionCharsArray |  3,685,789.0625 ns |   159,223.0523 ns |
  SwapBlocksInOneMillionCharsArray_TripleReverse |    862,001.7578 ns |    41,358.2216 ns |
         SwapBlocksInOneMillionCharsArray_Unsafe |  3,116,211.3281 ns |    65,640.4489 ns |
          SwapBlocksInOneThousandCharsArray_Linq |     22,715.8417 ns |       624.7505 ns |
           SwapBlocksInOneThousandCharsArray_Mta |     11,289.8590 ns |       634.0909 ns |
               SwapBlocksInOneThousandCharsArray |      3,947.2153 ns |       140.7489 ns |
 SwapBlocksInOneThousandCharsArray_TripleReverse |        965.7844 ns |        35.1673 ns |
        SwapBlocksInOneThousandCharsArray_Unsafe |      3,332.1882 ns |       250.7237 ns |
