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
           SwapBlocksInOneMillionCharsArray_Linq | 23,616,528.1250 ns | 831,835.5147 ns |
            SwapBlocksInOneMillionCharsArray_Mta |  1,842,226.5625 ns | 131,991.5274 ns |
                SwapBlocksInOneMillionCharsArray |  3,732,751.5625 ns | 135,419.4330 ns |
          SwapBlocksInOneThousandCharsArray_Linq |     23,980.9387 ns |   1,060.9825 ns |
           SwapBlocksInOneThousandCharsArray_Mta |     11,365.2100 ns |     699.6984 ns |
               SwapBlocksInOneThousandCharsArray |      3,915.6082 ns |     153.2379 ns |
