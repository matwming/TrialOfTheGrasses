using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            var max = int.MinValue;
            var tempsum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                tempsum += nums[i];
                if(tempsum >= max)
                {
                    max = tempsum > nums[i]? tempsum : nums[i];
                    tempsum = max;
                }
            }
            return max;
        }
    }
}
