```ini
BenchmarkDotNet=v0.9.2.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500 CPU @ 3.30GHz, ProcessorCount=3
Frequency=10000000 ticks, Resolution=100.0000 ns
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE

Type=SwapBlocksBench  Mode=Throughput  

```
                                 Method |         Median |        StdDev |
--------------------------------------- |--------------- |-------------- |
  SwapBlocksInOneMillionCharsArray_Linq | 25,881.6500 us | 1,498.0779 us |
       SwapBlocksInOneMillionCharsArray |  3,569.3500 us |   154.3501 us |
 SwapBlocksInOneThousandCharsArray_Linq |     25.1852 us |     1.0915 us |
      SwapBlocksInOneThousandCharsArray |      3.5594 us |     0.1802 us |
