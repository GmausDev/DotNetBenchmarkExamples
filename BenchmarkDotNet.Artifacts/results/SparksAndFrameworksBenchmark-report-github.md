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
| Interpolation | .NET 6.0             | .NET 6.0             | 46.40 ns | 0.504 ns | 0.690 ns | 1.09x slower |   0.02x |
| Interpolation | .NET 7.0             | .NET 7.0             | 47.79 ns | 0.994 ns | 1.184 ns | 1.12x slower |   0.03x |
| Interpolation | .NET 8.0             | .NET 8.0             | 42.67 ns | 0.268 ns | 0.250 ns |     baseline |         |
| Interpolation | .NET Core 3.1        | .NET Core 3.1        |       NA |       NA |       NA |            ? |       ? |
| Interpolation | .NET Framework 4.8.1 | .NET Framework 4.8.1 |       NA |       NA |       NA |            ? |       ? |
| Interpolation | NativeAOT 8.0        | NativeAOT 8.0        |       NA |       NA |       NA |            ? |       ? |

Benchmarks with issues:
  SparksAndFrameworksBenchmark.Interpolation: .NET Core 3.1(Runtime=.NET Core 3.1)
  SparksAndFrameworksBenchmark.Interpolation: .NET Framework 4.8.1(Runtime=.NET Framework 4.8.1)
  SparksAndFrameworksBenchmark.Interpolation: NativeAOT 8.0(Runtime=NativeAOT 8.0)
