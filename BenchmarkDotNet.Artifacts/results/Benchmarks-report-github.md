```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
AMD Ryzen 7 1800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.402
  [Host]     : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2


```
| Method | Mean      | Error    | StdDev   | Ratio | RatioSD |
|------- |----------:|---------:|---------:|------:|--------:|
| Div1   |  37.87 μs | 0.152 μs | 0.142 μs |  1.00 |    0.00 |
| Div2   |  76.12 μs | 0.752 μs | 0.704 μs |  2.01 |    0.02 |
| Div3   | 113.58 μs | 0.382 μs | 0.357 μs |  3.00 |    0.01 |
| Div4   | 151.40 μs | 0.556 μs | 0.520 μs |  4.00 |    0.02 |
| Div5   | 189.32 μs | 0.527 μs | 0.493 μs |  5.00 |    0.02 |
