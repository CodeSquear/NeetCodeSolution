using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using NeetCodeSolution.BigOnotation.Array_Hashing_Benchmark_;

namespace NeetCodeSolution.Console.Array_Hashing;

public class ContainsDuplicateBenchmark
{
    public static void RunMark()
    {
        BenchmarkRunner.Run<Solution0001Benchmark>(
            DefaultConfig
                .Instance
                .WithOptions(ConfigOptions.DisableOptimizationsValidator)
        );
    }
}