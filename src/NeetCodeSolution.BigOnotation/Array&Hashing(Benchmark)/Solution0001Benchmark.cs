using BenchmarkDotNet.Attributes;
using NeetCodeSolution.ProblemSolution.Array_Hashing;

namespace NeetCodeSolution.BigOnotation.Array_Hashing_Benchmark_;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution0001Benchmark
{
    private readonly Solution0001 _solution = new Solution0001();

    private int[] _arrayWithDuplicates;
    private int[] _arrayWithoutDuplicates;

    [GlobalSetup]
    public void Setup()
    {
        _arrayWithDuplicates = Enumerable.Repeat(42, 10_000).ToArray();
        _arrayWithoutDuplicates = Enumerable.Range(1, 10_000).ToArray();
    }

    [Benchmark(Description = "Contains Duplicate - With Duplicates")]
    public bool WithDuplicates() => _solution.HasDuplicate(_arrayWithDuplicates);

    [Benchmark(Description = "Contains Duplicate - Without Duplicates")]
    public bool WithoutDuplicates() => _solution.HasDuplicate(_arrayWithoutDuplicates);
}