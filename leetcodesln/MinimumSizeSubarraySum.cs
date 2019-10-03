using System;

namespace leetcodesln
{
    public class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int low = 0, high = 0, min = int.MaxValue, sum = 0;

            for (; high < nums.Length; ++high)
            {
                sum += nums[high];

                while (sum >= s)
                {
                    min = Math.Min(min, high - low + 1);
                    sum -= nums[low++];
                }
            }
            return min == int.MaxValue ? 0 : min;
        }
    }
}
