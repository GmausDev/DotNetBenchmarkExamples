using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;

namespace Penguin // 🐧🐧🐧🐧🐧
{


[Config(typeof(Config))]    
// Tenemos que tener en cuenta que el orden magicamente afecta el resultado
[SimpleJob(RuntimeMoniker.Net481)]
[SimpleJob(RuntimeMoniker.Net50)]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80,baseline:true)]
[SimpleJob(RuntimeMoniker.NetCoreApp31)]


// El baseline true es para que se muestre como la base de los benchmarks a comparar
public class InterpolationBenchmark
{
    private string 
    title = "Mr. ✨✨✨", firstName = "Octocat", lastName = "randam", suffix = "III";
    
    [Benchmark]
    public string Interpolation() => $"{title} {firstName} {lastName} {suffix}";

    

    private class Config: ManualConfig
    {
        public Config()
        {
            SummaryStyle = SummaryStyle.Default.WithRatioStyle(BenchmarkDotNet.Columns.RatioStyle.Trend);
        }

    }
}

}