namespace NeetCodeSolution.ProblemSolution.TwoPointer;

public class Solution0001
{
    public bool IsPalindrome(string s)
    {
        string str = "";
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                str += char.ToLower(c);
            }
        }

        return str == new string(str.Reverse().ToArray());
    }
}