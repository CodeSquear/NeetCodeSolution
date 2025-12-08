using NeetCodeSolution.ProblemSolution.Array_Hashing;

namespace NeetCodeSolution.testing.Array_Hashing_Test_;

public class Solution0002Test
{
    private readonly Solution0002 _solution = new Solution0002();

    [Fact]
    public void IsAnagrams()
    {
        string s = "listen" , t = "netils";

        bool result = _solution.IsAnagram(s, t);

        Assert.True(result);
    }

    [Fact]
    public void IsNotAnagrams()
    {
        string s = "hello", t = "world";
        bool result = _solution.IsAnagram(s, t);
        Assert.True(result);
    }
}