using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBasedProblems.Two_Pointers;

public class ContainerWithMostWater
{
    public static int MaxArea()
    {
        int[] nums = new int[9] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int l = 0;
        int r = nums.Length - 1;
        int maxWater = int.MinValue;
        while (l < r)
        {
            //how much water can be stored.
            var water = (r - l) * Math.Min(nums[r], nums[l]);

            maxWater = Math.Max(maxWater, water);

            //shift the smaller value index, to check the next value

            if (nums[l] > nums[r])
                r--;
            else
                l++;
        }

        return maxWater;
    
    }
}
