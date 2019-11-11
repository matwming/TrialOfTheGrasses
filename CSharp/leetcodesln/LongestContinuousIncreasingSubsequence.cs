using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class LongestContinuousIncreasingSubsequence
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0) return 0;
            var max = int.MinValue;
            var current = 0;
            while(current < nums.Length)
            {              
                var partialLongest = FindPartialLongest(nums, current);
                current += partialLongest;
                max = max < partialLongest? partialLongest : max;
            }
            return max;
        }

        private int FindPartialLongest(int[] part, int current)
        {
            var partialMax = 0;
            while (current + 1 < part.Length && part[current] < part[current + 1])
            {
                partialMax++;
                current++;
            }
            return partialMax+1;
        }
    }
}
