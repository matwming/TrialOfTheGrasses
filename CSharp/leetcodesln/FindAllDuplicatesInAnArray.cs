using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class FindAllDuplicatesInAnArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var ans = new List<int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0) ans.Add(index + 1);
                else nums[index] = -nums[index];
            }
            return ans;
        }
    }
}
