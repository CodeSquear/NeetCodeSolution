namespace NeetCodeSolution.ProblemSolution.Stack;

public class Solution0001
{
    public bool IsValid(string s)
    {
        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        }
        return s.Length == 0;
    }
}