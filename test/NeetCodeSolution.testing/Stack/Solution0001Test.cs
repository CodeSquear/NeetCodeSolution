using NeetCodeSolution.ProblemSolution.Stack;

namespace NeetCodeSolution.testing.Stack;

public class Solution0001Test
{
    private readonly Solution0001 _solution = new Solution0001();

    private readonly string _smallStringCorr = "()[]{}";
    private readonly string _smallStringInCorr = "(]";
    private readonly string _largeStringCorr = new string('(', 5000) + new string(')', 5000);
    private readonly string _largeStringInCorr = new string('(', 5000) + new string(']', 5000);


    [Fact(DisplayName = "Valid Parentheses Small Correct Test")]
    public void ValidParenthesesSmallCorrectTest()
    {
        bool result = _solution.IsValid(_smallStringCorr);
        Assert.True(result);
    }

    [Fact(DisplayName = "Valid Parentheses Small Incorrect Test")]
    public void ValidParenthesesSmallIncorrectTest()
    {
        bool result = _solution.IsValid(_smallStringInCorr);
        Assert.False(result);
    }

    [Fact(DisplayName = "Valid Parentheses Large Correct Test")]
    public void ValidParenthesesLargeCorrectTest()
    {
        bool result = _solution.IsValid(_largeStringCorr);
        Assert.True(result);
    }

    [Fact(DisplayName = "Valid Parentheses Large Incorrect Test")]
    public void ValidParenthesesLargeIncorrectTest()
    {
        bool result = _solution.IsValid(_largeStringInCorr);
        Assert.False(result);
    }
}

