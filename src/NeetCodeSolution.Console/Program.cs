using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using NeetCodeSolution.BigOnotation.Array_Hashing_Benchmark_;
using NeetCodeSolution.Console.Array_Hashing;


// Solution/ArrayHashing/Problem1/ContainsDuplicate
ContainsDuplicateBenchmark.RunMark();

// Solution/ArrayHashing/Problem2/IsAnagram
/*BenchmarkRunner.Run<Solution0002Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);*/


// Solution/ArrayHashing/Problem3/TwoSum
BenchmarkRunner.Run<Solution0003Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);

