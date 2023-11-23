using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace Penguin // 🐧🐧🐧🐧🐧
{


    [Config(typeof(Config))]
    [RankColumn]
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.Default]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    // [SimpleJob(RuntimeMoniker.NetCoreApp31,baseline:true)]
    // [SimpleJob(RuntimeMoniker.Net50)]
    // [SimpleJob(RuntimeMoniker.Net60)]
    // [SimpleJob(RuntimeMoniker.Net70)]
    [SimpleJob(RuntimeMoniker.Net80)]

    public class ArrayIterationBenchmark
    {

        // Definimos parametros para el benchmark
        [Params(500)]
        public int N;

        private string[] benchmarkArray;

        // Podemos añadir una configuracion para los benchmarks
        [GlobalSetup]
        public void Setup()
        {
            this.benchmarkArray = new string[this.N];

            for (var i = 0; i < this.N; i++)
            {
                this.benchmarkArray[i] = $"i";
            }
        }

        [Benchmark]
        public void ForLoop()
        {
            for (var i = 0; i < this.N; i++)
            {
                _ = this.benchmarkArray[i];
            }
        }

        [Benchmark]
        public void ForEachLoop()
        {
            foreach (var item in this.benchmarkArray)
            {
                _ = item;
            }
        }

        [Benchmark]
        public void ArrayForEach()
        {
            Array.ForEach(this.benchmarkArray, item => _ = item);
        }

        [Benchmark]
        public void GetEnumerator()
        {
            var enumerator = this.benchmarkArray.GetEnumerator();

            while (enumerator.MoveNext())
            {
                _ = enumerator.Current;
            }
        }

        [Benchmark]
        public void SpanFor()
        {
            var span = this.benchmarkArray.AsSpan();

            for (var i = 0; i < this.N; i++)
            {
                _ = span[i];
            }
        }

        [Benchmark]
        public void SpanForEach()
        {
            var span = this.benchmarkArray.AsSpan();

            foreach (var item in span)
            {
                _ = item;
            }
        }
        // Configuramos las propiedades del benchmark, estilo si queremos crear plots o lo que sea
        private class Config: ManualConfig
        {
            public Config()
            {
                SummaryStyle = SummaryStyle.Default.WithRatioStyle(BenchmarkDotNet.Columns.RatioStyle.Trend);
            }

        }
    }
}