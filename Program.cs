using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var summary = BenchmarkRunner.Run<Benchmarks1>();
public class Benchmarks1
{
    private const int n = 10001;
    private int x = 3;
    [Benchmark(Baseline = true)]
    public int Div1()
        {
            int a = 1;
            for (int i = 0; i < n; i++)
                {
                    a /= x;
                }
            return a;
        }
    [Benchmark]
    public int Div2()
        {
            int a = 1, b = 2;
            for (int i = 0; i < n; i++)
            {
            a /= x;
            b /= x;
            }
            return a + b;
        }
    [Benchmark]
    public int Div3()
    {
        int a = 1, b = 2, c = 3;
        for (int i = 0; i < n; i++)
        {
            a /= x;
            b /= x;
            c /= x;
        }
        return a + b + c;
    }
    [Benchmark]
    public int Div4()
    {
    int a = 1, b = 2, c = 3, d = 4;
    for (int i = 0; i < n; i++)
        {
            a /= x;
            b /= x;
            c /= x;
            d /= x;
        }
    return a + b + c + d;
    }
    [Benchmark]
    public int Div5()
    {
        int a = 1, b = 2, c = 3, d = 4, e = 5;
        for (int i = 0; i < n; i++)
            {
                a /= x;
                b /= x;
                c /= x;
                d /= x;
                e /= x;
            }
        return a + b + c + d + e;
    }
}