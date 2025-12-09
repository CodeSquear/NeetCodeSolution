using NeetCodeSolution.ProblemSolution.Array_Hashing;

namespace NeetCodeSolution.testing.Array_Hashing_Test_;

public class Solution0003Test
{
    private readonly Solution0003 _solution = new Solution0003();

    [Fact]
    public void TwoSum_Correct_Case()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = _solution.TwoSum(nums, target);
        Assert.Equal([0,1], result);
    }

    [Fact]
    public void TwoSum_Another_Case()
    {
        int[] nums = { 3, 2, 4 };
        int target = 6;
        int[] result = _solution.TwoSum(nums, target);
        Assert.Equal([1,2], result);
    }

    [Fact]
    public void TwoSum_Negative_Numbers_Case()
    {
        int[] nums = { -1, -2, -3, -4, -5 };
        int target = -8;
        int[] result = _solution.TwoSum(nums, target);
        Assert.Equal([2,4], result);
    }
}