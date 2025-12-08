using BenchmarkDotNet.Attributes;
using NeetCodeSolution.ProblemSolution.Array_Hashing;

namespace NeetCodeSolution.BigOnotation.Array_Hashing_Benchmark_;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution0002Benchmark
{
    private readonly Solution0002 _solution = new Solution0002();

    private string[] _anagramsS;
    private string[] _anagramsT;
    private string[] _nonAnagramS;
    private string[] _nonAnagramT;

    [GlobalSetup]
    public void Setup()
    {
        _anagramsS =
        [
            "listen", "silent", "enlist", "inlets", "tinsel",
            "evil", "vile", "live", "veil", "levi"
        ];

        _nonAnagramS =
        [
            "hello", "world", "benchmark", "performance", "testing",
            "example", "string", "array", "hashing", "solution"
        ];
    }

    [Benchmark(Description = "Group Anagrams - With Anagrams")]
    public void WithAnagrams()
    {
        foreach (var item in _anagramsS)
            _solution.IsAnagram(_anagramsS[0], item);
    }

    [Benchmark(Description = "Group Anagrams - Without Anagrams")]
    public void WithoutAnagrams()
    {
        foreach (var item in _nonAnagramS)
            _solution.IsAnagram(_nonAnagramS[0], item);
    }
}