using System;

namespace leetcodesln
{
    public class MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            if(k > nums.Length) throw new Exception();

            var max = 0.00;
            var left = 0;
            var right = k;
            for (int i = 0; i < k; i++)
            {
                max += nums[i];
            }
            var current = max;
            while(right < nums.Length)
            {
                current = current - nums[left] + nums[right];
                max = max > current? max : current;
                left++;
                right++;
            }
            return max/k;
        }
    }
}