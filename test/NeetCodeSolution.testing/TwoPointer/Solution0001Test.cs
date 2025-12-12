using NeetCodeSolution.ProblemSolution.TwoPointer;

namespace NeetCodeSolution.testing.TwoPointer;

public class Solution0001Test
{
    private readonly Solution0001 _solution = new Solution0001();

    private readonly string s = "Was it a car or a cat I saw?";
    private readonly string t = "a car or a cat";
    private readonly string d = "tab a cat";

    [Fact(DisplayName = "Palindrome-Case-One")]
    public void IsPalindromeTest()
    {
        bool result = _solution.IsPalindrome(s);
        Assert.True(result);
    }

    [Fact(DisplayName = "Palindrome-Case-Two")]
    public void IsNotPalindromeTest1()
    {
        bool result = _solution.IsPalindrome(d);
        Assert.False(result);
    }

    [Fact(DisplayName = "Palindrome-Case-There")]
    public void IsNotPalindromeTest2()
    {
        bool result = _solution.IsPalindrome(t);
        Assert.False(result);
    }
}