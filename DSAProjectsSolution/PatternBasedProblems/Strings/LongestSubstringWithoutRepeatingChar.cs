namespace PatternBasedProblems.Strings;

public class LongestSubstringWithoutRepeatingChar
{
    public static int LengthOfLongestSubstring()
    {
        string s = "abcabcbb"; // Example input
        int maxLength = 0;

        #region approach one
        //for(int i = 0; i < s.Length; i++)
        //{
        //    HashSet<char> charSet = new HashSet<char>();
        //    int currentLength = 0;
        //    for (int j = i; j < s.Length; j++)
        //    {
        //        if (charSet.Contains(s[j]))
        //        {
        //            break; // Found a repeating character, break the inner loop
        //        }
        //        charSet.Add(s[j]);
        //        currentLength++;
        //    }
        //    maxLength = Math.Max(maxLength, currentLength);
        //}

        #endregion


        #region approach two.
        ///Comments
        ///In above code, we are iterating same index multiple times.
        ///eg: to find Longest substring from index 1, we go from 1 -> index 4.
        /// to find the Longest substring from index 2, we again start from 3. (Can this be handled?)
        /// Yes - If we store the index position of previous counter.
        /// Longest substring without repeating char means, how far are same chars from each other.
        /// get the distance of maximum ones.

        int left = 0;
        var charIndexMap = new Dictionary<char, int>();
        for(int right = 0; right < s.Length; right++)
        {

            if (charIndexMap.ContainsKey(s[right]))
            {
                left = Math.Max(left, charIndexMap[s[right]] + 1);
            
                ///✅ +1 skips over the previous occurrence of the repeated character. 
                ///✅ Math.Max() ensures left only moves forward.
            }

            //store the index of the char
            charIndexMap[s[right]] = right;

            maxLength = Math.Max(maxLength, right - left + 1);
            ///Why + 1?
            ///Without + 1, you'd underestimate:
            ///You’d count only the difference between positions, not the total number of characters.
            ///eg: right - left + 1 = 5 - 2 + 1 = 4 (diff between left to right is 3 but count is 4)
        }

        #endregion
        return maxLength;
    }
}
