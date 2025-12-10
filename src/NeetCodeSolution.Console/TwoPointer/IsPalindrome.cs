using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using NeetCodeSolution.BigOnotation.TwoPointer;
using NeetCodeSolution.ProblemSolution.TwoPointer;
using Solution0001Benchmark = NeetCodeSolution.BigOnotation.Array_Hashing_Benchmark_.Solution0001Benchmark;

namespace NeetCodeSolution.Console.TwoPointer;

public class IsPalindrome
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