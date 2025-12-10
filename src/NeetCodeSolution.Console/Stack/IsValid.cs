using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using NeetCodeSolution.BigOnotation.Stack;

namespace NeetCodeSolution.Console.Stack;

public class IsValidBenchmark
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