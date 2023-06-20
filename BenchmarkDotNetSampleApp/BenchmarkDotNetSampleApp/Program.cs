using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNetSampleApp.Benchmarks;


/// Run benchmarks for sorting
Summary sortBenchmarksSummary = BenchmarkRunner.Run<SortBenchmarks>();

/// Run benchmarks for strings
Summary stringBenchmarksSummary = BenchmarkRunner.Run<StringBenchmarks>();