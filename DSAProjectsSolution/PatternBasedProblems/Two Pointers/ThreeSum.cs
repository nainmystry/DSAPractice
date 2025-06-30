namespace PatternBasedProblems.Two_Pointers;

public class ThreeSum
{

    /*
     Q - https://leetcode.com/problems/3sum/description/
     

     The ThreeSum pattern solves problems where you're asked to find three numbers in an array that meet a certain condition.
     
     It reduces the brute-force O(n³) approach to O(n²) by:
     - Sort the array. (Required so decision can be made whether to move left pointer or right pointer)
     - Fixing one number in a loop.(start)
     - Using two pointers (left and right) to find the other two numbers.
     */

    public static IList<IList<int>> ThreeSumM()
    {
        int[] nums = new int[6] { -1, 0, 1, 2, -1, -4 };
        //int[] nums = new int[5] { -2, 0, 1, 1, 2 };

        Array.Sort(nums);
        Dictionary<string, IList<int>> map = new Dictionary<string, IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            int l = i + 1;
            int r = nums.Length - 1;
            int target = nums[i];
            while(l < r)
            {
                
                if((l != i && l != r && r != i) && 
                    (nums[l] + nums[r] + target) == 0)
                {
                    var key = nums[l].ToString() + nums[r].ToString() + target.ToString();
                    if (!map.ContainsKey(key))
                        map[key] = new List<int> { nums[l], nums[r], target };
                    //break;
                }

                if (target + (nums[l] + nums[r]) > 0)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

        }

        return map.Values.ToList();
    }

}
