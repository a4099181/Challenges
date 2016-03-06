```ini
BenchmarkDotNet=v0.9.2.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500 CPU @ 3.30GHz, ProcessorCount=3
Frequency=10000000 ticks, Resolution=100.0000 ns
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE

Type=SwapBlocksBench  Mode=Throughput  

```
                            Method |        Median |      StdDev |
---------------------------------- |-------------- |------------ |
  SwapBlocksInOneMillionCharsArray | 4,394.4031 us | 258.0343 us |
 SwapBlocksInOneThousandCharsArray |     4.3157 us |   0.3205 us |
