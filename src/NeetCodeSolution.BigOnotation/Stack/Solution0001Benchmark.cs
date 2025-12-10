using BenchmarkDotNet.Attributes;
using NeetCodeSolution.ProblemSolution.Stack;

namespace NeetCodeSolution.BigOnotation.Stack;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution0001Benchmark
{
    private readonly Solution0001 _solution = new Solution0001();

    private string _smallStringCorr;
    private string _smallStringInCorr;

    private string _largeStringCorr;
    private string _largeStringInCorr;

    [GlobalSetup]
    public void Setup()
    {
        _smallStringCorr = "()[]{}";
        _smallStringInCorr = "(]";
        _largeStringCorr = new string('(', 5000) + new string(')', 5000);
        _largeStringInCorr = new string('(', 5000) + new string(']', 5000);
    }

    [Benchmark(Description = "Valid Parentheses Small Correct Test")]
    public void ValidParenthesesSmallCorrectTest() =>
        _solution.IsValid(_smallStringCorr);

    [Benchmark(Description = "Valid Parentheses Small Incorrect Test")]
    public void ValidParenthesesSmallIncorrectTest() =>
        _solution.IsValid(_smallStringInCorr);

    [Benchmark(Description = "Valid Parentheses Large Correct Test")]
    public void ValidParenthesesLargeCorrectTest() =>
        _solution.IsValid(_largeStringCorr);

    [Benchmark(Description = "Valid Parentheses Large Incorrect Test")]
    public void ValidParenthesesLargeIncorrectTest() =>
        _solution.IsValid(_largeStringInCorr);
}