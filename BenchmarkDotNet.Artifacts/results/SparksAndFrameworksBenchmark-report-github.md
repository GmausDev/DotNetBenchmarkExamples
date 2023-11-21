```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method        | Job      | Runtime  | Mean     | Error    | StdDev   | Median   | Ratio        | RatioSD |
|-------------- |--------- |--------- |---------:|---------:|---------:|---------:|-------------:|--------:|
| Interpolation | .NET 6.0 | .NET 6.0 | 48.45 ns | 2.022 ns | 5.899 ns | 47.69 ns |     baseline |         |
| Interpolation | .NET 7.0 | .NET 7.0 | 58.97 ns | 2.172 ns | 6.404 ns | 60.42 ns | 1.23x slower |   0.16x |
| Interpolation | .NET 8.0 | .NET 8.0 | 61.47 ns | 2.154 ns | 6.145 ns | 59.80 ns | 1.29x slower |   0.23x |
