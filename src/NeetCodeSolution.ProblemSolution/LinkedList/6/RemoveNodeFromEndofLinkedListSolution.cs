public class ProblemSolution
{
    public void SortColor(int[] nums)
    {
        while(!ChechArrNotINF(nums))
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(i + 1 < nums.Length && nums[i] > nums[i + 1])
                    (nums[i] , nums[i + 1]) = (nums[i + 1] , nums[i]);
            }
        }
    }

    private static bool ChechArrNotINF(int[] nums)
    {
        bool resul = true;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(i + 1 < nums.Length && nums[i] > nums[i + 1])
                resul = false;
        }


        return resul;
    }
}