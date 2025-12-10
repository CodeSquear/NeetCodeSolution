using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using NeetCodeSolution.BigOnotation.Array_Hashing_Benchmark_;

namespace NeetCodeSolution.Console.Array_Hashing;

public class TwoSumBenchmark
{
    public static void RunMark()
    {
        BenchmarkRunner.Run<Solution0003Benchmark>(
            DefaultConfig
                .Instance
                .WithOptions(ConfigOptions.DisableOptimizationsValidator)
        );
    }
}