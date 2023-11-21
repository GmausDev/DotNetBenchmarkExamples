

// [Config(typeof(Config))]
// [SimpleJob(RuntimeMoniker.NetCoreApp31,baseline:true)]
// [SimpleJob(RuntimeMoniker.Net50)]
// [SimpleJob(RuntimeMoniker.Net60)]
// [SimpleJob(RuntimeMoniker.Net80)]

// public class SparksAndFrameworksBenchmark
// {
//     private string 
//     title = "Mr. ✨✨✨", firstName = "John", lastName = "Doe", suffix = "III";
//     [Benchmark]
//     public string Interpolation() => $"{title} {firstName} {lastName} {suffix}{title} {firstName} {lastName} {suffix}";
    
//     private class Config: ManualConfig
//     {
//         public Config()
//         {
//             SummaryStyle = SummaryStyle.Default.WithRatioStyle(BenchmarkDotNet.Columns.RatioStyle.Trend);
//         }

//     }
// }