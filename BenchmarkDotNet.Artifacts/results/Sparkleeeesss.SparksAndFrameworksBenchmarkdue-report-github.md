```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method        | Job           | Runtime       | N     | Mean      | Error     | StdDev     | Median    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|-------------- |-------------- |-------------- |------ |----------:|----------:|-----------:|----------:|------:|--------:|-----:|----------:|------------:|
| ForLoop       | .NET 5.0      | .NET 5.0      | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| ForLoop       | .NET Core 3.1 | .NET Core 3.1 | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| ForLoop       | .NET 6.0      | .NET 6.0      | 10000 |  4.319 μs | 0.3887 μs |  1.1461 μs |  4.999 μs |     ? |       ? |    1 |         - |           ? |
| ForLoop       | .NET 8.0      | .NET 8.0      | 10000 |  4.601 μs | 0.3669 μs |  1.0704 μs |  5.009 μs |     ? |       ? |    1 |         - |           ? |
|               |               |               |       |           |           |            |           |       |         |      |           |             |
| ForEachLoop   | .NET 5.0      | .NET 5.0      | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| ForEachLoop   | .NET Core 3.1 | .NET Core 3.1 | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| ForEachLoop   | .NET 8.0      | .NET 8.0      | 10000 |  2.644 μs | 0.1232 μs |  0.3634 μs |  2.489 μs |     ? |       ? |    1 |         - |           ? |
| ForEachLoop   | .NET 6.0      | .NET 6.0      | 10000 |  2.792 μs | 0.1660 μs |  0.4816 μs |  2.556 μs |     ? |       ? |    2 |         - |           ? |
|               |               |               |       |           |           |            |           |       |         |      |           |             |
| ArrayForEach  | .NET 5.0      | .NET 5.0      | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| ArrayForEach  | .NET Core 3.1 | .NET Core 3.1 | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| ArrayForEach  | .NET 8.0      | .NET 8.0      | 10000 |  2.498 μs | 0.0464 μs |  0.1240 μs |  2.456 μs |     ? |       ? |    1 |         - |           ? |
| ArrayForEach  | .NET 6.0      | .NET 6.0      | 10000 | 17.223 μs | 0.3414 μs |  0.6819 μs | 17.386 μs |     ? |       ? |    2 |         - |           ? |
|               |               |               |       |           |           |            |           |       |         |      |           |             |
| GetEnumerator | .NET 5.0      | .NET 5.0      | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| GetEnumerator | .NET Core 3.1 | .NET Core 3.1 | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| GetEnumerator | .NET 8.0      | .NET 8.0      | 10000 | 11.645 μs | 0.3536 μs |  1.0144 μs | 11.238 μs |     ? |       ? |    1 |      32 B |           ? |
| GetEnumerator | .NET 6.0      | .NET 6.0      | 10000 | 74.941 μs | 3.4336 μs | 10.0161 μs | 71.715 μs |     ? |       ? |    2 |      32 B |           ? |
|               |               |               |       |           |           |            |           |       |         |      |           |             |
| SpanFor       | .NET 5.0      | .NET 5.0      | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| SpanFor       | .NET Core 3.1 | .NET Core 3.1 | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| SpanFor       | .NET 8.0      | .NET 8.0      | 10000 |  2.841 μs | 0.1397 μs |  0.4098 μs |  2.730 μs |     ? |       ? |    1 |         - |           ? |
| SpanFor       | .NET 6.0      | .NET 6.0      | 10000 |  4.911 μs | 0.0968 μs |  0.1292 μs |  4.880 μs |     ? |       ? |    2 |         - |           ? |
|               |               |               |       |           |           |            |           |       |         |      |           |             |
| SpanForEach   | .NET 5.0      | .NET 5.0      | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| SpanForEach   | .NET Core 3.1 | .NET Core 3.1 | 10000 |        NA |        NA |         NA |        NA |     ? |       ? |    ? |        NA |           ? |
| SpanForEach   | .NET 8.0      | .NET 8.0      | 10000 |  2.813 μs | 0.1603 μs |  0.4728 μs |  2.729 μs |     ? |       ? |    1 |         - |           ? |
| SpanForEach   | .NET 6.0      | .NET 6.0      | 10000 |  3.618 μs | 0.0895 μs |  0.2479 μs |  3.617 μs |     ? |       ? |    2 |         - |           ? |

Benchmarks with issues:
  SparksAndFrameworksBenchmarkdue.ForLoop: .NET 5.0(Runtime=.NET 5.0) [N=10000]
  SparksAndFrameworksBenchmarkdue.ForLoop: .NET Core 3.1(Runtime=.NET Core 3.1) [N=10000]
  SparksAndFrameworksBenchmarkdue.ForEachLoop: .NET 5.0(Runtime=.NET 5.0) [N=10000]
  SparksAndFrameworksBenchmarkdue.ForEachLoop: .NET Core 3.1(Runtime=.NET Core 3.1) [N=10000]
  SparksAndFrameworksBenchmarkdue.ArrayForEach: .NET 5.0(Runtime=.NET 5.0) [N=10000]
  SparksAndFrameworksBenchmarkdue.ArrayForEach: .NET Core 3.1(Runtime=.NET Core 3.1) [N=10000]
  SparksAndFrameworksBenchmarkdue.GetEnumerator: .NET 5.0(Runtime=.NET 5.0) [N=10000]
  SparksAndFrameworksBenchmarkdue.GetEnumerator: .NET Core 3.1(Runtime=.NET Core 3.1) [N=10000]
  SparksAndFrameworksBenchmarkdue.SpanFor: .NET 5.0(Runtime=.NET 5.0) [N=10000]
  SparksAndFrameworksBenchmarkdue.SpanFor: .NET Core 3.1(Runtime=.NET Core 3.1) [N=10000]
  SparksAndFrameworksBenchmarkdue.SpanForEach: .NET 5.0(Runtime=.NET 5.0) [N=10000]
  SparksAndFrameworksBenchmarkdue.SpanForEach: .NET Core 3.1(Runtime=.NET Core 3.1) [N=10000]
