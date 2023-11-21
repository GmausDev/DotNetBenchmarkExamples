using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// var summary = BenchmarkRunner.Run<Benchmarks1>();
var summary = BenchmarkRunner.Run<SparksAndFrameworksBenchmark>();
[Config(typeof(Config))]    
// [SimpleJob(RuntimeMoniker.NetCoreApp31,baseline:true)]
[SimpleJob(RuntimeMoniker.Net60,baseline:true)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80)]

public class SparksAndFrameworksBenchmark
{
    private string 
    title = "Mr. ✨✨✨", firstName = "John", lastName = "Doe", suffix = "III";
    [Benchmark]
    public string Interpolation() => $"{title} {firstName} {lastName} {suffix}{title} {firstName} {lastName} {suffix}";
    
    private class Config: ManualConfig
    {
        public Config()
        {
            SummaryStyle = SummaryStyle.Default.WithRatioStyle(BenchmarkDotNet.Columns.RatioStyle.Trend);
        }

    }
}


// public class Benchmarks1
// {
//     private const int n = 10001;
//     private int x = 3;
//     [Benchmark(Baseline = true)]
//     public int Div1()
//         {
//             int a = 1;
//             for (int i = 0; i < n; i++)
//                 {
//                     a /= x;
//                 }
//             return a;
//         }
//     [Benchmark]
//     public int Div2()
//         {
//             int a = 1, b = 2;
//             for (int i = 0; i < n; i++)
//             {
//             a /= x;
//             b /= x;
//             }
//             return a + b;
//         }
//     [Benchmark]
//     public int Div3()
//     {
//         int a = 1, b = 2, c = 3;
//         for (int i = 0; i < n; i++)
//         {
//             a /= x;
//             b /= x;
//             c /= x;
//         }
//         return a + b + c;
//     }
//     [Benchmark]
//     public int Div4()
//     {
//     int a = 1, b = 2, c = 3, d = 4;
//     for (int i = 0; i < n; i++)
//         {
//             a /= x;
//             b /= x;
//             c /= x;
//             d /= x;
//         }
//     return a + b + c + d;
//     }
//     [Benchmark]
//     public int Div5()
//     {
//         int a = 1, b = 2, c = 3, d = 4, e = 5;
//         for (int i = 0; i < n; i++)
//             {
//                 a /= x;
//                 b /= x;
//                 c /= x;
//                 d /= x;
//                 e /= x;
//             }
//         return a + b + c + d + e;
//     }
// }
