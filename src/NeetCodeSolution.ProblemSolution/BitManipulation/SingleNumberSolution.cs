using System.Collections.Generic;

namespace NeetCodeSolution.ProblemSolution.BitManipulation;

public class SingleNumberSolution
{
    public int SingleNumber(int[] nums)
    {
        foreach (var item in GetDict(nums))
            if (item.Value == 1)
                return item.Key;

        return -1;
    }
    private static Dictionary<int, int> GetDict(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;

        return dict;
    }
}