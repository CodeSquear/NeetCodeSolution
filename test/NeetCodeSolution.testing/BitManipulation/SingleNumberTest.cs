using NeetCodeSolution.ProblemSolution.BitManipulation;
using Xunit;

namespace NeetCodeSolution.testing.BitManipulation;

public class SingleNumberTest
{
    private readonly SingleNumberSolution _solution = new SingleNumberSolution();

    [Theory(DisplayName = "Single Number Test Cases")]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new int[] { 1 }, 1)]
    public void SingleNumberTestCases(int[] nums, int expected)
    {
        int result = _solution.SingleNumber(nums);
        Assert.Equal(expected, result);
    }
}