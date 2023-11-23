```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method | Job                  | Runtime              | Mean     | Error    | StdDev   | Ratio        | RatioSD |
|------- |--------------------- |--------------------- |---------:|---------:|---------:|-------------:|--------:|
| Div1   | .NET 6.0             | .NET 6.0             | 29.71 μs | 0.479 μs | 0.448 μs | 1.01x faster |   0.02x |
| Div2   | .NET 6.0             | .NET 6.0             | 29.83 μs | 0.575 μs | 0.615 μs | 1.01x faster |   0.02x |
| Div3   | .NET 6.0             | .NET 6.0             | 44.79 μs | 0.847 μs | 0.792 μs | 1.49x slower |   0.02x |
| Div4   | .NET 6.0             | .NET 6.0             | 60.10 μs | 0.729 μs | 0.681 μs | 2.00x slower |   0.02x |
| Div5   | .NET 6.0             | .NET 6.0             | 74.67 μs | 1.468 μs | 1.508 μs | 2.48x slower |   0.04x |
| Div1   | .NET 7.0             | .NET 7.0             | 30.24 μs | 0.151 μs | 0.134 μs | 1.00x slower |   0.01x |
| Div2   | .NET 7.0             | .NET 7.0             | 30.44 μs | 0.125 μs | 0.097 μs | 1.01x slower |   0.01x |
| Div3   | .NET 7.0             | .NET 7.0             | 45.23 μs | 0.879 μs | 1.079 μs | 1.50x slower |   0.04x |
| Div4   | .NET 7.0             | .NET 7.0             | 60.34 μs | 0.700 μs | 0.655 μs | 2.00x slower |   0.04x |
| Div5   | .NET 7.0             | .NET 7.0             | 75.90 μs | 1.387 μs | 2.199 μs | 2.54x slower |   0.07x |
| Div1   | .NET 8.0             | .NET 8.0             | 30.10 μs | 0.432 μs | 0.383 μs |     baseline |         |
| Div2   | .NET 8.0             | .NET 8.0             | 30.61 μs | 0.261 μs | 0.231 μs | 1.02x slower |   0.01x |
| Div3   | .NET 8.0             | .NET 8.0             | 45.39 μs | 0.793 μs | 0.741 μs | 1.51x slower |   0.03x |
| Div4   | .NET 8.0             | .NET 8.0             | 59.58 μs | 0.630 μs | 0.590 μs | 1.98x slower |   0.03x |
| Div5   | .NET 8.0             | .NET 8.0             | 74.88 μs | 0.727 μs | 0.680 μs | 2.49x slower |   0.03x |
| Div1   | .NET Core 3.1        | .NET Core 3.1        |       NA |       NA |       NA |            ? |       ? |
| Div2   | .NET Core 3.1        | .NET Core 3.1        |       NA |       NA |       NA |            ? |       ? |
| Div3   | .NET Core 3.1        | .NET Core 3.1        |       NA |       NA |       NA |            ? |       ? |
| Div4   | .NET Core 3.1        | .NET Core 3.1        |       NA |       NA |       NA |            ? |       ? |
| Div5   | .NET Core 3.1        | .NET Core 3.1        |       NA |       NA |       NA |            ? |       ? |
| Div1   | .NET Framework 4.8.1 | .NET Framework 4.8.1 |       NA |       NA |       NA |            ? |       ? |
| Div2   | .NET Framework 4.8.1 | .NET Framework 4.8.1 |       NA |       NA |       NA |            ? |       ? |
| Div3   | .NET Framework 4.8.1 | .NET Framework 4.8.1 |       NA |       NA |       NA |            ? |       ? |
| Div4   | .NET Framework 4.8.1 | .NET Framework 4.8.1 |       NA |       NA |       NA |            ? |       ? |
| Div5   | .NET Framework 4.8.1 | .NET Framework 4.8.1 |       NA |       NA |       NA |            ? |       ? |
| Div1   | NativeAOT 8.0        | NativeAOT 8.0        |       NA |       NA |       NA |            ? |       ? |
| Div2   | NativeAOT 8.0        | NativeAOT 8.0        |       NA |       NA |       NA |            ? |       ? |
| Div3   | NativeAOT 8.0        | NativeAOT 8.0        |       NA |       NA |       NA |            ? |       ? |
| Div4   | NativeAOT 8.0        | NativeAOT 8.0        |       NA |       NA |       NA |            ? |       ? |
| Div5   | NativeAOT 8.0        | NativeAOT 8.0        |       NA |       NA |       NA |            ? |       ? |

Benchmarks with issues:
  Benchmarks1.Div1: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmarks1.Div2: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmarks1.Div3: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmarks1.Div4: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmarks1.Div5: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmarks1.Div1: .NET Framework 4.8.1(Runtime=.NET Framework 4.8.1)
  Benchmarks1.Div2: .NET Framework 4.8.1(Runtime=.NET Framework 4.8.1)
  Benchmarks1.Div3: .NET Framework 4.8.1(Runtime=.NET Framework 4.8.1)
  Benchmarks1.Div4: .NET Framework 4.8.1(Runtime=.NET Framework 4.8.1)
  Benchmarks1.Div5: .NET Framework 4.8.1(Runtime=.NET Framework 4.8.1)
  Benchmarks1.Div1: NativeAOT 8.0(Runtime=NativeAOT 8.0)
  Benchmarks1.Div2: NativeAOT 8.0(Runtime=NativeAOT 8.0)
  Benchmarks1.Div3: NativeAOT 8.0(Runtime=NativeAOT 8.0)
  Benchmarks1.Div4: NativeAOT 8.0(Runtime=NativeAOT 8.0)
  Benchmarks1.Div5: NativeAOT 8.0(Runtime=NativeAOT 8.0)
