using BenchmarkDotNet.Attributes;
using NeetCodeSolution.ProblemSolution.Array_Hashing;

namespace NeetCodeSolution.BigOnotation.Array_Hashing_Benchmark_;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution0003Benchmark
{
    private readonly Solution0003 _solution = new Solution0003();
    private readonly Random _random = new Random();

    private readonly int[] _nums = new int[] { 2, 7, 11, 15 };
    private readonly int _target = 9;

    private int[] _largeNums;
    private int _largeTarget;

    [GlobalSetup]
    public void Setup()
    {
        _largeNums = Enumerable.Range(1, 10000).ToArray();
        _largeTarget = _random.Next(1, 10000);
    }

    [Benchmark(Description = "TwoSum Small Array Test")]
    public void TwoSumSmallArrayTest() =>
        _solution.TwoSum(_nums, _target);

    [Benchmark(Description = "TwoSum Large Array Test")]
    public void TwoSumLargeArrayTest() =>
        _solution.TwoSum(_largeNums, _largeTarget);
}