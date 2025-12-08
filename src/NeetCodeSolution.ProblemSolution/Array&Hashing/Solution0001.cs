namespace NeetCodeSolution.ProblemSolution.Array_Hashing;

public class Solution0001
{
    public bool HasDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count != nums.Length;
    }
}