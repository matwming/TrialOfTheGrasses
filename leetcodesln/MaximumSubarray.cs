using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var max = nums[0];
            var pre = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if(pre < 0)
                {
                    pre = nums[i];
                }
                else
                {
                    pre = pre + nums[i];
                }
                    max = max > pre ? max : pre;
            }
            return max;
        }
    }
}
