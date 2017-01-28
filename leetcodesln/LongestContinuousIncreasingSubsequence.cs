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
                var remain = new int[nums.Length - current];
                for (int i = current, j =0; i < nums.Length; i++, j++)
                {
                    remain[j] = nums[i];
                }

                var partialLongest = FindPartialLongest(remain);
                current += partialLongest;
                max = max < partialLongest? partialLongest : max;
            }
            return max;
        }

        private int FindPartialLongest(int[] part)
        {
            int index = 0;
            while (index + 1 < part.Length && part[index] < part[index + 1])
            {
                index++;
            }
            return index+1;
        }
    }
}
