```ini
BenchmarkDotNet=v0.9.2.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500 CPU @ 3.30GHz, ProcessorCount=3
Frequency=10000000 ticks, Resolution=100.0000 ns
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE

Type=SwapBlocksBench  Mode=Throughput  

```
                                          Method |             Median |          StdDev |
------------------------------------------------ |------------------- |---------------- |
           SwapBlocksInOneMillionCharsArray_Linq | 23,276,725.0000 ns | 782,348.7115 ns |
            SwapBlocksInOneMillionCharsArray_Mta |  1,800,566.4063 ns | 153,920.7041 ns |
       SwapBlocksInOneMillionCharsArray_Parallel |  1,617,972.2656 ns | 137,736.6620 ns |
                SwapBlocksInOneMillionCharsArray |  3,693,123.4375 ns | 153,052.4331 ns |
  SwapBlocksInOneMillionCharsArray_TripleReverse |    857,128.9063 ns |  31,643.8578 ns |
         SwapBlocksInOneMillionCharsArray_Unsafe |  3,080,021.8750 ns | 107,203.5716 ns |
          SwapBlocksInOneThousandCharsArray_Linq |     23,151.1078 ns |   1,629.3305 ns |
           SwapBlocksInOneThousandCharsArray_Mta |     11,597.5891 ns |     584.6262 ns |
      SwapBlocksInOneThousandCharsArray_Parallel |     12,497.3923 ns |     694.6706 ns |
               SwapBlocksInOneThousandCharsArray |      3,807.6138 ns |     232.2637 ns |
 SwapBlocksInOneThousandCharsArray_TripleReverse |        981.1211 ns |      45.0404 ns |
        SwapBlocksInOneThousandCharsArray_Unsafe |      3,356.6441 ns |     184.9572 ns |
