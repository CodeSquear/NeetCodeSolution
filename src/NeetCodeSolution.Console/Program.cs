using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using NeetCodeSolution.BigOnotation.Array_Hashing_Benchmark_;


// Solution/ArrayHashing/Problem1/ContainsDuplicate
BenchmarkRunner.Run<Solution0001Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);