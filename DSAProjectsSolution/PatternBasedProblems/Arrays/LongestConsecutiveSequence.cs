namespace PatternBasedProblems.Arrays;

public class LongestConsecutiveSequence
{
    public static int LongestConsecutive()
    {
        var nums = new int[6] { 100, 4, 200, 1, 3, 2 };
        int maxLength = 0;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int currentLength = 1;            
            while (i + 1 < nums.Length && (nums[i] == nums[i + 1] || nums[i + 1] == nums[i] + 1))
            {
                if (nums[i] != nums[i + 1])
                    currentLength++;
                i++;
            }
            maxLength = Math.Max(maxLength, currentLength);
        }

        return maxLength;
    }
}
