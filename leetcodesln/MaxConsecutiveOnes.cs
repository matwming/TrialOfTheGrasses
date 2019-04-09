using System;

namespace leetcodesln
{
    public class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int ans = 0;
            int current = 0;

            foreach (var num in nums)
            {
                current = num == 0 ? 0 : ++current;
                ans = Math.Max(ans, current);
            }
            return ans;
        }
    }
}
