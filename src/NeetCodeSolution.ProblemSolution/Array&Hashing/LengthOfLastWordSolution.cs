namespace NeetCodeSolution.ProblemSolution.Array_Hashing;

public class LengthOfLastWordSolution
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split().ToList().Last().Length;
    }
}