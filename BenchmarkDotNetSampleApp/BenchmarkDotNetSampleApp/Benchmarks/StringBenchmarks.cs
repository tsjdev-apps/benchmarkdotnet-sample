using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkDotNetSampleApp.Benchmarks
{
    [RankColumn]
    public class StringBenchmarks
    {
        private readonly int _numberOfItems = 100000;

        [Benchmark]
        public string ConcatStringsWithStringBuilder()
        {
            StringBuilder sb = new();

            for (int i = 0; i < _numberOfItems; i++)
            {
                sb.Append($"Hello World! {i}");
            }

            return sb.ToString();
        }

        [Benchmark]
        public string ConcatStringsWithStringInterpolation()
        {
            string str = string.Empty;

            for (int i = 0; i < _numberOfItems; i++)
            {
                str += $"Hello World! {i}";
            }

            return str;
        }

        [Benchmark]
        public string ConcatStringsWithList()
        {
            List<string> list = new(_numberOfItems);

            for (int i = 0; i < _numberOfItems; i++)
            {
                list.Add($"Hello World! {i}");
            }

            return list.ToString() ?? string.Empty;
        }
    }
}
