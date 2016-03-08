```ini
BenchmarkDotNet=v0.9.2.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500 CPU @ 3.30GHz, ProcessorCount=3
Frequency=10000000 ticks, Resolution=100.0000 ns
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE

Type=SwapBlocksBench  Mode=Throughput  

```
                                   Method |         Median |        StdDev |
----------------------------------------- |--------------- |-------------- |
    SwapBlocksInOneMillionCharsArray_Linq | 24,418.2938 us | 1,412.9228 us |
     SwapBlocksInOneMillionCharsArray_Mta |  1,948.3547 us |   149.3281 us |
         SwapBlocksInOneMillionCharsArray |  3,869.6086 us |   153.6214 us |
  SwapBlocksInOneMillionCharsArray_Unsafe |  3,333.0418 us |   135.9808 us |
   SwapBlocksInOneThousandCharsArray_Linq |     23.5428 us |     0.7585 us |
    SwapBlocksInOneThousandCharsArray_Mta |     10.9949 us |     0.6794 us |
        SwapBlocksInOneThousandCharsArray |      4.3223 us |     0.1596 us |
 SwapBlocksInOneThousandCharsArray_Unsafe |      3.4050 us |     0.1059 us |
