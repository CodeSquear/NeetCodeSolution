using BenchmarkDotNet.Attributes;
using NeetCodeSolution.ProblemSolution.TwoPointer;

namespace NeetCodeSolution.BigOnotation.TwoPointer;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution0001Benchmark
{
    private readonly Solution0001 _solution = new Solution0001();

    private  string _smallStringPalindrome;
    private  string _largeStringPalindrome;

    private  string _smallStringNotPalindrome;
    private  string _bigStringNotPalindrome;

    [GlobalSetup]
    public void SetUp()
    {
        _smallStringPalindrome = "aba";
        _smallStringNotPalindrome = "daf";

        _largeStringPalindrome =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXXWVUTSRQPONMLKJIHGFEDCBA";

        _bigStringNotPalindrome =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXXWVUTSRQPONMLKJIHGFEDCBA" +
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXXWVUTSRQPONMLKJIHGFEDCBA";
    }
}