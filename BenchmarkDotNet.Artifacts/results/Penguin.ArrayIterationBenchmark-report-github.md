```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=.NET 8.0  Runtime=.NET 8.0  

```
| Method        | N   | Mean     | Error    | StdDev   | Median   | Rank | Gen0   | Allocated |
|-------------- |---- |---------:|---------:|---------:|---------:|-----:|-------:|----------:|
| ForEachLoop   | 500 | 133.8 ns |  0.61 ns |  0.57 ns | 133.9 ns |    1 |      - |         - |
| ForLoop       | 500 | 139.8 ns |  1.53 ns |  1.28 ns | 139.6 ns |    2 |      - |         - |
| ArrayForEach  | 500 | 140.2 ns |  0.85 ns |  0.79 ns | 140.2 ns |    2 |      - |         - |
| SpanForEach   | 500 | 142.1 ns |  1.02 ns |  0.96 ns | 142.3 ns |    2 |      - |         - |
| SpanFor       | 500 | 150.7 ns |  2.67 ns |  2.50 ns | 150.7 ns |    3 |      - |         - |
| GetEnumerator | 500 | 557.2 ns | 11.17 ns | 28.83 ns | 548.6 ns |    4 | 0.0048 |      32 B |
