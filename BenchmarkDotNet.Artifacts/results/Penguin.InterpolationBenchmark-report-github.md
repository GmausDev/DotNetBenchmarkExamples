```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.100
  [Host]               : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  .NET 5.0             : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  .NET 6.0             : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  .NET 7.0             : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  .NET 8.0             : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  .NET Core 3.1        : .NET Core 3.1.32 (CoreCLR 4.700.22.55902, CoreFX 4.700.22.56512), X64 RyuJIT AVX2
  .NET Framework 4.8.1 : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256


```
| Method        | Job                  | Runtime              | Mean     | Error    | StdDev    | Median   | Ratio        | RatioSD |
|-------------- |--------------------- |--------------------- |---------:|---------:|----------:|---------:|-------------:|--------:|
| Interpolation | .NET 5.0             | .NET 5.0             | 56.81 ns | 1.417 ns |  4.020 ns | 56.10 ns | 1.28x slower |   0.07x |
| Interpolation | .NET 6.0             | .NET 6.0             | 54.73 ns | 4.290 ns | 12.650 ns | 59.25 ns | 1.13x faster |   0.08x |
| Interpolation | .NET 7.0             | .NET 7.0             | 49.30 ns | 1.035 ns |  0.968 ns | 48.91 ns | 1.01x slower |   0.02x |
| Interpolation | .NET 8.0             | .NET 8.0             | 48.83 ns | 0.697 ns |  0.618 ns | 49.03 ns |     baseline |         |
| Interpolation | .NET Core 3.1        | .NET Core 3.1        | 75.87 ns | 2.181 ns |  6.293 ns | 75.15 ns | 1.57x slower |   0.09x |
| Interpolation | .NET Framework 4.8.1 | .NET Framework 4.8.1 | 79.67 ns | 2.248 ns |  6.302 ns | 78.91 ns | 1.75x slower |   0.14x |
