using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetSampleApp.Benchmarks
{
    [RankColumn]
    public class SortBenchmarks
    {
        private int[]? _testData;

        [GlobalSetup]
        public void Setup()
        {
            Random random = new();
            
            _testData = Enumerable.Range(1, 10000)
                .Select(_ => random.Next(0, 10000)).ToArray();
        }

        [Benchmark]
        public void QuickSort()
        {
            int[] testArray = (int[]?)_testData?.Clone() ?? Array.Empty<int>();
            Array.Sort(testArray);
        }

        [Benchmark]
        public void BubbleSort()
        {
            int[] testArray = (int[]?)_testData?.Clone() ?? Array.Empty<int>();
            int temp;

            for (int write = 0; write < testArray.Length; write++)
            {
                for (int sort = 0; sort < testArray.Length - 1; sort++)
                {
                    if (testArray[sort] > testArray[sort + 1])
                    {
                        temp = testArray[sort + 1];
                        testArray[sort + 1] = testArray[sort];
                        testArray[sort] = temp;
                    }
                }
            }
        }
    }
}
