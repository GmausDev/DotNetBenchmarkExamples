```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method        | Job                  | Runtime              | Mean     | Error    | StdDev   | Ratio        | RatioSD |
|-------------- |--------------------- |--------------------- |---------:|---------:|---------:|-------------:|--------:|
| Interpolation | .NET 5.0             | .NET 5.0             |       NA |       NA |       NA |            ? |       ? |
| Interpolation | .NET 6.0             | .NET 6.0             | 81.51 ns | 1.091 ns | 0.967 ns | 1.04x slower |   0.02x |
| Interpolation | .NET 7.0             | .NET 7.0             | 78.64 ns | 0.695 ns | 0.616 ns | 1.01x slower |   0.01x |
| Interpolation | .NET 8.0             | .NET 8.0             | 78.09 ns | 0.728 ns | 0.608 ns |     baseline |         |
| Interpolation | .NET Core 3.1        | .NET Core 3.1        |       NA |       NA |       NA |            ? |       ? |
| Interpolation | .NET Framework 4.8.1 | .NET Framework 4.8.1 |       NA |       NA |       NA |            ? |       ? |

Benchmarks with issues:
  SparksAndFrameworksBenchmark.Interpolation: .NET 5.0(Runtime=.NET 5.0)
  SparksAndFrameworksBenchmark.Interpolation: .NET Core 3.1(Runtime=.NET Core 3.1)
  SparksAndFrameworksBenchmark.Interpolation: .NET Framework 4.8.1(Runtime=.NET Framework 4.8.1)
