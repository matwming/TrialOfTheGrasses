using System;

namespace leetcodesln
{
    public class LargestNumberAtLeastTwiceOfOthers
    {
        public int DominantIndex(int[] nums)
        {
            if (nums.Length==1)
            {
                return 0;
            }
            int[] numsCopy = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numsCopy[i] = nums[i];
            }
            Array.Sort(numsCopy);
            return numsCopy[numsCopy.Length - 1] - numsCopy[numsCopy.Length - 2] >= numsCopy[numsCopy.Length-2] ? Array.IndexOf(nums, numsCopy[numsCopy.Length - 1]) : -1;
        }
    }
}
