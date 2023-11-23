using BenchmarkDotNet.Running;
using System;
using System.Diagnostics;

namespace DotnetBenchamarkExamples // 📎📎📎📎.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            //Oldschool benchmarking


            // Console.WriteLine(stopwatch1.ElapsedMilliseconds + " vs. " +
            // stopwatch2.ElapsedMilliseconds);
            // if (stopwatch1.ElapsedMilliseconds < stopwatch2.ElapsedMilliseconds)
            // Console.WriteLine("The first method is faster");
            // else
            // Console.WriteLine("The second method is faster");
            
// How can it be implemented? We can introduce a “maximum acceptable error” (let’s 
// say 20%5
//  of the average of two measurements) and use it during comparison
            
            
            Console.WriteLine("Start benchmarking🐧🐧🐧🐧🐧");
            //  _= BenchmarkRunner.Run<Penguin.ArrayIterationBenchmark>();
            _= BenchmarkRunner.Run<Penguin.InterpolationBenchmark>();
            // _= BenchmarkRunner.Run<Penguin.DivBenchmark>();
            Console.WriteLine("Just stop📎📎📎📎📎");
        }
        // It's not the fastest algorithm,
        // but we will optimize it later.
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= n - 1; i++)
            if (n % i == 0)
            return false;
            return true;
        }
    }
}


