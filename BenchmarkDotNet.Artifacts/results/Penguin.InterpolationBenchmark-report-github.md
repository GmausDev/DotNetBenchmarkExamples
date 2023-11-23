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
| Interpolation | .NET 5.0             | .NET 5.0             | 60.15 ns | 4.543 ns | 13.394 ns | 53.36 ns | 2.01x slower |   0.38x |
| Interpolation | .NET 6.0             | .NET 6.0             | 44.52 ns | 5.773 ns | 17.022 ns | 33.65 ns | 2.02x slower |   0.19x |
| Interpolation | .NET 7.0             | .NET 7.0             | 39.36 ns | 0.770 ns |  0.720 ns | 39.42 ns | 1.07x slower |   0.02x |
| Interpolation | .NET 8.0             | .NET 8.0             | 36.66 ns | 0.450 ns |  0.421 ns | 36.57 ns |     baseline |         |
| Interpolation | .NET Core 3.1        | .NET Core 3.1        | 54.72 ns | 1.141 ns |  2.028 ns | 54.30 ns | 1.48x slower |   0.07x |
| Interpolation | .NET Framework 4.8.1 | .NET Framework 4.8.1 | 72.14 ns | 1.846 ns |  4.926 ns | 70.98 ns | 1.99x slower |   0.14x |
