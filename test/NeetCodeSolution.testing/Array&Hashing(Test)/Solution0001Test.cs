using NeetCodeSolution.ProblemSolution.Array_Hashing;

namespace NeetCodeSolution.testing.Array_Hashing_Test_;

public class Solution0001Test
{
    private readonly Solution0001 _solution = new Solution0001();

    [Fact]
    public void HasDuplicate_WithDuplicates_ReturnsTrue()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4, 5, 3 };
        // Act
        bool result = _solution.HasDuplicate(nums);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void HasDuplicate_WithoutDuplicates_ReturnsFalse()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4, 5 };
        // Act
        bool result = _solution.HasDuplicate(nums);
        // Assert
        Assert.False(result);
    }
}