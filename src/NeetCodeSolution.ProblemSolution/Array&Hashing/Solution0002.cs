namespace NeetCodeSolution.ProblemSolution.Array_Hashing;

public class Solution0002
{
    public bool IsAnagram(string s, string t)
    {
        return SortingString(s) == SortingString(t);
    }

    private static string SortingString(string str)
    {
        var chars = str.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}